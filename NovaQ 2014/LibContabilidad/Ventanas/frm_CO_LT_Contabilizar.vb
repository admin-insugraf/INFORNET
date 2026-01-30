Imports System.Windows.Forms

Public Class frm_CO_LT_Contabilizar

    Private Sub frm_CO_LT_Contabilizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Meses_en_Combo(cmb_mes)
        mtb_ayo.Text = Date.Now.Year
        mtb_fecha.Text = Date.Now
        gb_caja.Enabled = False
    End Sub

    Private Sub btn_Conta_Click(sender As Object, e As EventArgs) Handles btn_Conta.Click
        If Not mtb_fecha.MaskFull Then
            MessageBox.Show("Ingrese la fecha del asiento", "Cuidado")
            mtb_fecha.Focus()
            Exit Sub
        End If

        Dim mensaje As String = ""
        Dim operacion As String = ""

        If rb_compras.Checked Then operacion = "Compras"
        If rb_ventas.Checked Then operacion = "Ventas"
        If rb_caja.Checked Then operacion = "Caja"
        If rb_hono.Checked Then operacion = "Honorarios"

        mensaje = "Seguro de Contabilizar el asiento de " & operacion & " con fecha : " & mtb_fecha.Text
        If MessageBox.Show(mensaje, "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim ac As New ClsOperaciones.Asiento_Contable

            If rb_ventas.Checked Then ac.Contabilizar_Ventas(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, mtb_fecha.Text)
            If rb_compras.Checked Then ac.Contabilizar_Compras(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, mtb_fecha.Text)
            If rb_hono.Checked Then ac.Contabilizar_Honorarios(Integer.Parse(mtb_ayo.Text), cmb_mes.SelectedIndex + 1, mtb_fecha.Text)
            If rb_caja.Checked Then
                If rb_caja_ing.Checked Then
                    ac.Contabilizar_Caja_Ingresos(mtb_fec_des.Text, mtb_fec_has.Text, DateTime.Parse(mtb_fecha.Text))
                End If
                If rb_caja_egr.Checked Then
                    ac.Contabilizar_Caja_Egresos(mtb_fec_des.Text, mtb_fec_has.Text, DateTime.Parse(mtb_fecha.Text))
                End If
            End If

            MessageBox.Show("Listo!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ac = Nothing

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error : " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try



    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub cmb_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mes.SelectedIndexChanged
        mtb_fecha.Text = ""
    End Sub

    Private Sub mtb_fecha_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub rb_caja_CheckedChanged(sender As Object, e As EventArgs) Handles rb_caja.CheckedChanged
        gb_caja.Enabled = rb_caja.Checked
    End Sub

    Private Sub mtb_fec_des_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fec_has.Focus()
        End If
    End Sub

    Private Sub mtb_fec_has_KeyDown(sender As Object, e As KeyEventArgs) Handles mtb_fec_has.KeyDown
        If e.KeyCode = Keys.Enter Then
            mtb_fecha.Focus()
        End If
    End Sub
End Class