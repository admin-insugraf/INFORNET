Imports System.Windows.Forms
Public Class frm_CO_RP_Egp

    Private Sub frm_CO_RP_Egp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Meses_en_Combo(cmb_mes)
        mtb_ayo.Text = Date.Now.Year
        cmb_mes.SelectedIndex = Date.Now.Month - 1
        mtb_ayo.Focus()
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click
        Try
            Cursor = Cursors.WaitCursor
            Dim reporteBL As New ClsOperaciones.ReportesCO
            Dim crystalBL As New LibReportes.ClsReporte
            Dim dt_tmp As DataTable = Nothing
            Dim FECHA As String = String.Empty
            FECHA = "01/" & Format(cmb_mes.SelectedIndex + 1, "00") & "/" & mtb_ayo.Text.Trim
            Dim Str_titulo As String = "Del 01 de Enero al " & CDate(ModBas.Ultimo_Dia_Mes(CDate(FECHA))).Day & " de " & cmb_mes.Text & " del " & mtb_ayo.Text.Trim()

            Dim opc As Integer = 1
            Dim opc_letra As String = ""

            If (rb_acu.Checked) Then opc = 1 : opc_letra = rb_acu.Text
            If (rb_acu_com.Checked) Then opc = 2 : opc_letra = rb_acu_com.Text
            If (rb_men.Checked) Then opc = 3 : opc_letra = rb_men.Text
            If (rb_men_acu.Checked) Then opc = 4 : opc_letra = rb_men_acu.Text

            If rdb_funcion.Checked Then
                dt_tmp = reporteBL.get_Reporte_EGP(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, opc)
                Str_titulo = Str_titulo & Chr(13) & " Por Función"
            ElseIf rdb_naturaleza.Checked Then
                dt_tmp = reporteBL.get_Reporte_EGP_Naturaleza(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, opc)
                Str_titulo = Str_titulo & Chr(13) & " Por Naturaleza"
            End If


            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty

            If dt_info_emp.Rows.Count > 0 Then
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            dt_info_emp = Nothing
            fq = Nothing

            Select Case opc
                Case 1, 3
                    crystalBL.Muestra_Reporte("CO_10.RPT", dt_tmp, "", "", "pPeriodo;" & mtb_ayo.Text.Trim(), "pEmpresa;" & razon, "pTitulo1;" & Str_titulo, "pTipo;" & opc_letra)
                Case 2, 4
                    crystalBL.Muestra_Reporte("CO_11.RPT", dt_tmp, "", "", "pPeriodo;" & mtb_ayo.Text.Trim(), "pEmpresa;" & razon, "pTitulo1;" & Str_titulo, "pAyo1;" & mtb_ayo.Text, "pAyo2;" & (Integer.Parse(mtb_ayo.Text) - 1).ToString(), "pTipo;" & opc_letra)
            End Select

            crystalBL = Nothing
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub mtb_ayo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtb_ayo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_mes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rb_acu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rb_acu.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rb_acu_com_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rb_acu_com.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rb_men_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rb_men_acu.KeyPress, rb_men.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
End Class