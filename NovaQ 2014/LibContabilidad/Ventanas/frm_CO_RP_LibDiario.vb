Imports System.Windows.Forms
Public Class frm_CO_RP_LibDiario

    Private Sub frm_CO_RP_LibDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Meses_en_Combo(cmb_mes)
        mtb_ayo.Text = gFechaSis.Year
        cmb_mes.SelectedIndex = gFechaSis.Month - 1
        Call Cargar_Subdarios()

        dgv_subdiarios.Columns("SEL").ReadOnly = False
        dgv_subdiarios.Columns("COD").ReadOnly = True
        dgv_subdiarios.Columns("DES").ReadOnly = True

        dgv_subdiarios.Columns("SEL").Width = 50
        dgv_subdiarios.Columns("COD").Width = 60
        dgv_subdiarios.Columns("DES").Width = 220

        chk_todos.Checked = True
    End Sub
    Private Sub Cargar_Subdarios()
        Dim subBL As New ClsOperaciones.CO_TB_SUBDIARIO
        Dim dt_tmp As DataTable = subBL.get_Subdiarios()
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            dgv_subdiarios.Rows.Add(True, dt_tmp.Rows(i)("SD_ID").ToString(), dt_tmp.Rows(i)("SD_DESCRIPCION").ToString())
        Next
        subBL = Nothing
    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click
        'dgv_subdiarios.Refresh()
        'dgv_subdiarios.Update()

        dgv_subdiarios.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgv_subdiarios.RowCount() = 0 Then
            MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
            Exit Sub
        Else

        End If

        Cursor = Cursors.WaitCursor
        Call Grabar_Codigos()
        Call Mostrar_Reporte()
        Cursor = Cursors.Default

    End Sub

    Private Sub Grabar_Codigos()
        Dim fq As New ClsOperaciones.freeQuery
        Dim lista As New List(Of ClsEntidades.CO_TB_CODIGOS_TMP)

        For i As Integer = 0 To dgv_subdiarios.Rows.Count - 1
            If dgv_subdiarios.Rows(i).Cells("SEL").Value Then
                lista.Add(New ClsEntidades.CO_TB_CODIGOS_TMP(dgv_subdiarios.Rows(i).Cells("COD").Value.ToString(), Environment.MachineName))
            End If
        Next
        fq.Insert_Cod_Tmp(lista)

        lista = Nothing
        fq = Nothing

    End Sub

    Public Sub Mostrar_Reporte()
        Dim reporteBL As New ClsOperaciones.ReportesCO
        Dim crystalBL As New LibReportes.ClsReporte
        Dim fq As New ClsOperaciones.freeQuery
        Dim dt_tmp As DataTable = Nothing
        Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
        Dim ruc As String = String.Empty
        Dim razon As String = String.Empty

        If dt_info_emp.Rows.Count > 0 Then
            ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
            razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
        End If

        dt_info_emp = Nothing
        fq = Nothing

        dt_tmp = reporteBL.Libro_Diario(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, Environment.MachineName)

        If rdb_detallado.Checked Then
            crystalBL.Muestra_Reporte("CO_02.RPT", dt_tmp, "", "", "pPeriodo;" & Strings.UCase(cmb_mes.Text) & "-" & mtb_ayo.Text, _
                                      "pRuc;" & ruc, "pRazon;" & razon, "pMensaje;Mensual", "pFecha_Pag;0")
        ElseIf rdb_resumido.Checked Then
            crystalBL.Muestra_Reporte("CO_02_RESUMIDO.RPT", dt_tmp, "", "", "pPeriodo;" & Strings.UCase(cmb_mes.Text) & "-" & mtb_ayo.Text, _
                                      "pRuc;" & ruc, "pRazon;" & razon, "pMensaje;Mensual", "pFecha_Pag;0")
        End If


        dt_tmp = Nothing
        fq = Nothing
        crystalBL = Nothing

    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        For i As Integer = 0 To dgv_subdiarios.Rows.Count - 1
            dgv_subdiarios.Rows(i).Cells("SEL").Value = chk_todos.Checked
        Next
        'dgv_subdiarios.Refresh()
        dgv_subdiarios.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
End Class