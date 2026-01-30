Imports System.Windows.Forms

Public Class FrmfacturacionTienda_Cantidad
    Public fl_close As Boolean = False
    Public cantidad As Double = 0
    Public tamaño As Double = 0
    Public nueva_cantidad As Double = 0
    Public cantidad_equivalente As Double = 0
    Public factor As Double = 0

    Private Sub txt_cantidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_tamaño_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tamaño.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_factor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_factor.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_total_cantidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_total_cantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub FrmfacturacionTienda_Cantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_factor.Text = factor
        txt_factor.Text = Format(Double.Parse(txt_factor.Text), "##,##0.00")
        txt_cantidad.Select()
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_tamaño.Select()
        End If
    End Sub

    Private Sub txt_tamaño_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_tamaño.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cantidad.Text <> "" And txt_tamaño.Text <> "" Then
                txt_nueva_cantidad.Text = Math.Round(CDbl(txt_cantidad.Text) * CDbl(txt_tamaño.Text), 2)
                txt_nueva_cantidad.Text = Format(Double.Parse(txt_nueva_cantidad.Text), "##,##0.00")
            End If
            txt_factor.Select()
        End If
    End Sub

    Private Sub txt_factor_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_factor.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txt_cantidad.Text <> "" And txt_tamaño.Text <> "" And txt_factor.Text <> "" Then
                txt_total_cantidad.Text = Math.Round((CDbl(txt_cantidad.Text) * CDbl(txt_tamaño.Text)) / CDbl(txt_factor.Text), 2)
                txt_total_cantidad.Text = Format(Double.Parse(txt_total_cantidad.Text), "##,##0.00")
            End If

            txt_total_cantidad.Select()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        fl_close = True
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        cantidad = CDbl(txt_cantidad.Text)
        tamaño = CDbl(txt_tamaño.Text)
        nueva_cantidad = CDbl(txt_nueva_cantidad.Text)
        cantidad_equivalente = CDbl(txt_total_cantidad.Text)
        Me.Close()
    End Sub

    Private Sub txt_total_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_total_cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
End Class