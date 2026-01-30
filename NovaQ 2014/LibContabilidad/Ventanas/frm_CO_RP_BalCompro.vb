Imports System.Windows.Forms
Imports System.Drawing

Public Class frm_CO_RP_BalCompro
    Dim dt_tmp As DataTable = Nothing
    Dim dt_tmp_detalle As DataTable = Nothing
    Private Sub frm_CO_RP_BalCompro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Meses_en_Combo(cmb_mes)
        Call Cargar_Combos()
        mtb_ayo.Text = gFechaSis.Year
        cmb_mes.SelectedIndex = Date.Now.Month - 1
        chk_solo_ctas_tit.Enabled = False
        chk_con_cta_tit.Checked = False
        mtb_ayo.Focus()

    End Sub

    Public Sub Cargar_Combos()
        Try
            Dim monedaBL As New ClsOperaciones.CO_TB_MONEDA
            Dim tipAnexBL As New ClsOperaciones.CO_TB_TIPO_ANEXO
            Dim tipMovBL As New ClsOperaciones.CO_TB_TIPO_MOV

            cmb_Moneda.DisplayMember = "MO_DESCRIPCION"
            cmb_Moneda.ValueMember = "MO_ABRE"
            cmb_Moneda.DataSource = monedaBL.get_Monedas_II()

            monedaBL = Nothing
            tipAnexBL = Nothing
            tipMovBL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub chk_con_cta_tit_CheckedChanged(sender As Object, e As EventArgs) Handles chk_con_cta_tit.CheckedChanged
        chk_solo_ctas_tit.Enabled = chk_con_cta_tit.Checked
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click

        Try
            Cursor = Cursors.WaitCursor
            Dim Str_Titulo As String = "Balance de Comprobacion al mes de " & cmb_mes.Text & " " & mtb_ayo.Text
            Dim Dbl_Sum_Debe As String = "0.00"
            Dim Dbl_Sum_Haber As String = "0.00"
            Dim Dbl_Sum_Sal_Debe As String = "0.00"
            Dim Dbl_Sum_Sal_Haber As String = "0.00"
            Dim reporteBL As New ClsOperaciones.ReportesCO
            Dim crystalBL As New LibReportes.ClsReporte
            Dim fq As New ClsOperaciones.freeQuery
            'Dim dt_tmp As DataTable = Nothing
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If
            dt_info_emp = Nothing
            fq = Nothing
            'dt_tmp = reporteBL.Balance_Comprobacion(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, IIf(chk_con_cta_tit.Checked, 1, 0), IIf(rb_acumulado.Checked, 1, 0), 2)
            dt_tmp = reporteBL.Balance_Comprobacion(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, IIf(chk_con_cta_tit.Checked, 1, 0), IIf(rb_acumulado.Checked, 1, 0), 2, IIf(chk_solo_ctas_tit.Checked, 1, 0), cmb_Moneda.SelectedIndex + 1)

            If dt_tmp.Rows.Count() <> 0 Then
                If chk_solo_ctas_tit.Checked Then
