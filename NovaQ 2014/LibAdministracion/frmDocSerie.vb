Imports System.Windows.Forms
Public Class frmDocSerie
    Private STRTipoDoc As String
    Private STRNumSerie As String

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        STRTipoDoc = String.Empty
        STRNumSerie = String.Empty
    End Sub

    Public Property TipoDoc As String
        Get
            Return STRTipoDoc
        End Get
        Set(value As String)
            STRTipoDoc = value
        End Set
    End Property

    Public Property NumSerie As String
        Get
            Return STRNumSerie
        End Get
        Set(value As String)
            STRNumSerie = value
        End Set
    End Property

    Private Sub tSalir_Click(sender As Object, e As EventArgs) Handles tSalir.Click
        Me.Close()
    End Sub

    Private Sub txtSerieDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerieDoc.KeyPress
        'ModFunciones.OnlyNum(e, txtSerieDoc)
        If e.KeyChar = ChrW(Keys.Enter) Then tAceptar.Select()
    End Sub

    Private Sub tAceptar_Click(sender As Object, e As EventArgs) Handles tAceptar.Click
        If txtTipoDoc.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar el tipo de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTipoDoc.Focus()
            Exit Sub
        ElseIf txtSerieDoc.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar la serie del documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSerieDoc.Focus()
            Exit Sub
        End If
        TipoDoc = txtTipoDoc.Text.Trim
        STRNumSerie = txtSerieDoc.Text.Trim
        Me.Close()
    End Sub

    Private Sub txtTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoDoc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then txtSerieDoc.Focus()
    End Sub

    Private Sub txtTipoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipoDoc.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Tipo_Doc()
        End If
    End Sub
    Private Sub Ayuda_Tipo_Doc()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ADM_SP_S_TIPO_DOC"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = False
            frm.Titulo = "Tipos de Documentos"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtTipoDoc.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtSerieDoc.Text = frm.Data_Matriz.Rows(0).Item(2).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtTipoDoc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtTipoDoc.MouseDoubleClick
        Ayuda_Tipo_Doc()
    End Sub
End Class