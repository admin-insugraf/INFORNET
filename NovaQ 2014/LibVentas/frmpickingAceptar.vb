Imports LibCobranzas
Imports System.Windows.Forms

Public Class frmPickingAceptar
    Private clsFacturaBl As ClsNegocio.RECEIVABLE
    Dim dtDetalleFact As DataTable
    Private Sub txtVendedor_DoubleClick(sender As Object, e As EventArgs) Handles txtVendedor.DoubleClick
        Ayuda_Vendedor()
    End Sub

    Private Sub Ayuda_Vendedor(Optional ByVal _CodigoVendedor As String = "")
        Try
            If _CodigoVendedor = String.Empty Then
                Dim frm As New frmBuscar
                Dim sql As String = String.Empty
                sql = "[PUR_SP_S_USUARIOS_PICKING]"
                frm.CadenaConsulta = sql
                frm.Titulo = "Lista de Trabajadores"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtVendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    lblVendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()

            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Vendedor")
                dtDetalleFact = clsFacturaBl.Get_ManualEMPLOYEELOGISTICA(_CodigoVendedor)
                If dtDetalleFact.Rows.Count() <> 0 Then
                    txtVendedor.Text = dtDetalleFact.Rows(0).Item(0)
                    lblVendedor.Text = dtDetalleFact.Rows(0).Item(1)
                Else
                    MsgBox("No hay informacion con el codigo especificado.", MsgBoxStyle.Critical)
                    txtVendedor.Text = String.Empty
                    lblVendedor.Text = String.Empty
                    txtVendedor.Select()
                    Exit Sub
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Supongamos que el DateTimePicker se llama DateTimePicker1
        Dim horaSeleccionada As TimeSpan = dtpHoraRecepcion.Value.TimeOfDay

        ' Comprobar si la hora es 00:00:00 (inicio del día)
        If horaSeleccionada = TimeSpan.Zero Then
            MessageBox.Show("Por favor, seleccione una hora válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Opcional: enfocar el control
            dtpHoraRecepcion.Focus()
        Else
            ' La hora es válida
            'MessageBox.Show("Hora seleccionada: " & horaSeleccionada.ToString())
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    
End Class