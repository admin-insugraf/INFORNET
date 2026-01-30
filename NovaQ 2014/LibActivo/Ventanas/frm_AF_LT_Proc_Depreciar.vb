Imports System.Windows.Forms

Public Class frm_AF_LT_Proc_Depreciar

    Private Sub frm_AF_LT_Proc_Depreciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Meses_en_Combo(cmb_mes)
        mtb_fec_proc.Text = LibComunVar.ClsVarComun.FechaSistema
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Procesar_Click(sender As Object, e As EventArgs) Handles Tool_Procesar.Click

        'If cmb_mes.SelectedIndex = 0 Then
        '    MsgBox("Seleccione un mes")
        '    cmb_mes.Focus()
        '    Exit Sub
        'End If
        Me.Cursor = Cursors.WaitCursor

        Dim activoBL As New ClsOperaciones.AF_MA_ACTIVO
        Dim dt_tmp As DataTable = activoBL.get_Listado_04_calc_depre(mtb_fec_proc.Text)

        pb_calculo.Minimum = 0
        pb_calculo.Maximum = dt_tmp.Rows.Count

        activoBL.delete_periodo_depreciacion(nud_anho.Value, cmb_mes.SelectedIndex)

        For Each f As DataRow In dt_tmp.Rows
            activoBL.Calcular_Depreciacion(f.Item("AC_IDACTIVO"), nud_anho.Value, cmb_mes.SelectedIndex)
            pb_calculo.Increment(1)
        Next

        Me.Cursor = Cursors.Default

        MsgBox("Proceso generado correctamente!", MsgBoxStyle.Information, "Sistemas")

        pb_calculo.Value = 0

    End Sub

    Private Sub cmb_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mes.SelectedIndexChanged
        If cmb_mes.SelectedIndex = 0 Then Exit Sub
        mtb_fec_proc.Text = (New DateTime(nud_anho.Value, cmb_mes.SelectedIndex, 1)).AddMonths(1).AddDays(-1).Date
    End Sub

End Class