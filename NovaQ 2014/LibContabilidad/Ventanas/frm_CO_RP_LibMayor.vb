Imports System.Windows.Forms
Public Class frm_CO_RP_LibMayor

    Private Sub frm_CO_RP_LibMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Cargar_Meses_en_Combo(cmb_mes)
        mtb_ayo.Text = Date.Now().Year
        cmb_mes.SelectedIndex = Date.Now().Month - 1
        Call Cargar_Cuentas()

        dgv_cuentas.Columns("SEL").ReadOnly = False
        dgv_cuentas.Columns("COD").ReadOnly = True
        dgv_cuentas.Columns("DES").ReadOnly = True

        dgv_cuentas.Columns("SEL").Width = 50
        dgv_cuentas.Columns("COD").Width = 60
        dgv_cuentas.Columns("DES").Width = 220
        chk_todos.Checked = True
        mtb_ayo.Focus()
    End Sub

    Private Sub Cargar_Cuentas()
        Dim planBL As New ClsOperaciones.CO_TB_PLANCTAS
        Dim dt_cuentas As DataTable = planBL.get_Cuentas_Mov(Integer.Parse(mtb_ayo.Text))

        For i As Integer = 0 To dt_cuentas.Rows.Count - 1
            dgv_cuentas.Rows.Add(True, dt_cuentas.Rows(i)("PC_NUM_CTA").ToString(), dt_cuentas.Rows(i)("PC_DES_CTA").ToString())
        Next

        dt_cuentas = Nothing
        planBL = Nothing

    End Sub

    Private Sub Tool_imprimir_Click(sender As Object, e As EventArgs) Handles Tool_imprimir.Click
        dgv_cuentas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        If dgv_cuentas.RowCount() = 0 Then
            MsgBox("No hay registros para Procesar.", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim estado As Boolean = False
            For Each row As DataGridViewRow In dgv_cuentas.Rows
                If row.Cells(0).Value = True Then
                    estado = True
                    Exit For
                End If
            Next
            If estado = False Then
                MessageBox.Show("Debe seleccionar al menos un item", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dgv_cuentas.Focus()
                Exit Sub
            End If
        End If
        dgv_cuentas.Refresh()
        Cursor = Cursors.WaitCursor
        Call Grabar_Codigos()
        Call Grabar_Saldos()
        Call Grabar_Ctas_Ant_Mes()
        Call Mostrar_Reporte()
        Cursor = Cursors.Default
    End Sub

    Private Sub Tool_salir_Click(sender As Object, e As EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Grabar_Ctas_Ant_Mes()
        Dim fq As New ClsOperaciones.freeQuery
        fq.Grabar_Ctas_Ant_Mes(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, Environment.MachineName)
        fq = Nothing
    End Sub

    Private Sub Grabar_Saldos()
        Dim fq As New ClsOperaciones.freeQuery
        Dim lista As New List(Of String)

        For i As Integer = 0 To dgv_cuentas.Rows.Count - 1
            If dgv_cuentas.Rows(i).Cells("SEL").Value Then
                lista.Add(dgv_cuentas.Rows(i).Cells("COD").Value.ToString())
            End If
        Next

        fq.Insert_Saldos_Cuentas(lista, Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, Environment.MachineName, 1)

        lista = Nothing
        fq = Nothing

    End Sub

    Private Sub Grabar_Codigos()
        Dim fq As New ClsOperaciones.freeQuery
        Dim lista As New List(Of ClsEntidades.CO_TB_CODIGOS_TMP)
        For i As Integer = 0 To dgv_cuentas.Rows.Count - 1
            If dgv_cuentas.Rows(i).Cells("SEL").Value Then
                lista.Add(New ClsEntidades.CO_TB_CODIGOS_TMP(dgv_cuentas.Rows(i).Cells("COD").Value.ToString(), Environment.MachineName))
            End If
        Next
        fq.Insert_Cod_Tmp(lista)
        lista = Nothing
        fq = Nothing
    End Sub

    Private Sub Mostrar_Reporte()
        Try
            Dim reporteBL As New ClsOperaciones.ReportesCO
            Dim crystalBL As New LibReportes.ClsReporte
            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_tmp As DataTable = Nothing
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("NAME").ToString()
            End If
            dt_info_emp = Nothing
            fq = Nothing
            dt_tmp = reporteBL.Libro_Mayor(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, Environment.MachineName)
            If dt_tmp.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("CO_03.RPT", dt_tmp, "", "", "pPeriodo;" & mtb_ayo.Text, "pRuc;" & ruc, "pRazon;" & razon)
            Else
                MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            End If

            dt_tmp = Nothing
            reporteBL = Nothing
            crystalBL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        For i As Integer = 0 To dgv_cuentas.Rows.Count - 1
            dgv_cuentas.Rows(i).Cells("SEL").Value = chk_todos.Checked
        Next
        dgv_cuentas.Refresh()
    End Sub

    Private Sub mtb_ayo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtb_ayo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmb_mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_mes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub
 
End Class
