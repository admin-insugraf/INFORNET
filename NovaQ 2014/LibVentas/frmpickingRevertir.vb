Imports LibCobranzas

Public Class frmPickingRevertir

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
                sql = "[FACT_SP_S_RECEIVABLE_tipo_picking_revertir]"
                frm.CadenaConsulta = sql
                frm._Flag_Filtro = True
                frm.Filtros1 = ""
                frm.Titulo = "Vendedor"
                frm.ShowDialog()
                If frm.Data_Matriz.Rows.Count > 0 Then
                    txtVendedor.Text = frm.Data_Matriz.Rows(0).Item(0)
                    lblVendedor.Text = frm.Data_Matriz.Rows(0).Item(1)
                End If
                frm.Close()

            Else
                clsFacturaBl = New ClsNegocio.RECEIVABLE
                dtDetalleFact = New DataTable("Vendedor")
                dtDetalleFact = clsFacturaBl.Get_ManualTIPO_REVERTIR_PICKING(_CodigoVendedor)
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
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmPickingRevertir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class