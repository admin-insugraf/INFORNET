Imports System.Windows.Forms

Public Class FrmConceptosGenerales

    Private Sub FrmConceptosGenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Cargar_Data()
    End Sub

    Private Sub Cargar_Data()
        Dim parametrosBL As New ClsOperaciones.CO_TB_PARAMETROS_RRHH
        Dim dt_param As DataTable = parametrosBL.getParametros()
        If dt_param.Rows.Count > 0 Then
            txt_asig_familiar.Text = dt_param.Rows(0)("ASIG_FAM").ToString()
            txt_asig_familiar.Text = Format(CDbl(txt_asig_familiar.Text), "##,##0.00")
            txt_fcjmms.Text = dt_param.Rows(0)("FCJMMS").ToString()
            txt_fcjmms.Text = Format(CDbl(txt_fcjmms.Text), "##,##0.00")
            txt_rem_minima_vital.Text = dt_param.Rows(0)("RMV").ToString()
            txt_rem_minima_vital.Text = Format(CDbl(txt_rem_minima_vital.Text), "##,##0.00")
            txt_essalud_vida.Text = dt_param.Rows(0)("ESSALUD_VIDA").ToString()
            txt_essalud_vida.Text = Format(CDbl(txt_essalud_vida.Text), "##,##0.00")
            txt_essalud.Text = dt_param.Rows(0)("ESSALUD").ToString()
            txt_essalud.Text = Format(CDbl(txt_essalud.Text), "##,##0.00")
            txt_aseg_tu_pension.Text = dt_param.Rows(0)("ASEG_PENSION").ToString()
            txt_aseg_tu_pension.Text = Format(CDbl(txt_aseg_tu_pension.Text), "##,##0.00")
            txt_sctr_salud.Text = dt_param.Rows(0)("SCTR_SALUD").ToString()
            txt_sctr_salud.Text = Format(CDbl(txt_sctr_salud.Text), "##,##0.00")
            txt_sctr_pension.Text = dt_param.Rows(0)("SCTR_PENSION").ToString()
            txt_sctr_pension.Text = Format(CDbl(txt_sctr_pension.Text), "##,##0.00")
            txt_vida_ley.Text = dt_param.Rows(0)("VIDA_LEY").ToString()
            txt_vida_ley.Text = Format(CDbl(txt_vida_ley.Text), "##,##0.00")
            txt_senati.Text = dt_param.Rows(0)("SENATI").ToString()
            txt_senati.Text = Format(CDbl(txt_senati.Text), "##,##0.00")
            txt_tope_seguro.Text = dt_param.Rows(0)("TOP_SEG").ToString()
            txt_tope_seguro.Text = Format(CDbl(txt_tope_seguro.Text), "##,##0.00")
            txt_aporte_oblig_afp.Text = dt_param.Rows(0)("APORTE_OBLIG_AFP").ToString()
            txt_aporte_oblig_afp.Text = Format(CDbl(txt_aporte_oblig_afp.Text), "##,##0.00")
            txt_rem_hr_ex_100.Text = dt_param.Rows(0)("REM_HR_100").ToString()
            txt_rem_hr_ex_100.Text = Format(CDbl(txt_rem_hr_ex_100.Text), "##,##0.00")
            txt_costo_h_extra1.Text = dt_param.Rows(0)("COST_H_EXTRA1").ToString()
            txt_costo_h_extra1.Text = Format(CDbl(txt_costo_h_extra1.Text), "##,##0.00")
            txt_costo_h_extra2.Text = dt_param.Rows(0)("COST_H_EXTRA2").ToString()
            txt_costo_h_extra2.Text = Format(CDbl(txt_costo_h_extra2.Text), "##,##0.00")
            txt_afp_mineria.Text = dt_param.Rows(0)("AFP_MINERIA").ToString()
            txt_afp_mineria.Text = Format(CDbl(txt_afp_mineria.Text), "##,##0.00")
            txt_dias_efectivos.Text = dt_param.Rows(0)("DIAS_MES").ToString()
            txt_dias_efectivos.Text = Format(CDbl(txt_dias_efectivos.Text), "##,##0.00")
            txt_domingos_feriados.Text = dt_param.Rows(0)("DOMINGOS_FERIADOS").ToString()
            txt_domingos_feriados.Text = Format(CDbl(txt_domingos_feriados.Text), "##,##0.00")
            txt_horas_efectivas.Text = dt_param.Rows(0)("HORAS_TRABAJADAS").ToString()
            txt_horas_efectivas.Text = Format(CDbl(txt_horas_efectivas.Text), "##,##0.00")
            txt_eps_por.Text = dt_param.Rows(0)("EPS_POR").ToString()
            txt_eps_por.Text = Format(CDbl(txt_eps_por.Text), "##,##0.00")
        End If
        parametrosBL = Nothing
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim parametrosBL As New ClsOperaciones.CO_TB_PARAMETROS_RRHH
            If parametrosBL.Update(txt_asig_familiar.Text, txt_fcjmms.Text, txt_rem_minima_vital.Text, txt_essalud_vida.Text, txt_essalud.Text, txt_aseg_tu_pension.Text, _
                                txt_sctr_salud.Text, txt_sctr_pension.Text, txt_vida_ley.Text, txt_senati.Text, txt_tope_seguro.Text, txt_aporte_oblig_afp.Text, txt_rem_hr_ex_100.Text, _
                                txt_costo_h_extra1.Text, txt_costo_h_extra2.Text, txt_afp_mineria.Text, txt_dias_efectivos.Text, txt_domingos_feriados.Text, txt_horas_efectivas.Text, _
                                txt_eps_por.Text) Then
                MsgBox("Proceso generado correctamente!", MsgBoxStyle.Information, "Sistemas")
                Cargar_Data()
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_cta_detraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sctr_pension.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_igv_cp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fcjmms.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txt_asig_familiar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_asig_familiar.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_rem_minima_vital_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rem_minima_vital.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_essalud_vida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_essalud_vida.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_essalud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_essalud.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_aseg_tu_pension_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_aseg_tu_pension.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_sctr_salud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sctr_salud.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_vida_ley_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_vida_ley.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_senati_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_senati.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_tope_seguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tope_seguro.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_aporte_oblig_afp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_aporte_oblig_afp.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_rem_hr_ex_100_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rem_hr_ex_100.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_costo_h_extra1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costo_h_extra1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_costo_h_extra2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costo_h_extra2.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_afp_mineria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_afp_mineria.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_dias_efectivos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dias_efectivos.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_domingos_feriados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_domingos_feriados.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_horas_efectivas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_horas_efectivas.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_asig_familiar_Leave(sender As Object, e As EventArgs) Handles txt_asig_familiar.Leave
        If txt_asig_familiar.Text.Length = 0 Then
            txt_asig_familiar.Text = "0"
        End If
    End Sub

    Private Sub txt_fcjmms_Leave(sender As Object, e As EventArgs) Handles txt_fcjmms.Leave
        If txt_fcjmms.Text.Length = 0 Then
            txt_fcjmms.Text = "0"
        End If
    End Sub

    Private Sub txt_rem_minima_vital_Leave(sender As Object, e As EventArgs) Handles txt_rem_minima_vital.Leave
        If txt_rem_minima_vital.Text.Length = 0 Then
            txt_rem_minima_vital.Text = "0"
        End If
    End Sub

    Private Sub txt_essalud_vida_Leave(sender As Object, e As EventArgs) Handles txt_essalud_vida.Leave
        If txt_essalud_vida.Text.Length = 0 Then
            txt_essalud_vida.Text = "0"
        End If
    End Sub

    Private Sub txt_essalud_Leave(sender As Object, e As EventArgs) Handles txt_essalud.Leave
        If txt_essalud.Text.Length = 0 Then
            txt_essalud.Text = "0"
        End If
    End Sub

    Private Sub txt_aseg_tu_pension_Leave(sender As Object, e As EventArgs) Handles txt_aseg_tu_pension.Leave
        If txt_aseg_tu_pension.Text.Length = 0 Then
            txt_aseg_tu_pension.Text = "0"
        End If
    End Sub

    Private Sub txt_sctr_salud_Leave(sender As Object, e As EventArgs) Handles txt_sctr_salud.Leave
        If txt_sctr_salud.Text.Length = 0 Then
            txt_sctr_salud.Text = "0"
        End If
    End Sub

    Private Sub txt_sctr_pension_Leave(sender As Object, e As EventArgs) Handles txt_sctr_pension.Leave
        If txt_sctr_pension.Text.Length = 0 Then
            txt_sctr_pension.Text = "0"
        End If
    End Sub

    Private Sub txt_vida_ley_Leave(sender As Object, e As EventArgs) Handles txt_vida_ley.Leave
        If txt_vida_ley.Text.Length = 0 Then
            txt_vida_ley.Text = "0"
        End If
    End Sub

    Private Sub txt_senati_Leave(sender As Object, e As EventArgs) Handles txt_senati.Leave
        If txt_senati.Text.Length = 0 Then
            txt_senati.Text = "0"
        End If
    End Sub

    Private Sub txt_tope_seguro_Leave(sender As Object, e As EventArgs) Handles txt_tope_seguro.Leave
        If txt_tope_seguro.Text.Length = 0 Then
            txt_tope_seguro.Text = "0"
        End If
    End Sub

    Private Sub txt_aporte_oblig_afp_Leave(sender As Object, e As EventArgs) Handles txt_aporte_oblig_afp.Leave
        If txt_aporte_oblig_afp.Text.Length = 0 Then
            txt_aporte_oblig_afp.Text = "0"
        End If
    End Sub

    Private Sub txt_rem_hr_ex_100_Leave(sender As Object, e As EventArgs) Handles txt_rem_hr_ex_100.Leave
        If txt_rem_hr_ex_100.Text.Length = 0 Then
            txt_rem_hr_ex_100.Text = "0"
        End If
    End Sub

    Private Sub txt_costo_h_extra1_Leave(sender As Object, e As EventArgs) Handles txt_costo_h_extra1.Leave
        If txt_costo_h_extra1.Text.Length = 0 Then
            txt_costo_h_extra1.Text = "0"
        End If
    End Sub

    Private Sub txt_costo_h_extra2_Leave(sender As Object, e As EventArgs) Handles txt_costo_h_extra2.Leave
        If txt_costo_h_extra2.Text.Length = 0 Then
            txt_costo_h_extra2.Text = "0"
        End If
    End Sub

    Private Sub txt_afp_mineria_Leave(sender As Object, e As EventArgs) Handles txt_afp_mineria.Leave
        If txt_afp_mineria.Text.Length = 0 Then
            txt_afp_mineria.Text = "0"
        End If
    End Sub

    Private Sub txt_dias_efectivos_Leave(sender As Object, e As EventArgs) Handles txt_dias_efectivos.Leave
        If txt_dias_efectivos.Text.Length = 0 Then
            txt_dias_efectivos.Text = "0"
        End If
    End Sub

    Private Sub txt_domingos_feriados_Leave(sender As Object, e As EventArgs) Handles txt_domingos_feriados.Leave
        If txt_domingos_feriados.Text.Length = 0 Then
            txt_domingos_feriados.Text = "0"
        End If
    End Sub

    Private Sub txt_horas_efectivas_Leave(sender As Object, e As EventArgs) Handles txt_horas_efectivas.Leave
        If txt_horas_efectivas.Text.Length = 0 Then
            txt_horas_efectivas.Text = "0"
        End If
    End Sub

    Private Sub txt_eps_por_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eps_por.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_eps_por_Leave(sender As Object, e As EventArgs) Handles txt_eps_por.Leave
        If txt_eps_por.Text.Length = 0 Then
            txt_eps_por.Text = "0"
        End If
    End Sub
End Class