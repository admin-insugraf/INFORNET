Imports System.Windows.Forms

Public Class frm_CX_LT_Letras

    Private Sub frm_CX_LT_Letras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        gb_cliente.Enabled = True
    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Blokear_Controles()
        txt_cod_ane.Clear()
        txt_des_ane.Clear()
        dgv_letras.Rows.Clear()
        dgv_pendientes.Rows.Clear()
        gb_cliente.Enabled = False
        dgv_letras.Enabled = False
        dgv_pendientes.Enabled = False
    End Sub

    Private Sub Sumar_Marcados()
        Dim total As Double = 0
        Dim con As Integer = 0
        For i As Integer = 0 To dgv_pendientes.Rows.Count - 1
            If dgv_pendientes.Rows(i).Cells("chk_Sel").Value Then
                total += dgv_pendientes.Rows(i).Cells("COL_MONTO_CO").Value
                con += 1
            End If
        Next
        mtb_total_cob.Text = Format(total, "##,###.#0")
        lbl_sel.Text = "Total Seleccionados : " & con
    End Sub

    Private Sub Calcular_Letras()
        Dim num_letras As Integer = dgv_letras.Rows.Count
        Dim total_comprobantes As Double = CDbl(mtb_total_cob.Text)
        Dim monto_letra As Double = Math.Round(total_comprobantes / num_letras, 2)
        Dim fecha_ini As Date = Date.Now
        Dim fecha_var As Date = fecha_ini

        dgv_letras.Rows.Clear()
        For i As Integer = 0 To num_letras - 1
            fecha_var = fecha_var.AddMonths(1)
            If fecha_var.DayOfWeek = DayOfWeek.Sunday Then
                fecha_var = fecha_var.AddDays(1)
            End If
            dgv_letras.Rows.Add()
            dgv_letras.Rows(i).Cells(0).Value = (i + 1).ToString.PadLeft(3, "0")
            dgv_letras.Rows(i).Cells(1).Value = "LT"
            dgv_letras.Rows(i).Cells(2).Value = "0001"
            dgv_letras.Rows(i).Cells(3).Value = monto_letra
            dgv_letras.Rows(i).Cells(4).Value = fecha_var
            dgv_letras.Rows(i).Cells(5).Value = "1"
        Next

        Dim c As Double = 0
        For j As Integer = 0 To dgv_letras.Rows.Count - 1
            c += dgv_letras.Rows(j).Cells("monto").Value
        Next
        mtb_total_letra.Text = Format(c, "##,###.#0")

    End Sub

    Private Sub txt_cod_ane_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cod_ane.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cod_ane.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            'buscamos por ruc
            Dim clienteBL As New ClsOperaciones.CUSTOMER
            Dim clienteBE As New ClsEntidades.CUSTOMER
            clienteBE.ID = txt_cod_ane.Text.Trim
            clienteBL.get_Clientes_x_DocPer(clienteBE)
            If clienteBE.HasRows Then
                txt_des_ane.Text = clienteBE.NAME
                Call Cargar_Documentos_Pendientes()
            Else
                txt_des_ane.Text = "!!Anexeo no Existe!!"
                dgv_pendientes.Rows.Clear()
            End If
            clienteBE = Nothing
            clienteBL = Nothing
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If mtb_total_cob.Text <= 0 Then Exit Sub
        dgv_letras.Rows.Add()
        Call Calcular_Letras()
    End Sub


    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dgv_letras.Rows.Count = 0 Then Exit Sub
        dgv_letras.Rows.RemoveAt(dgv_letras.Rows.Count - 1)
        If dgv_letras.Rows.Count = 0 Then Exit Sub
        Call Calcular_Letras()
    End Sub

    Private Sub Fitrar_grilla()

    End Sub

    Private Sub btn_busca_cli_Click(sender As Object, e As EventArgs) Handles btn_busca_cli.Click
        Dim frm_clientes As New frm_CX_LT_BuscaClientes
        frm_clientes.ShowDialog()
        If frm_clientes.bol_aceptar Then
            txt_cod_ane.Text = frm_clientes.ls_cliente(0)
            txt_des_ane.Text = frm_clientes.ls_cliente(1)
            Call Cargar_Documentos_Pendientes()
        End If
        frm_clientes.Dispose()
    End Sub

    Private Sub Cargar_Documentos_Pendientes()
        Dim saldosBL As New ClsOperaciones.CUSTOMER_BALANCE
        dgv_pendientes.DataSource = saldosBL.get_Documentos_Pendientes_x_Clientes(txt_cod_ane.Text)
        saldosBL = Nothing

        For i As Integer = 0 To dgv_pendientes.RowCount - 1
            dgv_pendientes.Rows(i).Cells("COL_MONTO_CO").Value = dgv_pendientes.Rows(i).Cells("COL_MONTO_SALDO").Value
        Next
        dgv_pendientes.Update()

        lbl_tot.Text = "Total Registros     : " & dgv_pendientes.Rows.Count.ToString
        lbl_sel.Text = "Total Seleccionados : 0"
    End Sub

    Private Sub btn_mostrar_docs_Click(sender As Object, e As EventArgs) Handles btn_mostrar_docs.Click
        Call Cargar_Documentos_Pendientes()
    End Sub

    Private Sub dgv_pendientes_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendientes.CellValidated
        Call Sumar_Marcados()
    End Sub

    Private Sub btn_reg_letras_Click(sender As Object, e As EventArgs) Handles btn_reg_letras.Click

        If txt_cod_ane.Text.Trim = "" Then
            Avisar("Ingrese un codigo de cliente valido")
            btn_busca_cli.Focus()
            Exit Sub
        End If


        If dgv_letras.Rows.Count = 0 Then
            Avisar("Ingrese letras")
            Exit Sub
        End If

        If Val(mtb_total_letra.Text) = 0 Then
            Avisar("No se puede seguir con total dletras cero")
            Exit Sub
        End If



        Dim letraBE As New ClsEntidades.LETTER_EXCHANGE
        Dim letraDetBE As ClsEntidades.LETTER_EXCHANGE_LINE
        Dim letraBL As New ClsOperaciones.LETTER_EXCHANGE
        Dim lista_det As New List(Of ClsEntidades.LETTER_EXCHANGE_LINE)

        With letraBE
            .ID = 0
            .DATE_EXCHANGE = 0
            .VOUCHER_ID = 0
            .CREATE_DATE = 0
            .USER_ID = 0
            .STATUS = 0
            .ACCEPT_DATE = 0
            .SELL_RATE = 0
            .CURRENCY_ID = 0
            .CUSTOMER_ID = 0
        End With

        For i As Integer = 0 To dgv_letras.Rows.Count - 1
            letraDetBE = New ClsEntidades.LETTER_EXCHANGE_LINE
            With letraDetBE
                .ID = dgv_letras.Rows(i).Cells(0).Value
                .ITEM = dgv_letras.Rows(i).Cells(0).Value
                .TYPE_DOC = dgv_letras.Rows(i).Cells(1).Value
                .NUMBER_DOC = dgv_letras.Rows(i).Cells(2).Value
                .AMOUNT = dgv_letras.Rows(i).Cells(3).Value
                .CADUCATE_DATE = dgv_letras.Rows(i).Cells(4).Value
                .IS_ORIG = dgv_letras.Rows(i).Cells(5).Value
            End With
        Next

        letraBL.Insert(letraBE, lista_det, dtTable, "", "", "", "", "")

        MessageBox.Show("Listo!" & Chr(13) & "N° Planilla : " & letraBE.ID, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        lista_det = Nothing
        letraDetBE = Nothing
        letraBE = Nothing
        letraBL = Nothing

        Call Blokear_Controles()
    End Sub
End Class