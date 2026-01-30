Imports LibComunVar
Imports System.Windows.Forms
Imports LibReportes
Imports Microsoft.Office.Interop.Excel.ApplicationClass
Imports Microsoft.Office.Interop

Public Class Frm_Reporte_BI

    Dim reporteBL As ClsBuscar
    Dim crystalBL As ClsReporte
    Dim dtImprimir As DataTable
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS
    Dim tiempo_total_ As Double
    Dim t_ejecutado As String
    Dim tiempo_total_improductivo_ As Double
    Dim Pedido_Det_HP As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL
    Dim Det_Informes_Mantenimiento As ClsEntidades.PARTE_PRODUCCION
    Dim dtdetalleArticuloPrincipal As DataTable

    Private Sub Frm_Reporte_BI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        chk_todos.Checked = True
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Function Validaciones() As Boolean
        Dim estado As Boolean = True
        Try
            If TextBox6.Text = "" Then
                MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
                estado = False
            End If

        Catch ex As Exception
            estado = False
        End Try
        Return estado
    End Function
    
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Equipos_Planta(TextBox6, TextBox5, "A")
        If e.KeyCode = Keys.Enter Then
            If TextBox6.Text = String.Empty Then
                Mostrando_Equipos_Planta(TextBox6, TextBox5, "A")
            End If
        End If
    End Sub

    Private Sub TextBox6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox6.MouseDoubleClick
        Mostrando_Equipos_Planta(TextBox6, TextBox5, "A")
    End Sub

    Private Sub Mostrando_Equipos_Planta(ByVal texto_cod As TextBox, ByVal texto_Des As TextBox, ByVal _tipo As String)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_EQUIPOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = _tipo
            frm.Titulo = "Seleccion de Procesos o Equipos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                texto_cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                texto_Des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("FECHA", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("OP", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("OPERARIO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("OPERARIO2", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("OPERARIO3", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("HORA_INICIO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("HORA_FINAL", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("TOTAL_HORAS", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("CODIGO_ACTIVIDAD", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("ESTADO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("MODELO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("MEDIDA", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("COLOR", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
        dtdetalleArticuloPrincipal.Columns.Add("KG", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("MERMA", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("TURNO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("EXTRA", Type.GetType("System.String"))
    End Sub

    Private Sub btn_mostrar_data_Click(sender As Object, e As EventArgs) Handles btn_mostrar_data.Click

        Try
            If TextBox6.Text = "" Then
                MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor

            GenerarColummnaDataTable()

            If Calcular_Tiempo_OP_No_Productivo_2(TextBox6.Text.Trim, dtpfechaInicio.Value.ToString("dd/MM/yyyy"), dtpfechaFin.Value.ToString("dd/MM/yyyy"), IIf(chk_todos.Checked, 0, txt_numero_op.Text)) = False Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                dgvDetalle1.DataSource = dtdetalleArticuloPrincipal
                dgvDetalle1.AutoResizeColumns()
                dgvDetalle1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvDetalle1.Columns("CANTIDAD").DefaultCellStyle.Format = "N2"
                dgvDetalle1.Columns("CANTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Calcular_Tiempo_OP_No_Productivo_2(ByVal codigo As String, ByVal fecha As String, ByVal fecha_fin As String, ByVal op As String) As Boolean
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            
            Dim dt_lista_ops As DataTable
            Dim dt_detalle_ops As DataTable

            Dim tiempo_inicio As TimeSpan = TimeSpan.Parse("00:00:00")
            Dim tiempo_final As TimeSpan = TimeSpan.Parse("00:00:00")
            Dim tiempo_total As TimeSpan

            Dim t_inicio_ As Date
            Dim t_fin_ As Date

            Dim FECHA_BI As String
            Dim OP_BI As String
            Dim OPERARIO As String
            Dim OPERARIO2 As String
            Dim OPERARIO3 As String
            Dim HORA_INICIO As String
            Dim HORA_FINAL As String
            Dim TOTAL_HORAS As String
            Dim CODIGO_ACTIVIDAD As String = ""
            Dim ESTADO As String
            Dim DESCRIPCION As String
            Dim MODELO As String
            Dim MEDIDA As String
            Dim COLOR As String
            Dim CANTIDAD As Double = 0
            Dim KG As String
            Dim MERMA As String
            Dim TURNO As String
            Dim EXTRA As String
            Dim _flag As Boolean = False
            Dim _inicio, _fin As String
            Dim _tiempo_total As String

            dt_detalle_ops = clsPedidoBl.Get_Consulta_Parte_Produccion(codigo, fecha, fecha_fin, op).Tables(0)
            dt_lista_ops = clsPedidoBl.Get_Consulta_Parte_Produccion(codigo, fecha, fecha_fin, op).Tables(1)
            If dt_lista_ops.Rows.Count() > 0 Then
                For Each item As DataRow In dt_lista_ops.Rows
                    For Each item2 As DataRow In dt_detalle_ops.Select("NumeroOP='" & item("NumeroOP") & "'")
                        'If item2("Proceso").ToString = "Inicio Producción" Or item2("Proceso").ToString = "Reinicio" Then
                        '    tiempo_inicio = TimeSpan.Parse(item2("Hora"))
                        'End If
                        'If item2("Proceso").ToString = "Fin Producción" Then
                        '    tiempo_final = TimeSpan.Parse(item2("Hora"))
                        'End If

                        'If tiempo_inicio <> TimeSpan.Parse("00:00:00") And tiempo_final <> TimeSpan.Parse("00:00:00") Then
                        '    tiempo_total = tiempo_final - tiempo_inicio
                        '    _flag = True
                        'End If

                        If item2("Proceso").ToString = "Inicio Producción" Or item2("Proceso").ToString = "Reinicio" Then
                            t_inicio_ = item2("Fecha_Ejecucion")
                            _inicio = "inicio"
                            tiempo_inicio = TimeSpan.Parse(item2("Hora"))
                        End If
                        If item2("Proceso").ToString = "Fin Producción" Then
                            t_fin_ = item2("Fecha_Ejecucion")
                            _fin = "fin"
                            tiempo_final = TimeSpan.Parse(item2("Hora"))
                        End If

                        If _inicio <> "" And _fin <> "" Then
                            Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                            _flag = True

                            Dim horas As Double = 0
                            Dim minutos As Double = 0
                            Dim segundos As Double = 0
                            Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                            horas = 0
                            minutos = 0
                            segundos = 0

                            If resta3 < 60 Then
                                horas = 0
                                minutos = 0
                                segundos = resta3
                            Else
                                minutos = Math.Floor(resta3 / 60)
                                If minutos < 60 Then
                                    horas = 0
                                    segundos = resta3 - (minutos * 60)
                                Else
                                    horas = Math.Floor(minutos / 60)
                                    minutos = minutos - (horas * 60)
                                    segundos = resta3 - (horas * 3600) - (minutos * 60)
                                End If
                            End If
                            _tiempo_total = (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00"))
                        End If

                        FECHA_BI = item2("Fecha_Trabajo").ToString
                        OP_BI = item2("NumeroOP").ToString
                        OPERARIO = item2("Operario").ToString
                        OPERARIO2 = "" 'item2("Proceso").ToString
                        OPERARIO3 = "" 'item2("Proceso").ToString
                        HORA_INICIO = tiempo_inicio.ToString
                        HORA_FINAL = tiempo_final.ToString
                        TOTAL_HORAS = _tiempo_total 'tiempo_total.ToString
                        If item2("SubProceso_Descripcion").ToString <> "" Then
                            CODIGO_ACTIVIDAD = item2("SubProceso_Descripcion").ToString
                        End If
                        If CODIGO_ACTIVIDAD = "PRODUCCION" Then
                            ESTADO = "PRODUCTIVO"
                        Else
                            ESTADO = "IMPRODUCTIVO"
                        End If

                        DESCRIPCION = ""
                        MODELO = ""
                        MEDIDA = ""
                        COLOR = ""
                        CANTIDAD = CANTIDAD + CDbl(item2("Cantidad_Obtenida").ToString)
                        KG = ""
                        MERMA = ""
                        TURNO = ""
                        EXTRA = ""

                        If _flag Then
                            Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                            row("FECHA") = FECHA_BI
                            row("OP") = OP_BI
                            row("OPERARIO") = OPERARIO
                            row("OPERARIO2") = OPERARIO2
                            row("OPERARIO3") = OPERARIO3
                            row("HORA_INICIO") = HORA_INICIO
                            row("HORA_FINAL") = HORA_FINAL
                            row("TOTAL_HORAS") = TOTAL_HORAS
                            row("CODIGO_ACTIVIDAD") = CODIGO_ACTIVIDAD
                            row("ESTADO") = ESTADO
                            row("DESCRIPCION") = DESCRIPCION
                            row("MODELO") = MODELO
                            row("MEDIDA") = MEDIDA
                            row("COLOR") = COLOR
                            row("CANTIDAD") = CANTIDAD
                            row("KG") = KG
                            row("MERMA") = MERMA
                            row("TURNO") = TURNO
                            row("EXTRA") = EXTRA

                            dtdetalleArticuloPrincipal.Rows.Add(row)
                            dtdetalleArticuloPrincipal.AcceptChanges()

                            _flag = False
                            tiempo_inicio = TimeSpan.Parse("00:00:00")
                            tiempo_final = TimeSpan.Parse("00:00:00")
                            tiempo_total = TimeSpan.Parse("00:00:00")
                            CANTIDAD = 0
                            _inicio = ""
                            _fin = ""
                            _tiempo_total = ""
                        End If
                    Next

                    If _inicio <> "" Or _fin <> "" Then
                        Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
                        row("FECHA") = FECHA_BI
                        row("OP") = OP_BI
                        row("OPERARIO") = OPERARIO
                        row("OPERARIO2") = OPERARIO2
                        row("OPERARIO3") = OPERARIO3
                        row("HORA_INICIO") = HORA_INICIO
                        row("HORA_FINAL") = HORA_FINAL
                        row("TOTAL_HORAS") = TOTAL_HORAS
                        row("CODIGO_ACTIVIDAD") = CODIGO_ACTIVIDAD
                        row("ESTADO") = ESTADO
                        row("DESCRIPCION") = DESCRIPCION
                        row("MODELO") = MODELO
                        row("MEDIDA") = MEDIDA
                        row("COLOR") = COLOR
                        row("CANTIDAD") = CANTIDAD
                        row("KG") = KG
                        row("MERMA") = MERMA
                        row("TURNO") = TURNO
                        row("EXTRA") = EXTRA

                        dtdetalleArticuloPrincipal.Rows.Add(row)
                        dtdetalleArticuloPrincipal.AcceptChanges()

                        _flag = False
                        tiempo_inicio = TimeSpan.Parse("00:00:00")
                        tiempo_final = TimeSpan.Parse("00:00:00")
                        tiempo_total = TimeSpan.Parse("00:00:00")
                        CANTIDAD = 0
                        _inicio = ""
                        _fin = ""
                        _tiempo_total = ""
                    End If
                Next
            End If



            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    
    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_numero_op.Text = ""
            txt_numero_op.Enabled = False
        Else
            txt_numero_op.Text = ""
            txt_numero_op.Enabled = True
            txt_numero_op.Focus()
        End If
    End Sub

    Private Sub txt_numero_op_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_numero_op.MouseDoubleClick
        Ayuda_OrdenProduccion()
    End Sub

    Private Sub txt_numero_op_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_numero_op.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_OrdenProduccion()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_numero_op.Text = "" Then
                Ayuda_OrdenProduccion()
            End If
        End If
    End Sub

    Private Sub Ayuda_OrdenProduccion()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PED_SP_S_MANTENIMIENTO_OP_BANDEJA_PRE_PRENSA_REQUERIMIENTO"
            frm.CadenaConsulta = sql
            frm.Titulo = "Lista de Ordenes de Producción"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_numero_op.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class