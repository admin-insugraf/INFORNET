Imports System.Windows.Forms

Public Class frm_CO_LT_DocsPendientes

    Public str_cuenta As String
    Public str_anexo As String
    Public int_ayo As Integer
    Public aceptar As Boolean = False
    Public lista As New List(Of String)


    Private Sub frm_CO_LT_DocsPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Documentos()
    End Sub

    Private Sub Tool_Aceptar_Click(sender As Object, e As EventArgs) Handles Tool_Aceptar.Click
        aceptar = True
        If dgv_docpen.Rows.Count > 0 Then
            If Not dgv_docpen.CurrentRow Is Nothing Then
                lista.Clear()
                lista.Add(dgv_docpen.CurrentRow.Cells("Tipo_Doc").Value.ToString())
                lista.Add(dgv_docpen.CurrentRow.Cells("Serie_Doc").Value.ToString())
                lista.Add(dgv_docpen.CurrentRow.Cells("Numero_Doc").Value.ToString())
                lista.Add(dgv_docpen.CurrentRow.Cells("Emision").Value.ToString())
                lista.Add(dgv_docpen.CurrentRow.Cells("Vencimiento").Value.ToString())
                lista.Add(dgv_docpen.CurrentRow.Cells("Moneda").Value.ToString())
                lista.Add(dgv_docpen.CurrentRow.Cells("DEBE").Value.ToString())
                lista.Add(dgv_docpen.CurrentRow.Cells("HABER").Value.ToString())
                'lista.Add(dgv_docpen.CurrentRow.Cells("Comprobante").Value.ToString())
            End If
        End If
        Me.Close()
    End Sub


    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        aceptar = False
        Me.Close()
    End Sub

    Public Sub Cargar_Documentos()
        Dim asientoBL As New ClsOperaciones.Asiento_Contable
        Dim dtdetalles As DataTable
        dtdetalles = New DataTable
        dtdetalles = asientoBL.get_Doc_Pendientes(str_cuenta, str_anexo, CInt(int_ayo))
        If dtdetalles.Rows.Count() <> 0 Then
            dgv_docpen.DataSource = dtdetalles
            asientoBL = Nothing

            dgv_docpen.Columns("Tipo_Doc").Width = 60
            dgv_docpen.Columns("Serie_Doc").Width = 100
            dgv_docpen.Columns("Numero_Doc").Width = 120
            dgv_docpen.Columns("Emision").Width = 70
            dgv_docpen.Columns("Vencimiento").Width = 70
            dgv_docpen.Columns("Moneda").Width = 40
            dgv_docpen.Columns("DEBE").Width = 100
            dgv_docpen.Columns("HABER").Width = 100
            dgv_docpen.Columns("DEBE").DefaultCellStyle.Format = "N2"
            dgv_docpen.Columns("HABER").DefaultCellStyle.Format = "N2"
            dgv_docpen.Columns("Comprobante").Width = 100
            dgv_docpen.Columns("Emision").DefaultCellStyle.Format = "d"
            dgv_docpen.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgv_docpen.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Else
            MsgBox("No hay informacion disponible para mostrar.", MsgBoxStyle.Information)
            aceptar = False
            Me.Close()
        End If
    End Sub

    Private Sub dgv_docpen_DoubleClick(sender As Object, e As EventArgs) Handles dgv_docpen.DoubleClick
        Call Tool_Aceptar_Click(sender, e)
    End Sub

    Private Sub frm_CO_LT_DocsPendientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            aceptar = False
            Me.Close()
        End If
    End Sub
End Class