denuevo:
                    For Each f As DataRow In dt_tmp.Rows
                        If f.ItemArray(0).ToString().Length <> 2 Then
                            dt_tmp.Rows.Remove(f)
                            GoTo denuevo
                        End If
                    Next

                    If chk_solo_ctas_tit.Checked Then
                        If dt_tmp.Rows.Count > 0 Then
                            Dbl_Sum_Debe = Double.Parse(dt_tmp.Compute("sum(DEBE)", "").ToString())
                            Dbl_Sum_Haber = Double.Parse(dt_tmp.Compute("sum(HABER)", "").ToString())
                            Dbl_Sum_Sal_Debe = Double.Parse(dt_tmp.Compute("sum(Saldo_Deudor)", "").ToString())
                            Dbl_Sum_Sal_Haber = Double.Parse(dt_tmp.Compute("sum(Saldo_Acreedor)", "").ToString())
                        Else
                            Dbl_Sum_Debe = 0
                            Dbl_Sum_Haber = 0
                            Dbl_Sum_Sal_Debe = 0
                            Dbl_Sum_Sal_Haber = 0
                        End If
                    Else
                        If dt_tmp.Rows.Count > 0 Then
                            Dbl_Sum_Debe = Double.Parse(dt_tmp.Compute("sum(DEBE)", "len(CUENTA) <> 2 ").ToString())
                            Dbl_Sum_Haber = Double.Parse(dt_tmp.Compute("sum(HABER)", "len(CUENTA) <> 2 ").ToString())
                            Dbl_Sum_Sal_Debe = Double.Parse(dt_tmp.Compute("sum(Saldo_Deudor)", "len(CUENTA) <> 2 ").ToString())
                            Dbl_Sum_Sal_Haber = Double.Parse(dt_tmp.Compute("sum(Saldo_Acreedor)", "len(CUENTA) <> 2 ").ToString())
                        Else
                            Dbl_Sum_Debe = 0
                            Dbl_Sum_Haber = 0
                            Dbl_Sum_Sal_Debe = 0
                            Dbl_Sum_Sal_Haber = 0
                        End If
                    End If
                End If
                'crystalBL.Muestra_Reporte("rpt_Balance_Comprobac.RPT", "", "", "", "pPeriodo;" + mtb_ayo.Text, "pRuc;" + ruc, "pRazon;" + razon, "pFecha_Pag;0", "pTitulo;" + Str_Titulo.ToUpper(), _
                '"pSoloCtaTit;" + IIf(chk_solo_ctas_tit.Checked, "1", "0"), "pNunDigCtaTit;2", "pSum_Debe;" + Dbl_Sum_Debe, _
                '"pSum_Haber;" + Dbl_Sum_Haber, "pSum_Saldo_Debe;" + Dbl_Sum_Sal_Debe, "pSum_Saldo_Haber;" + Dbl_Sum_Sal_Haber)


                crystalBL.Muestra_Reporte("rpt_Balance_Comprobac_lusa.rpt", dt_tmp, "", "", "@PERIODO;" + mtb_ayo.Text, "@RUC;" + ruc, "@RAZON;" + razon, _
                                          "@TITULO;" + Str_Titulo.ToUpper(), "@SUM_DEBE;" + Dbl_Sum_Debe, "@SUM_HABER;" + Dbl_Sum_Haber, _
                                          "@DEUDOR;" + Dbl_Sum_Sal_Debe, "@ACREEDOR;" + Dbl_Sum_Sal_Haber)

            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Information)
            End If
            dt_tmp = Nothing
            reporteBL = Nothing
            crystalBL = Nothing
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mtb_ayo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtb_ayo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_mes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rb_mensual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rb_mensual.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rb_acumulado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rb_acumulado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click

        Try
            Cursor = Cursors.WaitCursor

            Dim Dbl_Sum_Debe As String = "0.00"
            Dim Dbl_Sum_Haber As String = "0.00"
            Dim Dbl_Sum_Sal_Debe As String = "0.00"
            Dim Dbl_Sum_Sal_Haber As String = "0.00"
            Dim reporteBL As New ClsOperaciones.ReportesCO


            dt_tmp = reporteBL.Balance_Comprobacion_Detalle(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, IIf(chk_con_cta_tit.Checked, 1, 0), IIf(rb_acumulado.Checked, 1, 0), 2, IIf(chk_solo_ctas_tit.Checked, 1, 0), cmb_Moneda.SelectedIndex + 1)

            If dt_tmp.Rows.Count() <> 0 Then
                If chk_solo_ctas_tit.Checked Then
