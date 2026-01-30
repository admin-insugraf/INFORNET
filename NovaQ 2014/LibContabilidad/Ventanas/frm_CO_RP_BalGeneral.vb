Imports System.Windows.Forms
Public Class frm_CO_RP_BalGeneral

    Private Sub frm_CO_RP_BalGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Meses_en_Combo(cmb_mes)
        mtb_ayo.Text = Date.Now.Year
        cmb_mes.SelectedIndex = Date.Now.Month - 1
        mtb_ayo.Focus()
    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click

        Dim reporteBL As New ClsOperaciones.ReportesCO
        Dim fq As New ClsOperaciones.freeQuery
        Dim crystalBL As New LibReportes.ClsReporte
        Dim Dt_Rep_BalGen As DataTable = Nothing
        Dim dt_clases As DataTable = Nothing
        Dim dt_grupos As DataTable = Nothing
        Dim Dt_ctas_sobregiro As DataTable = Nothing
        Dim Dt_cuentas As DataTable = Nothing

        Cursor = Cursors.WaitCursor


        Dim periodo As Integer = Integer.Parse(mtb_ayo.Text)
        Dim mes As Integer = (cmb_mes.SelectedIndex + 1)
        Dim Str_Titulo As String = "Estado de Situacion Financiera a " & cmb_mes.Text & " " & mtb_ayo.Text.Trim()
        dt_clases = reporteBL.BG_getClases()
        Dt_ctas_sobregiro = reporteBL.BG_getCuentas10s_sobreGiro(Integer.Parse(mtb_ayo.Text))
        reporteBL.BG_Limpiar_Tabla_Balance_Gral()

        For Each fc As DataRow In dt_clases.Rows
            dt_grupos = reporteBL.BG_getGrupos_x_Clase(Integer.Parse(fc("CBG_ID").ToString()))
            For Each fg As DataRow In dt_grupos.Rows
                Dt_cuentas = reporteBL.BG_getCuentas_x_Grupo(Integer.Parse(fg("GBG_ID").ToString()), periodo)
                For Each fcu As DataRow In Dt_cuentas.Rows
                    reporteBL.BG_setImportes_Balance_Gral(Integer.Parse(fc("CBG_ID").ToString()), Integer.Parse(fg("GBG_ID").ToString()), fcu("PC_NUM_CTA").ToString(), periodo, mes, IIf(rb_mensual.Checked, 1, 0))
                Next
            Next
        Next

        reporteBL.BG_set_Actualiza_Importe_CajaBancos_Cero()
        For Each f As DataRow In Dt_ctas_sobregiro.Rows
            reporteBL.BG_setActualizar_Cta10_SobreGiro(f("PC_NUM_CTA").ToString(), periodo, mes, IIf(rb_acumulado.Checked, 1, 0))
        Next

        reporteBL.BG_set_Actualizar_Resultado_Ejercicio(periodo, mes, "89")
        reporteBL.BG_setActualizar_Importe_PasivoPatrimonio()
        Dt_Rep_BalGen = reporteBL.BG_getBalance_Gral_1()
        Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
        Dim ruc As String = String.Empty
        Dim razon As String = String.Empty
        If dt_info_emp.Rows.Count > 0 Then
            ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
            razon = dt_info_emp.Rows(0)("NAME").ToString()
        End If

        crystalBL.Muestra_Reporte("CO_09.RPT", Dt_Rep_BalGen, "", "", "pTitulo;" + Str_Titulo, "pRuc;" & ruc, "pRazon;" & razon, "pFormato;" & IIf(rb_acumulado.Checked, "Acumulado", "Mensual"))

        dt_info_emp = Nothing
        fq = Nothing
        crystalBL = Nothing

        Cursor = Cursors.Default

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
End Class