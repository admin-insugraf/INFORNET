Imports System.Windows.Forms

Public Class frm_CO_MA_Parametros


    Private Sub Ayuda_CuentasContables(ByVal CajaTexto As TextBox)
        Try
            Dim frm As frmBuscar
            frm = New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_CUENTA_CONTABLE"
            frm.CadenaConsulta = sql
            frm.Titulo = "Cuentas Contables"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                CajaTexto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frm_CO_MA_Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim parametrosBL As New ClsOperaciones.CO_TB_PARAMETROS
        Dim dt_param As DataTable = parametrosBL.getParametros()
        If dt_param.Rows.Count > 0 Then
            txt_igv.Text = dt_param.Rows(0)("CTA_IGV").ToString()
            txt_dif_gan.Text = dt_param.Rows(0)("CTA_DIF_GAN").ToString()
            txt_dif_per.Text = dt_param.Rows(0)("CTA_DIF_PER").ToString()
            txt_ret_hono.Text = dt_param.Rows(0)("CTA_RETEN_RH").ToString()
            txt_base_rh.Text = dt_param.Rows(0)("CTA_BASE_HONO").ToString()
            txt_cta_isc.Text = dt_param.Rows(0)("CTA_ISC").ToString()
            txt_cta_detraccion.Text = dt_param.Rows(0)("CTA_DETRACCION").ToString()
            txt_igv_cp.Text = dt_param.Rows(0)("CTA_IGV_CP").ToString()
            txt_cta_cobranza_contado.Text = dt_param.Rows(0)("CTA_COB_CONTADO").ToString()

            txt_igv_ret.Text = dt_param.Rows(0)("CTA_IGV_RET").ToString()
            txt_cta_42_soles.Text = dt_param.Rows(0)("CTA_42_MN_COMPRAS").ToString()
            txt_cta_42_dolares.Text = dt_param.Rows(0)("CTA_42_ME_COMPRAS").ToString()

        End If
        parametrosBL = Nothing
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click
        Try
            Dim parametrosBL As New ClsOperaciones.CO_TB_PARAMETROS
            Me.Cursor = Cursors.WaitCursor
            If parametrosBL.Update(txt_igv.Text.Trim(), txt_dif_gan.Text.Trim(), txt_dif_per.Text.Trim(),
                                    txt_ret_hono.Text.Trim(), txt_base_rh.Text.Trim(), txt_cta_isc.Text.Trim(),
                                    txt_cta_detraccion.Text.Trim(), txt_igv_cp.Text.Trim(), txt_cta_cobranza_contado.Text.Trim(),
                                    txt_igv_ret.Text.Trim(), txt_cta_42_soles.Text.Trim(), txt_cta_42_dolares.Text.Trim()) Then
                parametrosBL = Nothing
                MessageBox.Show("Proceso generado correctamente!", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
 
    Private Sub txt_igv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_igv.MouseDoubleClick
        Ayuda_CuentasContables(txt_igv)
    End Sub

    Private Sub txt_igv_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_igv.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_igv)
        End If
    End Sub

    Private Sub txt_dif_gan_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dif_gan.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_dif_gan)
        End If
    End Sub

    Private Sub txt_dif_gan_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_dif_gan.MouseDoubleClick
        Ayuda_CuentasContables(txt_dif_gan)
    End Sub

    Private Sub txt_dif_per_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_dif_per.MouseDoubleClick
        Ayuda_CuentasContables(txt_dif_per)
    End Sub

    Private Sub txt_dif_per_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dif_per.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_dif_per)
        End If
    End Sub

    Private Sub txt_ret_hono_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_ret_hono.MouseDoubleClick
        Ayuda_CuentasContables(txt_ret_hono)
    End Sub

    Private Sub txt_ret_hono_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ret_hono.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_ret_hono)
        End If
    End Sub

    Private Sub txt_base_rh_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_base_rh.MouseDoubleClick
        Ayuda_CuentasContables(txt_base_rh)
    End Sub

    Private Sub txt_base_rh_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_base_rh.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_base_rh)
        End If
    End Sub

    Private Sub txt_cta_isc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_isc.MouseDoubleClick
        Ayuda_CuentasContables(txt_cta_isc)
    End Sub

    Private Sub txt_cta_isc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_isc.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cta_isc)
        End If
    End Sub

    Private Sub frm_CO_MA_Parametros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ret_hono.KeyPress, txt_igv.KeyPress, txt_dif_per.KeyPress, txt_dif_gan.KeyPress, txt_cta_isc.KeyPress, txt_base_rh.KeyPress, MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cta_detraccion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_detraccion.MouseDoubleClick
        Ayuda_CuentasContables(txt_cta_detraccion)
    End Sub

    Private Sub txt_cta_detraccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_detraccion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cta_detraccion)
        End If
    End Sub

    Private Sub txt_cta_detraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cta_detraccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_igv_cp_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_igv_cp.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_igv_cp)
        End If
    End Sub

    Private Sub txt_igv_cp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_igv_cp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_igv_cp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_igv_cp.MouseDoubleClick
        Ayuda_CuentasContables(txt_igv_cp)
    End Sub

    Private Sub txt_cta_cobranza_contado_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_cobranza_contado.MouseDoubleClick
        Ayuda_CuentasContables(txt_cta_cobranza_contado)
    End Sub

    Private Sub txt_cta_cobranza_contado_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_cobranza_contado.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cta_cobranza_contado)
        End If
    End Sub

    Private Sub txt_igv_ret_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_igv_ret.MouseDoubleClick
        Ayuda_CuentasContables(txt_igv_ret)
    End Sub

    Private Sub txt_igv_ret_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_igv_ret.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_igv_ret)
        End If
    End Sub

    Private Sub txt_igv_ret_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_igv_ret.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txt_cta_42_soles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_42_soles.MouseDoubleClick
        Ayuda_CuentasContables(txt_cta_42_soles)
    End Sub

    Private Sub txt_cta_42_dolares_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cta_42_dolares.MouseDoubleClick
        Ayuda_CuentasContables(txt_cta_42_dolares)
    End Sub

    Private Sub txt_cta_42_soles_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_42_soles.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cta_42_soles)
        End If
    End Sub

    Private Sub txt_cta_42_dolares_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cta_42_dolares.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_CuentasContables(txt_cta_42_dolares)
        End If
    End Sub
End Class