denuevo:
                    For Each f As DataRow In dt_tmp.Rows
                        If f.ItemArray(0).ToString().Length <> 2 Then
                            dt_tmp.Rows.Remove(f)
                            GoTo denuevo
                        End If
                    Next
                End If
                dgv_detalle.DataSource = Nothing
                dgv_detalle.DataSource = dt_tmp
                Formato_Grilla()
                Sumas()
                dgv_detalle.Focus()
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Information)
                dgv_detalle.DataSource = Nothing
            End If

            dt_tmp = Nothing
            reporteBL = Nothing

            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub Formato_Grilla()

        If dt_tmp.Rows.Count() <> 0 Then
            '     //formateamos la grilla
            dgv_detalle.Columns("CUENTA").Width = 50
            dgv_detalle.Columns("DESCRIPCION").Width = 140
            dgv_detalle.Columns("DEBE_APER").Width = 90
            dgv_detalle.Columns("HABER_APER").Width = 90
            dgv_detalle.Columns("DEBE").Width = 90
            dgv_detalle.Columns("HABER").Width = 90
            dgv_detalle.Columns("SALDO_DEUDOR").Width = 90
            dgv_detalle.Columns("SALDO_ACREEDOR").Width = 90
            dgv_detalle.Columns("OPCION").Visible = False
            dgv_detalle.Columns("INV_ACTIVO").Width = 90
            dgv_detalle.Columns("INV_PASIVO").Width = 90
            dgv_detalle.Columns("NATU_PERDIDA").Width = 90
            dgv_detalle.Columns("NATU_GANANCIA").Width = 90
            dgv_detalle.Columns("FUNC_PERDIDA").Width = 90
            dgv_detalle.Columns("FUNC_GANANCIA").Width = 90

            dgv_detalle.Columns("CUENTA").HeaderText = "Cuenta"
            dgv_detalle.Columns("DESCRIPCION").HeaderText = "Descripción"
            dgv_detalle.Columns("DEBE_APER").HeaderText = "Saldo Inicial Debito"
            dgv_detalle.Columns("HABER_APER").HeaderText = "Saldo Inicial Credito"
            dgv_detalle.Columns("DEBE").HeaderText = "Movimiento Debito"
            dgv_detalle.Columns("HABER").HeaderText = "Movimiento Credito"
            dgv_detalle.Columns("SALDO_DEUDOR").HeaderText = "Saldo Deudor"
            dgv_detalle.Columns("SALDO_ACREEDOR").HeaderText = "Saldo Acreedor"

            dgv_detalle.Columns("INV_ACTIVO").HeaderText = "Inventario Ativo"
            dgv_detalle.Columns("INV_PASIVO").HeaderText = "Inventario Pasivo"
            dgv_detalle.Columns("NATU_PERDIDA").HeaderText = "Naturaleza Perdida"
            dgv_detalle.Columns("NATU_GANANCIA").HeaderText = "Naturaleza Ganancia"
            dgv_detalle.Columns("FUNC_PERDIDA").HeaderText = "Función Perdida"
            dgv_detalle.Columns("FUNC_GANANCIA").HeaderText = "Función Ganancia"

            dgv_detalle.Columns("DEBE_APER").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("HABER_APER").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("DEBE").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("HABER").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("SALDO_DEUDOR").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("SALDO_ACREEDOR").DefaultCellStyle.Format = "N2"

            dgv_detalle.Columns("INV_ACTIVO").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("INV_PASIVO").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("NATU_PERDIDA").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("NATU_GANANCIA").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("FUNC_PERDIDA").DefaultCellStyle.Format = "N2"
            dgv_detalle.Columns("FUNC_GANANCIA").DefaultCellStyle.Format = "N2"

            'dgv_detalle.Columns("AC_FEC_VOUCHER").DefaultCellStyle.Format = "d"
            dgv_detalle.Columns("DEBE_APER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("HABER_APER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("SALDO_DEUDOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("SALDO_ACREEDOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgv_detalle.Columns("INV_ACTIVO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("INV_PASIVO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("NATU_PERDIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("NATU_GANANCIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("FUNC_PERDIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_detalle.Columns("FUNC_GANANCIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgv_detalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        'For i As Integer = 0 To dgv_detalle.Rows.Count() - 1
        '    If Strings.Len(dgv_detalle.Item(0, i).Value) = 2 Then
        '        dgv_detalle.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
        '        dgv_detalle.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Blue
        '    End If
        'Next

        'dgv_detalle.Update()
    End Sub

    Private Sub dgv_detalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_detalle.CellFormatting
        If Strings.Len(dgv_detalle.Rows(e.RowIndex).Cells("CUENTA").Value) = 2 Then
            dgv_detalle.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightBlue
            dgv_detalle.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_detalle.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Black
        Else
            dgv_detalle.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            dgv_detalle.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.White
        End If

        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            e.CellStyle.BackColor = Color.AliceBlue
        End If
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then
            e.CellStyle.BackColor = Color.AntiqueWhite
        End If
        If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            e.CellStyle.BackColor = Color.Aqua
        End If
        If e.ColumnIndex = 10 Or e.ColumnIndex = 9 Then
            e.CellStyle.BackColor = Color.Aquamarine
        End If

        If e.ColumnIndex = 12 Or e.ColumnIndex = 11 Then
            e.CellStyle.BackColor = Color.Azure
        End If
        If e.ColumnIndex = 14 Or e.ColumnIndex = 13 Then
            e.CellStyle.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Public Sub Sumas()
        If dt_tmp.Rows.Count > 0 Then
            si_debito.Text = Double.Parse(dt_tmp.Compute("sum(DEBE_APER)", "OPCION=1 ").ToString())
            si_credito.Text = Double.Parse(dt_tmp.Compute("sum(HABER_APER)", "OPCION=1 ").ToString())
            mov_debito.Text = Double.Parse(dt_tmp.Compute("sum(DEBE)", "OPCION=1 ").ToString())
            mov_credito.Text = Double.Parse(dt_tmp.Compute("sum(HABER)", "OPCION=1 ").ToString())
            saldo_deudor.Text = Double.Parse(dt_tmp.Compute("sum(SALDO_DEUDOR)", "OPCION=1 ").ToString())
            saldo_acreedor.Text = Double.Parse(dt_tmp.Compute("sum(SALDO_ACREEDOR)", "OPCION=1 ").ToString())
            inv_activo.Text = Double.Parse(dt_tmp.Compute("sum(INV_ACTIVO)", "OPCION=1 ").ToString())
            inv_pasivo.Text = Double.Parse(dt_tmp.Compute("sum(INV_PASIVO)", "OPCION=1 ").ToString())
            natu_perdida.Text = Double.Parse(dt_tmp.Compute("sum(NATU_PERDIDA)", "OPCION=1 ").ToString())
            natu_ganancia.Text = Double.Parse(dt_tmp.Compute("sum(NATU_GANANCIA)", "OPCION=1 ").ToString())
            fun_perdida.Text = Double.Parse(dt_tmp.Compute("sum(FUNC_PERDIDA)", "OPCION=1 ").ToString())
            fun_ganancia.Text = Double.Parse(dt_tmp.Compute("sum(FUNC_GANANCIA)", "OPCION=1 ").ToString())

            si_debito.Text = Format(Double.Parse(si_debito.Text), "##,##0.00")
            si_credito.Text = Format(Double.Parse(si_credito.Text), "##,##0.00")
            mov_debito.Text = Format(Double.Parse(mov_debito.Text), "##,##0.00")
            mov_credito.Text = Format(Double.Parse(mov_credito.Text), "##,##0.00")
            saldo_deudor.Text = Format(Double.Parse(saldo_deudor.Text), "##,##0.00")
            saldo_acreedor.Text = Format(Double.Parse(saldo_acreedor.Text), "##,##0.00")
            inv_activo.Text = Format(Double.Parse(inv_activo.Text), "##,##0.00")
            inv_pasivo.Text = Format(Double.Parse(inv_pasivo.Text), "##,##0.00")
            natu_perdida.Text = Format(Double.Parse(natu_perdida.Text), "##,##0.00")
            natu_ganancia.Text = Format(Double.Parse(natu_ganancia.Text), "##,##0.00")
            fun_perdida.Text = Format(Double.Parse(fun_perdida.Text), "##,##0.00")
            fun_ganancia.Text = Format(Double.Parse(fun_ganancia.Text), "##,##0.00")
            'inventario 2
            If Double.Parse(inv_pasivo.Text) - Double.Parse(inv_activo.Text) > 0 Then
                inv_activo_2.Text = Format(Math.Abs(Double.Parse(inv_pasivo.Text) - Double.Parse(inv_activo.Text)), "##,##0.00")
                inv_activo_2.Visible = True
            Else
                inv_activo_2.Text = ""
                inv_activo_2.Visible = False
            End If
            If Double.Parse(inv_pasivo.Text) - Double.Parse(inv_activo.Text) <= 0 Then
                inv_pasivo_2.Text = Format(Math.Abs(Double.Parse(inv_pasivo.Text) - Double.Parse(inv_activo.Text)), "##,##0.00")
                inv_pasivo_2.Visible = True
            Else
                inv_pasivo_2.Text = ""
                inv_pasivo_2.Visible = False
            End If

            'por naturaleza 2
            If Double.Parse(natu_perdida.Text) - Double.Parse(natu_ganancia.Text) <= 0 Then
                natu_perdida_2.Text = Format(Math.Abs(Double.Parse(natu_perdida.Text) - Double.Parse(natu_ganancia.Text)), "##,##0.00")
                natu_perdida_2.Visible = True
            Else
                natu_perdida_2.Text = ""
                natu_perdida_2.Visible = False
            End If
            If Double.Parse(natu_perdida.Text) - Double.Parse(natu_ganancia.Text) > 0 Then
                natu_ganancia_2.Text = Format(Math.Abs(Double.Parse(natu_perdida.Text) - Double.Parse(natu_ganancia.Text)), "##,##0.00")
                natu_ganancia_2.Visible = True
            Else
                natu_ganancia_2.Text = ""
                natu_ganancia_2.Visible = False
            End If

            'por funcion 2
            If Double.Parse(fun_perdida.Text) - Double.Parse(fun_ganancia.Text) <= 0 Then
                fun_perdida_2.Text = Format(Math.Abs(Double.Parse(fun_perdida.Text) - Double.Parse(fun_ganancia.Text)), "##,##0.00")
                fun_perdida_2.Visible = True
            Else
                fun_perdida_2.Text = ""
                fun_perdida_2.Visible = False
            End If
            If Double.Parse(fun_perdida.Text) - Double.Parse(fun_ganancia.Text) > 0 Then
                fun_ganancia_2.Text = Format(Math.Abs(Double.Parse(fun_perdida.Text) - Double.Parse(fun_ganancia.Text)), "##,##0.00")
                fun_ganancia_2.Visible = True
            Else
                fun_ganancia_2.Text = ""
                fun_ganancia_2.Visible = False
            End If
            'inventario
            If inv_activo_2.Text = "" Then
                inv_activo_3.Text = Format(Double.Parse(inv_activo.Text), "##,##0.00")
            Else
                inv_activo_3.Text = Format(Double.Parse(inv_activo.Text) + Double.Parse(inv_activo_2.Text), "##,##0.00")
            End If
            If inv_pasivo_2.Text = "" Then
                inv_pasivo_3.Text = Format(Double.Parse(inv_pasivo.Text), "##,##0.00")
            Else
                inv_pasivo_3.Text = Format(Double.Parse(inv_pasivo.Text) + Double.Parse(inv_pasivo_2.Text), "##,##0.00")
            End If

            'naturaleza
            If natu_perdida_2.Text = "" Then
                natu_perdida_3.Text = Format(Double.Parse(natu_perdida.Text), "##,##0.00")
            Else
                natu_perdida_3.Text = Format(Double.Parse(natu_perdida.Text) + Double.Parse(natu_perdida_2.Text), "##,##0.00")
            End If
            If natu_ganancia_2.Text = "" Then
                natu_ganancia_3.Text = Format(Double.Parse(natu_ganancia.Text), "##,##0.00")
            Else
                natu_ganancia_3.Text = Format(Double.Parse(natu_ganancia.Text) + Double.Parse(natu_ganancia_2.Text), "##,##0.00")
            End If

            'naturaleza
            If fun_perdida_2.Text = "" Then
                fun_perdida_3.Text = Format(Double.Parse(fun_perdida.Text), "##,##0.00")
            Else
                fun_perdida_3.Text = Format(Double.Parse(fun_perdida.Text) + Double.Parse(fun_perdida_2.Text), "##,##0.00")
            End If
            If fun_ganancia_2.Text = "" Then
                fun_ganancia_3.Text = Format(Double.Parse(fun_ganancia.Text), "##,##0.00")
            Else
                fun_ganancia_3.Text = Format(Double.Parse(fun_ganancia.Text) + Double.Parse(fun_ganancia_2.Text), "##,##0.00")
            End If

        Else
            si_debito.Text = "0"
            si_credito.Text = "0"
            mov_debito.Text = "0"
            mov_credito.Text = "0"
            saldo_deudor.Text = "0"
            saldo_acreedor.Text = "0"
            inv_activo.Text = "0"
            inv_pasivo.Text = "0"
            natu_perdida.Text = "0"
            natu_ganancia.Text = "0"
            fun_perdida.Text = "0"
            fun_ganancia.Text = "0"

            inv_activo_2.Text = "0"
            inv_pasivo_2.Text = "0"
            natu_perdida_2.Text = "0"
            natu_ganancia_2.Text = "0"
            fun_perdida_2.Text = "0"
            fun_ganancia_2.Text = "0"

            inv_activo_3.Text = "0"
            inv_pasivo_3.Text = "0"
            natu_perdida_3.Text = "0"
            natu_ganancia_3.Text = "0"
            fun_perdida_3.Text = "0"
            fun_ganancia_3.Text = "0"
        End If
    End Sub

    Private Sub dgv_detalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle.CellDoubleClick
        If dgv_detalle.RowCount() = 0 Then Exit Sub
        If dgv_detalle.CurrentRow Is Nothing Then Exit Sub

        dgv_detalle.Visible = False
        GroupBox4.Visible = False
        btn_consultar.Enabled = False
        Tool_imprimir.Enabled = False
        btn_regresar.Visible = True
        btn_actualizar.Visible = True
        cargar_detalle_cuenta()

    End Sub
    Public Sub cargar_detalle_cuenta()
        Try
            Cursor = Cursors.WaitCursor
            Dim reporteBL As New ClsOperaciones.ReportesCO

            dt_tmp_detalle = reporteBL.Balance_Comprobacion_Detalle_Cuenta(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, cmb_Moneda.SelectedIndex + 1, IIf(rb_acumulado.Checked, 2, 1), dgv_detalle.CurrentRow.Cells("CUENTA").Value.ToString, dgv_detalle.CurrentRow.Cells("OPCION").Value)

            If dt_tmp_detalle.Rows.Count() <> 0 Then
                dgv_movimiento_cuenta.DataSource = Nothing
                dgv_movimiento_cuenta.DataSource = dt_tmp_detalle
                Formato_Grilla_Detalle()
                Sumas_Detalle()
                dgv_movimiento_cuenta.Focus()
            Else
                MsgBox("No hay informacion para mostrar.", MsgBoxStyle.Information)
                dgv_movimiento_cuenta.DataSource = Nothing
            End If

            dt_tmp_detalle = Nothing
            reporteBL = Nothing

            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub Formato_Grilla_Detalle()

        If dt_tmp_detalle.Rows.Count() <> 0 Then
            '     //formateamos la grilla
            dgv_movimiento_cuenta.Columns("AD_IDCAB").Visible = False
            dgv_movimiento_cuenta.Columns("AD_SECUENCIA").Visible = False
            dgv_movimiento_cuenta.Columns("AC_IDSUBDIARIO").Width = 60
            dgv_movimiento_cuenta.Columns("DESCRIPCION_SUBDIARIO").Width = 120
            dgv_movimiento_cuenta.Columns("AC_NUM_VOUCHER").Width = 70
            dgv_movimiento_cuenta.Columns("AD_CUENTA").Width = 60
            dgv_movimiento_cuenta.Columns("PC_DES_CTA").Width = 150
            dgv_movimiento_cuenta.Columns("DEBITO").Width = 90
            dgv_movimiento_cuenta.Columns("CREDITO").Width = 90
            dgv_movimiento_cuenta.Columns("MONEDA").Width = 70
            dgv_movimiento_cuenta.Columns("AD_TCAM").Width = 60
            dgv_movimiento_cuenta.Columns("AD_GLOSA").Width = 150
            dgv_movimiento_cuenta.Columns("CODIGO_ANEXO").Width = 100
            dgv_movimiento_cuenta.Columns("DESCRIPCIO_ANEXO").Width = 120
            dgv_movimiento_cuenta.Columns("AD_TDOC").Width = 60
            dgv_movimiento_cuenta.Columns("AD_SDOC").Width = 90
            dgv_movimiento_cuenta.Columns("AD_NDOC").Width = 90
            dgv_movimiento_cuenta.Columns("AD_FDOC").Width = 90
            dgv_movimiento_cuenta.Columns("AD_VDOC").Width = 90

            dgv_movimiento_cuenta.Columns("AC_IDSUBDIARIO").HeaderText = "Sub."
            dgv_movimiento_cuenta.Columns("DESCRIPCION_SUBDIARIO").HeaderText = "Des. Sub."
            dgv_movimiento_cuenta.Columns("AC_NUM_VOUCHER").HeaderText = "N° Voucher"
            dgv_movimiento_cuenta.Columns("AD_CUENTA").HeaderText = "Cta. Cont."
            dgv_movimiento_cuenta.Columns("PC_DES_CTA").HeaderText = "Desc. Cta. Cont."
            dgv_movimiento_cuenta.Columns("DEBITO").HeaderText = "Debito"
            dgv_movimiento_cuenta.Columns("CREDITO").HeaderText = "Credito"
            dgv_movimiento_cuenta.Columns("MONEDA").HeaderText = "Mon."
            dgv_movimiento_cuenta.Columns("AD_TCAM").HeaderText = "T.C."
            dgv_movimiento_cuenta.Columns("AD_GLOSA").HeaderText = "Concepto"
            dgv_movimiento_cuenta.Columns("CODIGO_ANEXO").HeaderText = "Codigo"
            dgv_movimiento_cuenta.Columns("DESCRIPCIO_ANEXO").HeaderText = "Razón Social"
            dgv_movimiento_cuenta.Columns("AD_TDOC").HeaderText = "T. Doc."
            dgv_movimiento_cuenta.Columns("AD_SDOC").HeaderText = "Ser."
            dgv_movimiento_cuenta.Columns("AD_NDOC").HeaderText = "Número"
            dgv_movimiento_cuenta.Columns("AD_FDOC").HeaderText = "F. Emisión"
            dgv_movimiento_cuenta.Columns("AD_VDOC").HeaderText = "F. Vcto."

            dgv_movimiento_cuenta.Columns("DEBITO").DefaultCellStyle.Format = "N2"
            dgv_movimiento_cuenta.Columns("CREDITO").DefaultCellStyle.Format = "N2"
            dgv_movimiento_cuenta.Columns("AD_TCAM").DefaultCellStyle.Format = "N3"

            dgv_movimiento_cuenta.Columns("DEBITO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_movimiento_cuenta.Columns("CREDITO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_movimiento_cuenta.Columns("AD_TCAM").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            
            dgv_movimiento_cuenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        dgv_detalle.Visible = True
        GroupBox4.Visible = True
        btn_consultar.Enabled = True
        Tool_imprimir.Enabled = True
        btn_regresar.Visible = False
        btn_actualizar.Visible = False
    End Sub

    Public Sub Sumas_Detalle()
        If dt_tmp_detalle.Rows.Count > 0 Then
            total_mov_debe.Text = Double.Parse(dt_tmp_detalle.Compute("sum(DEBITO)", "AC_IDSUBDIARIO<>'07' ").ToString())
            total_mov_haber.Text = Double.Parse(dt_tmp_detalle.Compute("sum(CREDITO)", "AC_IDSUBDIARIO<>'07' ").ToString())
            total_mov_debe.Text = Format(Double.Parse(total_mov_debe.Text), "##,##0.00")
            total_mov_haber.Text = Format(Double.Parse(total_mov_haber.Text), "##,##0.00")

            total_cuenta_debe.Text = dgv_detalle.CurrentRow.Cells("DEBE").Value
            total_cuenta_haber.Text = dgv_detalle.CurrentRow.Cells("HABER").Value

            total_cuenta_debe.Text = Format(Double.Parse(total_cuenta_debe.Text), "##,##0.00")
            total_cuenta_haber.Text = Format(Double.Parse(total_cuenta_haber.Text), "##,##0.00")

            txt_total_monto_original.Text = "0.00"
            For Each row As DataRow In dt_tmp_detalle.Select("MontoOriginal>0", "")
                txt_total_monto_original.Text = Double.Parse(dt_tmp_detalle.Compute("sum(MontoOriginal)", "").ToString())
                txt_total_monto_original.Text = Format(Double.Parse(txt_total_monto_original.Text), "##,##0.00")
            Next

            
        Else
            total_mov_debe.Text = "0"
            total_mov_haber.Text = "0"
            total_cuenta_debe.Text = "0"
            total_cuenta_haber.Text = "0"
        End If
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If dgv_movimiento_cuenta.CurrentRow Is Nothing Then Exit Sub
        Try
            If MessageBox.Show("Se va a actualizar los movimientos" & vbCrLf & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                Dim monedaBL As New ClsOperaciones.CO_TB_MONEDA
                Dim reporteBL As New ClsOperaciones.ReportesCO
                Dim id_asiento As Integer = 0
                Dim item_asiento As Integer = 0
                Dim cuenta_asiento As String = String.Empty
                Dim consulta As String = String.Empty

                For i As Integer = 0 To dgv_movimiento_cuenta.Rows.Count - 1
                    id_asiento = dgv_movimiento_cuenta.Rows(i).Cells("AD_IDCAB").Value
                    item_asiento = dgv_movimiento_cuenta.Rows(i).Cells("Secuencia").Value
                    cuenta_asiento = dgv_movimiento_cuenta.Rows(i).Cells("AD_CUENTA").Value
                    consulta = "UPDATE dbo.CO_TB_ASIENTO_DET SET AD_CUENTA='" & cuenta_asiento & "' WHERE AD_IDCAB=" & id_asiento & " AND AD_SECUENCIA=" & item_asiento & " "
                    If monedaBL.Ejecuta_consulta(consulta) Then
                        reporteBL.Balance_Comprobacion_Actualizar_Cuenta(id_asiento, item_asiento)
                    End If
                Next
                MsgBox("Actualización exitosa", MsgBoxStyle.Information)
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class