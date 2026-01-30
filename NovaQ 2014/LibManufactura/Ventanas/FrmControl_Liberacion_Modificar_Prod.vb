Imports LibCobranzas
Imports System.Windows.Forms
Imports LibComunVar
Public Class FrmControl_Liberacion_Modificar_Prod
    Public dtdetalleArticulo As DataTable
    Public TipoArticulo As String = String.Empty
    Public flag_modif As Integer
 
    Private Sub FrmControl_Liberacion_Modificar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BLANK()
        If TipoArticulo = "MP" Then
            gbcomentario.Enabled = False
            txtcomentarios.BackColor = Drawing.Color.White
            txtcomentarios.ForeColor = Drawing.Color.Black
            txtvaloracion.BackColor = Drawing.Color.Aquamarine
            txtvaloracion.ForeColor = Drawing.Color.Black
            txtvaloracion.Select()
        ElseIf TipoArticulo = "ME" Then
            gbcomentario.Enabled = True
            txtvaloracion.Enabled = False
            txtcomentarios.BackColor = Drawing.Color.Aquamarine
            txtcomentarios.ForeColor = Drawing.Color.Black
            txtvaloracion.BackColor = Drawing.Color.White
            txtvaloracion.ForeColor = Drawing.Color.Black
            txtcomentarios.Select()
        End If
    End Sub
    
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        flag_modif = 0
        'FrmControl_Liberacion.flag_modificacion = 0
        Me.Close()
    End Sub

    Private Sub txtvaloracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvaloracion.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then btnAceptar.PerformClick()
    End Sub

    Public Sub BLANK()
        'txtcodigoArticulo.Text = String.Empty
        'txtdescripcionArticulo.Text = String.Empty
        'txtunidadMedida.Text = String.Empty
        'txtlote.Text = String.Empty
        'dtpFechaVencimiento.Value = Date.Now
        'txtnumeroProtocolo.Text = ""
        'txtcantidad.Text = ""
        'txtnumerobultos.Text = ""
        'txtnumanalisis.Text = ""
        txtvaloracion.Text = ""
        txtcomentarios.Text = String.Empty
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            GenerarColummnaDataTable()
            'Agregando los datos a devolver
            Dim row As DataRow = dtdetalleArticulo.NewRow

            row("CODIGO") = txtcodigoArticulo.Text
            row("DESCRIPCION") = txtdescripcionArticulo.Text
            row("UNIDAD") = txtunidadMedida.Text
            row("LOTE") = txtlote.Text
            row("FECHA_VENCIMIENTO") = dtpFechaVencimiento.Value.ToString("MMMM-yyyy")
            row("NUMERO_PROTOCOLO") = IIf(txtnumeroProtocolo.Text = String.Empty, 0, txtnumeroProtocolo.Text)
            row("CANTIDAD") = txtcantidad.Text
            row("NUMERO_BULTOS") = IIf(txtnumerobultos.Text = String.Empty, "", txtnumerobultos.Text)
            row("VALORACION") = IIf(txtvaloracion.Text = String.Empty, 0, txtvaloracion.Text)
            row("OPT_ENTREGA") = IIf(rbfinal.Checked = True, "Final", "Parcial")
            row("NUMERO_ANALISIS") = txtnumanalisis.Text
            row("COMENTARIO") = txtcomentarios.Text
            dtdetalleArticulo.Rows.Add(row)
            dtdetalleArticulo.AcceptChanges()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticulo = New DataTable
            dtdetalleArticulo.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("UNIDAD", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("LOTE", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("FECHA_VENCIMIENTO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUMERO_PROTOCOLO", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("NUMERO_BULTOS", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("VALORACION", Type.GetType("System.Double"))
            dtdetalleArticulo.Columns.Add("OPT_ENTREGA", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("NUMERO_ANALISIS", Type.GetType("System.String"))
            dtdetalleArticulo.Columns.Add("COMENTARIO", Type.GetType("System.String"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        ' FrmControl_Liberacion.flag_modificacion = 0
        Me.Close()
    End Sub

 
End Class