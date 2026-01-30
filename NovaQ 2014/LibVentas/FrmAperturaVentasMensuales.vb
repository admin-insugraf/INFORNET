Imports System.Windows.Forms
Imports LibCobranzas
Public Class FrmAperturaVentasMensuales


    Private Sub FrmAperturaVentasMensuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaANIO.Value = Date.Now()
        dtpfechaMES.Value = Date.Now()
    End Sub

    Private Sub Generar()
        Try
            Dim CierreVentasBl As New ClsOperaciones.RECEIVABLE
            '00 CONTABILIDAD
            '01 INVENTARIOS
            '02 VENTAS
            '03 COBRANZAS
            '04 COMPRAS
            '05 PAGOS
            '06 PRODUCCION

            Me.Cursor = Cursors.WaitCursor
            CierreVentasBl.GuardarCierre_Ventas(dtpfechaMES.Value.Month.ToString, dtpfechaANIO.Value.Year.ToString, "02", LibComunVar.ClsVarComun.USUARIO.ToString, System.Net.Dns.GetHostName, "APERTURA")
            MsgBox("Apertura de ventas se realizó con exito", MsgBoxStyle.Information, "Aviso")

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_ok_Click_1(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            If MessageBox.Show("Se procedera a abrir los meses seleccionados." & vbCrLf & "¿Desea continuar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Generar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class