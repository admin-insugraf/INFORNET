Public Class ToolbarComon
    Public Event NuevoClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EditarClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EliminarClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event GrabarClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event CancelarClick(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub ActivaEdicion(estado As Boolean)
        Me.Tool_Nuevo.Enabled = Not estado
        Me.Tool_Editar.Enabled = Not estado
        Me.Tool_Eliminar.Enabled = Not estado
        Me.Tool_Grabar.Enabled = estado
        Me.Tool_Cancelar.Enabled = estado
    End Sub

    Private Sub Tool_Nuevo_Click(sender As Object, e As EventArgs) Handles Tool_Nuevo.Click
        ActivaEdicion(True)
        RaiseEvent NuevoClick(Me, e)
    End Sub

    Private Sub Tool_Editar_Click(sender As Object, e As EventArgs) Handles Tool_Editar.Click
        ActivaEdicion(True)
        RaiseEvent EditarClick(True, e)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As Object, e As EventArgs) Handles Tool_Eliminar.Click
        If MessageBox.Show("Se va a eliminar el registro\n¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RaiseEvent EliminarClick(Me, e)
        End If
    End Sub

    Private Sub Tool_Grabar_Click(sender As Object, e As EventArgs) Handles Tool_Grabar.Click
        RaiseEvent GrabarClick(Me, e)
        ActivaEdicion(False)
    End Sub

    Private Sub Tool_Cancelar_Click(sender As Object, e As EventArgs) Handles Tool_Cancelar.Click
        RaiseEvent CancelarClick(Me, e)
        ActivaEdicion(False)
    End Sub
End Class
