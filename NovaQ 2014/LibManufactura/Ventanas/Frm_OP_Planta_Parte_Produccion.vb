Imports System.IO
Public Class Frm_OP_Planta_Parte_Produccion
    Dim clsPedidoBl As LibManufactura.ClsOperaciones.ORDERS
    Dim PedidoCabENT As ClsEntidades.MANTENIMIENTO_OP
    Dim articuloPA As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL
    Dim Pedido_Det_HP As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL
    Dim Mantenimiento_Parte_produccion As ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION
    Dim dtdetalle As DataTable
    Dim t_inicio, t_fin As TimeSpan
    Dim t_inicio_oficial, t_fin_oficial As TimeSpan
    Dim t_ejecutado As String

    Dim fecha_pausa As String
    Dim hora_pausa As String
    Dim tipo_pausa As String
    Private dtUsuario As DataTable
    Dim dtdetalleArticuloPrincipal As DataTable
    Dim op_operando As Boolean = False
    Dim _ULTIMO_ITEM As Integer = 0
    Dim _NUMERO_OP As Integer = 0
    Dim _TIPO_ORDEN As String = ""
    Dim _ITEM_OP As Integer = 0
    Dim crystalBL As LibReportes.ClsReporte
    Dim _fin_turno As Boolean = False
    Dim tiempo_total As TimeSpan
    Dim tiempo_total_ As Double
    Dim tiempo_total_improductivo_ As Double
    Dim _activa_timer As Boolean = False
    Dim _item As Integer

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
    Dim dt_tipo_maquina As DataTable
    Dim _tipo_maquina As String = ""
    'Dim dtv As DataView
    Dim dtv2 As DataView
    'Dim dtv3 As DataView
    Dim STRorden As String = String.Empty
    Dim _tiempo_total_programacion As Double = 0.0

    Dim Det_Informes_Mantenimiento As ClsEntidades.PARTE_PRODUCCION
    Dim dtdetalleArticuloPrincipal_Incripciones_RegSanit As DataTable

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.F1 Then Mostrando_Equipos_Planta(TextBox6, TextBox5, "A")
        If e.KeyCode = Keys.Enter Then
            If TextBox6.Text = String.Empty Then
                Mostrando_Equipos_Planta(TextBox6, TextBox5, "A")
            Else
                dtp_fecha_produccion_programada.Focus()
            End If
        End If
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

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Try
            If txt_usuario.Text = "" Then
                MsgBox("Debe elegir un Usuario. Verifique!!!", MsgBoxStyle.Exclamation)
                txt_usuario.Focus()
                Exit Sub
            End If

            If txt_cod_area.Text = "" Then
                MsgBox("Debe elegir un Area. Verifique!!!", MsgBoxStyle.Exclamation)
                txt_cod_area.Focus()
                Exit Sub
            End If

            If TextBox6.Text = "" Then
                MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
                TextBox6.Focus()
                Exit Sub
            End If

            'If cbo_turno.SelectedIndex = -1 Then
            '    MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If

            'If TextBox6.Text <> "15" And TextBox6.Text <> "20" And TextBox6.Text <> "35" And TextBox6.Text <> "13" And TextBox6.Text <> "25" And TextBox6.Text <> "6" And TextBox6.Text <> "37" Then
            '    MsgBox("El equipo elegido no forma parte de la Producción. Verifique!!!", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If

            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS

            Me.Cursor = Cursors.WaitCursor

            '6	TROQUELADORA
            '25	PLASTIFICADORA
            '35	roland
            '20	SPEED MASTER
            '15 GUIL. POLAR
            Dim dt_detalle_produccion_programada As DataTable
            Dim dt_detalle_produccion_programada2 As DataTable
            'Dim dt_detalle_produccion_programada3 As DataTable

            dt_tipo_maquina = clsPedidoBl.get_Tipo_Maquina(TextBox6.Text.Trim)
            If dt_tipo_maquina.Rows.Count > 0 Then
                _tipo_maquina = dt_tipo_maquina.Rows(0).Item("TIPO").ToString
            Else
                _tipo_maquina = ""
            End If

            'dgv_produccion_programada.DataSource = Nothing
            'dt_detalle_produccion_programada = clsPedidoBl.get_Parte_Produccion_Produccion_Programada_Verificar_Turno(TextBox6.Text.Trim, _
            '                                                                                          dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
            '                                                                                          "Inicio Turno", cbo_turno.Text)

            'If dt_detalle_produccion_programada.Rows.Count = 0 Then
            '    Me.Cursor = Cursors.Default
            '    MsgBox("Debe iniciar el Turno para poder continuar. Verifique!!!", MsgBoxStyle.Exclamation)
            '    btn_iniciar_turno.Visible = True
            '    btn_fin_turno.Visible = False
            '    btn_parte_maquina.Visible = False
            '    btn_grafico_x_op.Visible = False
            '    btn_inoperatividad.Visible = False
            '    btn_act_no_programadas.Visible = False
            '    btn_preparacion_especial.Visible = False
            '    _fin_turno = False
            '    Exit Sub
            'Else
            '    btn_iniciar_turno.Visible = False
            '    btn_inoperatividad.Visible = False 'True
            '    btn_act_no_programadas.Visible = False 'True
            '    btn_preparacion_especial.Visible = False ' True
            '    btn_fin_turno.Visible = True
            '    dt_detalle_produccion_programada = clsPedidoBl.get_Parte_Produccion_Produccion_Programada_Verificar_Turno(TextBox6.Text.Trim, _
            '                                                                                          dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
            '                                                                                          "Fin Turno", cbo_turno.Text)
            '    If dt_detalle_produccion_programada.Rows.Count = 0 Then
            '        btn_iniciar_turno.Visible = False
            '        btn_fin_turno.Visible = True
            '        btn_parte_maquina.Visible = False 'True
            '        btn_grafico_x_op.Visible = False
            '        _fin_turno = False
            '    Else
            '        btn_parte_maquina.Visible = False 'True
            '        btn_grafico_x_op.Visible = False 'True
            '        btn_fin_turno.Visible = False
            '        'btn_inoperatividad.Visible = False
            '        'btn_act_no_programadas.Visible = False
            '        btn_iniciar_turno.Visible = False
            '        btn_act_no_programadas.Visible = False
            '        btn_preparacion_especial.Visible = False ' True
            '        btn_inoperatividad.Visible = False
            '        _fin_turno = True
            '    End If
            'End If

            Dim fecha_1 As Date
            Dim fecha_2 As Date
            Dim fecha_3 As Date
            If chk_adjuntar_ops.Checked Then
                fecha_1 = dtp_fecha_produccion_programada.Value.AddDays(-1).ToString("dd/MM/yyyy")
                fecha_2 = dtp_fecha_produccion_programada.Value.AddDays(-1).ToString("dd/MM/yyyy")

                'If clsPedidoBl.Actualiza_Programacion_Parte_Diario(fecha_1, TextBox6.Text.Trim) Then
                '    fecha_2 = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
                '    dt_detalle_produccion_programada = clsPedidoBl.get_Parte_Produccion_Produccion_Programada2(TextBox6.Text.Trim, _
                '                                                                                          dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                '                                                                                          fecha_2.ToString("dd/MM/yyyy"), _
                '                                                                                          cbo_turno.Text)
                'Else
                '    Me.Cursor = Cursors.Default
                '    MsgBox("Hubo un error al actualizar la fecha de programación. Verifique!!!", MsgBoxStyle.Information, "Sistemas")
                '    Exit Sub
                'End If


                'dtv = New DataView
                dtv2 = New DataView
                'dtv3 = New DataView
                dt_detalle_produccion_programada = clsPedidoBl.get_Parte_Produccion_Produccion_Programada(TextBox6.Text.Trim, _
                                                                                                      dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                      fecha_2.ToString("dd/MM/yyyy"), _
                                                                                                      cbo_turno.Text)
                dtv2 = dt_detalle_produccion_programada.DefaultView
            Else
                fecha_1 = dtp_fecha_produccion_programada.Value.AddDays(-1).ToString("dd/MM/yyyy")
                fecha_2 = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
                fecha_3 = dtp_fecha_produccion_programada.Value.AddDays(1).ToString("dd/MM/yyyy")

                'dtv = New DataView
                dtv2 = New DataView
                'dtv3 = New DataView
                STRorden = ""

                'dt_detalle_produccion_programada = clsPedidoBl.get_Parte_Produccion_Produccion_Programada2(TextBox6.Text.Trim, _
                '                                                                                      fecha_1.ToString("dd/MM/yyyy"), _
                '                                                                                      fecha_2.ToString("dd/MM/yyyy"), _
                '                                                                                      cbo_turno.Text)
                'dtv = dt_detalle_produccion_programada.DefaultView
                dt_detalle_produccion_programada2 = clsPedidoBl.get_Parte_Produccion_Produccion_Programada2(TextBox6.Text.Trim, _
                                                                                                      fecha_2.ToString("dd/MM/yyyy"), _
                                                                                                      fecha_2.ToString("dd/MM/yyyy"), _
                                                                                                      cbo_turno.Text, IIf(chk_programacion_siguiente.Checked, "SI", "NO"))
                dtv2 = dt_detalle_produccion_programada2.DefaultView
                'dt_detalle_produccion_programada3 = clsPedidoBl.get_Parte_Produccion_Produccion_Programada2(TextBox6.Text.Trim, _
                '                                                                                      fecha_3.ToString("dd/MM/yyyy"), _
                '                                                                                      fecha_2.ToString("dd/MM/yyyy"), _
                '                                                                                      cbo_turno.Text)
                'dtv3 = dt_detalle_produccion_programada3.DefaultView

                tb_lista_programada.TabPages.Item(0).Text = fecha_2.ToString("dd/MM/yyyy")
                'tb_lista_programada.TabPages.Item(1).Text = fecha_2.ToString("dd/MM/yyyy")
                'tb_lista_programada.TabPages.Item(2).Text = fecha_3.ToString("dd/MM/yyyy")
                'tb_lista_programada.SelectedIndex = 0
            End If




            'If _tipo_maquina = "4" Then
            '    btn_ver_otra_maquina.Visible = True
            'Else
            '    btn_ver_otra_maquina.Visible = False
            'End If

            'dgv_produccion_programada.DataSource = Nothing
            dgv_produccion_programada2.DataSource = Nothing
            'dgv_produccion_programada3.DataSource = Nothing
            'Formato_Grillas(dtv, dgv_produccion_programada)
            Formato_Grillas(dtv2, dgv_produccion_programada2)
            'Formato_Grillas(dtv3, dgv_produccion_programada3)

            ''inicio de calculo de tiempo
            _tiempo_total_programacion = 0
            txt_tiempo_total_programado.Text = ""
            Dim hora_total As Double = 0
            Dim minutos_total As Double = 0

            For i As Integer = 0 To dgv_produccion_programada2.Rows.Count - 1
                _tiempo_total_programacion = _tiempo_total_programacion + CDbl(dgv_produccion_programada2.Rows(i).Cells("TIEMPO").Value)
                hora_total = hora_total + CDbl(dgv_produccion_programada2.Rows(i).Cells("Hora_Real").Value)
                minutos_total = minutos_total + CDbl(dgv_produccion_programada2.Rows(i).Cells("Minuto").Value)
            Next

            _tiempo_total_programacion = Math.Round(_tiempo_total_programacion, 2)

            'If _tiempo_total_programacion > 0 Then
            '    Dim parte_entera As Long = 0
            '    parte_entera = Convert.ToInt64(Math.Truncate(_tiempo_total_programacion))
            '    If parte_entera > 0 Then
            '        If (_tiempo_total_programacion - parte_entera) >= 0.6 Then
            '            txt_tiempo_total_programado.Text = CStr(parte_entera + 1) + " h"
            '        Else
            '            txt_tiempo_total_programado.Text = CStr(parte_entera) + " h"
            '        End If
            '    Else
            '        If _tiempo_total_programacion >= 0.6 Then
            '            txt_tiempo_total_programado.Text = "1 h"
            '        End If
            '    End If
            '    'Dim parte_Decimal As Double = parte_entera - _tiempo_total_programacion
            '    If (_tiempo_total_programacion - parte_entera) >= 0.6 Then
            '        txt_tiempo_total_programado.Text = txt_tiempo_total_programado.Text + " " + CStr(Math.Round(((_tiempo_total_programacion - parte_entera) - 0.6) * 100, 2)) + "'"
            '    Else
            '        txt_tiempo_total_programado.Text = txt_tiempo_total_programado.Text + " " + CStr(Math.Round(((_tiempo_total_programacion - parte_entera)) * 100, 2)) + "'"
            '    End If
            'ElseIf _tiempo_total_programacion <= 0 Then
            '    txt_tiempo_total_programado.Text = ""
            'End If

            If minutos_total > 0 Then
                Dim parte_entera As Double = 0
                parte_entera = Math.Floor(minutos_total / 60)
                hora_total = hora_total + parte_entera

                minutos_total = Math.Round((((minutos_total / 60) - Math.Floor(minutos_total / 60)) * 60), 0)

                txt_tiempo_total_programado.Text = CStr(hora_total) + " h " + CStr(minutos_total) + "'"

            ElseIf minutos_total <= 0 Then
                txt_tiempo_total_programado.Text = ""
            End If

            ''fin de calculo de tiempo

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Formato_Grillas(ByVal dt_puente As DataView, ByVal dg_puente As DataGridView)
        If dt_puente.Count() <> 0 Then
            
            If _tipo_maquina = "1" Then 'TextBox6.Text.Trim = "15" Or TextBox6.Text.Trim = "37" Then 'guillotina polar
                dg_puente.DataSource = dt_puente
                dg_puente.Columns("Orden").Width = 40
                dg_puente.Columns(0).Visible = False
                dg_puente.Columns(1).Visible = False
                dg_puente.Columns("Fecha Programada").Visible = True
                dg_puente.Columns("Fecha.Ingreso").Visible = False
                'dgv_produccion_programada.Columns("Orden").Width = 30
                dg_puente.Columns(4).Visible = False
                dg_puente.Columns(5).Visible = False
                dg_puente.Columns(6).Visible = False
                dg_puente.Columns(7).Width = 60
                dg_puente.Columns(8).Width = 80
                dg_puente.Columns(9).Width = 80
                dg_puente.Columns(10).Width = 150
                dg_puente.Columns(11).Width = 150
                dg_puente.Columns(12).Width = 150
                dg_puente.Columns(13).Width = 80
                dg_puente.Columns("Hora").Width = 50
                dg_puente.Columns(15).Width = 150
                dg_puente.Columns("Formato").Width = 80
                dg_puente.Columns(17).Width = 100
                dg_puente.Columns(19).Width = 100
                dg_puente.Columns("Hora Inicio").Visible = False
                dg_puente.Columns("Hora Final").Visible = False
                dg_puente.Columns("Pliegos Buenos").Visible = False
                dg_puente.Columns("Pliegos Malos").Visible = False
                dg_puente.Columns("PliegosBuenos").Visible = False
                dg_puente.Columns("PliegosMalos").Visible = False
                dg_puente.Columns("Observaciones Producción").Visible = False
                dg_puente.Columns("Hora_Real").Visible = False
                dg_puente.Columns("Minuto").Visible = False
                dg_puente.Columns("Estado").Width = 80
                dg_puente.Columns("Hora_Prep").Visible = False
                dg_puente.Columns("Minuto_Prep").Visible = False
                dg_puente.Columns("ObservacionesProducción").Width = 350
                dg_puente.Columns("DISPONIBILIDAD_PAPEL").HeaderText = "Papel Disponible?"
                dg_puente.Columns("NumeroOP").Visible = False

                dg_puente.Columns("Elemento").HeaderText = "Und"
                dg_puente.Columns("Tipo.Corte").Visible = False
                dg_puente.Columns("Material").Visible = False
                dg_puente.Columns("Formato").Visible = False
                dg_puente.Columns("DISPONIBILIDAD_PAPEL").Visible = False
                dg_puente.Columns("Tiraje").Visible = False
                dg_puente.Columns("Fecha.Entrega").Visible = False

                dg_puente.Columns("Elemento").Width = 50
                dg_puente.Columns("Cliente").Width = 250
                dg_puente.Columns("Producto").Width = 350
                dg_puente.Columns("Observaciones").Width = 350

                dg_puente.Columns("TIPO_ORDEN").HeaderText = "Tipo Orden"
                dg_puente.Columns("TIPO_ORDEN").DisplayIndex = 4

            ElseIf _tipo_maquina = "2" Then 'TextBox6.Text.Trim = "20" Or TextBox6.Text.Trim = "35" Or TextBox6.Text.Trim = "13" Then 'SM o ROLAND
                dg_puente.DataSource = dt_puente
                dg_puente.Columns(0).Visible = False
                dg_puente.Columns(1).Visible = False
                dg_puente.Columns(2).Width = 70
                dg_puente.Columns("Orden").Width = 40
                dg_puente.Columns(4).Visible = False
                dg_puente.Columns(5).Visible = False
                dg_puente.Columns(6).Visible = False
                dg_puente.Columns(7).Width = 60
                dg_puente.Columns(8).Width = 80
                dg_puente.Columns(9).Width = 80
                dg_puente.Columns(10).Width = 150
                dg_puente.Columns(11).Width = 150
                dg_puente.Columns(12).Width = 150
                dg_puente.Columns(13).Width = 80
                dg_puente.Columns(14).Width = 100
                dg_puente.Columns(15).Width = 150 'color
                dg_puente.Columns(18).Width = 50
                dg_puente.Columns(19).Width = 100
                dg_puente.Columns(20).Width = 50
                dg_puente.Columns(21).Width = 100
                dg_puente.Columns(22).Width = 50
                dg_puente.Columns(23).Width = 100
                dg_puente.Columns(24).Width = 100
                dg_puente.Columns("Hora Inicio").Visible = False
                dg_puente.Columns("Hora Final").Visible = False
                dg_puente.Columns("Pliegos Buenos").Visible = False
                dg_puente.Columns("Pliegos Malos").Visible = False
                dg_puente.Columns("Observaciones Producción").Visible = False
                dg_puente.Columns("Hora_Real").Visible = False
                dg_puente.Columns("Minuto").Visible = False

                dg_puente.Columns("Fecha Programada").Visible = True
                dg_puente.Columns("Hora").Width = 50
                dg_puente.Columns("Placas").Visible = False 'Width = 50
                dg_puente.Columns("Formato").Width = 80
                dg_puente.Columns("Estado").Width = 80
                dg_puente.Columns("Hora_Prep").Visible = False
                dg_puente.Columns("Minuto_Prep").Visible = False
                dg_puente.Columns("Fecha.Ingreso").Visible = False
                dg_puente.Columns("ObservacionesProducción").Width = 350
                dg_puente.Columns("DISPONIBILIDAD_PAPEL").HeaderText = "Papel Disponible?"
                dg_puente.Columns("DISPONIBILIDAD_PLACA").HeaderText = "Placa Disponible?"
                dg_puente.Columns("NumeroOP").Visible = False
            ElseIf _tipo_maquina = "3" Then 'TextBox6.Text.Trim = "25" Or TextBox6.Text.Trim = "28" Or TextBox6.Text.Trim = "18" Or TextBox6.Text.Trim = "40" Then 'PLASTIFICADORA
                dg_puente.DataSource = dt_puente
                dg_puente.Columns(0).Visible = False
                dg_puente.Columns(1).Visible = False
                dg_puente.Columns(2).Width = 70
                dg_puente.Columns("Orden").Width = 40
                dg_puente.Columns(4).Visible = False
                dg_puente.Columns(5).Visible = False
                dg_puente.Columns(6).Visible = False
                dg_puente.Columns(7).Width = 60
                dg_puente.Columns(8).Width = 80
                dg_puente.Columns(9).Width = 80
                dg_puente.Columns(10).Width = 150
                dg_puente.Columns(11).Width = 150
                dg_puente.Columns(12).Width = 150
                dg_puente.Columns(13).Width = 80
                dg_puente.Columns(14).Width = 50
                dg_puente.Columns(15).Width = 100
                dg_puente.Columns(16).Width = 50
                dg_puente.Columns(17).Width = 150
                dg_puente.Columns(18).Width = 50
                dg_puente.Columns(19).Width = 100
                dg_puente.Columns("Hora Inicio").Visible = False
                dg_puente.Columns("Hora Final").Visible = False
                dg_puente.Columns("Pliegos Buenos").Visible = False
                dg_puente.Columns("Pliegos Malos").Visible = False
                dg_puente.Columns("Observaciones Producción").Visible = False
                dg_puente.Columns("Hora_Real").Visible = False
                dg_puente.Columns("Minuto").Visible = False

                dg_puente.Columns("Fecha Programada").Visible = True
                dg_puente.Columns("Hora").Width = 50
                dg_puente.Columns("Formato").Width = 80
                dg_puente.Columns("Estado").Width = 80
                dg_puente.Columns("Hora_Prep").Visible = False
                dg_puente.Columns("Minuto_Prep").Visible = False
                dg_puente.Columns("Fecha.Ingreso").Visible = False
                dg_puente.Columns("ObservacionesProducción").Width = 350
                dg_puente.Columns("Tipo.Plastico").Width = 100
                dg_puente.Columns("NumeroOP").Visible = False
            ElseIf _tipo_maquina = "4" Then 'TextBox6.Text.Trim = "6" Or TextBox6.Text = "38" Then 'TROQUELADORA
                dg_puente.DataSource = dt_puente
                dg_puente.Columns(0).Visible = False
                dg_puente.Columns(1).Visible = False
                dg_puente.Columns(2).Width = 70
                dg_puente.Columns("Orden").Width = 40
                dg_puente.Columns(4).Visible = False
                dg_puente.Columns(5).Visible = False
                dg_puente.Columns(6).Visible = False
                dg_puente.Columns(7).Width = 60
                dg_puente.Columns(8).Width = 80
                dg_puente.Columns(9).Width = 80
                dg_puente.Columns(10).Width = 150
                dg_puente.Columns(11).Width = 150
                dg_puente.Columns(12).Width = 150
                dg_puente.Columns(13).Width = 80
                dg_puente.Columns(14).Width = 100
                dg_puente.Columns(15).Width = 150 'material
                dg_puente.Columns(16).Width = 50
                dg_puente.Columns(17).Width = 100
                dg_puente.Columns("Hora Inicio").Visible = False
                dg_puente.Columns("Hora Final").Visible = False
                dg_puente.Columns("Pliegos Buenos").Visible = False
                dg_puente.Columns("Pliegos Malos").Visible = False
                dg_puente.Columns("Observaciones Producción").Visible = False
                dg_puente.Columns("Hora_Real").Visible = False
                dg_puente.Columns("Minuto").Visible = False
                dg_puente.Columns("Fecha Programada").Visible = True
                dg_puente.Columns("Hora").Width = 50
                dg_puente.Columns("Formato").Width = 80
                dg_puente.Columns("Estado").Width = 80
                dg_puente.Columns("Hora_Prep").Visible = False
                dg_puente.Columns("Minuto_Prep").Visible = False
                dg_puente.Columns("Fecha.Ingreso").Visible = False
                dg_puente.Columns("ObservacionesProducción").Width = 350
                dg_puente.Columns("NumeroOP").Visible = False
            Else 'OTROS
                dg_puente.DataSource = dt_puente
                dg_puente.Columns(0).Visible = False
                dg_puente.Columns(1).Visible = False
                dg_puente.Columns(2).Width = 70
                dg_puente.Columns("Orden").Width = 40
                dg_puente.Columns(4).Visible = False
                dg_puente.Columns(5).Visible = False
                dg_puente.Columns(6).Visible = False
                dg_puente.Columns(7).Width = 60
                dg_puente.Columns(8).Width = 80
                dg_puente.Columns(9).Width = 80
                dg_puente.Columns(10).Width = 150
                dg_puente.Columns(11).Width = 150
                dg_puente.Columns(12).Width = 150
                dg_puente.Columns(13).Width = 80
                dg_puente.Columns(14).Width = 100
                dg_puente.Columns(15).Width = 150 'material
                dg_puente.Columns(16).Width = 50
                dg_puente.Columns(17).Width = 100
                dg_puente.Columns("Hora Inicio").Visible = False
                dg_puente.Columns("Hora Final").Visible = False
                dg_puente.Columns("Pliegos Buenos").Visible = False
                dg_puente.Columns("Pliegos Malos").Visible = False
                dg_puente.Columns("Observaciones Producción").Visible = False
                dg_puente.Columns("Hora_Real").Visible = False
                dg_puente.Columns("Minuto").Visible = False
                dg_puente.Columns("Fecha Programada").Visible = True
                dg_puente.Columns("Hora").Width = 50
                dg_puente.Columns("Formato").Width = 80
                dg_puente.Columns("Estado").Width = 80
                dg_puente.Columns("Hora_Prep").Visible = False
                dg_puente.Columns("Minuto_Prep").Visible = False
                dg_puente.Columns("Fecha.Ingreso").Visible = False
                dg_puente.Columns("ObservacionesProducción").Width = 350
                dg_puente.Columns("NumeroOP").Visible = False
            End If

            With dg_puente.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font("Tahoma", 8, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            If dg_puente.Name = "dgv_produccion_programada2" Then
                STRorden = dg_puente.Columns("NumeroOP").Name & "+" & dg_puente.Columns("Cliente").Name & "+" & dg_puente.Columns("Producto").Name
            End If
        End If
    End Sub

    Private Sub Frm_OP_Planta_Parte_Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TextBox6.Text = ""
        TextBox5.Text = ""
        Call GenerarColummnaDataTable_Historial_Personal()
        dtp_fecha_produccion_programada.Value = Date.Now
        dtp_fecha_produccion_programada_fin.Value = DateAdd(DateInterval.Day, 8, Date.Now)
        'CargaUsuarios()
        Cargar_Motivos_Pausa()
        Cargar_Turno()
        cbo_turno.SelectedIndex = 0
        chk_adjuntar_ops.Checked = False
        chk_programacion_siguiente.Checked = False
        btn_ver_otra_maquina.Visible = False
        txt_usuario.Focus()
    End Sub

    Private Sub Cargar_Turno()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cbo_turno.DataSource = monedaBL.get_Turno()
        cbo_turno.ValueMember = "CODIGO"
        cbo_turno.DisplayMember = "DESCRIPCION"

        monedaBL = Nothing
    End Sub

    Private Sub Cargar_Motivos_Pausa()
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        cbo_motivo_pausa.DataSource = monedaBL.get_Motivos_Pausa()
        cbo_motivo_pausa.ValueMember = "CODIGO"
        cbo_motivo_pausa.DisplayMember = "DESCRIPCION"

        cbo_motivo_pausa_falla_equipo.DataSource = monedaBL.get_Motivos_Pausa_Falla_equipo()
        cbo_motivo_pausa_falla_equipo.ValueMember = "CODIGO"
        cbo_motivo_pausa_falla_equipo.DisplayMember = "DESCRIPCION"

        'cbo_proceso_preparacion.DataSource = monedaBL.get_Procesos_Inicio_Prepacion(TextBox6.Text.Trim)
        'cbo_proceso_preparacion.ValueMember = "CODIGO"
        'cbo_proceso_preparacion.DisplayMember = "DESCRIPCION"

        'cbo_produccion.DataSource = monedaBL.get_Procesos_Produccion("")
        'cbo_produccion.ValueMember = "CODIGO"
        'cbo_produccion.DisplayMember = "DESCRIPCION"

        monedaBL = Nothing
    End Sub

    Private Sub Cargar_Motivos_Pausa_Produccion(ByVal _cod_equipo As String)
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
        'cbo_motivo_pausa.DataSource = monedaBL.get_Motivos_Pausa()
        'cbo_motivo_pausa.ValueMember = "CODIGO"
        'cbo_motivo_pausa.DisplayMember = "DESCRIPCION"

        'cbo_motivo_pausa_falla_equipo.DataSource = monedaBL.get_Motivos_Pausa_Falla_equipo()
        'cbo_motivo_pausa_falla_equipo.ValueMember = "CODIGO"
        'cbo_motivo_pausa_falla_equipo.DisplayMember = "DESCRIPCION"

        cbo_area.DataSource = monedaBL.get_Procesos_Area(_cod_equipo)
        cbo_area.ValueMember = "CODIGO"
        cbo_area.DisplayMember = "DESCRIPCION"

        cbo_proceso_preparacion.DataSource = Nothing

        'cbo_proceso_preparacion.DataSource = monedaBL.get_Procesos_Inicio_Prepacion(_cod_equipo)
        'cbo_proceso_preparacion.ValueMember = "CODIGO"
        'cbo_proceso_preparacion.DisplayMember = "DESCRIPCION"

        cbo_produccion.DataSource = monedaBL.get_Procesos_Produccion(_cod_equipo)
        cbo_produccion.ValueMember = "CODIGO"
        cbo_produccion.DisplayMember = "DESCRIPCION"

        cbo_area.SelectedIndex = -1

        monedaBL = Nothing
    End Sub

    Private Sub CargaUsuarios()
        Try
            Me.Cursor = Cursors.WaitCursor
            dtUsuario = New DataTable
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            dtUsuario = clsPedidoBl.get_Parte_Produccion_Usuarios(LibComunVar.ClsVarComun.USUARIO)
            If dtUsuario.Rows.Count > 0 Then
                txt_usuario.Text = dtUsuario.Rows(0).Item("CODUSUARIO").ToString
                txt_nombres.Text = dtUsuario.Rows(0).Item("NOMUSUARIO").ToString

                If dtUsuario.Rows(0).Item("IMAGEN").ToString = String.Empty Then
                    pb_img.Image = Nothing
                Else
                    pb_img.Image = Bytes2Image(dtUsuario.Rows(0).Item("IMAGEN"))
                End If
            Else
                txt_usuario.Text = ""
                txt_nombres.Text = ""
                pb_img.Image = Nothing
            End If
            ' ''txt_usuario.Text = LibComunVar.ClsVarComun.USUARIO
            ' ''txt_nombres.Text = LibComunVar.ClsVarComun.USUARIO
            ' ''Dim ruta_foto As String
            ' ''ruta_foto = Application.StartupPath & "/Fotos/" & LibComunVar.ClsVarComun.USUARIO & ".jpg"

            ' ''If File.Exists(ruta_foto) Then
            ' ''    pb_img.Image = Image.FromFile(ruta_foto)
            ' ''Else
            ' ''    pb_img.Image = Nothing
            ' ''End If


            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pb_inicio.Click
        If pb_inicio.Cursor = Cursors.Default Then
            If Label6.Text = "REINICIAR PRODUCCION" Then
                'If op_operando = True Then
                '    MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe TERMINAR la O.P., para iniciar otro.", MsgBoxStyle.Exclamation, "Sistemas")
                '    Exit Sub
                'End If
            End If
            If MsgBox("Esta seguro de INICIAR PROCESO DE PRODUCCION DEL EQUIPO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Timer1.Stop()
                pnl_proceso_produccion.Visible = True
                pnl_proceso_produccion.BringToFront()

                pb_inicio.Cursor = Cursors.No
                cbo_produccion.SelectedIndex = -1
                Button1.Enabled = False
            End If
        End If

        'If pb_inicio.Cursor = Cursors.Default Then
        '    pb_inicio.Cursor = Cursors.No
        '    Try
        '        Dim row As DataRow = dtdetalle.NewRow
        '        If Label6.Text = "REINICIAR PRODUCCION" Then
        '            If op_operando = True Then
        '                MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe TERMINAR la O.P., para iniciar otro.", MsgBoxStyle.Exclamation, "Sistemas")
        '                Exit Sub
        '            End If
        '        End If


        '        For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
        '            _ULTIMO_ITEM = row2("ITEM")
        '            Exit For
        '        Next

        '        row("ITEM") = _ULTIMO_ITEM + 1
        '        _item = row("ITEM")
        '        row("FECHA") = Date.Now.ToString("dd/MM/yyyy")
        '        row("HORA") = Date.Now.ToString("HH:mm:ss")
        '        If Label6.Text = "INICIO PRODUCCION" Then
        '            row("CONCEPTO") = "Inicio Producción"
        '            t_inicio = TimeSpan.Parse(row("HORA"))
        '            lst_historial.Items.Add("Fecha y Hora de Inicio Producción: ")
        '            ListBox1.Items.Add(t_inicio.ToString)
        '            Timer1.Start()
        '        ElseIf Label6.Text = "REINICIAR PRODUCCION" Then
        '            Timer1.Start()
        '            row("CONCEPTO") = "Reinicio"
        '        End If
        '        row("OBSERVACIONES") = ""
        '        row("MOTIVO_PAUSA") = ""
        '        row("PLIEGOS_BUENOS") = ""
        '        row("PLIEGOS_MALOS") = ""

        '        dtdetalle.Rows.Add(row)
        '        dtdetalle.AcceptChanges()

        '        dgv_detalle_historial.DataSource = dtdetalle
        '        Formato_Grilla_Detalle_Op()
        '        pb_inicio.Enabled = True
        '        pb_pausa.Enabled = True
        '        pb_fin.Enabled = True
        '        'pb_pausa_equipo.Enabled = True
        '        pb_inicio_prepar.Enabled = True
        '        Label6.Text = "INICIO PRODUCCION"
        '        pb_inicio.Cursor = Cursors.No
        '        pb_pausa.Cursor = Cursors.Default
        '        pb_fin.Cursor = Cursors.Default
        '        pb_pausa_equipo.Cursor = Cursors.Default
        '        pb_inicio_prepar.Cursor = Cursors.No

        '        pb_inicio_prepar_des.Visible = True
        '        pb_inicio_des.Visible = True
        '        'pb_pausa_equipo_des.Visible = False
        '        pb_pausa_des.Visible = False
        '        pb_fin_des.Visible = False

        '        Call Guardar_Parte_Produccion("OPERANDO")

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If

    End Sub

    Private Function Guardar_Parte_Produccion(ByVal _ESTADO As String) As Boolean

        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Mantenimiento_Parte_produccion = New ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION

            For Each row As DataRow In dtdetalle.Select("ITEM=" & _item)
                With Mantenimiento_Parte_produccion
                    .ID = _NUMERO_OP
                    .ITEM = _ITEM_OP
                    .TIPO_ORDEN = _TIPO_ORDEN
                    .ITEM_DET = row("ITEM")
                    .CONCEPTO = row("CONCEPTO")
                    .FECHA = row("FECHA")
                    .HORA = row("HORA")
                    .OBSERVACIONES = row("OBSERVACIONES")
                    .USER_ID = txt_usuario.Text 'LibComunVar.ClsVarComun.USUARIO
                    .PC_ID = Environment.MachineName
                    Dim _TIEMPO_CIERRE As String = Format(Math.Abs(CInt(lbl_hora.Text)), "00") & ":" & Format(Math.Abs(CInt(lbl_minuto.Text)), "00") & ":" & Format(Math.Abs(CInt(lbl_segundo.Text)), "00")
                    If lbl_hora.Text > 0 Then
                        .SIGNO = "POSITIVO"
                    ElseIf lbl_minuto.Text > 0 Then
                        .SIGNO = "POSITIVO"
                    Else
                        If lbl_hora.Text < 0 Then
                            .SIGNO = "NEGATIVO"
                        ElseIf lbl_minuto.Text < 0 Then
                            .SIGNO = "NEGATIVO"
                        End If
                    End If
                    .TIEMPO_CIERRE = _TIEMPO_CIERRE.ToString
                    .ESTADO = _ESTADO
                    .TURNO = "" 'cbo_turno.Text
                    .FECHA_TURNO = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
                    .MOTIVO_PAUSA = row("MOTIVO_PAUSA")
                    .PLIEGOS_BUENOS = row("PLIEGOS_BUENOS")
                    .PLIEGOS_MALOS = row("PLIEGOS_MALOS")
                    .AREA_PP = txt_cod_area.Text
                End With
            Next

            If clsPedidoBl.Guardar_Parte_Produccion_Detalle(Mantenimiento_Parte_produccion, TextBox6.Text.Trim) = False Then
                Call Guardar_Parte_Produccion(_ESTADO)
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_ms.Text += 1

        If lbl_ms.Text = 10 Then
            lbl_ms.Text = 1
            lbl_segundo.Text += 1
        End If

        If lbl_segundo.Text = 59 Then
            lbl_segundo.Text = 0
            lbl_minuto.Text += 1
        End If

        If lbl_minuto.Text = 59 Then
            lbl_minuto.Text = 0
            lbl_hora.Text += 1
        End If

        'lbl_ms.Text += 1

        'If lbl_ms.Text = 10 Then
        '    lbl_ms.Text = 1
        '    lbl_segundo.Text -= 1
        'End If

        'If lbl_segundo.Text = 0 Then
        '    lbl_segundo.Text = 59
        '    lbl_minuto.Text -= 1
        'End If

        'If lbl_minuto.Text = 0 Then
        '    If lbl_hora.Text > 0 Then
        '        lbl_minuto.Text = 59
        '        lbl_hora.Text -= 1
        '    End If
        'End If

        'If lbl_minuto.Text < 0 And lbl_minuto.Text > -10 And lbl_hora.Text = 0 Then
        '    lbl_hora.ForeColor = Color.Orange
        '    lbl_minuto.ForeColor = Color.Orange
        '    lbl_segundo.ForeColor = Color.Orange
        '    lbl_ms.ForeColor = Color.Orange
        '    Label4.ForeColor = Color.Orange
        '    Label2.ForeColor = Color.Orange
        'ElseIf lbl_minuto.Text < 0 And lbl_minuto.Text < -10 Then
        '    lbl_hora.ForeColor = Color.Red
        '    lbl_minuto.ForeColor = Color.Red
        '    lbl_segundo.ForeColor = Color.Red
        '    lbl_ms.ForeColor = Color.Red
        '    Label4.ForeColor = Color.Red
        '    Label2.ForeColor = Color.Red
        'End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pb_pausa.Click
        If pb_pausa.Cursor = Cursors.Default Then
            Timer1.Stop()
            If MsgBox("Esta seguro de PAUSAR la PRODUCCION?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                fecha_pausa = Date.Now.ToString("dd/MM/yyyy")
                hora_pausa = Date.Now.ToString("HH:mm:ss")
                tipo_pausa = "PAUSA"
                'lbl_inicio.Text = "REINICIAR"
                pnl_pausa.Visible = True
                pnl_pausa.BringToFront()
                txt_motivo_pausa.Text = ""
                txt_buenos_pausa.Text = ""
                txt_malos_pausa.Text = ""
                txt_buenos_pausa.ReadOnly = False
                txt_malos_pausa.ReadOnly = False
                txt_buenos_pausa.BackColor = Color.Aquamarine
                txt_malos_pausa.BackColor = Color.Aquamarine
                cbo_motivo_pausa.SelectedIndex = -1

                pb_inicio_prepar_des.Visible = False
                pb_inicio_des.Visible = False
                'pb_pausa_equipo_des.Visible = True
                'pb_pausa_des.Visible = True
                pb_fin_des.Visible = True

                txt_motivo_pausa.Focus()
            Else
                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pb_fin.Click
        If pb_fin.Cursor = Cursors.Default Then
            Timer1.Stop()
            If MsgBox("Esta seguro de FINALIZAR LA PRODUCCION?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                pb_fin.Cursor = Cursors.No
                Button1.Enabled = False

                lbl_ms.Text = "0"
                lbl_segundo.Text = "00"
                lbl_minuto.Text = "00"
                lbl_hora.Text = "00"
                pb_inicio.Enabled = True
                pb_pausa.Enabled = True
                pb_fin.Enabled = True
                'pb_pausa_equipo.Enabled = True
                pb_inicio_prepar.Enabled = True

                pb_inicio.Cursor = Cursors.No
                pb_pausa.Cursor = Cursors.No
                pb_fin.Cursor = Cursors.No
                pb_pausa_equipo.Cursor = Cursors.No
                pb_inicio_prepar.Cursor = Cursors.No

                pb_inicio_prepar_des.Visible = True
                pb_inicio_des.Visible = False 'True
                'pb_pausa_equipo_des.Visible = True
                'pb_pausa_des.Visible = True
                pb_fin_des.Visible = True

                pnl_fin.Visible = True
                pnl_fin.BringToFront()
                txt_buenos.Text = ""
                txt_malos.Text = ""
                txt_obs_produccion.Text = ""
                txt_obs_produccion.Focus()
                'Timer1.Stop()
            Else
                Timer1.Start()
            End If
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Panel1.Visible = False
        Timer1.Stop()
    End Sub



    Public Sub GenerarColummnaDataTable()
        dtdetalle = New DataTable
        dtdetalle.Columns.Add("ITEM", Type.GetType("System.Int64")) '0
        dtdetalle.Columns.Add("CONCEPTO", Type.GetType("System.String")) '1
        dtdetalle.Columns.Add("FECHA", Type.GetType("System.String")) '2
        dtdetalle.Columns.Add("HORA", Type.GetType("System.String")) '3
        dtdetalle.Columns.Add("OBSERVACIONES", Type.GetType("System.String")) '4
        dtdetalle.Columns.Add("TIEMPO_CIERRE", Type.GetType("System.String")) '5
        dtdetalle.Columns.Add("SIGNO", Type.GetType("System.String")) '6
        dtdetalle.Columns.Add("FECHA_REAL", Type.GetType("System.String")) '7
        dtdetalle.Columns.Add("MOTIVO_PAUSA", Type.GetType("System.String")) '8
        dtdetalle.Columns.Add("PLIEGOS_BUENOS", Type.GetType("System.Double")) '9
        dtdetalle.Columns.Add("PLIEGOS_MALOS", Type.GetType("System.String")) '10
        dtdetalle.Columns.Add("TIEMPO_ISOGRAF", Type.GetType("System.Double")) '11
        dtdetalle.Columns.Add("PROCESO_INICIO_PREPARACION", Type.GetType("System.String")) '12

        dgv_detalle_historial.DataSource = Nothing
        dgv_detalle_historial.DataSource = dtdetalle

        dgv_detalle_historial.Columns(0).HeaderText = "Item"
        dgv_detalle_historial.Columns(1).HeaderText = "Concepto"
        dgv_detalle_historial.Columns(2).HeaderText = "Fecha"
        dgv_detalle_historial.Columns(3).HeaderText = "Hora"
        dgv_detalle_historial.Columns(4).HeaderText = "Observaciones"
        dgv_detalle_historial.Columns(5).Visible = False
        dgv_detalle_historial.Columns(6).Visible = False
        dgv_detalle_historial.Columns(7).Visible = False
        dgv_detalle_historial.Columns(8).Visible = False
        dgv_detalle_historial.Columns(9).HeaderText = "Cantidad"
        dgv_detalle_historial.Columns(10).Visible = False
        dgv_detalle_historial.Columns(11).Visible = False
        dgv_detalle_historial.Columns(12).HeaderText = "Proceso"

        dgv_detalle_historial.AutoResizeColumns()
        dgv_detalle_historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Public Sub Formato_Grilla_Detalle_Op()
        If dtdetalle.Rows.Count > 0 Then
            dgv_detalle_historial.DataSource = dtdetalle

            dgv_detalle_historial.Columns(0).HeaderText = "Item"
            dgv_detalle_historial.Columns(1).HeaderText = "Concepto"
            dgv_detalle_historial.Columns(2).HeaderText = "Fecha"
            dgv_detalle_historial.Columns(3).HeaderText = "Hora"
            dgv_detalle_historial.Columns(4).HeaderText = "Observaciones"
            dgv_detalle_historial.Columns(5).Visible = False
            dgv_detalle_historial.Columns(6).Visible = False
            dgv_detalle_historial.Columns(7).Visible = False
            dgv_detalle_historial.Columns(8).Visible = False
            dgv_detalle_historial.Columns(9).HeaderText = "Cantidad"
            dgv_detalle_historial.Columns(10).Visible = False
            dgv_detalle_historial.Columns(11).Visible = False
            dgv_detalle_historial.Columns(12).HeaderText = "Proceso"

            dgv_detalle_historial.AutoResizeColumns()
            dgv_detalle_historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Else
            dgv_detalle_historial.DataSource = Nothing
        End If

    End Sub

    Private Sub Detalle_Op(ByVal opcion_ As String, ByVal id_ As Integer, ByVal item_ As Integer)
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim dt_detalle As DataTable

            dt_tipo_maquina = clsPedidoBl.get_Tipo_Maquina(opcion_)
            If dt_tipo_maquina.Rows.Count > 0 Then
                _tipo_maquina = dt_tipo_maquina.Rows(0).Item("TIPO").ToString
            Else
                _tipo_maquina = ""
            End If

            dt_detalle = clsPedidoBl.get_Parte_Produccion_Detalle(opcion_, id_, item_)
            dgv_detalle_op.DataSource = Nothing
            If dt_detalle.Rows.Count() <> 0 Then
                If _tipo_maquina = "1" Then 'TextBox6.Text.Trim = "15" Or TextBox6.Text.Trim = "37" Then 'guillotina polar
                    dgv_detalle_op.DataSource = dt_detalle

                    dgv_detalle_op.Columns(0).Visible = False
                    dgv_detalle_op.Columns(1).Visible = False
                    dgv_detalle_op.Columns(3).Visible = False
                    dgv_detalle_op.Columns(4).Visible = False
                    dgv_detalle_op.Columns(5).Visible = False
                    dgv_detalle_op.Columns(6).Visible = False
                    dgv_detalle_op.Columns(14).Visible = False
                    dgv_detalle_op.Columns("Fecha Programada").Visible = False
                    dgv_detalle_op.Columns("Fecha.Ingreso").Visible = False
                    dgv_detalle_op.Columns("Fecha.Entrega").Visible = False
                    dgv_detalle_op.Columns("Num.O.P.").Visible = False
                    dgv_detalle_op.Columns("Tipo.Corte").Visible = False
                    dgv_detalle_op.Columns("Material").Visible = False
                    dgv_detalle_op.Columns("Formato").Visible = False
                    dgv_detalle_op.Columns("Elemento").HeaderText = "Und"
                    dgv_detalle_op.AutoResizeColumns()
                    dgv_detalle_op.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ElseIf _tipo_maquina = "2" Then ' 'SM o ROLAND
                    dgv_detalle_op.DataSource = dt_detalle
                    dgv_detalle_op.Columns(0).Visible = False
                    dgv_detalle_op.Columns(1).Visible = False
                    dgv_detalle_op.Columns(4).Visible = False
                    dgv_detalle_op.Columns(5).Visible = False
                    dgv_detalle_op.Columns(6).Visible = False
                    dgv_detalle_op.Columns(17).Visible = False

                    dgv_detalle_op.Columns("Fecha Programada").Visible = False
                    dgv_detalle_op.Columns("Fecha.Ingreso").Visible = False
                    dgv_detalle_op.Columns("Fecha.Entrega").Visible = False
                    dgv_detalle_op.Columns("Num.O.P.").Visible = False
                    dgv_detalle_op.AutoResizeColumns()
                    dgv_detalle_op.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ElseIf _tipo_maquina = "3" Then ' 'PLASTIFICADORA
                    dgv_detalle_op.DataSource = dt_detalle
                    dgv_detalle_op.Columns(0).Visible = False
                    dgv_detalle_op.Columns(1).Visible = False
                    dgv_detalle_op.Columns(4).Visible = False
                    dgv_detalle_op.Columns(5).Visible = False
                    dgv_detalle_op.Columns(6).Visible = False
                    dgv_detalle_op.Columns(15).Visible = False 'hora

                    dgv_detalle_op.Columns("Fecha Programada").Visible = False
                    dgv_detalle_op.Columns("Fecha.Ingreso").Visible = False
                    dgv_detalle_op.Columns("Fecha.Entrega").Visible = False
                    dgv_detalle_op.Columns("Num.O.P.").Visible = False
                    dgv_detalle_op.AutoResizeColumns()
                    dgv_detalle_op.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                ElseIf _tipo_maquina = "4" Then ' 'TROQUELADORA
                    dgv_detalle_op.DataSource = dt_detalle
                    dgv_detalle_op.Columns(0).Visible = False
                    dgv_detalle_op.Columns(1).Visible = False
                    dgv_detalle_op.Columns(4).Visible = False
                    dgv_detalle_op.Columns(5).Visible = False
                    dgv_detalle_op.Columns(6).Visible = False
                    dgv_detalle_op.Columns(14).Visible = False

                    dgv_detalle_op.Columns("Fecha Programada").Visible = False
                    dgv_detalle_op.Columns("Fecha.Ingreso").Visible = False
                    dgv_detalle_op.Columns("Fecha.Entrega").Visible = False
                    dgv_detalle_op.Columns("Num.O.P.").Visible = False
                    dgv_detalle_op.AutoResizeColumns()
                    dgv_detalle_op.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                End If

                With dgv_detalle_op.ColumnHeadersDefaultCellStyle
                    .BackColor = Color.Navy
                    .ForeColor = Color.White
                    .Font = New Font("Tahoma", 8, FontStyle.Bold)
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Detalle_Op_Operando(ByVal opcion_ As String, ByVal fecha_ As String)
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim dt_detalle As DataTable

            dt_detalle = clsPedidoBl.get_Verificar_OP_operando(opcion_, fecha_)
            'dgv_detalle_op.DataSource = Nothing
            If dt_detalle.Rows.Count() <> 0 Then
                op_operando = True
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Detalle_Op_Operando_ii(ByVal opcion_ As String, ByVal fecha_ As String, ByVal id_ As Integer, ByVal item_ As Integer)
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim dt_detalle As DataTable

            dt_detalle = clsPedidoBl.get_Verificar_OP_operando_ii(opcion_, fecha_, id_, item_)
            'dgv_detalle_op.DataSource = Nothing
            If dt_detalle.Rows.Count() <> 0 Then
                op_operando = True
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Detalle_Actividad_Op(ByVal opcion_ As String, ByVal id_ As Integer, ByVal item_ As Integer)
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim _flag_final As Boolean = False
            Dim _flag_pausa As Boolean = False
            Dim _flag_inicio As Boolean = False
            Dim t_inicio_ As Date
            Dim t_fin_ As Date
            Dim horas As Double = 0
            Dim minutos As Double = 0
            Dim segundos As Double = 0
            Dim contador As Integer = 0
            Dim _estado_final As String = ""
            t_ejecutado = ""
            _activa_timer = False

            dtdetalle = clsPedidoBl.get_Parte_Produccion_Detalle_Movimientos(opcion_, id_, item_)
            dgv_detalle_historial.DataSource = Nothing
            If dtdetalle.Rows.Count() > 0 Then
                dgv_detalle_historial.DataSource = dtdetalle
                dgv_detalle_historial.Columns("TIEMPO_CIERRE").Visible = False
                dgv_detalle_historial.Columns("SIGNO").Visible = False
                dgv_detalle_historial.Columns("FECHA_REAL").Visible = False
                dgv_detalle_historial.Columns("MOTIVO_PAUSA").Visible = False
                dgv_detalle_historial.Columns("PLIEGOS_BUENOS").HeaderText = "Cantidad"
                dgv_detalle_historial.Columns("PLIEGOS_MALOS").Visible = False
                dgv_detalle_historial.Columns("TIEMPO_ISOGRAF").Visible = False
                dgv_detalle_historial.Columns("PROCESO_INICIO_PREPARACION").HeaderText = "Proceso Inicio Preparación"

                lst_historial.Items.Clear()
                ListBox1.Items.Clear()
                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                    _flag_final = True
                    Exit For
                Next

                If _flag_final = True Then 'ya termino

                    For Each row As DataRow In dtdetalle.Select("CONCEPTO in ('Pausa','Pausa Equipo Averiado','Pausa Falla en Equipo')")
                        _flag_pausa = True
                        Exit For
                    Next

                    If _flag_pausa = False Then 'SI NO HAY PAUSA
                        lst_historial.Items.Add("Fecha y Hora Final : ")
                        ListBox1.Items.Add(t_fin_.ToString)

                        Dim resta As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                        If resta < 60 Then
                            horas = 0
                            minutos = 0
                            segundos = resta
                        Else
                            minutos = Math.Floor(resta / 60)
                            If minutos < 60 Then
                                horas = 0
                                segundos = resta - (minutos * 60)
                            Else
                                horas = Math.Floor(minutos / 60)
                                minutos = minutos - (horas * 60)
                                segundos = resta - (horas * 3600) - (minutos * 60)
                            End If
                        End If



                        lst_historial.Items.Add("Tiempo Ejecutado : ")
                        ListBox1.Items.Add(Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00"))
                        lst_historial.Items.Add("---------------------------------------------------------------------")

                        'Dim programado As TimeSpan = TimeSpan.Parse(dgv_produccion_programada.CurrentRow.Cells("Hora_Real").Value & ":" & dgv_produccion_programada.CurrentRow.Cells("Minuto").Value)
                        'lst_historial.Items.Add("Tiempo Programado : " & programado.ToString)
                        'lst_historial.Items.Add("Tiempo Ejecutado : " & resta.ToString)
                        t_ejecutado = (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00"))
                        'Dim resta2 As TimeSpan = programado - resta
                        'lst_historial.Items.Add("Tiempo Neto : " & resta2.ToString)

                        lbl_hora.Text = "00"
                        lbl_minuto.Text = "00"
                        lbl_segundo.Text = "00"
                        lbl_ms.Text = "00"

                        pb_inicio.Enabled = True
                        pb_pausa.Enabled = True
                        pb_fin.Enabled = True
                        'pb_pausa_equipo.Enabled = True
                        pb_inicio_prepar.Enabled = True

                        pb_inicio.Cursor = Cursors.No
                        pb_pausa.Cursor = Cursors.No
                        pb_fin.Cursor = Cursors.No
                        pb_pausa_equipo.Cursor = Cursors.No
                        pb_inicio_prepar.Cursor = Cursors.No

                        pb_inicio_prepar_des.Visible = True
                        pb_inicio_des.Visible = False 'True
                        'pb_pausa_equipo_des.Visible = True
                        'pb_pausa_des.Visible = True
                        pb_fin_des.Visible = True

                    ElseIf _flag_pausa = True Then 'SI HAY PAUSA
                        Dim items_pausa As Integer = 0
                        Dim items_reinicio As Integer = 0
                        Dim ultima_pausa As Integer = 0
                        Dim ultima_reinicio As Integer = 0

                        Dim tiempo_transcurrido As Double
                        Dim _inicio As String = ""
                        Dim _fin As String = ""
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                            If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
                                If _inicio = "" Then
                                    t_inicio_ = row("FECHA_REAL")
                                    't_inicio_oficial = TimeSpan.Parse(row("FECHA_REAL"))
                                    _inicio = "inicio"
                                End If
                            End If
                            If row("CONCEPTO") = "Reinicio" Then
                                t_inicio_ = row("FECHA_REAL")
                                _inicio = "inicio"
                            End If
                            If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Or row("CONCEPTO") = "Pausa Falla en Equipo" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If
                            If row("CONCEPTO") = "Final" Or row("CONCEPTO") = "Fin Producción" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If

                            If _inicio <> "" And _fin <> "" Then
                                Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                tiempo_transcurrido = tiempo_transcurrido + resta3
                                _inicio = ""
                                _fin = ""
                            End If
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                            t_fin_ = row("FECHA_REAL")
                        Next

                        If tiempo_transcurrido < 60 Then
                            horas = 0
                            minutos = 0
                            segundos = tiempo_transcurrido
                        Else
                            minutos = Math.Floor(tiempo_transcurrido / 60)
                            If minutos < 60 Then
                                horas = 0
                                segundos = tiempo_transcurrido - (minutos * 60)
                            Else
                                horas = Math.Floor(minutos / 60)
                                minutos = minutos - (horas * 60)
                                segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                            End If
                        End If

                        lst_historial.Items.Add("Fecha y Hora Final : ")
                        ListBox1.Items.Add(t_fin_.ToString)
                        lst_historial.Items.Add("Tiempo Ejecutado : ")
                        ListBox1.Items.Add(Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00"))
                        lst_historial.Items.Add("---------------------------------------------------------------------")

                        'Dim programado As TimeSpan = TimeSpan.Parse(dgv_produccion_programada.CurrentRow.Cells("Hora_Real").Value & ":" & dgv_produccion_programada.CurrentRow.Cells("Minuto").Value)
                        'lst_historial.Items.Add("Tiempo Programado : " & programado.ToString)
                        'lst_historial.Items.Add("Tiempo Ejecutado : " & tiempo_transcurrido.ToString)
                        t_ejecutado = (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00"))
                        'Dim resta2 As TimeSpan = programado - tiempo_transcurrido
                        'lst_historial.Items.Add("Tiempo Neto : " & resta2.ToString)

                        lbl_hora.Text = "00"
                        lbl_minuto.Text = "00"
                        lbl_segundo.Text = "00"
                        lbl_ms.Text = "00"

                        pb_inicio.Enabled = True
                        pb_pausa.Enabled = True
                        pb_fin.Enabled = True
                        'pb_pausa_equipo.Enabled = True
                        pb_inicio_prepar.Enabled = True

                        pb_inicio.Cursor = Cursors.No
                        pb_pausa.Cursor = Cursors.No
                        pb_fin.Cursor = Cursors.No
                        pb_pausa_equipo.Cursor = Cursors.No
                        pb_inicio_prepar.Cursor = Cursors.No


                        pb_inicio_prepar_des.Visible = True
                        pb_inicio_des.Visible = False 'True
                        'pb_pausa_equipo_des.Visible = True
                        'pb_pausa_des.Visible = True
                        pb_fin_des.Visible = True

                    End If


                ElseIf _flag_final = False Then 'no termino

                    For Each row As DataRow In dtdetalle.Select("CONCEPTO IN ('Pausa','Pausa Equipo Averiado','Pausa Falla en Equipo')")
                        _flag_pausa = True
                        Exit For
                    Next


                    If _flag_pausa = True Then 'SI HAY PAUSA
                        Dim items_pausa As Integer = 0
                        Dim items_reinicio As Integer = 0
                        Dim ultima_pausa As Integer = 0
                        Dim ultima_reinicio As Integer = 0

                        Dim tiempo_transcurrido As Double
                        Dim _inicio As String = ""
                        Dim _fin As String = ""
                        contador = 0

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                            contador = contador + 1
                            If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
                                If _inicio = "" Then
                                    t_inicio_ = row("FECHA_REAL")
                                    _inicio = "inicio"
                                Else
                                    If contador = dtdetalle.Rows.Count Then
                                        t_fin_ = row("FECHA_REAL")
                                        _fin = "fin"
                                    End If
                                End If
                            End If
                            If row("CONCEPTO") = "Reinicio" Then
                                t_inicio_ = row("FECHA_REAL")
                                _inicio = "inicio"
                            End If
                            If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Or row("CONCEPTO") = "Pausa Falla en Equipo" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If
                            If row("CONCEPTO") = "Final" Or row("CONCEPTO") = "Fin Producción" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If

                            If _inicio <> "" And _fin <> "" Then
                                Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                tiempo_transcurrido = tiempo_transcurrido + resta3
                                _inicio = ""
                                _fin = ""
                            End If
                            items_pausa = row("ITEM")
                        Next

                        For Each row As DataRow In dtdetalle.Select("ITEM=" & items_pausa)
                            _estado_final = row("CONCEPTO")
                        Next

                        If _estado_final = "Pausa" Then 'SI SE QUEDÓ EN PAUSA

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'", "ITEM DESC")

                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                                lst_historial.Items.Add("Fecha y Hora de Inicio Producción: ")
                                ListBox1.Items.Add(t_inicio_.ToString)
                                pb_inicio_prepar.Cursor = Cursors.Default
                                pb_inicio.Cursor = Cursors.Default
                                pb_pausa.Cursor = Cursors.No
                                pb_fin.Cursor = Cursors.No
                                pb_pausa_equipo.Cursor = Cursors.No

                                lbl_inicio.Text = "REINICIAR"

                                pb_inicio_prepar_des.Visible = False
                                pb_inicio_des.Visible = False
                                'pb_pausa_equipo_des.Visible = True
                                'pb_pausa_des.Visible = True
                                pb_fin_des.Visible = True

                                Exit For
                            Next

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                                If _flag_inicio = False Then
                                    t_inicio_ = row("FECHA_REAL")
                                    _flag_inicio = True
                                End If
                                lst_historial.Items.Add("Fecha y Hora de Inicio: ")
                                ListBox1.Items.Add(row("FECHA_REAL").ToString)
                                pb_inicio.Cursor = Cursors.No
                                pb_fin.Cursor = Cursors.Default
                                Exit For
                            Next

                            't_fin_ = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                            'Dim resta4 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                            'tiempo_transcurrido = tiempo_transcurrido + resta4
                            tiempo_transcurrido = 0
                            If tiempo_transcurrido < 60 Then
                                horas = 0
                                minutos = 0
                                segundos = tiempo_transcurrido
                            Else
                                minutos = Math.Floor(tiempo_transcurrido / 60)
                                If minutos < 60 Then
                                    horas = 0
                                    segundos = tiempo_transcurrido - (minutos * 60)
                                Else
                                    horas = Math.Floor(minutos / 60)
                                    minutos = minutos - (horas * 60)
                                    segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                                End If
                            End If

                            _activa_timer = True

                            lbl_hora.Text = Format(horas, "00")
                            lbl_minuto.Text = Format(minutos, "00")
                            lbl_segundo.Text = Format(segundos, "00")
                            lbl_ms.Text = "00"
                            pb_fin_des.Visible = True

                        ElseIf _estado_final = "Reinicio" Or _estado_final = "Inicio" Or _estado_final = "Inicio Preparación de Equipo" Then 'SI SE REINICIO

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'", "ITEM ASC")
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                                lst_historial.Items.Add("Fecha y Hora Inicio Preparación de Equipo : ")
                                ListBox1.Items.Add(t_inicio_.ToString)
                                pb_inicio_prepar.Cursor = Cursors.Default
                                pb_inicio.Cursor = Cursors.Default
                                pb_pausa.Cursor = Cursors.Default
                                pb_fin.Cursor = Cursors.Default
                                pb_pausa_equipo.Cursor = Cursors.Default

                                pb_inicio_prepar_des.Visible = False
                                pb_inicio_des.Visible = False
                                'pb_pausa_equipo_des.Visible = False
                                'pb_pausa_des.Visible = False
                                pb_fin_des.Visible = False

                                Exit For
                            Next

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'", "ITEM DESC")

                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                                lst_historial.Items.Add("Fecha y Hora de Inicio Producción: ")
                                ListBox1.Items.Add(t_inicio_.ToString)
                                pb_inicio_prepar.Cursor = Cursors.Default
                                pb_inicio.Cursor = Cursors.Default
                                pb_pausa.Cursor = Cursors.Default
                                pb_fin.Cursor = Cursors.Default
                                pb_pausa_equipo.Cursor = Cursors.Default

                                pb_inicio_prepar_des.Visible = False
                                pb_inicio_des.Visible = False
                                'pb_pausa_equipo_des.Visible = False
                                'pb_pausa_des.Visible = False
                                pb_fin_des.Visible = False

                                Exit For
                            Next

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM DESC")
                                t_inicio_ = row("FECHA_REAL")
                                Exit For
                            Next

                            t_fin_ = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                            Dim resta4 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                            tiempo_transcurrido = tiempo_transcurrido + resta4

                            If tiempo_transcurrido < 60 Then
                                horas = 0
                                minutos = 0
                                segundos = tiempo_transcurrido
                            Else
                                minutos = Math.Floor(tiempo_transcurrido / 60)
                                If minutos < 60 Then
                                    horas = 0
                                    segundos = tiempo_transcurrido - (minutos * 60)
                                Else
                                    horas = Math.Floor(minutos / 60)
                                    minutos = minutos - (horas * 60)
                                    segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                                End If
                            End If

                            lbl_hora.Text = Format(horas, "00")
                            lbl_minuto.Text = Format(minutos, "00")
                            lbl_segundo.Text = Format(segundos, "00")
                            lbl_ms.Text = "00"
                            lbl_inicio.Text = "FIN"
                            pb_fin_des.Visible = True
                            Timer1.Start()

                            
                        ElseIf _estado_final = "Inicio Producción" Then
                            For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'", "ITEM DESC")

                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                                lst_historial.Items.Add("Fecha y Hora de Inicio Producción: ")
                                ListBox1.Items.Add(t_inicio_.ToString)
                                pb_inicio_prepar.Cursor = Cursors.Default
                                pb_inicio.Cursor = Cursors.Default
                                pb_pausa.Cursor = Cursors.Default
                                pb_fin.Cursor = Cursors.Default
                                pb_pausa_equipo.Cursor = Cursors.Default

                                pb_inicio_prepar_des.Visible = False
                                pb_inicio_des.Visible = False
                                'pb_pausa_equipo_des.Visible = False
                                'pb_pausa_des.Visible = False
                                pb_fin_des.Visible = False

                                Exit For
                            Next

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM DESC")
                                t_inicio_ = row("FECHA_REAL")
                                Exit For
                            Next

                            t_fin_ = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                            Dim resta4 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                            tiempo_transcurrido = tiempo_transcurrido + resta4

                            If tiempo_transcurrido < 60 Then
                                horas = 0
                                minutos = 0
                                segundos = tiempo_transcurrido
                            Else
                                minutos = Math.Floor(tiempo_transcurrido / 60)
                                If minutos < 60 Then
                                    horas = 0
                                    segundos = tiempo_transcurrido - (minutos * 60)
                                Else
                                    horas = Math.Floor(minutos / 60)
                                    minutos = minutos - (horas * 60)
                                    segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                                End If
                            End If

                            lbl_hora.Text = Format(horas, "00")
                            lbl_minuto.Text = Format(minutos, "00")
                            lbl_segundo.Text = Format(segundos, "00")
                            lbl_ms.Text = "00"
                            lbl_inicio.Text = "FIN"

                            'pb_inicio.Enabled = True
                            'pb_pausa.Enabled = True
                            pb_fin_des.Visible = True
                            'pb_pausa_equipo.Enabled = True
                            'pb_inicio_prepar.Enabled = True
                            Timer1.Start()

                        ElseIf _estado_final = "Fin Producción" Then

                            lbl_hora.Text = "00"
                            lbl_minuto.Text = "00"
                            lbl_segundo.Text = "00"
                            lbl_ms.Text = "00"
                            lbl_inicio.Text = "INICIO"
                            pb_fin_des.Visible = False
                        End If


                    ElseIf _flag_pausa = False Then ' NO HAY PAUSA
                        _estado_final = ""
                        For Each row As DataRow In dtdetalle.Rows
                            _estado_final = row("CONCEPTO")
                        Next

                        If _estado_final = "Inicio Producción" Then
                            For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'", "ITEM DESC")
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                                lst_historial.Items.Add("Fecha y Hora de Inicio Producción: ")
                                ListBox1.Items.Add(t_inicio_.ToString)
                                pb_inicio_prepar.Cursor = Cursors.Default
                                pb_inicio.Cursor = Cursors.Default
                                pb_pausa.Cursor = Cursors.Default
                                pb_fin.Cursor = Cursors.Default
                                pb_inicio_prepar_des.Visible = False
                                pb_inicio_des.Visible = False
                                'pb_pausa_equipo_des.Visible = False
                                'pb_pausa_des.Visible = False
                                pb_fin_des.Visible = False
                                Exit For
                            Next

                            Dim tiempo_transcurrido As Double
                            t_fin_ = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                            tiempo_transcurrido = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))

                            If tiempo_transcurrido < 60 Then
                                horas = 0
                                minutos = 0
                                segundos = tiempo_transcurrido
                            Else
                                minutos = Math.Floor(tiempo_transcurrido / 60)
                                If minutos < 60 Then
                                    horas = 0
                                    segundos = tiempo_transcurrido - (minutos * 60)
                                Else
                                    horas = Math.Floor(minutos / 60)
                                    minutos = minutos - (horas * 60)
                                    segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                                End If
                            End If

                            lbl_hora.Text = Format(horas, "00")
                            lbl_minuto.Text = Format(minutos, "00")
                            lbl_segundo.Text = Format(segundos, "00")
                            lbl_ms.Text = "00"
                            lbl_inicio.Text = "FIN"
                            pb_fin_des.Visible = True

                            Timer1.Start()
                        ElseIf _estado_final = "Fin Producción" Then

                            lbl_hora.Text = "00"
                            lbl_minuto.Text = "00"
                            lbl_segundo.Text = "00"
                            lbl_ms.Text = "00"
                            lbl_inicio.Text = "INICIO"

                        End If
                    End If
                End If
            Else

                lbl_hora.ForeColor = Color.Lime
                lbl_minuto.ForeColor = Color.Lime
                lbl_segundo.ForeColor = Color.Lime
                lbl_ms.ForeColor = Color.Lime
                Label4.ForeColor = Color.Lime
                Label2.ForeColor = Color.Lime

                pb_inicio.Enabled = True
                pb_pausa.Enabled = True
                pb_fin.Enabled = True
                'pb_pausa_equipo.Enabled = True
                pb_inicio_prepar.Enabled = True

                pb_inicio.Cursor = Cursors.No
                pb_pausa.Cursor = Cursors.No
                pb_fin.Cursor = Cursors.No
                pb_pausa_equipo.Cursor = Cursors.No
                pb_inicio_prepar.Cursor = Cursors.Default

                pb_inicio_prepar_des.Visible = False
                pb_inicio_des.Visible = False 'True
                'pb_pausa_equipo_des.Visible = True
                'pb_pausa_des.Visible = True
                pb_fin_des.Visible = True

                _activa_timer = True
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Detalle_Actividad_Op_Grafico(ByVal opcion_ As String, ByVal id_ As Integer, ByVal item_ As Integer)
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim _flag_final As Boolean = False
            Dim _flag_pausa As Boolean = False
            Dim _flag_inicio As Boolean = False
            Dim t_inicio_ As Date
            Dim t_fin_ As Date
            Dim horas As Double = 0
            Dim minutos As Double = 0
            Dim segundos As Double = 0
            t_ejecutado = ""
            Dim _estado_final_op As String = ""
            Dim _tiempo_isograf As Double = 0
            Dim _tiempo_infornet As Double = 0

            dtdetalle = clsPedidoBl.get_Parte_Produccion_Detalle_Movimientos(opcion_, id_, item_)
            If dtdetalle.Rows.Count() > 0 Then
                _tiempo_isograf = dtdetalle.Rows(0).Item("TIEMPO_ISOGRAF")
                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                    _flag_final = True
                    Exit For
                Next

                If _flag_final = True Then 'ya termino
                    _estado_final_op = "TERMINADO"
                    For Each row As DataRow In dtdetalle.Select("CONCEPTO in ('Pausa','Pausa Equipo Averiado')")
                        _flag_pausa = True
                        Exit For
                    Next

                    If _flag_pausa = False Then 'SI NO HAY PAUSA

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                            t_inicio_ = row("FECHA_REAL")
                            _flag_inicio = True
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                            t_fin_ = row("FECHA_REAL")
                        Next

                        Dim resta As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                        If resta < 60 Then
                            horas = 0
                            minutos = 0
                            segundos = resta
                        Else
                            minutos = Math.Floor(resta / 60)
                            If minutos < 60 Then
                                horas = 0
                                segundos = resta - (minutos * 60)
                            Else
                                horas = Math.Floor(minutos / 60)
                                minutos = minutos - (horas * 60)
                                segundos = resta - (horas * 3600) - (minutos * 60)
                            End If
                        End If


                        _tiempo_infornet = (horas * 60) + minutos
                        'lst_historial.Items.Add("Tiempo Ejecutado : ")
                        'ListBox1.Items.Add(Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00"))


                    ElseIf _flag_pausa = True Then 'SI HAY PAUSA
                        Dim items_pausa As Integer = 0
                        Dim items_reinicio As Integer = 0
                        Dim ultima_pausa As Integer = 0
                        Dim ultima_reinicio As Integer = 0

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                            t_inicio_ = row("FECHA_REAL")
                            _flag_inicio = True
                            Exit For
                        Next
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next

                        Dim tiempo_transcurrido As Double
                        Dim _inicio As String = ""
                        Dim _fin As String = ""
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                            If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
                                If _inicio = "" Then
                                    t_inicio_ = row("FECHA_REAL")
                                    't_inicio_oficial = TimeSpan.Parse(row("FECHA_REAL"))
                                    _inicio = "inicio"
                                End If
                            End If
                            If row("CONCEPTO") = "Reinicio" Then
                                t_inicio_ = row("FECHA_REAL")
                                _inicio = "inicio"
                            End If
                            If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If
                            If row("CONCEPTO") = "Final" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If

                            If _inicio <> "" And _fin <> "" Then
                                Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                tiempo_transcurrido = tiempo_transcurrido + resta3
                                _inicio = ""
                                _fin = ""
                            End If
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                            t_fin_ = row("FECHA_REAL")
                        Next

                        If tiempo_transcurrido < 60 Then
                            horas = 0
                            minutos = 0
                            segundos = tiempo_transcurrido
                        Else
                            minutos = Math.Floor(tiempo_transcurrido / 60)
                            If minutos < 60 Then
                                horas = 0
                                segundos = tiempo_transcurrido - (minutos * 60)
                            Else
                                horas = Math.Floor(minutos / 60)
                                minutos = minutos - (horas * 60)
                                segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                            End If
                        End If

                        'lst_historial.Items.Add("Tiempo Ejecutado : ")
                        'ListBox1.Items.Add(Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00"))
                        _tiempo_infornet = (horas * 60) + minutos
                    End If


                ElseIf _flag_final = False Then 'no termino
                    _estado_final_op = "EN PROCESO"
                    For Each row As DataRow In dtdetalle.Select("CONCEPTO IN ('Pausa','Pausa Equipo Averiado')")
                        _flag_pausa = True
                        Exit For
                    Next


                    If _flag_pausa = True Then 'SI HAY PAUSA
                        Dim items_pausa As Integer = 0
                        Dim items_reinicio As Integer = 0
                        Dim ultima_pausa As Integer = 0
                        Dim ultima_reinicio As Integer = 0

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                            t_inicio_ = row("FECHA_REAL")
                            _flag_inicio = True
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO IN ('Pausa','Pausa Equipo Averiado')", "ITEM ASC")
                            items_pausa += 1
                            ultima_pausa = row("ITEM")
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'", "ITEM ASC")
                            items_reinicio += 1
                            ultima_reinicio = row("ITEM")
                        Next

                        Dim tiempo_transcurrido As Double
                        Dim _inicio As String = ""
                        Dim _fin As String = ""
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                            If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
                                If _inicio = "" Then
                                    t_inicio_ = row("FECHA_REAL")
                                    _inicio = "inicio"
                                End If
                            End If
                            If row("CONCEPTO") = "Reinicio" Then
                                t_inicio_ = row("FECHA_REAL")
                                _inicio = "inicio"
                            End If
                            If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If
                            If row("CONCEPTO") = "Final" Then
                                t_fin_ = row("FECHA_REAL")
                                _fin = "fin"
                            End If

                            If _inicio <> "" And _fin <> "" Then
                                Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                tiempo_transcurrido = tiempo_transcurrido + resta3
                                _inicio = ""
                                _fin = ""
                            End If
                        Next

                        If items_pausa > items_reinicio Then 'SI SE QUEDÓ EN PAUSA

                            If tiempo_transcurrido < 60 Then
                                horas = 0
                                minutos = 0
                                segundos = tiempo_transcurrido
                            Else
                                minutos = Math.Floor(tiempo_transcurrido / 60)
                                If minutos < 60 Then
                                    horas = 0
                                    segundos = tiempo_transcurrido - (minutos * 60)
                                Else
                                    horas = Math.Floor(minutos / 60)
                                    minutos = minutos - (horas * 60)
                                    segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                                End If
                            End If

                            'aki esta el tiempo ejecutado
                            'lbl_hora.Text = Format(horas, "00")
                            'lbl_minuto.Text = Format(minutos, "00")
                            'lbl_segundo.Text = Format(segundos, "00")
                            _tiempo_infornet = (horas * 60) + minutos

                        ElseIf items_pausa = items_reinicio Then 'SI PAUSA Y REINICIO SON IGUALES

                            t_fin_ = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                            Dim resta4 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                            tiempo_transcurrido = tiempo_transcurrido + resta4

                            If tiempo_transcurrido < 60 Then
                                horas = 0
                                minutos = 0
                                segundos = tiempo_transcurrido
                            Else
                                minutos = Math.Floor(tiempo_transcurrido / 60)
                                If minutos < 60 Then
                                    horas = 0
                                    segundos = tiempo_transcurrido - (minutos * 60)
                                Else
                                    horas = Math.Floor(minutos / 60)
                                    minutos = minutos - (horas * 60)
                                    segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                                End If
                            End If

                            'aki esta el tiempo ejecutado
                            'lbl_hora.Text = Format(horas, "00")
                            'lbl_minuto.Text = Format(minutos, "00")
                            'lbl_segundo.Text = Format(segundos, "00")
                            _tiempo_infornet = (horas * 60) + minutos
                        End If


                    ElseIf _flag_pausa = False Then 'SI NO HAY PAUSA
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                            t_inicio_ = row("FECHA_REAL")
                            _flag_inicio = True
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                            If _flag_inicio = False Then
                                t_inicio_ = row("FECHA_REAL")
                                _flag_inicio = True
                            End If
                            Exit For
                        Next

                        Dim tiempo_transcurrido As Double
                        t_fin_ = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                        tiempo_transcurrido = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))

                        If tiempo_transcurrido < 60 Then
                            horas = 0
                            minutos = 0
                            segundos = tiempo_transcurrido
                        Else
                            minutos = Math.Floor(tiempo_transcurrido / 60)
                            If minutos < 60 Then
                                horas = 0
                                segundos = tiempo_transcurrido - (minutos * 60)
                            Else
                                horas = Math.Floor(minutos / 60)
                                minutos = minutos - (horas * 60)
                                segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                            End If
                        End If
                        'aki esta el tiempo ejecutado
                        'lbl_hora.Text = Format(horas, "00")
                        'lbl_minuto.Text = Format(minutos, "00")
                        'lbl_segundo.Text = Format(segundos, "00")
                        _tiempo_infornet = (horas * 60) + minutos
                    End If
                End If

                If clsPedidoBl.Guardar_Tiempo_Operado_x_OP_Analisis(opcion_, Strings.UCase(TextBox5.Text.Trim), id_, item_, _tiempo_isograf, _tiempo_infornet, _
                                                                    Strings.UCase(dtp_fecha_produccion_programada.Value.ToString("MMMM")), _
                                                                    dtp_fecha_produccion_programada.Value.Year.ToString, _
                                                                    _estado_final_op) = False Then
                    MsgBox("No se guardo los datos de la OP N° " & CStr(id_) & " y Item " & CStr(item_), MsgBoxStyle.Critical)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso: id_cab=" & id_ & ", item=" & item_)
        End Try
    End Sub

    'Private Sub Detalle_Actividad_Op(ByVal opcion_ As String, ByVal id_ As Integer, ByVal item_ As Integer)
    '    Try
    '        clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
    '        Me.Cursor = Cursors.WaitCursor
    '        Dim _flag_final As Boolean = False
    '        Dim _flag_pausa As Boolean = False
    '        Dim _flag_inicio As Boolean = False
    '        t_ejecutado = ""

    '        dtdetalle = clsPedidoBl.get_Parte_Produccion_Detalle_Movimientos(opcion_, id_, item_)
    '        dgv_detalle_historial.DataSource = Nothing
    '        If dtdetalle.Rows.Count() > 0 Then
    '            dgv_detalle_historial.DataSource = dtdetalle
    '            dgv_detalle_historial.Columns("TIEMPO_CIERRE").Visible = False
    '            dgv_detalle_historial.Columns("SIGNO").Visible = False
    '            lst_historial.Items.Clear()
    '            For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
    '                _flag_final = True
    '                Exit For
    '            Next

    '            If _flag_final = True Then 'ya termino

    '                For Each row As DataRow In dtdetalle.Select("CONCEPTO in ('Pausa','Pausa Equipo Averiado')")
    '                    _flag_pausa = True
    '                    Exit For
    '                Next

    '                If _flag_pausa = False Then 'SI NO HAY PAUSA

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
    '                        t_inicio = TimeSpan.Parse(row("HORA"))
    '                        _flag_inicio = True
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora Inicio Preparación de Equipo : " & t_inicio.ToString)
    '                        pb_inicio_prepar.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.No
    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio Producción: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default
    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default
    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
    '                        t_fin = TimeSpan.Parse(row("HORA"))
    '                    Next

    '                    lst_historial.Items.Add("Hora Final : " & t_fin.ToString)

    '                    Dim resta As TimeSpan = t_fin - t_inicio
    '                    lst_historial.Items.Add("Tiempo Ejecutado : " & resta.ToString)
    '                    lst_historial.Items.Add("---------------------------------------------------------------------")

    '                    Dim programado As TimeSpan = TimeSpan.Parse(dgv_produccion_programada.CurrentRow.Cells("Hora_Real").Value & ":" & dgv_produccion_programada.CurrentRow.Cells("Minuto").Value)
    '                    lst_historial.Items.Add("Tiempo Programado : " & programado.ToString)
    '                    lst_historial.Items.Add("Tiempo Ejecutado : " & resta.ToString)
    '                    t_ejecutado = resta.ToString
    '                    Dim resta2 As TimeSpan = programado - resta
    '                    lst_historial.Items.Add("Tiempo Neto : " & resta2.ToString)

    '                    lbl_hora.Text = "00"
    '                    lbl_minuto.Text = "00"
    '                    lbl_segundo.Text = "00"
    '                    lbl_ms.Text = "00"

    '                    pb_inicio.Enabled = True
    '                    pb_pausa.Enabled = True
    '                    pb_fin.Enabled = True
    '                    pb_pausa_equipo.Enabled = True
    '                    pb_inicio_prepar.Enabled = True

    '                    pb_inicio.Cursor = Cursors.No
    '                    pb_pausa.Cursor = Cursors.No
    '                    pb_fin.Cursor = Cursors.No
    '                    pb_pausa_equipo.Cursor = Cursors.No
    '                    pb_inicio_prepar.Cursor = Cursors.No

    '                    pb_inicio_prepar_des.Visible = True
    '                    pb_inicio_des.Visible = True
    '                    pb_pausa_equipo_des.Visible = True
    '                    pb_pausa_des.Visible = True
    '                    pb_fin_des.Visible = True


    '                    If lbl_minuto.Text < 0 And lbl_minuto.Text > -10 And lbl_hora.Text = 0 Then
    '                        lbl_hora.ForeColor = Color.Orange
    '                        lbl_minuto.ForeColor = Color.Orange
    '                        lbl_segundo.ForeColor = Color.Orange
    '                        lbl_ms.ForeColor = Color.Orange
    '                        Label4.ForeColor = Color.Orange
    '                        Label2.ForeColor = Color.Orange
    '                    ElseIf lbl_minuto.Text < 0 And lbl_minuto.Text < -10 Then
    '                        lbl_hora.ForeColor = Color.Red
    '                        lbl_minuto.ForeColor = Color.Red
    '                        lbl_segundo.ForeColor = Color.Red
    '                        lbl_ms.ForeColor = Color.Red
    '                        Label4.ForeColor = Color.Red
    '                        Label2.ForeColor = Color.Red
    '                    Else
    '                        lbl_hora.ForeColor = Color.Lime
    '                        lbl_minuto.ForeColor = Color.Lime
    '                        lbl_segundo.ForeColor = Color.Lime
    '                        lbl_ms.ForeColor = Color.Lime
    '                        Label4.ForeColor = Color.Lime
    '                        Label2.ForeColor = Color.Lime
    '                    End If
    '                ElseIf _flag_pausa = True Then 'SI HAY PAUSA
    '                    Dim items_pausa As Integer = 0
    '                    Dim items_reinicio As Integer = 0
    '                    Dim ultima_pausa As Integer = 0
    '                    Dim ultima_reinicio As Integer = 0

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
    '                        t_inicio = TimeSpan.Parse(row("HORA"))
    '                        _flag_inicio = True
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora Inicio Preparación de Equipo : " & t_inicio.ToString)
    '                        pb_inicio_prepar.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.No
    '                        Exit For
    '                    Next
    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio Producción: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default
    '                        Exit For
    '                    Next
    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default
    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO in ('Pausa','Pausa Equipo Averiado')", "ITEM ASC")
    '                        items_pausa += 1
    '                        ultima_pausa = row("ITEM")
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'", "ITEM ASC")
    '                        items_reinicio += 1
    '                        ultima_reinicio = row("ITEM")
    '                    Next

    '                    Dim tiempo_transcurrido As TimeSpan
    '                    Dim _inicio As String = ""
    '                    Dim _fin As String = ""
    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
    '                        If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                            _inicio = "inicio"
    '                        End If
    '                        If row("CONCEPTO") = "Reinicio" Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _inicio = "inicio"
    '                        End If
    '                        If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Then
    '                            t_fin = TimeSpan.Parse(row("HORA"))
    '                            _fin = "fin"
    '                        End If
    '                        If row("CONCEPTO") = "Final" Then
    '                            t_fin = TimeSpan.Parse(row("HORA"))
    '                            _fin = "fin"
    '                        End If

    '                        If _inicio <> "" And _fin <> "" Then
    '                            Dim resta3 As TimeSpan = t_fin - t_inicio
    '                            tiempo_transcurrido = tiempo_transcurrido + resta3
    '                            _inicio = ""
    '                            _fin = ""
    '                        End If
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
    '                        t_fin = TimeSpan.Parse(row("HORA"))
    '                    Next
    '                    lst_historial.Items.Add("Hora Final : " & t_fin.ToString)
    '                    lst_historial.Items.Add("Tiempo Ejecutado : " & tiempo_transcurrido.ToString)
    '                    lst_historial.Items.Add("---------------------------------------------------------------------")

    '                    Dim programado As TimeSpan = TimeSpan.Parse(dgv_produccion_programada.CurrentRow.Cells("Hora_Real").Value & ":" & dgv_produccion_programada.CurrentRow.Cells("Minuto").Value)
    '                    lst_historial.Items.Add("Tiempo Programado : " & programado.ToString)
    '                    lst_historial.Items.Add("Tiempo Ejecutado : " & tiempo_transcurrido.ToString)
    '                    t_ejecutado = tiempo_transcurrido.ToString
    '                    Dim resta2 As TimeSpan = programado - tiempo_transcurrido
    '                    lst_historial.Items.Add("Tiempo Neto : " & resta2.ToString)

    '                    lbl_hora.Text = "00"
    '                    lbl_minuto.Text = "00"
    '                    lbl_segundo.Text = "00"
    '                    lbl_ms.Text = "00"

    '                    pb_inicio.Enabled = True
    '                    pb_pausa.Enabled = True
    '                    pb_fin.Enabled = True
    '                    pb_pausa_equipo.Enabled = True
    '                    pb_inicio_prepar.Enabled = True

    '                    pb_inicio.Cursor = Cursors.No
    '                    pb_pausa.Cursor = Cursors.No
    '                    pb_fin.Cursor = Cursors.No
    '                    pb_pausa_equipo.Cursor = Cursors.No
    '                    pb_inicio_prepar.Cursor = Cursors.No

    '                    If lbl_minuto.Text < 0 And lbl_minuto.Text > -10 And lbl_hora.Text = 0 Then
    '                        lbl_hora.ForeColor = Color.Orange
    '                        lbl_minuto.ForeColor = Color.Orange
    '                        lbl_segundo.ForeColor = Color.Orange
    '                        lbl_ms.ForeColor = Color.Orange
    '                        Label4.ForeColor = Color.Orange
    '                        Label2.ForeColor = Color.Orange
    '                    ElseIf lbl_minuto.Text < 0 And lbl_minuto.Text < -10 Then
    '                        lbl_hora.ForeColor = Color.Red
    '                        lbl_minuto.ForeColor = Color.Red
    '                        lbl_segundo.ForeColor = Color.Red
    '                        lbl_ms.ForeColor = Color.Red
    '                        Label4.ForeColor = Color.Red
    '                        Label2.ForeColor = Color.Red
    '                    Else
    '                        lbl_hora.ForeColor = Color.Lime
    '                        lbl_minuto.ForeColor = Color.Lime
    '                        lbl_segundo.ForeColor = Color.Lime
    '                        lbl_ms.ForeColor = Color.Lime
    '                        Label4.ForeColor = Color.Lime
    '                        Label2.ForeColor = Color.Lime
    '                    End If

    '                    pb_inicio_prepar_des.Visible = True
    '                    pb_inicio_des.Visible = True
    '                    pb_pausa_equipo_des.Visible = True
    '                    pb_pausa_des.Visible = True
    '                    pb_fin_des.Visible = True

    '                End If


    '            ElseIf _flag_final = False Then 'no termino

    '                For Each row As DataRow In dtdetalle.Select("CONCEPTO IN ('Pausa','Pausa Equipo Averiado')")
    '                    _flag_pausa = True
    '                    Exit For
    '                Next


    '                If _flag_pausa = True Then 'SI HAY PAUSA
    '                    Dim items_pausa As Integer = 0
    '                    Dim items_reinicio As Integer = 0
    '                    Dim ultima_pausa As Integer = 0
    '                    Dim ultima_reinicio As Integer = 0

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
    '                        t_inicio = TimeSpan.Parse(row("HORA"))
    '                        _flag_inicio = True
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora Inicio Preparación de Equipo : " & t_inicio.ToString)
    '                        pb_inicio_prepar.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.No
    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio Producción: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default
    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default
    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO IN ('Pausa','Pausa Equipo Averiado')", "ITEM ASC")
    '                        items_pausa += 1
    '                        ultima_pausa = row("ITEM")
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'", "ITEM ASC")
    '                        items_reinicio += 1
    '                        ultima_reinicio = row("ITEM")
    '                    Next

    '                    If items_pausa > items_reinicio Then 'SI SE QUEDÓ EN PAUSA
    '                        Dim _signo As String = ""
    '                        For Each row As DataRow In dtdetalle.Select("ITEM=" & ultima_pausa)
    '                            t_inicio = TimeSpan.Parse(row("TIEMPO_CIERRE"))
    '                            _signo = row("SIGNO")
    '                        Next
    '                        lbl_hora.Text = Format(t_inicio.Hours, "00")
    '                        lbl_minuto.Text = Format(t_inicio.Minutes, "00")
    '                        lbl_segundo.Text = Format(t_inicio.Seconds, "00")

    '                        If _signo = "NEGATIVO" Then
    '                            lbl_hora.Text = "-" & lbl_hora.Text
    '                            lbl_minuto.Text = "-" & lbl_minuto.Text
    '                        End If

    '                        lbl_segundo.Text = Math.Abs(CInt(lbl_segundo.Text)).ToString
    '                        lbl_ms.Text = "00"

    '                        If lbl_minuto.Text < 0 And lbl_minuto.Text > -10 And lbl_hora.Text = 0 Then
    '                            lbl_hora.ForeColor = Color.Orange
    '                            lbl_minuto.ForeColor = Color.Orange
    '                            lbl_segundo.ForeColor = Color.Orange
    '                            lbl_ms.ForeColor = Color.Orange
    '                            Label4.ForeColor = Color.Orange
    '                            Label2.ForeColor = Color.Orange
    '                        ElseIf lbl_minuto.Text < 0 And lbl_minuto.Text < -10 Then
    '                            lbl_hora.ForeColor = Color.Red
    '                            lbl_minuto.ForeColor = Color.Red
    '                            lbl_segundo.ForeColor = Color.Red
    '                            lbl_ms.ForeColor = Color.Red
    '                            Label4.ForeColor = Color.Red
    '                            Label2.ForeColor = Color.Red
    '                        Else
    '                            lbl_hora.ForeColor = Color.Lime
    '                            lbl_minuto.ForeColor = Color.Lime
    '                            lbl_segundo.ForeColor = Color.Lime
    '                            lbl_ms.ForeColor = Color.Lime
    '                            Label4.ForeColor = Color.Lime
    '                            Label2.ForeColor = Color.Lime
    '                        End If

    '                        pb_inicio.Enabled = True
    '                        pb_pausa.Enabled = True
    '                        pb_fin.Enabled = True
    '                        pb_pausa_equipo.Enabled = True
    '                        pb_inicio_prepar.Enabled = True
    '                        Label6.Text = "REINICIAR PRODUCCION"

    '                        pb_inicio.Cursor = Cursors.Default
    '                        pb_pausa.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.No
    '                        pb_pausa_equipo.Cursor = Cursors.No

    '                        pb_inicio_prepar_des.Visible = True
    '                        pb_inicio_des.Visible = False
    '                        pb_pausa_equipo_des.Visible = True
    '                        pb_pausa_des.Visible = True
    '                        pb_fin_des.Visible = True


    '                    ElseIf items_pausa = items_reinicio Then 'SI PAUSA Y REINICIO SON IGUALES
    '                        Dim tiempo_transcurrido As TimeSpan
    '                        Dim _inicio As String = ""
    '                        Dim _fin As String = ""
    '                        For Each row As DataRow In dtdetalle.Select("ITEM<>" & ultima_reinicio, "ITEM ASC")
    '                            If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
    '                                t_inicio = TimeSpan.Parse(row("HORA"))
    '                                t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                                _inicio = "inicio"
    '                            End If
    '                            If row("CONCEPTO") = "Reinicio" Then
    '                                t_inicio = TimeSpan.Parse(row("HORA"))
    '                                _inicio = "inicio"
    '                            End If
    '                            If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Then
    '                                t_fin = TimeSpan.Parse(row("HORA"))
    '                                _fin = "fin"
    '                            End If

    '                            If _inicio <> "" And _fin <> "" Then
    '                                Dim resta As TimeSpan = t_fin - t_inicio
    '                                tiempo_transcurrido = tiempo_transcurrido + resta
    '                                _inicio = ""
    '                                _fin = ""
    '                            End If
    '                        Next

    '                        For Each row As DataRow In dtdetalle.Select("ITEM=" & ultima_reinicio)
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                        Next
    '                        t_fin = TimeSpan.Parse(Date.Now.ToString("HH:mm:ss"))
    '                        Dim resta3 As TimeSpan = t_fin - t_inicio
    '                        tiempo_transcurrido = tiempo_transcurrido + resta3
    '                        Dim programado1 As TimeSpan = TimeSpan.Parse(dgv_produccion_programada.CurrentRow.Cells("Hora_Real").Value & ":" & dgv_produccion_programada.CurrentRow.Cells("Minuto").Value)
    '                        Dim programado2 As TimeSpan = TimeSpan.Parse(dgv_produccion_programada.CurrentRow.Cells("Hora_Real2").Value & ":" & dgv_produccion_programada.CurrentRow.Cells("Minuto2").Value)
    '                        tiempo_transcurrido = programado1 - tiempo_transcurrido

    '                        lbl_hora.Text = Format(tiempo_transcurrido.Hours, "00")
    '                        lbl_minuto.Text = Format(tiempo_transcurrido.Minutes, "00")
    '                        lbl_segundo.Text = Format(tiempo_transcurrido.Seconds, "00")
    '                        lbl_segundo.Text = Math.Abs(CInt(lbl_segundo.Text)).ToString
    '                        lbl_ms.Text = "00"

    '                        If lbl_minuto.Text < 0 And lbl_minuto.Text > -10 And lbl_hora.Text = 0 Then
    '                            lbl_hora.ForeColor = Color.Orange
    '                            lbl_minuto.ForeColor = Color.Orange
    '                            lbl_segundo.ForeColor = Color.Orange
    '                            lbl_ms.ForeColor = Color.Orange
    '                            Label4.ForeColor = Color.Orange
    '                            Label2.ForeColor = Color.Orange
    '                        ElseIf lbl_minuto.Text < 0 And lbl_minuto.Text < -10 Then
    '                            lbl_hora.ForeColor = Color.Red
    '                            lbl_minuto.ForeColor = Color.Red
    '                            lbl_segundo.ForeColor = Color.Red
    '                            lbl_ms.ForeColor = Color.Red
    '                            Label4.ForeColor = Color.Red
    '                            Label2.ForeColor = Color.Red
    '                        Else
    '                            lbl_hora.ForeColor = Color.Lime
    '                            lbl_minuto.ForeColor = Color.Lime
    '                            lbl_segundo.ForeColor = Color.Lime
    '                            lbl_ms.ForeColor = Color.Lime
    '                            Label4.ForeColor = Color.Lime
    '                            Label2.ForeColor = Color.Lime
    '                        End If

    '                        pb_inicio.Enabled = True
    '                        pb_pausa.Enabled = True
    '                        pb_fin.Enabled = True
    '                        pb_pausa_equipo.Enabled = True
    '                        pb_inicio_prepar.Enabled = True
    '                        Timer1.Start()

    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_pausa.Cursor = Cursors.Default
    '                        pb_fin.Cursor = Cursors.Default
    '                        pb_pausa_equipo.Cursor = Cursors.Default
    '                        pb_inicio_prepar.Cursor = Cursors.No

    '                        pb_inicio_prepar_des.Visible = True
    '                        pb_inicio_des.Visible = True
    '                        pb_pausa_equipo_des.Visible = False
    '                        pb_pausa_des.Visible = False
    '                        pb_fin_des.Visible = False
    '                    End If


    '                ElseIf _flag_pausa = False Then 'SI NO HAY PAUSA
    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
    '                        t_inicio = TimeSpan.Parse(row("HORA"))
    '                        _flag_inicio = True
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora Inicio Preparación de Equipo : " & t_inicio.ToString)
    '                        pb_inicio_prepar.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.No
    '                        pb_inicio_prepar_des.Visible = True
    '                        pb_inicio_des.Visible = False
    '                        pb_pausa_equipo_des.Visible = True
    '                        pb_pausa_des.Visible = True
    '                        pb_fin_des.Visible = True

    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio Producción: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default

    '                        pb_inicio_prepar_des.Visible = True
    '                        pb_inicio_des.Visible = True
    '                        pb_pausa_equipo_des.Visible = False
    '                        pb_pausa_des.Visible = False
    '                        pb_fin_des.Visible = False

    '                        Exit For
    '                    Next

    '                    For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
    '                        If _flag_inicio = False Then
    '                            t_inicio = TimeSpan.Parse(row("HORA"))
    '                            _flag_inicio = True
    '                        End If
    '                        t_inicio_oficial = TimeSpan.Parse(row("HORA"))
    '                        lst_historial.Items.Add("Hora de Inicio Producción: " & TimeSpan.Parse(row("HORA")).ToString)
    '                        pb_inicio.Cursor = Cursors.No
    '                        pb_fin.Cursor = Cursors.Default

    '                        pb_inicio_prepar_des.Visible = True
    '                        pb_inicio_des.Visible = True
    '                        pb_pausa_equipo_des.Visible = False
    '                        pb_pausa_des.Visible = False
    '                        pb_fin_des.Visible = False

    '                        Exit For
    '                    Next


    '                    t_fin = TimeSpan.Parse(Date.Now.ToString("HH:mm:ss"))
    '                    Dim resta As TimeSpan = t_fin - t_inicio

    '                    Dim programado As TimeSpan = TimeSpan.Parse(dgv_produccion_programada.CurrentRow.Cells("Hora_Real").Value & ":" & dgv_produccion_programada.CurrentRow.Cells("Minuto").Value)
    '                    Dim resta2 As TimeSpan = programado - resta

    '                    lbl_hora.Text = Format(resta2.Hours, "00")
    '                    lbl_minuto.Text = Format(resta2.Minutes, "00")
    '                    lbl_segundo.Text = Format(resta2.Seconds, "00")
    '                    lbl_segundo.Text = Math.Abs(CInt(lbl_segundo.Text)).ToString
    '                    lbl_ms.Text = "00"

    '                    If lbl_minuto.Text < 0 And lbl_minuto.Text > -10 And lbl_hora.Text = 0 Then
    '                        lbl_hora.ForeColor = Color.Orange
    '                        lbl_minuto.ForeColor = Color.Orange
    '                        lbl_segundo.ForeColor = Color.Orange
    '                        lbl_ms.ForeColor = Color.Orange
    '                        Label4.ForeColor = Color.Orange
    '                        Label2.ForeColor = Color.Orange
    '                    ElseIf lbl_minuto.Text < 0 And lbl_minuto.Text < -10 Then
    '                        lbl_hora.ForeColor = Color.Red
    '                        lbl_minuto.ForeColor = Color.Red
    '                        lbl_segundo.ForeColor = Color.Red
    '                        lbl_ms.ForeColor = Color.Red
    '                        Label4.ForeColor = Color.Red
    '                        Label2.ForeColor = Color.Red
    '                    Else
    '                        lbl_hora.ForeColor = Color.Lime
    '                        lbl_minuto.ForeColor = Color.Lime
    '                        lbl_segundo.ForeColor = Color.Lime
    '                        lbl_ms.ForeColor = Color.Lime
    '                        Label4.ForeColor = Color.Lime
    '                        Label2.ForeColor = Color.Lime
    '                    End If

    '                    pb_inicio.Enabled = True
    '                    pb_pausa.Enabled = True
    '                    pb_fin.Enabled = True
    '                    pb_pausa_equipo.Enabled = True
    '                    pb_inicio_prepar.Enabled = True

    '                    Timer1.Start()
    '                End If
    '            End If
    '        Else
    '            lbl_hora.ForeColor = Color.Lime
    '            lbl_minuto.ForeColor = Color.Lime
    '            lbl_segundo.ForeColor = Color.Lime
    '            lbl_ms.ForeColor = Color.Lime
    '            Label4.ForeColor = Color.Lime
    '            Label2.ForeColor = Color.Lime

    '            pb_inicio.Enabled = True
    '            pb_pausa.Enabled = True
    '            pb_fin.Enabled = True
    '            pb_pausa_equipo.Enabled = True
    '            pb_inicio_prepar.Enabled = True

    '            pb_inicio.Cursor = Cursors.No
    '            pb_pausa.Cursor = Cursors.No
    '            pb_fin.Cursor = Cursors.No
    '            pb_pausa_equipo.Cursor = Cursors.No
    '            pb_inicio_prepar.Cursor = Cursors.Default

    '            pb_inicio_prepar_des.Visible = False
    '            pb_inicio_des.Visible = True
    '            pb_pausa_equipo_des.Visible = True
    '            pb_pausa_des.Visible = True
    '            pb_fin_des.Visible = True

    '        End If
    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub btn_confirmar_u_maquina_Click(sender As Object, e As EventArgs) Handles btn_confirmar_u_maquina.Click
        If Validar_Parte_Produccion() = False Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            If MsgBox("Esta seguro de registrar el Parte de Producción?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

                PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP

                For i As Integer = 0 To dgv_produccion_programada2.Rows.Count - 1
                    If dgv_produccion_programada2.Rows(i).Cells("SEL").Value Then
                        PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
                        With PedidoCabENT
                            .ID = _NUMERO_OP
                            .ITEM = _ITEM_OP
                            .HORA_INICIO_PRODUCCION = dgv_produccion_programada2.Rows(i).Cells("Hora Inicio").Value
                            .HORA_FINAL_PRODUCCION = dgv_produccion_programada2.Rows(i).Cells("Hora Final").Value
                            .PLIEGOS_BUENOS_PRODUCCION = dgv_produccion_programada2.Rows(i).Cells("Pliegos Buenos").Value
                            .PLIEGOS_MALOS_PRODUCCION = dgv_produccion_programada2.Rows(i).Cells("Pliegos Malos").Value
                            .OBS_PRODUCCION = dgv_produccion_programada2.Rows(i).Cells("Observaciones Producción").Value
                            .USER_ID_DESPACHO = TextBox6.Text.Trim
                            .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        End With
                        MantenimientoOP_Lista.Add(PedidoCabENT)
                    End If
                Next

                If clsPedidoBl.Guardar_Parte_Produccion(MantenimientoOP_Lista) Then
                    MsgBox("Parte de Producción Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    dgv_produccion_programada2.DataSource = Nothing
                    TextBox6.Text = ""
                    TextBox5.Text = ""
                    dtp_fecha_produccion_programada.Value = Date.Now
                    TextBox6.Focus()
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Validar_Parte_Produccion() As Boolean
        Try
            dgv_produccion_programada2.CommitEdit(DataGridViewDataErrorContexts.Commit)
            If dgv_produccion_programada2.RowCount() = 0 Then
                MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
                Return False
            Else
                Dim estado As Boolean = False
                For Each row As DataGridViewRow In dgv_produccion_programada2.Rows
                    If row.Cells("SEL").Value = True Then
                        estado = True
                        Exit For
                    End If
                Next
                If estado = False Then
                    MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgv_produccion_programada2.Focus()
                    Return False
                End If


            End If
            dgv_produccion_programada2.Refresh()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub TextBox6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox6.MouseDoubleClick
        Mostrando_Equipos_Planta(TextBox6, TextBox5, "A")
    End Sub

    Private Sub btn_aceptar_pausa_Click(sender As Object, e As EventArgs) Handles btn_aceptar_pausa.Click
        Try
            If cbo_motivo_pausa.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Motivo de Pausa.", MsgBoxStyle.Exclamation, "Sistemas")
                Exit Sub
            End If
            If txt_buenos_pausa.Text = "" Then
                MsgBox("Debe ingresar la cantidad.", MsgBoxStyle.Exclamation, "Aviso")
                txt_buenos_pausa.Focus()
                Exit Sub
            End If
            'If txt_malos_pausa.Text = "" Then
            '    MsgBox("Debe ingresar la cantidad de Malos.", MsgBoxStyle.Exclamation, "Aviso")
            '    txt_malos_pausa.Focus()
            '    Exit Sub
            'End If
            'If cbo_motivo_pausa.SelectedValue = "603" Or cbo_motivo_pausa.SelectedValue = "604" Or cbo_motivo_pausa.SelectedValue = "503" Then
            '    If txt_motivo_pausa.Text = "" Then
            '        MsgBox("Debe ingresar el Motivo de Pausa en observaciones.", MsgBoxStyle.Exclamation, "Aviso")
            '        txt_motivo_pausa.Focus()
            '        Exit Sub
            '    End If

            'End If

            Me.Cursor = Cursors.WaitCursor
            'btn_aceptar_pausa.Enabled = False
            pnl_pausa.Visible = False
            Dim row As DataRow = dtdetalle.NewRow

            For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
                _ULTIMO_ITEM = row2("ITEM")
                Exit For
            Next

            row("ITEM") = _ULTIMO_ITEM + 1
            _item = row("ITEM")
            If tipo_pausa = "PAUSA" Then
                row("CONCEPTO") = "Pausa"
            ElseIf tipo_pausa = "PAUSA EQUIPO" Then
                row("CONCEPTO") = "Pausa Falla en Equipo"
            End If
            row("FECHA") = fecha_pausa
            row("HORA") = hora_pausa
            row("OBSERVACIONES") = txt_motivo_pausa.Text.Trim
            row("MOTIVO_PAUSA") = cbo_motivo_pausa.SelectedValue
            row("PLIEGOS_BUENOS") = txt_buenos_pausa.Text
            row("PLIEGOS_MALOS") = 0 'txt_malos_pausa.Text
            row("PROCESO_INICIO_PREPARACION") = cbo_motivo_pausa.Text

            dtdetalle.Rows.Add(row)
            dtdetalle.AcceptChanges()

            dgv_detalle_historial.DataSource = dtdetalle
            Formato_Grilla_Detalle_Op()
            Call CalcularTotales_Cantidad()
            pb_inicio.Enabled = True
            pb_pausa.Enabled = True
            pb_fin.Enabled = True
            'pb_pausa_equipo.Enabled = True
            pb_inicio_prepar.Enabled = True
            lbl_inicio.Text = "REINICIAR"
            pb_inicio.Cursor = Cursors.Default
            pb_pausa.Cursor = Cursors.No
            pb_fin.Cursor = Cursors.No
            pb_pausa_equipo.Cursor = Cursors.No
            pb_inicio_prepar.Cursor = Cursors.Default
            pb_fin_des.Visible = True

            Call Guardar_Parte_Produccion("PAUSADO")
            _activa_timer = True
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_motivo_pausa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_motivo_pausa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_aceptar_pausa_Click(sender, e)
        End If
    End Sub

    Private Sub dtp_fecha_produccion_programada_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_produccion_programada.KeyDown
        If e.KeyCode = Keys.Enter Then Button36.Focus()
    End Sub



    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Try
            'If txt_buenos.Text = "" Then
            '    MsgBox("Debe ingresar la cantidad.", MsgBoxStyle.Exclamation, "Aviso")
            '    txt_buenos.Focus()
            '    Exit Sub
            'End If
            'If txt_malos.Text = "" Then
            '    MsgBox("Debe ingresar la cantidad de Malos.", MsgBoxStyle.Exclamation, "Aviso")
            '    txt_malos.Focus()
            '    Exit Sub
            'End If

            Me.Cursor = Cursors.WaitCursor
            Dim row As DataRow = dtdetalle.NewRow

            For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
                _ULTIMO_ITEM = row2("ITEM")
                Exit For
            Next

            row("ITEM") = _ULTIMO_ITEM + 1
            _item = row("ITEM")
            row("CONCEPTO") = "Final"
            row("FECHA") = Date.Now.ToString("dd/MM/yyyy")
            row("HORA") = Date.Now.ToString("HH:mm:ss")
            row("OBSERVACIONES") = ""
            row("MOTIVO_PAUSA") = ""
            row("PLIEGOS_BUENOS") = 0 'txt_buenos.Text
            row("PLIEGOS_MALOS") = 0 'txt_malos.Text

            dtdetalle.Rows.Add(row)
            dtdetalle.AcceptChanges()

            dgv_detalle_historial.DataSource = dtdetalle
            Formato_Grilla_Detalle_Op()
            Call CalcularTotales_Cantidad()
            If Guardar_Parte_Produccion("TERMINADO") Then
                Call Detalle_Actividad_Op(TextBox6.Text.Trim, _NUMERO_OP, _ITEM_OP)
            End If

            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
            Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

            PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP

            PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
            With PedidoCabENT
                .ID = _NUMERO_OP
                .ITEM = _ITEM_OP
                .TIPO_ORDEN = _TIPO_ORDEN
                .HORA_INICIO_PRODUCCION = ""
                .HORA_FINAL_PRODUCCION = ""
                .PLIEGOS_BUENOS_PRODUCCION = txt_buenos.Text.Trim
                .PLIEGOS_MALOS_PRODUCCION = txt_malos.Text.Trim
                .OBS_PRODUCCION = txt_obs_produccion.Text.Trim
                .USER_ID_DESPACHO = TextBox6.Text.Trim
                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                .TIEMPO_EJECUTADO = t_ejecutado
            End With
            MantenimientoOP_Lista.Add(PedidoCabENT)

            If clsPedidoBl.Guardar_Parte_Produccion(MantenimientoOP_Lista) Then
                Button1.Enabled = True
                MsgBox("Parte de Producción Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                pnl_fin.Visible = False
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_buenos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_buenos.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_obs_produccion.Focus()
        End If
    End Sub

    Private Sub txt_malos_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_malos.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_obs_produccion.Focus()
        End If
    End Sub

    Private Sub txt_obs_produccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_obs_produccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_finalizar.Focus()
        End If
    End Sub

    Private Sub pb_pausa_equipo_Click(sender As Object, e As EventArgs) Handles pb_pausa_equipo.Click
        If pb_pausa_equipo.Cursor = Cursors.Default Then
            Timer1.Stop()
            If MsgBox("Esta seguro de PAUSAR la PRODUCCION POR FALLAS EN EQUIPO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                fecha_pausa = Date.Now.ToString("dd/MM/yyyy")
                hora_pausa = Date.Now.ToString("HH:mm:ss")
                tipo_pausa = "PAUSA EQUIPO"
                Label6.Text = "REINICIAR PRODUCCION"
                pnl_pausa_falla_equipo.Visible = True
                pnl_pausa_falla_equipo.BringToFront()
                txt_motivo_pausa_falla_equipo.Text = ""
                cbo_motivo_pausa_falla_equipo.SelectedIndex = 0

                pb_inicio_prepar_des.Visible = False
                pb_inicio_des.Visible = False
                'pb_pausa_equipo_des.Visible = True
                'pb_pausa_des.Visible = True
                pb_fin_des.Visible = True

                txt_motivo_pausa_falla_equipo.Focus()
            Else
                Timer1.Start()
            End If
        End If

        'Try
        '    If pb_pausa_equipo.Cursor = Cursors.Default Then
        '        Timer1.Stop()
        '        If MsgBox("Esta seguro de PAUSAR la PRODUCCION POR FALLAS EN EQUIPO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
        '            Me.Cursor = Cursors.WaitCursor
        '            fecha_pausa = Date.Now.ToString("dd/MM/yyyy")
        '            hora_pausa = Date.Now.ToString("HH:mm:ss")
        '            tipo_pausa = "PAUSA EQUIPO"
        '            Label6.Text = "REINICIAR PRODUCCION"

        '            pb_inicio_prepar_des.Visible = True
        '            pb_inicio_des.Visible = False
        '            pb_pausa_equipo_des.Visible = True
        '            pb_pausa_des.Visible = True
        '            pb_fin_des.Visible = True


        '            Me.Cursor = Cursors.WaitCursor
        '            Dim row As DataRow = dtdetalle.NewRow

        '            For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
        '                _ULTIMO_ITEM = row2("ITEM")
        '                Exit For
        '            Next

        '            row("ITEM") = _ULTIMO_ITEM + 1
        '            _item = row("ITEM")
        '            If tipo_pausa = "PAUSA EXTRA" Then
        '                row("CONCEPTO") = "Pausa"
        '            ElseIf tipo_pausa = "PAUSA EQUIPO" Then
        '                row("CONCEPTO") = "Pausa Falla en Equipo"
        '            End If
        '            row("FECHA") = fecha_pausa
        '            row("HORA") = hora_pausa
        '            row("OBSERVACIONES") = ""
        '            row("MOTIVO_PAUSA") = "03"
        '            row("PLIEGOS_BUENOS") = ""
        '            row("PLIEGOS_MALOS") = ""

        '            dtdetalle.Rows.Add(row)
        '            dtdetalle.AcceptChanges()

        '            dgv_detalle_historial.DataSource = dtdetalle
        '            Formato_Grilla_Detalle_Op()

        '            pb_inicio.Enabled = True
        '            pb_pausa.Enabled = True
        '            pb_fin.Enabled = True
        '            pb_pausa_equipo.Enabled = True
        '            pb_inicio_prepar.Enabled = True
        '            Label6.Text = "REINICIAR PRODUCCION"
        '            pb_inicio.Cursor = Cursors.Default
        '            pb_pausa.Cursor = Cursors.No
        '            pb_fin.Cursor = Cursors.No
        '            pb_pausa_equipo.Cursor = Cursors.No
        '            pb_inicio_prepar.Cursor = Cursors.No

        '            If Guardar_Parte_Produccion("PAUSADO") Then
        '                Dim DT_DATOS_ENVIO_EMAIL As DataTable
        '                DT_DATOS_ENVIO_EMAIL = clsPedidoBl.GET_DEVOLVER_DATOS_ENVIO_EMAIL("08")

        '                If DT_DATOS_ENVIO_EMAIL.Rows.Count() <> 0 Then
        '                    _REMITENTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTFROM").ToString
        '                    _RECEPCIONANTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTTO").ToString
        '                    _SERVER = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSERVER").ToString
        '                    _USUARIO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTUSERNAME").ToString
        '                    _PASSWORD = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTPASSWORD").ToString
        '                    _ASUNTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSUBJECT").ToString
        '                    _TITULO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("REMITENTE").ToString
        '                    _PUERTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTMSG").ToString
        '                End If

        '                _mensaje = "Se registro Falla en Equipo: " & vbCrLf & vbCrLf

        '                _mensaje = _mensaje & vbTab & " - N° O.P. : " & dgv_produccion_programada.CurrentRow.Cells("Num.O.P.").Value & vbCrLf
        '                _mensaje = _mensaje & vbTab & " - CLIENTE : " & dgv_produccion_programada.CurrentRow.Cells("Cliente").Value & vbCrLf
        '                _mensaje = _mensaje & vbTab & " - PRODUCTO : " & dgv_produccion_programada.CurrentRow.Cells("Producto").Value & vbCrLf
        '                _mensaje = _mensaje & vbTab & " - CANTIDAD : " & dgv_produccion_programada.CurrentRow.Cells("Tiraje").Value & vbCrLf


        '                Try
        '                    Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, _RECEPCIONANTE, _ASUNTO, _mensaje)
        '                    Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
        '                    Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
        '                    smpt.EnableSsl = True
        '                    smpt.Credentials = acceso
        '                    smpt.Port = _PUERTO
        '                    smpt.Host = _SERVER

        '                    smpt.Send(mensajes)
        '                    'MsgBox("Mensaje enviado correctamente", MsgBoxStyle.Information, "Aviso")

        '                Catch ex As Exception
        '                    Me.Cursor = Cursors.Default
        '                    MsgBox(ex.Message)
        '                End Try
        '            End If

        '            Me.Cursor = Cursors.Default
        '        Else
        '            Timer1.Start()
        '        End If
        '    End If
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub pb_inicio_prepar_Click(sender As Object, e As EventArgs) Handles pb_inicio_prepar.Click
        If pb_inicio_prepar.Cursor = Cursors.Default Then
            'If op_operando = True Then
            '    MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe TERMINAR la O.P., para iniciar otro.", MsgBoxStyle.Exclamation, "Sistemas")
            '    Exit Sub
            'End If

            If lbl_inicio.Text = "INICIO" Or lbl_inicio.Text = "REINICIAR" Then
                'If MsgBox("Esta seguro de INICIAR PROCESO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                Timer1.Stop()
                pnl_proceso_inicio_preparacion.Visible = True
                pnl_proceso_inicio_preparacion.BringToFront()

                pb_inicio_prepar.Cursor = Cursors.No
                cbo_proceso_preparacion.SelectedIndex = -1
                txt_obs_inicio.Text = ""
                Button1.Enabled = False
                'End If
            ElseIf lbl_inicio.Text = "FIN" Then
                Timer1.Stop()
                If MsgBox("Esta seguro de FINALIZAR LA PRODUCCION?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                    pb_inicio_prepar.Cursor = Cursors.No
                    Button1.Enabled = False

                    lbl_ms.Text = "0"
                    lbl_segundo.Text = "00"
                    lbl_minuto.Text = "00"
                    lbl_hora.Text = "00"
                    pb_inicio.Enabled = True
                    pb_pausa.Enabled = True
                    pb_fin.Enabled = True
                    'pb_pausa_equipo.Enabled = True
                    pb_inicio_prepar.Enabled = True

                    pb_inicio.Cursor = Cursors.No
                    pb_pausa.Cursor = Cursors.No
                    pb_fin.Cursor = Cursors.No
                    pb_pausa_equipo.Cursor = Cursors.No
                    pb_inicio_prepar.Cursor = Cursors.No

                    pb_inicio_prepar_des.Visible = True
                    pb_inicio_des.Visible = False 'True
                    'pb_pausa_equipo_des.Visible = True
                    'pb_pausa_des.Visible = True
                    pb_fin_des.Visible = True

                    pnl_proceso_fin_preparacion.Visible = True
                    pnl_proceso_fin_preparacion.BringToFront()
                    'txt_buenos.Text = ""
                    'txt_malos.Text = ""
                    txt_cantidad_fin.Text = ""
                    txt_obs_fin.Text = ""
                    txt_cantidad_fin.Focus()
                    'Timer1.Stop()
                Else
                    Timer1.Start()
                End If
            End If
        End If

    End Sub

    Private Sub Agregar_HP_Dos(ByVal _item As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

            With Pedido_Det_HP
                .USER_ID = txt_usuario.Text.Trim
                .EQUIPO_COD = TextBox6.Text.Trim
                .FECHA = dgv_produccion_programada2.CurrentRow.Cells("Fecha Programada").Value
                .ITEM = _item
                .DESCRIPCION = "Inicio O.P. "
                .NUMERO_OP = dgv_produccion_programada2.CurrentRow.Cells("Num.O.P.").Value
                .NUMERO_OP_ID = _NUMERO_OP
                .ITEM_OP_ID = _ITEM_OP
                .USER_ID_REGISTRO = LibComunVar.ClsVarComun.USUARIO
                .PC_ID_REGISTRO = Environment.MachineName
                .TURNO = cbo_turno.Text
                .FECHA_TURNO = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
            End With

            If clsPedidoBl.Guardar_Parte_Produccion_Historial_Personal(Pedido_Det_HP) = False Then
                MsgBox("Registro de Historial del Personal no se registro.", MsgBoxStyle.Exclamation, "Sistemas")
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Panel1.Visible = False
        Timer1.Stop()
        Button36_Click(sender, e)
        op_operando = False

        pb_inicio_prepar_des.Visible = False
        pb_inicio_des.Visible = False
        'pb_pausa_equipo_des.Visible = False
        'pb_pausa_des.Visible = False
        pb_fin_des.Visible = False
        btn_manejo_troquel.Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_parte_personal_Click(sender As Object, e As EventArgs) Handles btn_parte_personal.Click
        txt_titulo_hp.Text = "HISTORIAL DEL PERSONAL " & Strings.UCase(txt_usuario.Text.Trim)
        txt_descripcion_hp.Text = ""
        dtp_fecha_hp.Enabled = False
        dtp_fecha_hp.Value = Date.Now
        txt_num_op_hp.Text = ""
        Call Lista_Historial_Personal()
        txt_descripcion_hp.Focus()
        pnl_produccion_programada.Enabled = False
        pnl_historial_personal.Visible = True
    End Sub
    Private Sub Lista_Historial_Personal()
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            dtdetalleArticuloPrincipal = clsPedidoBl.get_Parte_Produccion_Historial_Personal(TextBox6.Text.Trim, _
                                                                                            dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                            cbo_turno.Text)
            dgv_detalle_hp.DataSource = Nothing
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                dgv_detalle_hp.DataSource = dtdetalleArticuloPrincipal

                If TextBox6.Text.Trim = "15" Then 'guillotina polar
                    dgv_detalle_hp.Columns("ITEM").Width = 40
                    dgv_detalle_hp.Columns("HORA INICIO").Width = 120
                    dgv_detalle_hp.Columns("HORA FINAL").Width = 120
                    dgv_detalle_hp.Columns("O.P").Width = 50
                    dgv_detalle_hp.Columns("CLIENTE").Width = 150
                    dgv_detalle_hp.Columns("PRODUCTO").Width = 150
                    dgv_detalle_hp.Columns("ELEMENTO").Width = 150
                    dgv_detalle_hp.Columns("TIPO CORTE").Width = 80
                    dgv_detalle_hp.Columns("ESTADO").Width = 80

                    dgv_detalle_hp.Columns("RESULTADO BUENOS").Width = 80
                    dgv_detalle_hp.Columns("RESULTADO MALOS").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO PROGRAMADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO EJECUTADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO (+ ó -)").Width = 80

                    dgv_detalle_hp.Columns("OBSERVACIONES").Width = 250
                ElseIf TextBox6.Text.Trim = "20" Or TextBox6.Text.Trim = "35" Or TextBox6.Text.Trim = "13" Then 'SM o ROLAND
                    dgv_detalle_hp.Columns("ITEM").Width = 40
                    dgv_detalle_hp.Columns("HORA INICIO").Width = 120
                    dgv_detalle_hp.Columns("HORA FINAL").Width = 120
                    dgv_detalle_hp.Columns("O.P").Width = 50
                    dgv_detalle_hp.Columns("CLIENTE").Width = 150
                    dgv_detalle_hp.Columns("PRODUCTO").Width = 150
                    dgv_detalle_hp.Columns("ELEMENTO").Width = 150
                    dgv_detalle_hp.Columns("ACTIVIDAD").Width = 80
                    dgv_detalle_hp.Columns("LADO IMPRESION").Width = 80

                    dgv_detalle_hp.Columns("RESULTADO BUENOS").Width = 80
                    dgv_detalle_hp.Columns("RESULTADO MALOS").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO PROGRAMADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO EJECUTADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO (+ ó -)").Width = 80

                    dgv_detalle_hp.Columns("ESTADO").Width = 80
                    dgv_detalle_hp.Columns("OBSERVACIONES").Width = 250
                ElseIf TextBox6.Text.Trim = "25" Or TextBox6.Text.Trim = "28" Or TextBox6.Text.Trim = "18" Or TextBox6.Text.Trim = "40" Then 'PLASTIFICADORA
                    dgv_detalle_hp.Columns("ITEM").Width = 40
                    dgv_detalle_hp.Columns("HORA INICIO").Width = 120
                    dgv_detalle_hp.Columns("HORA FINAL").Width = 120
                    dgv_detalle_hp.Columns("O.P").Width = 50
                    dgv_detalle_hp.Columns("CLIENTE").Width = 150
                    dgv_detalle_hp.Columns("PRODUCTO").Width = 150
                    dgv_detalle_hp.Columns("ELEMENTO").Width = 150
                    dgv_detalle_hp.Columns("LADO APLICACION").Width = 80
                    dgv_detalle_hp.Columns("ESTADO").Width = 80

                    dgv_detalle_hp.Columns("RESULTADO BUENOS").Width = 80
                    dgv_detalle_hp.Columns("RESULTADO MALOS").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO PROGRAMADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO EJECUTADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO (+ ó -)").Width = 80

                    dgv_detalle_hp.Columns("OBSERVACIONES").Width = 250
                ElseIf TextBox6.Text.Trim = "6" Or TextBox6.Text = "38" Then 'TROQUELADORA
                    dgv_detalle_hp.Columns("ITEM").Width = 40
                    dgv_detalle_hp.Columns("HORA INICIO").Width = 120
                    dgv_detalle_hp.Columns("HORA FINAL").Width = 120
                    dgv_detalle_hp.Columns("O.P").Width = 50
                    dgv_detalle_hp.Columns("CLIENTE").Width = 150
                    dgv_detalle_hp.Columns("PRODUCTO").Width = 150
                    dgv_detalle_hp.Columns("ELEMENTO").Width = 150
                    dgv_detalle_hp.Columns("ESTADO").Width = 80

                    dgv_detalle_hp.Columns("RESULTADO BUENOS").Width = 80
                    dgv_detalle_hp.Columns("RESULTADO MALOS").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO PROGRAMADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO EJECUTADO").Width = 80
                    dgv_detalle_hp.Columns("TIEMPO (+ ó -)").Width = 80

                    dgv_detalle_hp.Columns("OBSERVACIONES").Width = 250
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_num_op_hp_Leave(sender As Object, e As EventArgs) Handles txt_num_op_hp.Leave
        If txt_num_op_hp.Text.Trim().Length > 0 Then
            txt_num_op_hp.Text = txt_num_op_hp.Text.PadLeft(6, Char.Parse("0"))
        End If
    End Sub

    Private Sub txt_descripcion_hp_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_descripcion_hp.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_num_op_hp.Focus()
        End If
    End Sub


    Private Sub txt_num_op_hp_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_num_op_hp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add_hp.Focus()
        End If
    End Sub

    Private Sub btn_exit_hp_Click(sender As Object, e As EventArgs) Handles btn_exit_hp.Click
        pnl_produccion_programada.Enabled = True
        pnl_historial_personal.Visible = False
    End Sub
    Public Sub GenerarColummnaDataTable_Historial_Personal()
        dtdetalleArticuloPrincipal = New DataTable
        dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal.Columns.Add("USUARIO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("NUMERO_OP", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal.Columns.Add("FECHA", Type.GetType("System.String"))

        dgv_detalle_hp.DataSource = Nothing
        dgv_detalle_hp.DataSource = dtdetalleArticuloPrincipal

        dgv_detalle_hp.Columns(0).HeaderText = "Item"
        dgv_detalle_hp.Columns(1).HeaderText = "Usuario"
        dgv_detalle_hp.Columns(2).HeaderText = "Descripción"
        dgv_detalle_hp.Columns(3).HeaderText = "N° Orden Producción"
        dgv_detalle_hp.Columns(4).HeaderText = "Fecha"

        'dgv_detalle_hp.AutoResizeColumns()
        'dgv_detalle_hp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btn_add_hp_Click(sender As Object, e As EventArgs) Handles btn_add_hp.Click
        Try
            If Validacion_HP() = False Then Exit Sub

            Dim row As DataRow = dtdetalleArticuloPrincipal.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal.Rows.Count() + 1
            row("USUARIO") = txt_usuario.Text.Trim
            row("DESCRIPCION") = txt_descripcion_hp.Text.Trim
            row("NUMERO_OP") = txt_num_op_hp.Text.Trim
            row("FECHA") = dtp_fecha_hp.Value.ToString("dd/MM/yyyy")

            dtdetalleArticuloPrincipal.Rows.Add(row)
            dtdetalleArticuloPrincipal.AcceptChanges()

            Call Agregar_HP(row("ITEM"))

            txt_descripcion_hp.Text = ""
            txt_num_op_hp.Text = ""
            txt_descripcion_hp.Focus()

            dgv_detalle_hp.DataSource = dtdetalleArticuloPrincipal

            'dgvDetalle.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Validacion_HP() As Boolean

        If txt_descripcion_hp.Text.Trim = "" Then
            MsgBox("Debe digitar una descripción de la Actividad.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub Agregar_HP(ByVal _item As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

            With Pedido_Det_HP
                .USER_ID = txt_usuario.Text.Trim
                .FECHA = dtp_fecha_hp.Value.ToString("dd/MM/yyyy")
                .ITEM = _item
                .DESCRIPCION = txt_descripcion_hp.Text.Trim
                .NUMERO_OP = txt_num_op_hp.Text.Trim
                .USER_ID_REGISTRO = LibComunVar.ClsVarComun.USUARIO
                .PC_ID_REGISTRO = Environment.MachineName
            End With


            If clsPedidoBl.Guardar_Parte_Produccion_Historial_Personal(Pedido_Det_HP) = False Then
                MsgBox("Registro de Historial del Personal no se registro.", MsgBoxStyle.Exclamation, "Sistemas")
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox6.Text = "" Then
            MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TextBox6.Text <> "15" And TextBox6.Text <> "20" And TextBox6.Text <> "35" And TextBox6.Text <> "13" And TextBox6.Text <> "25" And TextBox6.Text <> "6" And TextBox6.Text = "38" And TextBox6.Text = "37" And TextBox6.Text = "28" And TextBox6.Text = "18" And TextBox6.Text = "40" Then
            MsgBox("El equipo elegido no forma parte de la Producción. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If dgv_produccion_programada2.Rows.Count = 0 Then Exit Sub

        txt_titulo_hp.Text = "PARTE DIARIO DEL PERSONAL " & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy") & "-" & TextBox5.Text.Trim
        txt_descripcion_hp.Text = ""
        dtp_fecha_hp.Enabled = False
        dtp_fecha_hp.Value = dtp_fecha_produccion_programada.Value
        txt_num_op_hp.Text = ""
        Call Lista_Historial_Personal()
        txt_descripcion_hp.Focus()
        pnl_produccion_programada.Enabled = False
        pnl_historial_personal.Visible = True
    End Sub

    Private Sub dtp_fecha_produccion_programada_fin_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_fecha_produccion_programada_fin.KeyDown
        If e.KeyCode = Keys.Enter Then Button36_Click(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_parte_maquina.Click
        Try
            If TextBox6.Text = "" Then
                MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cbo_turno.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'If TextBox6.Text <> "15" And TextBox6.Text <> "20" And TextBox6.Text <> "35" And TextBox6.Text <> "13" And TextBox6.Text <> "25" And TextBox6.Text <> "6" And TextBox6.Text <> "37" Then
            '    MsgBox("El equipo elegido no esta habilitado para esta opción. Verifique!!!", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If

            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte
            Me.Cursor = Cursors.WaitCursor

            '6	TROQUELADORA
            '25	PLASTIFICADORA
            '35	roland
            '20	SPEED MASTER
            '15 GUIL. POLAR
            Dim dt_detalle_produccion_programada As DataTable
            tiempo_total_ = 0

            'If Calcular_Tiempo_OP_2(dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), TextBox6.Text.Trim, cbo_turno.Text) = False Then
            '    Me.Cursor = Cursors.Default
            '    Exit Sub
            'End If

            If Calcular_Tiempo_OP_No_Productivo_2(dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), TextBox6.Text.Trim, cbo_turno.Text) = False Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            dt_detalle_produccion_programada = clsPedidoBl.get_Mantenimiento_Produccion_Programada_Parte_Diario_Nuevo(TextBox6.Text.Trim, _
                                                                                                   dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                   dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                   cbo_turno.Text)
            If dt_detalle_produccion_programada.Rows.Count() <> 0 Then

                'crystalBL.Muestra_Reporte("rpt_Formato_Corte_PP.rpt", dt_detalle_produccion_programada, "", "", _
                '                      "@OPCION;" & TextBox6.Text, _
                '                      "@FECHA;" & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                '                      "@TURNO;" & cbo_turno.Text, _
                '                      "titulo;" & "PARTE PRODUCCION DIARIO DEL PERSONAL " & Strings.UCase(TextBox5.Text.Trim))
                crystalBL.Muestra_Reporte("rpt_Formato_Corte_PP_Nuevo.rpt", dt_detalle_produccion_programada, "", "", _
                                      "@OPCION;" & TextBox6.Text, _
                                      "@FECHA;" & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                      "@TURNO;" & cbo_turno.Text, _
                                      "titulo;" & "PARTE PRODUCCION DIARIO DEL PERSONAL " & Strings.UCase(TextBox5.Text.Trim), _
                                      "HORAS_PROGRAMADAS;" & txt_tiempo_total_programado.Text)

                'If TextBox6.Text.Trim = "15" Then 'guillotina polar
                '    crystalBL.Muestra_Reporte("rpt_Formato_Corte_PP_I.rpt", dt_detalle_produccion_programada, "", "", _
                '                          "@OPCION;" & TextBox6.Text, _
                '                          "@FECHA;" & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                '                          "@TURNO;" & cbo_turno.Text, _
                '                          "titulo;" & "PARTE PRODUCCION DIARIO DEL PERSONAL" & Strings.UCase(TextBox5.Text.Trim))
                'ElseIf TextBox6.Text.Trim = "20" Or TextBox6.Text.Trim = "35" Or TextBox6.Text.Trim = "13" Then 'SM o ROLAND
                '    crystalBL.Muestra_Reporte("rpt_Formato_Impresion_PP_I.rpt", dt_detalle_produccion_programada, "", "", _
                '                          "@OPCION;" & TextBox6.Text, _
                '                          "@FECHA;" & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                '                          "@TURNO;" & cbo_turno.Text, _
                '                          "titulo;" & "PARTE PRODUCCION DIARIO DEL PERSONAL" & Strings.UCase(TextBox5.Text.Trim))
                'ElseIf TextBox6.Text.Trim = "25" Then 'PLASTIFICADORA
                '    crystalBL.Muestra_Reporte("rpt_Formato_Plastico_PP_I.rpt", dt_detalle_produccion_programada, "", "", _
                '                          "@OPCION;" & TextBox6.Text, _
                '                          "@FECHA;" & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                '                          "@TURNO;" & cbo_turno.Text, _
                '                          "titulo;" & "PARTE PRODUCCION DIARIO DEL PERSONAL" & Strings.UCase(TextBox5.Text.Trim))
                'ElseIf TextBox6.Text.Trim = "6" Then 'TROQUELADORA
                '    crystalBL.Muestra_Reporte("rpt_Formato_Troquel_PP_I.rpt", dt_detalle_produccion_programada, "", "", _
                '                          "@OPCION;" & TextBox6.Text, _
                '                          "@FECHA;" & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                '                          "@TURNO;" & cbo_turno.Text, _
                '                          "titulo;" & "PARTE PRODUCCION DIARIO DEL PERSONAL" & Strings.UCase(TextBox5.Text.Trim))
                'End If
            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Calcular_Tiempo_OP(ByVal fecha As String, ByVal equipo As String, ByVal turno As String) As Boolean
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim _flag_final As Boolean = False
            Dim _flag_pausa As Boolean = False
            Dim _flag_inicio As Boolean = False
            Dim bandera As Boolean = True
            Dim resta As TimeSpan
            Dim tiempo_productivo As TimeSpan
            Dim tiempo_transcurrido As TimeSpan
            Dim tiempo_puente As TimeSpan
            Dim estado_op As String = ""
            t_ejecutado = ""

            Dim dt_lista_ops As DataTable
            tiempo_total = tiempo_productivo
            dt_lista_ops = clsPedidoBl.get_Lista_Detalles_OP(fecha, equipo, turno)

            If dt_lista_ops.Rows.Count() > 0 Then
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    dtdetalle = clsPedidoBl.get_Detalle_Parte_Diario(dt_lista_ops.Rows(i).Item("ID_CAB"), dt_lista_ops.Rows(i).Item("ITEM"), equipo, fecha, turno)
                    _flag_inicio = False
                    _flag_final = False
                    _flag_pausa = False
                    estado_op = ""

                    tiempo_transcurrido = tiempo_puente
                    If dtdetalle.Rows.Count > 0 Then
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                            _flag_final = True
                            Exit For
                        Next

                        If _flag_final = True Then 'ya termino

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO in ('Pausa','Pausa Equipo Averiado')")
                                _flag_pausa = True
                                Exit For
                            Next

                            If _flag_pausa = False Then 'SI NO HAY PAUSA

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                                    t_inicio = TimeSpan.Parse(row("HORA"))
                                    _flag_inicio = True
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                                    If _flag_inicio = False Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _flag_inicio = True
                                    End If
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                                    If _flag_inicio = False Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _flag_inicio = True
                                    End If
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'")
                                    If _flag_inicio = False Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _flag_inicio = True
                                    End If
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                                    t_fin = TimeSpan.Parse(row("HORA"))
                                Next

                                resta = t_fin - t_inicio
                                tiempo_productivo = tiempo_productivo + resta
                                tiempo_total = tiempo_total + resta
                            ElseIf _flag_pausa = True Then 'SI HAY PAUSA
                                Dim items_pausa As Integer = 0
                                Dim items_reinicio As Integer = 0
                                Dim ultima_pausa As Integer = 0
                                Dim ultima_reinicio As Integer = 0


                                Dim _inicio As String = ""
                                Dim _fin As String = ""
                                For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                                    If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
                                        If _flag_inicio = False Then
                                            t_inicio = TimeSpan.Parse(row("HORA"))
                                            _flag_inicio = True
                                            _inicio = "inicio"
                                        End If
                                    End If
                                    If row("CONCEPTO") = "Reinicio" Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _inicio = "inicio"
                                    End If
                                    If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Then
                                        t_fin = TimeSpan.Parse(row("HORA"))
                                        _fin = "fin"
                                    End If
                                    If row("CONCEPTO") = "Final" Then
                                        t_fin = TimeSpan.Parse(row("HORA"))
                                        _fin = "fin"
                                    End If

                                    If _inicio <> "" And _fin <> "" Then
                                        Dim resta3 As TimeSpan = t_fin - t_inicio
                                        tiempo_transcurrido = tiempo_transcurrido + resta3
                                        _inicio = ""
                                        _fin = ""
                                    End If
                                Next

                                resta = tiempo_transcurrido
                                tiempo_productivo = tiempo_productivo + resta
                                tiempo_total = tiempo_total + resta
                            End If

                            estado_op = "TERMINADO"
                        ElseIf _flag_final = False Then 'no termino

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO IN ('Pausa','Pausa Equipo Averiado')")
                                _flag_pausa = True
                                Exit For
                            Next


                            If _flag_pausa = True Then 'SI HAY PAUSA
                                Dim items_pausa As Integer = 0
                                Dim items_reinicio As Integer = 0
                                Dim ultima_pausa As Integer = 0
                                Dim ultima_reinicio As Integer = 0

                                Dim _inicio As String = ""
                                Dim _fin As String = ""
                                For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                                    If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Preparación de Equipo" Or row("CONCEPTO") = "Inicio Producción" Then
                                        If _flag_inicio = False Then
                                            t_inicio = TimeSpan.Parse(row("HORA"))
                                            _flag_inicio = True
                                            _inicio = "inicio"
                                        End If
                                    End If
                                    If row("CONCEPTO") = "Reinicio" Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _inicio = "inicio"
                                    End If
                                    If row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Then
                                        t_fin = TimeSpan.Parse(row("HORA"))
                                        _fin = "fin"
                                    End If
                                    If row("CONCEPTO") = "Final" Then
                                        t_fin = TimeSpan.Parse(row("HORA"))
                                        _fin = "fin"
                                    End If

                                    If _inicio <> "" And _fin <> "" Then
                                        Dim resta3 As TimeSpan = t_fin - t_inicio
                                        tiempo_transcurrido = tiempo_transcurrido + resta3
                                        _inicio = ""
                                        _fin = ""
                                    End If
                                Next

                                resta = tiempo_transcurrido
                                tiempo_productivo = tiempo_productivo + resta
                                tiempo_total = tiempo_total + resta
                            ElseIf _flag_pausa = False Then 'SI NO HAY PAUSA
                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                                    t_inicio = TimeSpan.Parse(row("HORA"))
                                    _flag_inicio = True
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                                    If _flag_inicio = False Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _flag_inicio = True
                                    End If
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                                    If _flag_inicio = False Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _flag_inicio = True
                                    End If
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'")
                                    If _flag_inicio = False Then
                                        t_inicio = TimeSpan.Parse(row("HORA"))
                                        _flag_inicio = True
                                    End If
                                    t_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                t_fin = TimeSpan.Parse(Date.Now.ToString("HH:mm:ss"))
                                resta = t_fin - t_inicio
                                tiempo_productivo = tiempo_productivo + resta
                                tiempo_total = tiempo_total + resta
                            End If

                            estado_op = "PAUSADO"

                        End If

                        Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                        If clsPedidoBl.Guardar_Tiempo_Operado_OPS(dt_lista_ops.Rows(i).Item("ID_CAB"), dt_lista_ops.Rows(i).Item("ITEM"), equipo, _
                                                                  fecha, resta.ToString, bandera, tiempo_transcurrido.ToString, turno, estado_op) = False Then
                            Me.Cursor = Cursors.Default
                            Return False
                        Else
                            bandera = False
                        End If
                    End If
                Next
                tiempo_total = tiempo_total
                If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO PRODUCTIVO", tiempo_total.ToString, True, turno) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            Else
                If clsPedidoBl.Guardar_Tiempo_(equipo, fecha, "TIEMPO PRODUCTIVO", tiempo_total.ToString, True) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Calcular_Tiempo_OP_2(ByVal fecha As String, ByVal equipo As String, ByVal turno As String) As Boolean
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim _flag_final As Boolean = False
            Dim _flag_pausa As Boolean = False
            Dim _flag_inicio As Boolean = False
            Dim bandera As Boolean = True
            Dim resta As Double
            Dim tiempo_productivo As Double
            Dim tiempo_transcurrido As Double
            Dim tiempo_puente As Double
            Dim estado_op As String = ""
            Dim _pliegos_buenos As String = ""
            Dim _pliegos_malos As String = ""
            t_ejecutado = ""
            Dim t_inicio_ As Date
            Dim t_fin_ As Date
            Dim horas As Double
            Dim minutos As Double
            Dim segundos As Double

            Dim dt_lista_ops As DataTable
            'tiempo_total = tiempo_productivo
            dt_lista_ops = clsPedidoBl.get_Lista_Detalles_OP(fecha, equipo, turno)
            tiempo_productivo = 0
            If dt_lista_ops.Rows.Count() > 0 Then
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    dtdetalle = clsPedidoBl.get_Detalle_Parte_Diario(dt_lista_ops.Rows(i).Item("ID_CAB"), dt_lista_ops.Rows(i).Item("ITEM"), equipo, fecha, turno)
                    _flag_inicio = False
                    _flag_final = False
                    _flag_pausa = False
                    estado_op = ""
                    _pliegos_buenos = ""
                    _pliegos_malos = ""

                    resta = 0
                    tiempo_transcurrido = tiempo_puente
                    If dtdetalle.Rows.Count > 0 Then
                        For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                            _flag_final = True
                            Exit For
                        Next

                        If _flag_final = True Then 'ya termino

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO in ('Pausa','Pausa Equipo Averiado','Pausa Falla en Equipo')")
                                _flag_pausa = True
                                Exit For
                            Next

                            If _flag_pausa = False Then 'SI NO HAY PAUSA

                                'For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                                '    t_inicio_ = row("FECHA_REAL")
                                '    _flag_inicio = True
                                '    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                '    Exit For
                                'Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                                    If _flag_inicio = False Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _flag_inicio = True
                                    End If
                                    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                                    If _flag_inicio = False Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _flag_inicio = True
                                    End If
                                    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'")
                                    If _flag_inicio = False Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _flag_inicio = True
                                    End If
                                    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Final'")
                                    t_fin_ = row("FECHA_REAL")
                                Next

                                If _flag_inicio = False Then
                                    t_inicio_ = t_fin_
                                End If
                                resta = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                tiempo_productivo = tiempo_productivo + resta

                            ElseIf _flag_pausa = True Then 'SI HAY PAUSA
                                Dim items_pausa As Integer = 0
                                Dim items_reinicio As Integer = 0
                                Dim ultima_pausa As Integer = 0
                                Dim ultima_reinicio As Integer = 0


                                Dim _inicio As String = ""
                                Dim _inicio_produccion As Boolean = False
                                Dim _fin As String = ""
                                For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                                    If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Producción" Then
                                        If _flag_inicio = False Then
                                            t_inicio_ = row("FECHA_REAL")
                                            _flag_inicio = True
                                            _inicio = "inicio"
                                            _inicio_produccion = True
                                        End If
                                    End If
                                    If row("CONCEPTO") = "Reinicio" And _inicio_produccion Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _inicio = "inicio"
                                    End If
                                    If (row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Or row("CONCEPTO") = "Pausa Falla en Equipo") And _inicio_produccion Then
                                        t_fin_ = row("FECHA_REAL")
                                        _fin = "fin"
                                    End If
                                    If row("CONCEPTO") = "Final" And _inicio_produccion Then
                                        t_fin_ = row("FECHA_REAL")
                                        _fin = "fin"
                                    End If

                                    If _inicio <> "" And _fin <> "" Then
                                        Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                        tiempo_transcurrido = tiempo_transcurrido + resta3
                                        _inicio = ""
                                        _fin = ""
                                        _flag_inicio = False
                                    ElseIf _inicio = "" And _fin <> "" Then
                                        _fin = ""
                                    End If
                                Next

                                resta = tiempo_transcurrido
                                tiempo_productivo = tiempo_productivo + resta

                            End If

                            estado_op = "TERMINADO"
                        ElseIf _flag_final = False Then 'no termino

                            For Each row As DataRow In dtdetalle.Select("CONCEPTO IN ('Pausa','Pausa Equipo Averiado','Pausa Falla en Equipo')")
                                _flag_pausa = True
                                Exit For
                            Next


                            If _flag_pausa = True Then 'SI HAY PAUSA
                                Dim items_pausa As Integer = 0
                                Dim items_reinicio As Integer = 0
                                Dim ultima_pausa As Integer = 0
                                Dim ultima_reinicio As Integer = 0

                                Dim _inicio As String = ""
                                Dim _inicio_produccion As Boolean = False
                                Dim _fin As String = ""
                                For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM ASC")
                                    If row("CONCEPTO") = "Inicio" Or row("CONCEPTO") = "Inicio Producción" Then
                                        If _flag_inicio = False Then
                                            t_inicio_ = row("FECHA_REAL")
                                            _flag_inicio = True
                                            _inicio = "inicio"
                                            _inicio_produccion = True
                                        End If
                                    End If
                                    If row("CONCEPTO") = "Reinicio" And _inicio_produccion Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _inicio = "inicio"
                                    End If
                                    If (row("CONCEPTO") = "Pausa" Or row("CONCEPTO") = "Pausa Equipo Averiado" Or row("CONCEPTO") = "Pausa Falla en Equipo") And _inicio_produccion Then
                                        t_fin_ = row("FECHA_REAL")
                                        _fin = "fin"
                                    End If
                                    If row("CONCEPTO") = "Final" And _inicio_produccion Then
                                        t_fin_ = row("FECHA_REAL")
                                        _fin = "fin"
                                    End If

                                    If _inicio <> "" And _fin <> "" Then
                                        Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                        tiempo_transcurrido = tiempo_transcurrido + resta3
                                        _inicio = ""
                                        _fin = ""
                                        _flag_inicio = False
                                    End If
                                Next

                                resta = tiempo_transcurrido
                                tiempo_productivo = tiempo_productivo + resta

                            ElseIf _flag_pausa = False Then 'SI NO HAY PAUSA
                                'For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Preparación de Equipo'")
                                '    t_inicio_ = row("FECHA_REAL")
                                '    _flag_inicio = True
                                '    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                '    Exit For
                                'Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio Producción'")
                                    If _flag_inicio = False Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _flag_inicio = True
                                    End If
                                    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Inicio'")
                                    If _flag_inicio = False Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _flag_inicio = True
                                    End If
                                    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                For Each row As DataRow In dtdetalle.Select("CONCEPTO='Reinicio'")
                                    If _flag_inicio = False Then
                                        t_inicio_ = row("FECHA_REAL")
                                        _flag_inicio = True
                                    End If
                                    't_inicio_oficial = TimeSpan.Parse(row("HORA"))
                                    Exit For
                                Next

                                t_fin_ = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                                resta = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                                tiempo_productivo = tiempo_productivo + resta

                            End If

                            estado_op = "PAUSADO"

                        End If

                        Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                        horas = 0
                        minutos = 0
                        segundos = 0

                        If resta < 60 Then
                            horas = 0
                            minutos = 0
                            segundos = resta
                        Else
                            minutos = Math.Floor(resta / 60)
                            If minutos < 60 Then
                                horas = 0
                                segundos = resta - (minutos * 60)
                            Else
                                horas = Math.Floor(minutos / 60)
                                minutos = minutos - (horas * 60)
                                segundos = resta - (horas * 3600) - (minutos * 60)
                            End If
                        End If

                        For Each row As DataRow In dtdetalle.Select("CONCEPTO<>'XX'", "ITEM DESC")
                            _pliegos_buenos = row("PLIEGOS_BUENOS")
                            _pliegos_malos = row("PLIEGOS_MALOS")
                            Exit For
                        Next

                        If clsPedidoBl.Guardar_Tiempo_Operado_OPS(dt_lista_ops.Rows(i).Item("ID_CAB"), dt_lista_ops.Rows(i).Item("ITEM"), equipo, _
                                                                  fecha, (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")), _
                                                                  bandera, (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")), _
                                                                  turno, estado_op, _pliegos_buenos, _pliegos_malos) = False Then
                            Me.Cursor = Cursors.Default
                            Return False
                        Else
                            bandera = False
                        End If
                    End If
                Next

                horas = 0
                minutos = 0
                segundos = 0

                If tiempo_productivo < 60 Then
                    horas = 0
                    minutos = 0
                    segundos = tiempo_productivo
                Else
                    minutos = Math.Floor(tiempo_productivo / 60)
                    If minutos < 60 Then
                        horas = 0
                        segundos = tiempo_productivo - (minutos * 60)
                    Else
                        horas = Math.Floor(minutos / 60)
                        minutos = minutos - (horas * 60)
                        segundos = tiempo_productivo - (horas * 3600) - (minutos * 60)
                    End If
                End If

                tiempo_total_ = tiempo_total_ + tiempo_productivo

                If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO PRODUCTIVO", (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")), True, turno) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            Else
                horas = 0
                minutos = 0
                segundos = 0

                If clsPedidoBl.Guardar_Tiempo_(equipo, fecha, "TIEMPO PRODUCTIVO", (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")), True) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Calcular_Tiempo_OP_No_Productivo(ByVal fecha As String, ByVal equipo As String, ByVal turno As String) As Boolean
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim _flag_final As Boolean = False
            Dim _flag_pausa As Boolean = False
            Dim _flag_inicio As Boolean = False
            Dim bandera As Boolean = True
            Dim resta As TimeSpan
            t_ejecutado = ""

            Dim dt_lista_ops As DataTable
            Dim id_cab_actual As Integer = 0
            Dim item_actual As Integer = 0
            Dim _inicio As String = ""
            Dim _fin As String = ""

            Dim tiempo_no_productivo As TimeSpan
            Dim tiempo_pausado As TimeSpan
            Dim tiempo_pausado_ea As TimeSpan
            Dim tiempo_sin_trabajo As TimeSpan
            Dim tiempo_act_no_programada As TimeSpan

            dt_lista_ops = clsPedidoBl.get_Detalle_Parte_Diario_Tiempo_No_Productivo(equipo, fecha, turno)
            'OBTENEMOS EL TIEMPO NO PRODUCTIVO
            If dt_lista_ops.Rows.Count() > 0 Then
                Dim tiempo_transcurrido As TimeSpan
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    If i = 0 Then
                        id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                        item_actual = dt_lista_ops.Rows(i).Item("ITEM")
                        t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                        _inicio = "inicio"
                    Else
                        If id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB") And item_actual = dt_lista_ops.Rows(i).Item("ITEM") Then
                            t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _inicio = "inicio"
                        Else
                            If _fin = "Fin Sin Trabajo" Then
                                t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                _inicio = "inicio"
                                id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                                item_actual = dt_lista_ops.Rows(i).Item("ITEM")
                                t_fin = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                _fin = "fin"
                            Else
                                id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                                item_actual = dt_lista_ops.Rows(i).Item("ITEM")
                                t_fin = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                _fin = "fin"
                                'If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Sin Trabajo" Or dt_lista_ops.Rows(i).Item("CONCEPTO") = "Mantenimiento Equipo" Then
                                '    _fin = "Fin Sin Trabajo"
                                'End If
                            End If

                        End If
                    End If

                    If _inicio <> "" And _fin <> "" And _fin <> "Fin Sin Trabajo" Then
                        Dim resta3 As TimeSpan = t_fin - t_inicio
                        tiempo_transcurrido = tiempo_transcurrido + resta3
                        _inicio = ""
                        _fin = ""
                        If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Sin Trabajo" Or dt_lista_ops.Rows(i).Item("CONCEPTO") = "Mantenimiento Equipo" Or dt_lista_ops.Rows(i).Item("CONCEPTO") = "Actividad No Programada" Then
                            _fin = "Fin Sin Trabajo"
                        End If
                    End If
                Next

                tiempo_no_productivo = tiempo_transcurrido
                tiempo_total = tiempo_total + tiempo_no_productivo
                Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO NO PRODUCTIVO", tiempo_no_productivo.ToString, False, turno) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If

            End If

            _inicio = ""
            _fin = ""
            'OBTENEMOS EL TIEMPO PAUSADO
            dt_lista_ops = clsPedidoBl.get_Detalle_Parte_Diario_Tiempo_No_Productivo(equipo, fecha, turno)
            If dt_lista_ops.Rows.Count() > 0 Then
                Dim tiempo_transcurrido2 As TimeSpan
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    If i = 0 Then
                        id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                        item_actual = dt_lista_ops.Rows(i).Item("ITEM")

                        If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Pausa" Then
                            t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _inicio = "inicio"
                        End If

                    Else
                        If id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB") And item_actual = dt_lista_ops.Rows(i).Item("ITEM") Then
                            If _inicio = "" Then
                                If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Pausa" Then
                                    t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                    _inicio = "inicio"
                                End If
                            Else
                                If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Reinicio" Then
                                    t_fin = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                    _fin = "fin"
                                End If
                            End If
                        Else
                            id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                            item_actual = dt_lista_ops.Rows(i).Item("ITEM")
                            _inicio = ""
                            _fin = ""
                        End If
                    End If

                    If _inicio <> "" And _fin <> "" Then
                        Dim resta3 As TimeSpan = t_fin - t_inicio
                        tiempo_transcurrido2 = tiempo_transcurrido2 + resta3
                        _inicio = ""
                        _fin = ""
                    End If
                Next

                tiempo_pausado = tiempo_transcurrido2
                tiempo_total = tiempo_total + tiempo_pausado
                Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO PAUSADO", tiempo_pausado.ToString, False, turno) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            End If

            _inicio = ""
            _fin = ""
            'OBTENEMOS EL TIEMPO PAUSADO POR EQUIPO AVERIADO Y/O MANTENIMIENTO DE EQUIPO
            dt_lista_ops = clsPedidoBl.get_Detalle_Parte_Diario_Tiempo_No_Productivo(equipo, fecha, turno)
            If dt_lista_ops.Rows.Count() > 0 Then
                Dim tiempo_transcurrido3 As TimeSpan
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    If i = 0 Then
                        id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                        item_actual = dt_lista_ops.Rows(i).Item("ITEM")

                        If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Pausa Equipo Averiado" Or dt_lista_ops.Rows(i).Item("CONCEPTO") = "Mantenimiento Equipo" Then
                            t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _inicio = "inicio"
                        End If
                    Else
                        If _inicio = "" Then
                            If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Pausa Equipo Averiado" Or dt_lista_ops.Rows(i).Item("CONCEPTO") = "Mantenimiento Equipo" Then
                                t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                _inicio = "inicio"
                            End If
                        Else
                            t_fin = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _fin = "fin"
                        End If
                    End If

                    If _inicio <> "" And _fin <> "" Then
                        Dim resta3 As TimeSpan = t_fin - t_inicio
                        tiempo_transcurrido3 = tiempo_transcurrido3 + resta3
                        _inicio = ""
                        _fin = ""
                    End If
                Next

                tiempo_pausado_ea = tiempo_transcurrido3
                tiempo_total = tiempo_total + tiempo_pausado_ea
                Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO EQUIPO AVERIADO/MANTENIMIENTO", tiempo_pausado_ea.ToString, False, turno) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            End If


            _inicio = ""
            _fin = ""
            'OBTENEMOS EL TIEMPO SIN TRABAJO
            dt_lista_ops = clsPedidoBl.get_Detalle_Parte_Diario_Tiempo_No_Productivo(equipo, fecha, turno)
            If dt_lista_ops.Rows.Count() > 0 Then
                Dim tiempo_transcurrido4 As TimeSpan
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    If i = 0 Then
                        id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                        item_actual = dt_lista_ops.Rows(i).Item("ITEM")

                        If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Sin Trabajo" Then
                            t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _inicio = "inicio"
                        End If
                    Else
                        If _inicio = "" Then
                            If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Sin Trabajo" Then
                                t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                _inicio = "inicio"
                            End If
                        Else
                            t_fin = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _fin = "fin"
                            'If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Sin Trabajo" Then
                            '    t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            '    _inicio = "inicio"
                            'End If
                        End If
                    End If

                    If _inicio <> "" And _fin <> "" Then
                        Dim resta3 As TimeSpan = t_fin - t_inicio
                        tiempo_transcurrido4 = tiempo_transcurrido4 + resta3
                        _inicio = ""
                        _fin = ""
                        If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Sin Trabajo" Then
                            t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _inicio = "inicio"
                        End If
                    End If
                Next

                tiempo_sin_trabajo = tiempo_transcurrido4
                tiempo_total = tiempo_total + tiempo_sin_trabajo
                Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO SIN TRABAJO", tiempo_sin_trabajo.ToString, False, turno) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            End If

            _inicio = ""
            _fin = ""
            'OBTENEMOS EL TIEMPO ACTIVIDAD NO PROGRAMADA
            dt_lista_ops = clsPedidoBl.get_Detalle_Parte_Diario_Tiempo_No_Productivo(equipo, fecha, turno)
            If dt_lista_ops.Rows.Count() > 0 Then
                Dim tiempo_transcurrido4 As TimeSpan
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    If i = 0 Then
                        id_cab_actual = dt_lista_ops.Rows(i).Item("ID_CAB")
                        item_actual = dt_lista_ops.Rows(i).Item("ITEM")

                        If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Actividad No Programada" Then
                            t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _inicio = "inicio"
                        End If
                    Else
                        If _inicio = "" Then
                            If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Actividad No Programada" Then
                                t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                                _inicio = "inicio"
                            End If
                        Else
                            t_fin = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _fin = "fin"
                            'If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Sin Trabajo" Then
                            '    t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            '    _inicio = "inicio"
                            'End If
                        End If
                    End If

                    If _inicio <> "" And _fin <> "" Then
                        Dim resta3 As TimeSpan = t_fin - t_inicio
                        tiempo_transcurrido4 = tiempo_transcurrido4 + resta3
                        _inicio = ""
                        _fin = ""
                        If dt_lista_ops.Rows(i).Item("CONCEPTO") = "Actividad No Programada" Then
                            t_inicio = TimeSpan.Parse(dt_lista_ops.Rows(i).Item("HORA"))
                            _inicio = "inicio"
                        End If
                    End If
                Next

                tiempo_act_no_programada = tiempo_transcurrido4
                tiempo_total = tiempo_total + tiempo_act_no_programada
                Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

                If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO ACT. NO PROGRAMADA", tiempo_act_no_programada.ToString, False, turno) = False Then
                    Me.Cursor = Cursors.Default
                    Return False
                Else
                    bandera = False
                End If
            End If

            If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, "TIEMPO TOTAL", tiempo_total.ToString, False, turno) = False Then
                Me.Cursor = Cursors.Default
                Return False
            Else
                bandera = False
            End If

            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Guarda_Tiempos_Parte_Diario(ByVal concepto As String, ByVal tiempo_transcurrido As Double, ByVal fecha As String, ByVal equipo As String, ByVal turno As String, ByVal flag_ As String)
        Try
            Dim horas As Double = 0
            Dim minutos As Double = 0
            Dim segundos As Double = 0
            Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

            horas = 0
            minutos = 0
            segundos = 0

            If tiempo_transcurrido < 60 Then
                horas = 0
                minutos = 0
                segundos = tiempo_transcurrido
            Else
                minutos = Math.Floor(tiempo_transcurrido / 60)
                If minutos < 60 Then
                    horas = 0
                    segundos = tiempo_transcurrido - (minutos * 60)
                Else
                    horas = Math.Floor(minutos / 60)
                    minutos = minutos - (horas * 60)
                    segundos = tiempo_transcurrido - (horas * 3600) - (minutos * 60)
                End If
            End If

            If clsPedidoBl.Guardar_Tiempo_Produccion_OPS(equipo, fecha, concepto, (Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")), flag_, turno) = False Then
                Me.Cursor = Cursors.Default
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Calcular_Tiempo_OP_No_Productivo_2(ByVal fecha As String, ByVal equipo As String, ByVal turno As String) As Boolean
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim _flag_final As Boolean = False
            Dim _flag_pausa As Boolean = False
            Dim _flag_inicio As Boolean = False
            Dim bandera As Boolean = True
            'Dim resta As Double
            t_ejecutado = ""

            Dim dt_lista_ops As DataTable
            Dim id_cab_actual As Integer = 0
            Dim item_actual As Integer = 0
            Dim item_pausa As Integer = 0
            Dim _inicio As String = ""
            Dim _id_op As Integer = 0
            Dim _fin As String = ""
            Dim t_inicio_ As Date
            Dim t_fin_ As Date

            Dim tiempo_no_productivo As Double = 0 'TimeSpan
            Dim tiempo_pausado As Double = 0 'TimeSpan
            Dim tiempo_pausado_falla_en_equipo As Double = 0 'TimeSpan
            Dim tiempo_puesta_punto As Double = 0 'TimeSpan
            Dim tiempo_pausado_mantenimiento_de_equipo As Double = 0 'TimeSpan
            Dim tiempo_pausado_almuerzo As Double = 0 'TimeSpan
            Dim tiempo_pausado_ea As Double = 0 'TimeSpan
            Dim tiempo_sin_trabajo As Double = 0 'TimeSpan
            Dim tiempo_sin_trabajo_almuerzo As Double = 0 'TimeSpan
            Dim tiempo_act_no_programada As Double = 0 'TimeSpan
            Dim tiempo_transcurrido As Double = 0 'TimeSpan
            Dim tiempo_productivo As Double = 0 'TimeSpan
            Dim tiempo_transcurrido_prensa As Double = 0
            Dim tiempo_transcurrido_pre_prensa As Double = 0
            Dim tiempo_transcurrido_logistica As Double = 0
            Dim tiempo_transcurrido_mantenimiento_701 As Double = 0
            Dim tiempo_transcurrido_mantenimiento_702 As Double = 0
            Dim tiempo_transcurrido_pcp As Double = 0
            Dim tiempo_transcurrido_otros As Double = 0

            Dim concepto As String = ""
            Dim motivo_pausa As String = ""
            Dim cod_motivo_pausa As String = ""
            Dim horas As Double = 0
            Dim minutos As Double = 0
            Dim segundos As Double = 0
            tiempo_total_ = 0
            tiempo_total_improductivo_ = 0
            '***************INICIO*********************
            dt_lista_ops = clsPedidoBl.get_Detalle_Parte_Diario_Tiempo_No_Productivo(equipo, fecha, turno)
            If dt_lista_ops.Rows.Count() > 0 Then
                For i As Integer = 0 To dt_lista_ops.Rows.Count - 1
                    If i = 0 And dt_lista_ops.Rows(i).Item("CONCEPTO") = "Inicio Turno" Then
                        t_inicio_ = dt_lista_ops.Rows(i).Item("FECHA_REAL")
                        _inicio = "inicio"
                        concepto = dt_lista_ops.Rows(i).Item("CONCEPTO")
                        motivo_pausa = dt_lista_ops.Rows(i).Item("GRUPO_PAUSA")
                        cod_motivo_pausa = dt_lista_ops.Rows(i).Item("MOTIVO_PAUSA")
                    Else
                        t_fin_ = dt_lista_ops.Rows(i).Item("FECHA_REAL")
                        _fin = "fin"

                        If _inicio <> "" And _fin <> "" Then
                            Dim resta3 As Double = DateDiff(DateInterval.Second, CDate(t_inicio_), CDate(t_fin_))
                            If concepto = "Inicio Turno" Or concepto = "Sin Trabajo" Or concepto = "Final" Then
                                tiempo_no_productivo = tiempo_no_productivo + resta3
                            ElseIf concepto = "Actividad No Programada" Then
                                tiempo_act_no_programada = tiempo_act_no_programada + resta3
                            ElseIf concepto = "Inicio Preparación de Equipo" Then
                                tiempo_puesta_punto = tiempo_puesta_punto + resta3
                            ElseIf concepto = "Inicio Producción" Or concepto = "Reinicio" Then
                                tiempo_productivo = tiempo_productivo + resta3
                            ElseIf concepto = "Pausa" Then
                                If motivo_pausa = "PRENSA" Then
                                    tiempo_transcurrido_prensa = tiempo_transcurrido_prensa + resta3
                                ElseIf motivo_pausa = "PRE PRENSA" Then
                                    tiempo_transcurrido_pre_prensa = tiempo_transcurrido_pre_prensa + resta3
                                ElseIf motivo_pausa = "LOGISTICA" Then
                                    tiempo_transcurrido_logistica = tiempo_transcurrido_logistica + resta3
                                ElseIf motivo_pausa = "MANTENIMIENTO" And cod_motivo_pausa = "701" Then
                                    tiempo_transcurrido_mantenimiento_701 = tiempo_transcurrido_mantenimiento_701 + resta3
                                ElseIf motivo_pausa = "MANTENIMIENTO" And (cod_motivo_pausa = "702" Or cod_motivo_pausa = "703") Then
                                    tiempo_transcurrido_mantenimiento_702 = tiempo_transcurrido_mantenimiento_702 + resta3
                                ElseIf motivo_pausa = "PCP" Then
                                    tiempo_transcurrido_pcp = tiempo_transcurrido_pcp + resta3
                                ElseIf motivo_pausa = "OTROS" Then
                                    tiempo_transcurrido_otros = tiempo_transcurrido_otros + resta3
                                End If
                            End If

                            _inicio = ""
                            _fin = ""
                        End If

                        t_inicio_ = dt_lista_ops.Rows(i).Item("FECHA_REAL")
                        _inicio = "inicio"
                        concepto = dt_lista_ops.Rows(i).Item("CONCEPTO")
                        motivo_pausa = dt_lista_ops.Rows(i).Item("GRUPO_PAUSA")
                        cod_motivo_pausa = dt_lista_ops.Rows(i).Item("MOTIVO_PAUSA")
                    End If
                Next
                Guarda_Tiempos_Parte_Diario("TIEMPO PRODUCTIVO", tiempo_productivo, fecha, equipo, turno, True)
                Guarda_Tiempos_Parte_Diario("TIEMPO NO PRODUCTIVO", tiempo_no_productivo, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("TIEMPO PUESTA A PUNTO", tiempo_puesta_punto, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("PRENSA (Centro Improductivo)", tiempo_transcurrido_prensa, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("PRE PRENSA (Centro Improductivo)", tiempo_transcurrido_pre_prensa, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("LOGISTICA (Centro Improductivo)", tiempo_transcurrido_logistica, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("MANTENIMIENTO PREVENTIVO", tiempo_transcurrido_mantenimiento_701, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("MANTENIMIENTO (Centro Improductivo)", tiempo_transcurrido_mantenimiento_702, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("PCP (Centro Improductivo)", tiempo_transcurrido_pcp, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("OTROS (Centro Improductivo)", tiempo_transcurrido_otros, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("TIEMPO ACT. NO PROGRAMADA", tiempo_act_no_programada, fecha, equipo, turno, False)

                tiempo_total_ = tiempo_productivo + tiempo_no_productivo + tiempo_puesta_punto + tiempo_transcurrido_prensa + tiempo_transcurrido_pre_prensa +
                    tiempo_transcurrido_logistica + tiempo_transcurrido_mantenimiento_701 + tiempo_transcurrido_mantenimiento_702 + tiempo_transcurrido_pcp +
                    tiempo_transcurrido_otros + tiempo_act_no_programada

                tiempo_total_improductivo_ = tiempo_no_productivo + tiempo_transcurrido_prensa + tiempo_transcurrido_pre_prensa +
                    tiempo_transcurrido_logistica + tiempo_transcurrido_mantenimiento_702 + tiempo_transcurrido_pcp +
                    tiempo_transcurrido_otros + tiempo_act_no_programada

                Guarda_Tiempos_Parte_Diario("TIEMPO TOTAL", tiempo_total_, fecha, equipo, turno, False)
                Guarda_Tiempos_Parte_Diario("TIEMPO TOTAL IMPRODUCTIVO", tiempo_total_improductivo_, fecha, equipo, turno, False)
            End If
            '*************** FIN  *********************


            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_inoperatividad.Click
        If TextBox6.Text = "" Then
            MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cbo_turno.SelectedIndex = -1 Then
            MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'If TextBox6.Text <> "15" And TextBox6.Text <> "20" And TextBox6.Text <> "35" And TextBox6.Text <> "13" And TextBox6.Text <> "25" And TextBox6.Text <> "6" And TextBox6.Text <> "37" Then
        '    MsgBox("El equipo elegido no forma parte de la Producción. Verifique!!!", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        Dim dt_detalle As DataTable

        dt_detalle = clsPedidoBl.get_Verificar_OP_operando(TextBox6.Text.Trim, dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"))
        If dt_detalle.Rows.Count() <> 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe PAUSAR/TERMINAR la O.P., para registrar la INOPERATIVIDAD.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        Dim frm As New Frm_OP_Planta_No_Actividad
        frm.usuario = txt_usuario.Text.Trim
        frm.maquina = TextBox6.Text.Trim
        frm.fecha = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
        frm.equipo = Strings.UCase(TextBox5.Text.Trim)
        frm.turno = cbo_turno.Text
        frm.ShowDialog()
    End Sub

    Private Sub btn_fin_turno_Click(sender As Object, e As EventArgs) Handles btn_fin_turno.Click
        Try
            If TextBox6.Text = "" Then
                MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cbo_turno.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'If TextBox6.Text <> "15" And TextBox6.Text <> "20" And TextBox6.Text <> "35" And TextBox6.Text <> "13" And TextBox6.Text <> "25" And TextBox6.Text <> "6" And TextBox6.Text <> "37" Then
            '    MsgBox("El equipo elegido no forma parte de la Producción. Verifique!!!", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If

            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Me.Cursor = Cursors.WaitCursor
            Dim dt_detalle As DataTable

            dt_tipo_maquina = clsPedidoBl.get_Tipo_Maquina(TextBox6.Text.Trim)
            If dt_tipo_maquina.Rows.Count > 0 Then
                _tipo_maquina = dt_tipo_maquina.Rows(0).Item("TIPO").ToString
            Else
                _tipo_maquina = ""
            End If

            dt_detalle = clsPedidoBl.get_Verificar_OP_operando(TextBox6.Text.Trim, dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"))
            If dt_detalle.Rows.Count() <> 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe TERMINAR la O.P., para FINALIZAR el Turno.", MsgBoxStyle.Exclamation, "Sistemas")
                Exit Sub
            End If

            Dim dt_valida_fin_turno As DataTable
            dt_valida_fin_turno = clsPedidoBl.get_Parte_Produccion_Produccion_Programada_Verificar_Turno(TextBox6.Text.Trim, _
                                                                                                      dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                      "Fin Turno", cbo_turno.Text)
            If dt_valida_fin_turno.Rows.Count > 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("Esta registrado el Fin de Turno para el Equipo, Turno y Fecha elegida.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                If MsgBox("Esta seguro de Finalizar el " & cbo_turno.Text & " de la fecha " & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy") & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                    If Agregar_HP_Iniciar_Terminar_Turno("Fin Turno", cbo_turno.Text) Then
                        'If _tipo_maquina = "2" Or _tipo_maquina = "3" Or _tipo_maquina = "4" Then
                        '    Graba_Parte_Produccion_BI()
                        'End If
                        btn_parte_maquina.Visible = False 'True
                        btn_inoperatividad.Visible = False
                        btn_act_no_programadas.Visible = False
                        btn_preparacion_especial.Visible = False
                        btn_fin_turno.Visible = False
                        btn_iniciar_turno.Visible = False
                        _fin_turno = True
                    Else
                        btn_parte_maquina.Visible = False
                        btn_inoperatividad.Visible = False 'True
                        btn_act_no_programadas.Visible = False 'True
                        btn_preparacion_especial.Visible = False ' True
                        btn_fin_turno.Visible = True
                        btn_iniciar_turno.Visible = False
                        _fin_turno = False
                    End If
                    Me.Cursor = Cursors.Default
                Else
                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Graba_Parte_Produccion_BI()
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            crystalBL = New LibReportes.ClsReporte

            Dim dt_detalle_produccion_programada As DataSet
            tiempo_total_ = 0

            If Calcular_Tiempo_OP_No_Productivo_2(dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), TextBox6.Text.Trim, cbo_turno.Text) = False Then
                Exit Sub
            End If

            dt_detalle_produccion_programada = clsPedidoBl.get_Mantenimiento_Produccion_Programada_Parte_Diario_Nuevo_Otro(TextBox6.Text.Trim, _
                                                                                                   dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                   dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                   cbo_turno.Text)
            If dt_detalle_produccion_programada.Tables(0).Rows.Count() <> 0 Then
                dgvDetalle1.DataSource = dt_detalle_produccion_programada.Tables(1)

                clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
                Det_Informes_Mantenimiento = New ClsEntidades.PARTE_PRODUCCION
                Dim MantenimientoOP_Lista As New List(Of ClsEntidades.PARTE_PRODUCCION)

                For i As Integer = 0 To dgvDetalle1.Rows.Count - 1
                    Det_Informes_Mantenimiento = New ClsEntidades.PARTE_PRODUCCION
                    With Det_Informes_Mantenimiento
                        .MAQUINA_COD = TextBox6.Text
                        .TURNO_COD = cbo_turno.Text
                        .FECHA = dgvDetalle1.Rows(i).Cells("FECHA").Value
                        .MAQUINA = dgvDetalle1.Rows(i).Cells("MAQUINA").Value
                        .HORARIO = dgvDetalle1.Rows(i).Cells("HORARIO").Value
                        .TURNO = dgvDetalle1.Rows(i).Cells("TURNO").Value
                        .SUPERVISOR = dgvDetalle1.Rows(i).Cells("SUPERVISOR").Value
                        .MAQUINISTA = dgvDetalle1.Rows(i).Cells("MAQUINISTA").Value
                        .AYUDANTE = dgvDetalle1.Rows(i).Cells("AYUDANTE").Value

                        .HORAS_FIJAS = dgvDetalle1.Rows(i).Cells("HORAS_FIJAS").Value
                        .HORAS_EXTRAS = dgvDetalle1.Rows(i).Cells("HORAS_EXTRAS").Value
                        .HORAS_PROGRAMADAS = dgvDetalle1.Rows(i).Cells("HORAS_PROGRAMADAS").Value
                        .HORAS_TRABAJADAS = dgvDetalle1.Rows(i).Cells("HORAS_COTIZADAS").Value
                        .HORAS_PRODUCTIVAS = dgvDetalle1.Rows(i).Cells("HORAS_PRODUCTIVAS").Value
                        .MANTENIMIENTO_PREVENTIVO = dgvDetalle1.Rows(i).Cells("MANTENIMIENTO_PREVENTIVO").Value
                        .VELOCIDAD_TEORICA = dgvDetalle1.Rows(i).Cells("VELOCIDAD_TEORICA").Value
                        .VELOCIDAD_REAL = dgvDetalle1.Rows(i).Cells("VELOCIDAD_REAL").Value
                        .PRODUCTIVIDAD = dgvDetalle1.Rows(i).Cells("PRODUCTIVIDAD").Value
                        .RESULTADOS = dgvDetalle1.Rows(i).Cells("RESULTADOS").Value
                        .REFRIGERIO = dgvDetalle1.Rows(i).Cells("REFRIGERIO").Value
                        .PLIEGOS_PRODUCIDOS = dgvDetalle1.Rows(i).Cells("PLIEGOS_PRODUCIDOS").Value


                        .AREA_IMPRODUCTIVA = dgvDetalle1.Rows(i).Cells("AREA_IMPRODUCTIVA").Value
                        .OBSERVACIONES = dgvDetalle1.Rows(i).Cells("OBSERVACIONES").Value
                        .TIEMPO_INVERTIDO = dgvDetalle1.Rows(i).Cells("TIEMPO_INVERTIDO").Value
                        .PORCENTAJE = dgvDetalle1.Rows(i).Cells("%_PORCENTAJE").Value
                        .CODIGO = dgvDetalle1.Rows(i).Cells("CODIGO").Value
                        .OBS = dgvDetalle1.Rows(i).Cells("OBS").Value
                        .USER_ID = LibComunVar.ClsVarComun.USUARIO
                        .PC_ID = Environment.MachineName

                        .HORAS_PROGRAMADAS_ISOGRAF = dgvDetalle1.Rows(i).Cells("HORAS_PROGRAMADAS_ISOGRAF").Value
                        .PLIEGOS_PROGRAMADAS_ISOGRAF = dgvDetalle1.Rows(i).Cells("PLIEGOS_PROGRAMADOS_ISOGRAF").Value
                        .PLIEGOS_BUENOS = dgvDetalle1.Rows(i).Cells("PLIEGOS_BUENOS").Value
                        .PLIEGOS_MALOS = dgvDetalle1.Rows(i).Cells("PLIEGOS_MALOS").Value
                    End With
                    MantenimientoOP_Lista.Add(Det_Informes_Mantenimiento)
                Next

                If clsPedidoBl.Guardar_Parte_Produccion_BI(MantenimientoOP_Lista, dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), cbo_turno.Text, TextBox6.Text) Then
                    'MsgBox("Proceso Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
                    dgvDetalle1.DataSource = Nothing
                End If

            Else
                'MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Agregar_HP_Iniciar_Terminar_Turno(ByVal _OPCION_TURNO As String, ByVal _TURNO As String, Optional ByVal _AYUDANTE As String = "",
                                                        Optional ByVal _SUPERVISOR As String = "",
                                                        Optional ByVal _HORAS_PROG_ISOGRAF As Double = 0, Optional ByVal _PLIEGOS_PROG_ISOGRAF As Double = 0) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Pedido_Det_HP = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL

            With Pedido_Det_HP
                .USER_ID = txt_usuario.Text.Trim
                .FECHA = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
                .ITEM = 0
                .DESCRIPCION = ""
                .NUMERO_OP = _OPCION_TURNO
                .EQUIPO_COD = TextBox6.Text.Trim
                .USER_ID_REGISTRO = LibComunVar.ClsVarComun.USUARIO
                .PC_ID_REGISTRO = Environment.MachineName
                .TURNO = _TURNO
                .FECHA_TURNO = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
                .AYUDANTE = _AYUDANTE
                .SUPERVISOR = _SUPERVISOR
                .HORAS_PROGRAMADAS_ISOGRAF = _HORAS_PROG_ISOGRAF
                .PLIEGOS_PROGRAMADAS_ISOGRAF = _PLIEGOS_PROG_ISOGRAF
            End With

            articuloPA = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL
            Dim ls_det_pa As New List(Of ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL)

            For i As Integer = 0 To dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count() - 1
                articuloPA = New ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL
                With articuloPA
                    .USER_ID = txt_usuario.Text.Trim
                    .EQUIPO_COD = TextBox6.Text.Trim
                    .USER_ID_REGISTRO = LibComunVar.ClsVarComun.USUARIO
                    .PC_ID_REGISTRO = Environment.MachineName
                    .TURNO = "" '_TURNO
                    .FECHA_TURNO = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
                    .HORAS_PROGRAMADAS_ISOGRAF = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows(i).Item("ITEM")
                    .AYUDANTE = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows(i).Item("CODIGO").ToString
                    .SUPERVISOR = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows(i).Item("DESCRIPCION").ToString
                    .NUMERO_OP = txt_cod_area.Text
                End With
                ls_det_pa.Add(articuloPA)
            Next


            If clsPedidoBl.Guardar_Parte_Produccion_Historial_Personal_Sin_Trabajo(Pedido_Det_HP, ls_det_pa) = False Then
                MsgBox("Registro de Ayudantes no se registro.", MsgBoxStyle.Critical, "Sistemas")
                Me.Cursor = Cursors.Default
                Return False
            Else
                MsgBox("Registro de Ayudantes exitoso.", MsgBoxStyle.Information, "Sistemas")
                Me.Cursor = Cursors.Default
                Return True
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btn_iniciar_turno_Click(sender As Object, e As EventArgs) Handles btn_iniciar_turno.Click
        Try
            If TextBox6.Text = "" Then
                MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cbo_turno.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'If TextBox6.Text <> "15" And TextBox6.Text <> "20" And TextBox6.Text <> "35" And TextBox6.Text <> "13" And TextBox6.Text <> "25" And TextBox6.Text <> "6" And TextBox6.Text <> "37" Then
            '    MsgBox("El equipo elegido no forma parte de la Producción. Verifique!!!", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If
            Dim dt_valida_inicio_turno As DataTable
            Dim ayudante As String = ""
            Dim supervisor As String = ""
            Dim _numero As Single = 0

            Me.Cursor = Cursors.WaitCursor
            dt_valida_inicio_turno = clsPedidoBl.get_Parte_Produccion_Produccion_Programada_Verificar_Turno_Finalizado(TextBox6.Text.Trim, _
                                                                                                      dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                      "Inicio Turno", cbo_turno.Text)
            _numero = dt_valida_inicio_turno.Rows.Count
            If dt_valida_inicio_turno.Rows.Count > 0 And _numero Mod 2 <> 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("Existe un turno anterior sin Finalizar. Verifique!!!", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                dt_valida_inicio_turno = clsPedidoBl.get_Parte_Produccion_Produccion_Programada_Verificar_Turno(TextBox6.Text.Trim, _
                                                                                                      dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                      "Inicio Turno", cbo_turno.Text)
                If dt_valida_inicio_turno.Rows.Count > 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Esta registrado el Inicio de Turno para el Equipo, Turno y Fecha elegida.", MsgBoxStyle.Exclamation)
                    Exit Sub
                Else
                    If MsgBox("Esta seguro de Iniciar el " & cbo_turno.Text & " de la fecha " & dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy") & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
                        Me.Cursor = Cursors.Default
                        txt_cod_supervisor.Text = ""
                        txt_des_supervisor.Text = ""
                        txt_cod_ayudante.Text = ""
                        txt_des_ayudante.Text = ""
                        pnl_actualiza_datos.Visible = True
                        pnl_actualiza_datos.BringToFront()
                        txt_cod_supervisor.Focus()

                        'ayudante = String.Empty
                        'ayudante = InputBox("Introduzca el Nombre del Ayudante.", "Nombre de Ayudante")
                        'If ayudante = "" Then
                        '    Me.Cursor = Cursors.Default
                        '    MsgBox("Debe ingresar el nombre del Ayudante.!!!", MsgBoxStyle.Exclamation, "Sistemas")
                        '    Exit Sub
                        'End If
                        'supervisor = String.Empty
                        'supervisor = InputBox("Introduzca el Nombre del Supervisor.", "Nombre de Supervisor")
                        'If supervisor = "" Then
                        '    Me.Cursor = Cursors.Default
                        '    MsgBox("Debe ingresar el nombre del Supervisor.!!!", MsgBoxStyle.Exclamation, "Sistemas")
                        '    Exit Sub
                        'End If
                        'If Agregar_HP_Iniciar_Terminar_Turno("Inicio Turno", cbo_turno.Text, ayudante, supervisor) Then
                        '    Button36_Click(sender, e)
                        '    Me.Cursor = Cursors.Default
                        '    btn_iniciar_turno.Visible = False
                        '    btn_fin_turno.Visible = True
                        '    btn_inoperatividad.Visible = True
                        '    btn_act_no_programadas.Visible = True
                        '    btn_parte_maquina.Visible = True
                        'Else
                        '    Me.Cursor = Cursors.Default
                        '    btn_iniciar_turno.Visible = True
                        '    btn_fin_turno.Visible = False
                        '    btn_inoperatividad.Visible = False
                        '    btn_act_no_programadas.Visible = False
                        'End If
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_turno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_turno.SelectedIndexChanged
        dgv_produccion_programada2.DataSource = Nothing
        btn_act_no_programadas.Visible = False
        btn_parte_maquina.Visible = False
        btn_inoperatividad.Visible = False
    End Sub

    Private Sub cbo_turno_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_turno.KeyDown
        If e.KeyCode = Keys.Enter Then Button36.Focus() 'Button36_Click(sender, e)
    End Sub

    Private Sub btn_act_no_programadas_Click(sender As Object, e As EventArgs) Handles btn_act_no_programadas.Click
        If TextBox6.Text = "" Then
            MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cbo_turno.SelectedIndex = -1 Then
            MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'If TextBox6.Text <> "15" And TextBox6.Text <> "20" And TextBox6.Text <> "35" And TextBox6.Text <> "13" And TextBox6.Text <> "25" And TextBox6.Text <> "6" And TextBox6.Text <> "37" Then
        '    MsgBox("El equipo elegido no forma parte de la Producción. Verifique!!!", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        Dim dt_detalle As DataTable

        dt_detalle = clsPedidoBl.get_Verificar_OP_operando(TextBox6.Text.Trim, dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"))
        If dt_detalle.Rows.Count() <> 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe PAUSAR/TERMINAR la O.P., para registrar la ACTIVIDAD NO PROGRAMADA.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        Dim frm As New Frm_OP_Planta_Act_No_Programada
        frm.usuario = txt_usuario.Text.Trim
        frm.maquina = TextBox6.Text.Trim
        frm.fecha = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
        frm.equipo = Strings.UCase(TextBox5.Text.Trim)
        frm.turno = cbo_turno.Text
        frm.ShowDialog()
    End Sub



    Private Sub txt_buenos_pausa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_buenos_pausa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_malos_pausa.Focus()
        End If
    End Sub

    Private Sub txt_malos_pausa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_malos_pausa.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_motivo_pausa.Focus()
        End If
    End Sub

    Private Sub cbo_motivo_pausa_Leave(sender As Object, e As EventArgs) Handles cbo_motivo_pausa.Leave
        'If cbo_motivo_pausa.SelectedValue = "01" Or cbo_motivo_pausa.SelectedValue = "05" Then
        '    txt_buenos_pausa.ReadOnly = False
        '    txt_malos_pausa.ReadOnly = False
        '    txt_buenos_pausa.BackColor = Color.Aquamarine
        '    txt_malos_pausa.BackColor = Color.Aquamarine
        '    txt_buenos_pausa.Focus()
        'Else
        '    txt_buenos_pausa.ReadOnly = True
        '    txt_malos_pausa.ReadOnly = True
        '    txt_buenos_pausa.BackColor = Color.Red
        '    txt_malos_pausa.BackColor = Color.Red
        '    txt_buenos_pausa.Focus()
        'End If
        txt_buenos_pausa.ReadOnly = False
        txt_malos_pausa.ReadOnly = False
        txt_buenos_pausa.BackColor = Color.Aquamarine
        txt_malos_pausa.BackColor = Color.Aquamarine
        txt_buenos_pausa.Focus()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btn_grafico_x_op.Click
        Try
            clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            Dim data_ops As DataTable
            Me.Cursor = Cursors.WaitCursor
            Dim _id_cab As Integer = 0
            Dim _item As Integer = 0

            data_ops = clsPedidoBl.get_Parte_Produccion_Detalle_Ops(TextBox6.Text.Trim, dtp_fecha_produccion_programada.Value.Year, dtp_fecha_produccion_programada.Value.Month)
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = data_ops.Rows.Count()
            If data_ops.Rows.Count > 0 Then
                gbopciones.Visible = True
                For i As Integer = 0 To data_ops.Rows.Count - 1
                    ProgressBar1.Value = i
                    Call Detalle_Actividad_Op_Grafico(TextBox6.Text.Trim, data_ops.Rows(i).Item("ID_CAB"), data_ops.Rows(i).Item("ITEM"))
                    ProgressBar1.PerformStep()
                Next
                ProgressBar1.Value = 0
                MsgBox("Proceso Finalizado correctamente", MsgBoxStyle.Information)
                gbopciones.Visible = False
            Else
                gbopciones.Visible = False
                MsgBox("No existe información a procesar.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            gbopciones.Visible = False
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_aceptar_proc_Click(sender As Object, e As EventArgs) Handles btn_aceptar_proc.Click
        If cbo_proceso_preparacion.SelectedIndex = -1 Then
            MsgBox("Debe elegir un proceso" & Chr(13) & "para el INICIO DE PRODUCCION.", MsgBoxStyle.Exclamation, "Sistemas")
            cbo_proceso_preparacion.Focus()
            Exit Sub
        End If

        'If op_operando = True Then
        '    MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe TERMINAR la O.P., para iniciar otro.", MsgBoxStyle.Exclamation, "Sistemas")
        '    Exit Sub
        'End If
        'If MsgBox("Desea registrar el proceso elegido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
        'pb_inicio_prepar.Cursor = Cursors.No
        Timer1.Start()
        _activa_timer = False
        Try
            Dim row As DataRow = dtdetalle.NewRow

            For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
                _ULTIMO_ITEM = row2("ITEM")
                Exit For
            Next

            row("ITEM") = _ULTIMO_ITEM + 1
            _item = row("ITEM")
            row("FECHA") = Date.Now.ToString("dd/MM/yyyy")
            row("HORA") = Date.Now.ToString("HH:mm:ss")
            'row("CONCEPTO") = "Inicio Preparación de Equipo"
            't_inicio = TimeSpan.Parse(row("HORA"))
            'lst_historial.Items.Add("Fecha y Hora Inicio Producción : ")
            'ListBox1.Items.Add(t_inicio.ToString)

            row("OBSERVACIONES") = txt_obs_inicio.Text
            row("MOTIVO_PAUSA") = cbo_proceso_preparacion.SelectedValue
            row("PLIEGOS_BUENOS") = 0
            row("PLIEGOS_MALOS") = ""
            row("PROCESO_INICIO_PREPARACION") = cbo_proceso_preparacion.Text

            If lbl_inicio.Text = "INICIO" Then
                row("CONCEPTO") = "Inicio Producción"
                t_inicio = TimeSpan.Parse(row("HORA"))
                lst_historial.Items.Add("Fecha y Hora de Inicio Producción: ")
                ListBox1.Items.Add(t_inicio.ToString)
                Timer1.Start()
            ElseIf lbl_inicio.Text = "REINICIAR" Or lbl_inicio.Text = "REINICIAR PRODUCCION" Then
                Timer1.Start()
                row("CONCEPTO") = "Reinicio"
            End If

            dtdetalle.Rows.Add(row)
            dtdetalle.AcceptChanges()

            dgv_detalle_historial.DataSource = dtdetalle
            Formato_Grilla_Detalle_Op()
            Call CalcularTotales_Cantidad()
            lbl_inicio.Text = "FIN"
            pb_inicio.Cursor = Cursors.Default
            pb_pausa.Cursor = Cursors.Default
            pb_fin.Cursor = Cursors.Default
            pb_pausa_equipo.Cursor = Cursors.Default
            pb_inicio_prepar.Cursor = Cursors.Default

            pb_inicio_prepar_des.Visible = False
            pb_inicio_des.Visible = False
            'pb_pausa_equipo_des.Visible = False
            'pb_pausa_des.Visible = False
            pb_fin_des.Visible = False

            pnl_proceso_inicio_preparacion.Visible = False
            pb_inicio_prepar.Cursor = Cursors.Default
            Button1.Enabled = True
            pb_fin_des.Visible = True

            Me.Cursor = Cursors.WaitCursor
            Call Guardar_Parte_Produccion("OPERANDO")
            'Call Agregar_HP_Dos(0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
        'End If

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        pnl_proceso_inicio_preparacion.Visible = False

        pb_inicio_prepar.Cursor = Cursors.Default

        Button1.Enabled = True
        If _activa_timer = False Then
            Timer1.Start()
        End If

    End Sub

    Private Sub btn_preparacion_especial_Click(sender As Object, e As EventArgs) Handles btn_preparacion_especial.Click
        If TextBox6.Text = "" Then
            MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cbo_turno.SelectedIndex = -1 Then
            MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim dt_detalle As DataTable

        dt_detalle = clsPedidoBl.get_Verificar_OP_operando(TextBox6.Text.Trim, dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"))
        If dt_detalle.Rows.Count() <> 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe PAUSAR/TERMINAR la O.P., para registrar la INOPERATIVIDAD.", MsgBoxStyle.Exclamation, "Sistemas")
            Exit Sub
        End If

        Dim frm As New Frm_OP_Planta_Preparacion_Especial_Equipo
        frm.usuario = txt_usuario.Text.Trim
        frm.maquina = TextBox6.Text.Trim
        frm.fecha = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
        frm.equipo = Strings.UCase(TextBox5.Text.Trim)
        frm.turno = cbo_turno.Text
        frm.ShowDialog()
    End Sub

    Private Sub btn_aceptar_pausa_falla_equipo_Click(sender As Object, e As EventArgs) Handles btn_aceptar_pausa_falla_equipo.Click
        Try
            If cbo_motivo_pausa_falla_equipo.SelectedIndex = -1 Then
                MsgBox("Debe elegir un Motivo de Pausa.", MsgBoxStyle.Exclamation, "Sistemas")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            pnl_pausa_falla_equipo.Visible = False
            Dim row As DataRow = dtdetalle.NewRow

            For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
                _ULTIMO_ITEM = row2("ITEM")
                Exit For
            Next

            row("ITEM") = _ULTIMO_ITEM + 1
            _item = row("ITEM")
            If tipo_pausa = "PAUSA EXTRA" Then
                row("CONCEPTO") = "Pausa"
            ElseIf tipo_pausa = "PAUSA EQUIPO" Then
                row("CONCEPTO") = "Pausa Falla en Equipo"
            End If
            row("FECHA") = fecha_pausa
            row("HORA") = hora_pausa
            row("OBSERVACIONES") = txt_motivo_pausa_falla_equipo.Text.Trim
            row("MOTIVO_PAUSA") = "03"
            row("PLIEGOS_BUENOS") = 0
            row("PLIEGOS_MALOS") = ""

            dtdetalle.Rows.Add(row)
            dtdetalle.AcceptChanges()

            dgv_detalle_historial.DataSource = dtdetalle
            Formato_Grilla_Detalle_Op()
            Call CalcularTotales_Cantidad()
            pb_inicio.Enabled = True
            pb_pausa.Enabled = True
            pb_fin.Enabled = True
            'pb_pausa_equipo.Enabled = True
            pb_inicio_prepar.Enabled = True
            Label6.Text = "REINICIAR PRODUCCION"
            pb_inicio.Cursor = Cursors.Default
            pb_pausa.Cursor = Cursors.No
            pb_fin.Cursor = Cursors.No
            pb_pausa_equipo.Cursor = Cursors.No
            pb_inicio_prepar.Cursor = Cursors.Default

            If Guardar_Parte_Produccion("PAUSADO") Then
                Dim DT_DATOS_ENVIO_EMAIL As DataTable
                DT_DATOS_ENVIO_EMAIL = clsPedidoBl.GET_DEVOLVER_DATOS_ENVIO_EMAIL("08")

                If DT_DATOS_ENVIO_EMAIL.Rows.Count() <> 0 Then
                    _REMITENTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTFROM").ToString
                    _RECEPCIONANTE = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTTO").ToString
                    _SERVER = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSERVER").ToString
                    _USUARIO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTUSERNAME").ToString
                    _PASSWORD = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTPASSWORD").ToString
                    _ASUNTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTSUBJECT").ToString
                    _TITULO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("REMITENTE").ToString
                    _PUERTO = DT_DATOS_ENVIO_EMAIL.Rows(0).Item("TXTMSG").ToString
                End If

                _mensaje = "Se registro Falla en Equipo: " & vbCrLf & vbCrLf

                _mensaje = _mensaje & vbTab & " - N° O.P. : " & dgv_produccion_programada2.CurrentRow.Cells("Num.O.P.").Value & vbCrLf
                _mensaje = _mensaje & vbTab & " - CLIENTE : " & dgv_produccion_programada2.CurrentRow.Cells("Cliente").Value & vbCrLf
                _mensaje = _mensaje & vbTab & " - PRODUCTO : " & dgv_produccion_programada2.CurrentRow.Cells("Producto").Value & vbCrLf
                _mensaje = _mensaje & vbTab & " - CANTIDAD : " & dgv_produccion_programada2.CurrentRow.Cells("Tiraje").Value & vbCrLf
                _mensaje = _mensaje & vbTab & " - MAQUINA : " & TextBox6.Text.Trim & " - " & Strings.UCase(TextBox5.Text.Trim) & vbCrLf
                _mensaje = _mensaje & vbTab & " - OBSERVACIONES : " & txt_motivo_pausa_falla_equipo.Text.Trim & vbCrLf


                'Try
                '    Dim mensajes As New Net.Mail.MailMessage(_REMITENTE, _RECEPCIONANTE, _ASUNTO, _mensaje)
                '    Dim smpt As New Net.Mail.SmtpClient(_SERVER, _PUERTO)
                '    Dim acceso As New Net.NetworkCredential(_USUARIO, _PASSWORD)
                '    smpt.EnableSsl = True
                '    smpt.Credentials = acceso
                '    smpt.Port = _PUERTO
                '    smpt.Host = _SERVER

                '    smpt.Send(mensajes)
                '    'MsgBox("Mensaje enviado correctamente", MsgBoxStyle.Information, "Aviso")

                'Catch ex As Exception
                '    Me.Cursor = Cursors.Default
                '    MsgBox(ex.Message)
                'End Try
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        pnl_proceso_produccion.Visible = False

        pb_inicio.Cursor = Cursors.Default

        Button1.Enabled = True
        If _activa_timer = False Then
            Timer1.Start()
        End If
    End Sub

    Private Sub btn_aceptar_produccion_Click(sender As Object, e As EventArgs) Handles btn_aceptar_produccion.Click
        If cbo_produccion.SelectedIndex = -1 Then
            MsgBox("Debe elegir un proceso" & Chr(13) & "para la PRODUCCION DEL EQUIPO.", MsgBoxStyle.Exclamation, "Sistemas")
            cbo_produccion.Focus()
            Exit Sub
        End If

        'If op_operando = True Then
        '    MsgBox("Existe alguna O.P. con estado OPERANDO" & Chr(13) & "debe TERMINAR la O.P., para iniciar otro.", MsgBoxStyle.Exclamation, "Sistemas")
        '    Exit Sub
        'End If
        'If MsgBox("Desea registrar el proceso elegido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
        'pb_inicio_prepar.Cursor = Cursors.No
        Timer1.Start()
        _activa_timer = False
        Try
            Dim row As DataRow = dtdetalle.NewRow

            For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
                _ULTIMO_ITEM = row2("ITEM")
                Exit For
            Next

            row("ITEM") = _ULTIMO_ITEM + 1
            _item = row("ITEM")
            row("FECHA") = Date.Now.ToString("dd/MM/yyyy")
            row("HORA") = Date.Now.ToString("HH:mm:ss")
            If Label6.Text = "INICIO PRODUCCION" Then
                row("CONCEPTO") = "Inicio Producción"
                t_inicio = TimeSpan.Parse(row("HORA"))
                lst_historial.Items.Add("Fecha y Hora de Inicio Producción: ")
                ListBox1.Items.Add(t_inicio.ToString)
                Timer1.Start()
            ElseIf Label6.Text = "REINICIAR PRODUCCION" Then
                Timer1.Start()
                row("CONCEPTO") = "Reinicio"
            End If

            row("OBSERVACIONES") = ""
            row("MOTIVO_PAUSA") = cbo_produccion.SelectedValue
            row("PLIEGOS_BUENOS") = 0
            row("PLIEGOS_MALOS") = ""
            row("PROCESO_INICIO_PREPARACION") = cbo_produccion.Text

            dtdetalle.Rows.Add(row)
            dtdetalle.AcceptChanges()

            dgv_detalle_historial.DataSource = dtdetalle
            Formato_Grilla_Detalle_Op()
            Call CalcularTotales_Cantidad()
            pb_inicio.Enabled = True
            pb_pausa.Enabled = True
            pb_fin.Enabled = True
            pb_inicio_prepar.Enabled = True
            Label6.Text = "INICIO PRODUCCION"
            pb_inicio.Cursor = Cursors.No
            pb_pausa.Cursor = Cursors.Default
            pb_fin.Cursor = Cursors.Default
            pb_pausa_equipo.Cursor = Cursors.Default
            pb_inicio_prepar.Cursor = Cursors.No

            pb_inicio_prepar_des.Visible = True
            pb_inicio_des.Visible = False 'True
            'pb_pausa_des.Visible = False
            pb_fin_des.Visible = False

            pnl_proceso_produccion.Visible = False
            'pb_inicio_prepar.Cursor = Cursors.Default
            Button1.Enabled = True

            Me.Cursor = Cursors.WaitCursor
            Call Guardar_Parte_Produccion("OPERANDO")

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
        'End If

    End Sub

    Private Sub btn_manejo_troquel_Click(sender As Object, e As EventArgs) Handles btn_manejo_troquel.Click
        'Dim frmmanejotroquel As New Frm_OP_Planta_Bandeja_Manejo_Troqueles_Operario
        'frmmanejotroquel.ShowDialog()
    End Sub

    Private Sub dgv_produccion_programada2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_produccion_programada2.CellFormatting
        If dgv_produccion_programada2.Rows(e.RowIndex).Cells("ESTADO").Value = "OPERANDO" Then
            dgv_produccion_programada2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Blue
            dgv_produccion_programada2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Blue
        ElseIf dgv_produccion_programada2.Rows(e.RowIndex).Cells("ESTADO").Value = "TERMINADO" Then
            dgv_produccion_programada2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            dgv_produccion_programada2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Red
        ElseIf dgv_produccion_programada2.Rows(e.RowIndex).Cells("ESTADO").Value = "PAUSADO" Then
            dgv_produccion_programada2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
            dgv_produccion_programada2.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Orange
        End If
    End Sub


    Private Sub dgv_produccion_programada2_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_produccion_programada2.CellMouseDoubleClick
        If dgv_produccion_programada2.CurrentRow Is Nothing Then Exit Sub
        If dgv_produccion_programada2.Rows.Count = 0 Then Exit Sub

        If _fin_turno = True Then
            MsgBox("El turno ya Finalizo, no puede registrar movimientos. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Try
            Me.Cursor = Cursors.WaitCursor

            TextBox3.Text = "PARTE PRODUCCION " & Strings.UCase(TextBox5.Text.Trim) & "- OP N° " & dgv_produccion_programada2.CurrentRow.Cells("Num.O.P.").Value

            lbl_hora.Text = "00" 'Format(dgv_produccion_programada.CurrentRow.Cells("Hora_Real").Value, "00")
            lbl_minuto.Text = "00" 'Format(dgv_produccion_programada.CurrentRow.Cells("Minuto").Value, "00")
            lbl_segundo.Text = "00"
            lbl_ms.Text = "00"

            lbl_hora_programado.Text = Format(dgv_produccion_programada2.CurrentRow.Cells("Hora_Real").Value, "00")
            lbl_minuto_programdo.Text = Format(dgv_produccion_programada2.CurrentRow.Cells("Minuto").Value, "00")

            lbl_hora_programado_prep.Text = Format(dgv_produccion_programada2.CurrentRow.Cells("Hora_Prep").Value, "00")
            lbl_minuto_programado_prep.Text = Format(dgv_produccion_programada2.CurrentRow.Cells("Minuto_Prep").Value, "00")

            lbl_hora.ForeColor = Color.Lime
            lbl_minuto.ForeColor = Color.Lime
            lbl_segundo.ForeColor = Color.Lime
            lbl_ms.ForeColor = Color.Lime
            Label4.ForeColor = Color.Lime
            Label2.ForeColor = Color.Lime

            pb_inicio.Cursor = Cursors.Default
            pb_pausa.Cursor = Cursors.Default
            pb_fin.Cursor = Cursors.Default
            pb_pausa_equipo.Cursor = Cursors.Default
            pb_inicio_prepar.Cursor = Cursors.Default

            Label6.Text = "INICIO PRODUCCION"
            _item = 0
            lst_historial.Items.Clear()
            ListBox1.Items.Clear()
            _ULTIMO_ITEM = 0

            Call GenerarColummnaDataTable()
            _NUMERO_OP = dgv_produccion_programada2.CurrentRow.Cells("ID_CAB").Value
            _ITEM_OP = dgv_produccion_programada2.CurrentRow.Cells("ITEM").Value
            _TIPO_ORDEN = dgv_produccion_programada2.CurrentRow.Cells("TIPO_ORDEN").Value
            Call Detalle_Op(TextBox6.Text.Trim, _NUMERO_OP, dgv_produccion_programada2.CurrentRow.Cells("ITEM").Value)
            'If dgv_produccion_programada.CurrentRow.Cells("Estado").Value = "EN PROCESO" Then
            Call Detalle_Op_Operando_ii(TextBox6.Text.Trim, dgv_produccion_programada2.CurrentRow.Cells("Fecha Programada").Value, _NUMERO_OP, _ITEM_OP)
            'End If
            Call Detalle_Actividad_Op(TextBox6.Text.Trim, _NUMERO_OP, dgv_produccion_programada2.CurrentRow.Cells("ITEM").Value)
            Call CalcularTotales_Cantidad()
            Call Cargar_Motivos_Pausa_Produccion(TextBox6.Text.Trim)

            Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE
            cbo_proceso_preparacion.DataSource = monedaBL.get_Procesos_Inicio_Prepacion(txt_des_area.Text)
            cbo_proceso_preparacion.ValueMember = "CODIGO"
            cbo_proceso_preparacion.DisplayMember = "DESCRIPCION"

            If TextBox6.Text = "28" Then 'barnizadora
                pb_barnizadora.Visible = True
                pb_dobladora.Visible = False
                pb_spes_master.Visible = False
                pb_roland.Visible = False
                pb_plastificadora.Visible = False
                pb_troqueladora.Visible = False
                pb_cortadora.Visible = False
                btn_manejo_troquel.Visible = False
            ElseIf TextBox6.Text = "18" Then 'dobladora
                pb_barnizadora.Visible = False
                pb_dobladora.Visible = True
                pb_spes_master.Visible = False
                pb_roland.Visible = False
                pb_plastificadora.Visible = False
                pb_troqueladora.Visible = False
                pb_cortadora.Visible = False
                btn_manejo_troquel.Visible = False
            ElseIf TextBox6.Text = "20" Then 'sped master
                pb_barnizadora.Visible = False
                pb_dobladora.Visible = False
                pb_spes_master.Visible = True
                pb_roland.Visible = False
                pb_plastificadora.Visible = False
                pb_troqueladora.Visible = False
                pb_cortadora.Visible = False
                btn_manejo_troquel.Visible = False
            ElseIf TextBox6.Text = "35" Then 'roland
                pb_barnizadora.Visible = False
                pb_dobladora.Visible = False
                pb_spes_master.Visible = False
                pb_roland.Visible = True
                pb_plastificadora.Visible = False
                pb_troqueladora.Visible = False
                pb_cortadora.Visible = False
                btn_manejo_troquel.Visible = False
            ElseIf TextBox6.Text = "25" Then 'plastificadora
                pb_barnizadora.Visible = False
                pb_dobladora.Visible = False
                pb_spes_master.Visible = False
                pb_roland.Visible = False
                pb_plastificadora.Visible = True
                pb_troqueladora.Visible = False
                pb_cortadora.Visible = False
                btn_manejo_troquel.Visible = False
            ElseIf TextBox6.Text = "6" Or TextBox6.Text = "38" Then 'troqueladora
                pb_barnizadora.Visible = False
                pb_dobladora.Visible = False
                pb_spes_master.Visible = False
                pb_roland.Visible = False
                pb_plastificadora.Visible = False
                pb_troqueladora.Visible = True
                pb_cortadora.Visible = False
                btn_manejo_troquel.Visible = True
            ElseIf TextBox6.Text = "15" Or TextBox6.Text = "37" Then 'cortadora
                pb_barnizadora.Visible = False
                pb_dobladora.Visible = False
                pb_spes_master.Visible = False
                pb_roland.Visible = False
                pb_plastificadora.Visible = False
                pb_troqueladora.Visible = False
                pb_cortadora.Visible = True
                btn_manejo_troquel.Visible = False
            Else
                pb_barnizadora.Visible = False
                pb_dobladora.Visible = False
                pb_spes_master.Visible = False
                pb_roland.Visible = False
                pb_plastificadora.Visible = False
                pb_troqueladora.Visible = False
                pb_cortadora.Visible = False
                btn_manejo_troquel.Visible = False
            End If

            If dgv_produccion_programada2.CurrentRow.Cells("ESTADO").Value = "TERMINADO" Then
                lbl_hora.Text = "00"
                lbl_minuto.Text = "00"
                lbl_segundo.Text = "00"
                lbl_ms.Text = "00"

                pb_inicio.Enabled = True
                pb_pausa.Enabled = True
                pb_fin.Enabled = True
                'pb_pausa_equipo.Enabled = True
                pb_inicio_prepar.Enabled = True

                pb_inicio.Cursor = Cursors.No
                pb_pausa.Cursor = Cursors.No
                pb_fin.Cursor = Cursors.No
                pb_pausa_equipo.Cursor = Cursors.No
                pb_inicio_prepar.Cursor = Cursors.No
            End If

            Panel1.Visible = True
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Panel1.Visible = False
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CalcularTotales_Cantidad()
        Try
            If dtdetalle.Rows.Count() <> 0 Then
                lbl_total_cantidad.Text = "Total Producido: " & Format(dtdetalle.Compute("sum (PLIEGOS_BUENOS) ", ""), "0.00")
            Else
                lbl_total_cantidad.Text = "Total Producido: 0.00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        If STRorden = "" Then Exit Sub

        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv2), CurrencyManager)
        Dim INTnewpos As Integer
        dtv2.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos

    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave

    End Sub

    Private Sub btn_ver_otra_maquina_Click(sender As Object, e As EventArgs) Handles btn_ver_otra_maquina.Click
        If TextBox6.Text = "" Then
            MsgBox("Debe elegir un Equipo y/o Maquina. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cbo_turno.SelectedIndex = -1 Then
            MsgBox("Debe elegir un Turno de trabajo. Verifique!!!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            Dim Stock As Double = 0.0
            sql = "COMPRA_SP_S_EQUIPOS"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = "A"
            frm.Titulo = "Seleccion de Procesos o Equipos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                Dim _maquina As String = ""

                _maquina = frm.Data_Matriz.Rows(0).Item(0).ToString

                Dim fecha_1 As Date
                Dim fecha_2 As Date
                Dim fecha_3 As Date

                fecha_1 = dtp_fecha_produccion_programada.Value.AddDays(-1).ToString("dd/MM/yyyy")
                fecha_2 = dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy")
                fecha_3 = dtp_fecha_produccion_programada.Value.AddDays(1).ToString("dd/MM/yyyy")

                dtv2 = New DataView
                STRorden = ""
                Dim dt_detalle_produccion_programada2 As DataTable

                dt_detalle_produccion_programada2 = clsPedidoBl.get_Parte_Produccion_Produccion_Programada2_Troquel(TextBox6.Text.Trim, _
                                                                                                      fecha_2.ToString("dd/MM/yyyy"), _
                                                                                                      fecha_2.ToString("dd/MM/yyyy"), _
                                                                                                      cbo_turno.Text, IIf(chk_programacion_siguiente.Checked, "SI", "NO"), _
                                                                                                      _maquina)
                dtv2 = dt_detalle_produccion_programada2.DefaultView
                tb_lista_programada.TabPages.Item(0).Text = fecha_2.ToString("dd/MM/yyyy")

                dgv_produccion_programada2.DataSource = Nothing
                Formato_Grillas(dtv2, dgv_produccion_programada2)

                ''inicio de calculo de tiempo
                _tiempo_total_programacion = 0
                txt_tiempo_total_programado.Text = ""
                Dim hora_total As Double = 0
                Dim minutos_total As Double = 0

                For i As Integer = 0 To dgv_produccion_programada2.Rows.Count - 1
                    _tiempo_total_programacion = _tiempo_total_programacion + CDbl(dgv_produccion_programada2.Rows(i).Cells("TIEMPO").Value)
                    hora_total = hora_total + CDbl(dgv_produccion_programada2.Rows(i).Cells("Hora_Real").Value)
                    minutos_total = minutos_total + CDbl(dgv_produccion_programada2.Rows(i).Cells("Minuto").Value)
                Next

                _tiempo_total_programacion = Math.Round(_tiempo_total_programacion, 2)

                If minutos_total > 0 Then
                    Dim parte_entera As Double = 0
                    parte_entera = Math.Floor(minutos_total / 60)
                    hora_total = hora_total + parte_entera

                    minutos_total = Math.Round((((minutos_total / 60) - Math.Floor(minutos_total / 60)) * 60), 0)

                    txt_tiempo_total_programado.Text = CStr(hora_total) + " h " + CStr(minutos_total) + "'"

                ElseIf minutos_total <= 0 Then
                    txt_tiempo_total_programado.Text = ""
                End If

            End If
            Me.Cursor = Cursors.Default
            frm.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_buenos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buenos.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_malos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_malos.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_supervisor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_supervisor.MouseDoubleClick
        Ayuda_Trabajador(txt_cod_supervisor, txt_des_supervisor)
    End Sub

    Private Sub txt_cod_supervisor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_supervisor.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.F1 Then
            Ayuda_Trabajador(txt_cod_supervisor, txt_des_supervisor)
        End If
        If e.KeyCode = Keys.Enter Then
            txt_cod_ayudante.Focus()
        End If
    End Sub

    Private Sub Ayuda_Trabajador(ByVal _caja_cod As TextBox, ByVal _caja_des As TextBox)
        Try
            Dim frm As New frmBuscar

            Dim sql As String = String.Empty
            sql = "FACT_SP_S_EMPLOYEE_II"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE TRABAJADORES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _caja_cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                _caja_des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ayuda_Ayudante(ByVal _caja_cod As TextBox, ByVal _caja_des As TextBox)
        Try
            Dim frm As New frmBuscar

            Dim sql As String = String.Empty
            sql = "FACT_SP_S_EMPLOYEE_III"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE TRABAJADORES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _caja_cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                _caja_des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_ayudante_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_ayudante.MouseDoubleClick
        Ayuda_Ayudante(txt_cod_ayudante, txt_des_ayudante)
    End Sub

    Private Sub txt_cod_ayudante_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_ayudante.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.F1 Then
            Ayuda_Ayudante(txt_cod_ayudante, txt_des_ayudante)
        End If
        If e.KeyCode = Keys.Enter Then
            btn_confirmar.Focus()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Cursor = Cursors.Default
        pnl_actualiza_datos.Visible = False
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dt_programacion As DataTable
            dt_programacion = New DataTable

            dt_programacion = clsPedidoBl.get_Parte_Produccion_Produccion_Programada2(TextBox6.Text.Trim, _
                                                                                                  dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                  dtp_fecha_produccion_programada.Value.ToString("dd/MM/yyyy"), _
                                                                                                  cbo_turno.Text, IIf(chk_programacion_siguiente.Checked, "SI", "NO"))

            Dim hora_total As Double = 0
            Dim minutos_total As Double = 0
            Dim tiraje_total As Double = 0

            For i As Integer = 0 To dt_programacion.Rows.Count - 1
                hora_total = hora_total + CDbl(dt_programacion.Rows(i).Item("Hora_Real").ToString) 'dt_tipo_maquina.Rows(0).Item("TIPO").ToString
                minutos_total = minutos_total + CDbl(dt_programacion.Rows(i).Item("Minuto").ToString)
                tiraje_total = tiraje_total + CDbl(dt_programacion.Rows(i).Item("Tiraje").ToString)
            Next
            hora_total = hora_total + Math.Round(minutos_total / 60, 2)
            If Agregar_HP_Iniciar_Terminar_Turno("Inicio Turno", cbo_turno.Text, txt_des_ayudante.Text, txt_des_supervisor.Text, hora_total, tiraje_total) Then
                Button36_Click(sender, e)
                btn_cancelar_Click(sender, e)
                Me.Cursor = Cursors.Default
                btn_iniciar_turno.Visible = False
                btn_fin_turno.Visible = True
                btn_inoperatividad.Visible = False 'True
                btn_act_no_programadas.Visible = False 'True
                btn_parte_maquina.Visible = False 'True
            Else
                Me.Cursor = Cursors.Default
                btn_cancelar_Click(sender, e)
                btn_iniciar_turno.Visible = True
                btn_fin_turno.Visible = False
                btn_inoperatividad.Visible = False
                btn_act_no_programadas.Visible = False
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub chk_adjuntar_ops_CheckedChanged(sender As Object, e As EventArgs) Handles chk_adjuntar_ops.CheckedChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        tipo_pausa = ""
        'lbl_inicio.Text = "INICIO"
        pnl_pausa.Visible = False
        'pb_pausa_des.Visible = False
        pb_fin_des.Visible = False
        Timer1.Start()
    End Sub

    Private Sub btn_aceptar_fin_Click(sender As Object, e As EventArgs) Handles btn_aceptar_fin.Click
        Try
            If LibComunVar.ClsVarComun.RucEmpresa <> "20556850454" Then
                If txt_cantidad_fin.Text = "" Then
                    MsgBox("Debe ingresar la cantidad.", MsgBoxStyle.Exclamation, "Aviso")
                    txt_cantidad_fin.Focus()
                    Exit Sub
                End If
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim row As DataRow = dtdetalle.NewRow

            For Each row2 As DataRow In dtdetalle.Select("", "ITEM DESC")
                _ULTIMO_ITEM = row2("ITEM")
                Exit For
            Next

            row("ITEM") = _ULTIMO_ITEM + 1
            _item = row("ITEM")
            row("CONCEPTO") = "Fin Producción"
            row("FECHA") = Date.Now.ToString("dd/MM/yyyy")
            row("HORA") = Date.Now.ToString("HH:mm:ss")
            row("OBSERVACIONES") = ""
            row("MOTIVO_PAUSA") = ""
            If txt_cantidad_fin.Text = "" Then txt_cantidad_fin.Text = "0"
            row("PLIEGOS_BUENOS") = txt_cantidad_fin.Text
            row("PLIEGOS_MALOS") = ""

            dtdetalle.Rows.Add(row)
            dtdetalle.AcceptChanges()

            dgv_detalle_historial.DataSource = dtdetalle
            Formato_Grilla_Detalle_Op()
            Call CalcularTotales_Cantidad()
            lbl_inicio.Text = "INICIO"
            pb_inicio.Cursor = Cursors.Default
            pb_pausa.Cursor = Cursors.Default
            pb_fin.Cursor = Cursors.Default
            pb_pausa_equipo.Cursor = Cursors.Default
            pb_inicio_prepar.Cursor = Cursors.Default

            pb_inicio_prepar_des.Visible = False
            pb_inicio_des.Visible = False
            'pb_pausa_equipo_des.Visible = False
            'pb_pausa_des.Visible = False
            pb_fin_des.Visible = False

            pb_inicio_prepar.Cursor = Cursors.Default
            Button1.Enabled = True

            Call Guardar_Parte_Produccion("OPERANDO")
            Button1.Enabled = True
            pnl_proceso_fin_preparacion.Visible = False



            'If Guardar_Parte_Produccion("OPERANDO") Then
            '    Call Detalle_Actividad_Op(TextBox6.Text.Trim, _NUMERO_OP, _ITEM_OP)
            'End If

            'clsPedidoBl = New LibManufactura.ClsOperaciones.ORDERS
            'PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
            'Dim MantenimientoOP_Lista As New List(Of ClsEntidades.MANTENIMIENTO_OP)

            'PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP

            'PedidoCabENT = New ClsEntidades.MANTENIMIENTO_OP
            'With PedidoCabENT
            '    .ID = _NUMERO_OP
            '    .ITEM = _ITEM_OP
            '    .HORA_INICIO_PRODUCCION = ""
            '    .HORA_FINAL_PRODUCCION = ""
            '    .PLIEGOS_BUENOS_PRODUCCION = txt_buenos.Text.Trim
            '    .PLIEGOS_MALOS_PRODUCCION = txt_malos.Text.Trim
            '    .OBS_PRODUCCION = txt_obs_produccion.Text.Trim
            '    .USER_ID_DESPACHO = TextBox6.Text.Trim
            '    .USER_ID = LibComunVar.ClsVarComun.USUARIO
            '    .TIEMPO_EJECUTADO = t_ejecutado
            'End With
            'MantenimientoOP_Lista.Add(PedidoCabENT)

            'If clsPedidoBl.Guardar_Parte_Produccion(MantenimientoOP_Lista) Then
            '    Button1.Enabled = True
            '    MsgBox("Parte de Producción Generado Correctamente.", MsgBoxStyle.Information, "Sistemas")
            '    pnl_fin.Visible = False
            'End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_area.SelectedIndexChanged
        Dim monedaBL As New ClsOperaciones.CURRENCY_TYPE

        cbo_proceso_preparacion.DataSource = monedaBL.get_Procesos_Inicio_Prepacion(cbo_area.Text)
        cbo_proceso_preparacion.ValueMember = "CODIGO"
        cbo_proceso_preparacion.DisplayMember = "DESCRIPCION"
    End Sub

    Private Sub txt_buenos_pausa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buenos_pausa.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_usuario_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_usuario.MouseDoubleClick
        Ayuda_Usuario()
    End Sub

    Private Sub txt_usuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Usuario()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_usuario.Text = "" Then
                Ayuda_Usuario()
            Else
                txt_cod_area.Focus()
            End If
        End If
    End Sub

    Private Sub Ayuda_Usuario()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "PUR_SP_S_USUARIOS_PARTE_PRODUCCION"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE USUARIOS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_usuario.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_nombres.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            Else
                txt_usuario.Text = ""
                txt_nombres.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_area_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_area.MouseDoubleClick
        Ayuda_Area()
    End Sub

    Private Sub txt_cod_area_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_area.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Area()
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_area.Text = "" Then
                Ayuda_Area()
            Else
                TextBox6.Focus()
            End If

        End If
    End Sub

    Private Sub Ayuda_Area()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "MANTENIMIENTO_SP_S_PROCESOS_AREA_I"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE AREAS"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txt_cod_area.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_area.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            Else
                txt_cod_area.Text = ""
                txt_des_area.Text = ""
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cantidad_fin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad_fin.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidad_fin_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad_fin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_obs_fin.Focus()
        End If
    End Sub

    Private Sub btn_lista_ayudantes_Click(sender As Object, e As EventArgs) Handles btn_lista_ayudantes.Click
        If txt_cod_area.Text = "" Then
            MsgBox("Debe elegir un Area.", MsgBoxStyle.Exclamation)
            txt_cod_area.Focus()
            Exit Sub
        End If

        If TextBox6.Text = "" Then
            MsgBox("Debe elegir una Maquina.", MsgBoxStyle.Exclamation)
            TextBox6.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.Default
        txt_cod_ayudante_2.Text = ""
        txt_des_ayudante_2.Text = ""
        GenerarColummnaDataTable_Ayudamtes()
        pnl_actualiza_datos_2.Visible = True
        pnl_actualiza_datos_2.BringToFront()
        txt_cod_ayudante_2.Focus()
    End Sub
    Public Sub GenerarColummnaDataTable_Ayudamtes()
        dtdetalleArticuloPrincipal_Incripciones_RegSanit = New DataTable
        dtdetalleArticuloPrincipal_Incripciones_RegSanit.Columns.Add("ITEM", Type.GetType("System.Int64"))
        dtdetalleArticuloPrincipal_Incripciones_RegSanit.Columns.Add("CODIGO", Type.GetType("System.String"))
        dtdetalleArticuloPrincipal_Incripciones_RegSanit.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dgvDetalle.DataSource = Nothing
        dgvDetalle.DataSource = dtdetalleArticuloPrincipal_Incripciones_RegSanit

        dgvDetalle.Columns(0).HeaderText = "Item"
        'dgvDetalle.Columns(0).Visible = False
        dgvDetalle.Columns(1).HeaderText = "Codigo"
        dgvDetalle.Columns(2).HeaderText = "Descripción"

        dgvDetalle.AutoResizeColumns()
        dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub txt_cod_ayudante_2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cod_ayudante_2.MouseDoubleClick
        Ayuda_Ayudante_2(txt_cod_ayudante_2, txt_des_ayudante_2)
    End Sub

    Private Sub txt_cod_ayudante_2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_ayudante_2.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.F1 Then
            Ayuda_Ayudante_2(txt_cod_ayudante_2, txt_des_ayudante_2)
        End If
        If e.KeyCode = Keys.Enter Then
            If txt_cod_ayudante_2.Text = "" Then
                Ayuda_Ayudante_2(txt_cod_ayudante_2, txt_des_ayudante_2)
            Else
                btn_add.Focus()
            End If

        End If
    End Sub

    Private Sub Ayuda_Ayudante_2(ByVal _caja_cod As TextBox, ByVal _caja_des As TextBox)
        Try
            Dim frm As New frmBuscar

            Dim sql As String = String.Empty
            sql = "PUR_SP_S_USUARIOS_PARTE_PRODUCCION"
            frm.CadenaConsulta = sql
            frm.Titulo = "LISTA DE TRABAJADORES"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                _caja_cod.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                _caja_des.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Validacion_Ingreso() = False Then Exit Sub
            If dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count > 0 Then
                For Each rows As DataRow In dtdetalleArticuloPrincipal_Incripciones_RegSanit.Select("CODIGO='" & txt_cod_ayudante_2.Text.Trim & "' ")
                    MsgBox("El Ayudante elegido ya se encuentra adjuntado.", MsgBoxStyle.Information, "Aviso")
                    Exit Try
                Next
            End If
            Dim row As DataRow = dtdetalleArticuloPrincipal_Incripciones_RegSanit.NewRow
            row("ITEM") = dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count() + 1
            row("CODIGO") = txt_cod_ayudante_2.Text.Trim
            row("DESCRIPCION") = txt_des_ayudante_2.Text.Trim
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Add(row)
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.AcceptChanges()
            txt_cod_ayudante_2.Text = String.Empty
            txt_des_ayudante_2.Text = String.Empty
            txt_cod_ayudante_2.Focus()
            dgvDetalle.DataSource = dtdetalleArticuloPrincipal_Incripciones_RegSanit
            'dgvDetalle.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Validacion_Ingreso() As Boolean

        If txt_cod_ayudante_2.Text.Trim = "" Then
            MsgBox("Debe elegir un Ayudante.", MsgBoxStyle.Exclamation, "Sistemas")
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If dgvDetalle.RowCount = 0 Then Exit Sub
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub

        If MsgBox("Seguro de eliminar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuidado!") = MsgBoxResult.Yes Then
            EliminandoArticulo()
        End If
    End Sub

    Private Sub EliminandoArticulo()
        Try
            Dim Codigo As String = String.Empty
            Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
            'Borrando los Datos
            For Each item As DataRow In dtdetalleArticuloPrincipal_Incripciones_RegSanit.Select("ITEM=" & Codigo)
                item.Delete()
                dtdetalleArticuloPrincipal_Incripciones_RegSanit.AcceptChanges()
            Next
            RehacerSecuencia()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows
            i += 1
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.BeginInit()
            items("ITEM") = i
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.EndInit()
            dtdetalleArticuloPrincipal_Incripciones_RegSanit.AcceptChanges()
        Next
    End Sub

    Private Sub btn_cancelar_2_Click(sender As Object, e As EventArgs) Handles btn_cancelar_2.Click
        Me.Cursor = Cursors.Default
        pnl_actualiza_datos_2.Visible = False
    End Sub

    Private Sub btn_confirmar_2_Click(sender As Object, e As EventArgs) Handles btn_confirmar_2.Click
        Try
            If dtdetalleArticuloPrincipal_Incripciones_RegSanit.Rows.Count = 0 Then
                MsgBox("No se adjunto ningun Ayudante. Verifique!!!.", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim dt_programacion As DataTable
            dt_programacion = New DataTable

            If Agregar_HP_Iniciar_Terminar_Turno("Inicio Turno", cbo_turno.Text, txt_des_ayudante.Text, txt_des_supervisor.Text, 0.0, 0.0) Then
                btn_cancelar_2_Click(sender, e)
                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.Default
                btn_cancelar_2_Click(sender, e)
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
End Class