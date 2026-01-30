Public Class FrmTipoNumeracion
    Public NumeracionGuiaRemision As String
    Public fl_datos As Boolean = False
    Public Almacen As String = String.Empty
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim clsGuiaRemisionBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim dtguiaRemision As DataTable
    Public TipoNumeracion As String = String.Empty

    Public Modo_edicion As Boolean = False
    Public Numero_edicion As String = ""
    Public Numero_Serie As String = ""

    Private Sub GeneracionCodigoAutomatico()
        Try
            If rbManual.Checked Then
                If txtNumeracionManual.Text = String.Empty Then
                    MsgBox("Debe ingresar una numeracion", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    clsAlmacenBl = New ClsTransacciones.clsAlmacen
                    clsAlmacenBl.Get_NumeroGuiaRemision(Numero_Serie)
                    txtNumeracionManual.Text = clsAlmacenBl.NUMBER_SERIE + String.Format("{0:0000000}", CInt(txtNumeracionManual.Text.Trim))
                    clsGuiaRemisionBl = New ClsOperaciones.WAREHOUSE_TRANS
                    dtguiaRemision = New DataTable
                    dtguiaRemision = clsGuiaRemisionBl.get_VerificacionCodigoGuiaRemision("GS", Almacen, txtNumeracionManual.Text)
                    If dtguiaRemision.Rows.Count() <> 0 Then
                        MsgBox("El correlativo ingresado ya existe.", MsgBoxStyle.Information)
                        fl_datos = False
                        Exit Sub
                    Else
                        NumeracionGuiaRemision = String.Empty
                        TipoNumeracion = String.Empty
                        NumeracionGuiaRemision = txtNumeracionManual.Text
                        TipoNumeracion = "M"
                    End If
                End If
            End If
            If rbAutomatica.Checked Then
                If Modo_edicion Then
                    NumeracionGuiaRemision = String.Empty
                    NumeracionGuiaRemision = Numero_edicion
                    txtNumeracionManual.Text = Numero_edicion
                    TipoNumeracion = "A"
                Else
                    If txtNumeracionManual.Text = String.Empty Then
                        clsAlmacenBl = New ClsTransacciones.clsAlmacen
                        clsAlmacenBl.Get_NumeroGuiaRemision(Numero_Serie)
                        NumeracionGuiaRemision = String.Empty
                        TipoNumeracion = String.Empty
                        NumeracionGuiaRemision = CStr(clsAlmacenBl.NUMBER_SERIE & String.Format("{0:0000000}", CInt(clsAlmacenBl.LAST_NUMBER + 1)))
                        txtNumeracionManual.Text = NumeracionGuiaRemision
                        dtguiaRemision = New DataTable
                        clsGuiaRemisionBl = New ClsOperaciones.WAREHOUSE_TRANS
                        dtguiaRemision = clsGuiaRemisionBl.get_VerificacionCodigoGuiaRemision("GS", Almacen, txtNumeracionManual.Text)
                        If dtguiaRemision.Rows.Count() <> 0 Then
                            MsgBox("El correlativo ingresado ya existe.", MsgBoxStyle.Information)
                            fl_datos = False
                            Exit Sub
                        Else
                            NumeracionGuiaRemision = String.Empty
                            TipoNumeracion = String.Empty
                            NumeracionGuiaRemision = txtNumeracionManual.Text
                            TipoNumeracion = "A"
                        End If

                        'TipoNumeracion = "A"
                    End If
                End If
            End If
            fl_datos = True
        Catch ex As Exception
            fl_datos = False
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptarNumeracion_Click(sender As Object, e As EventArgs) Handles btnAceptarNumeracion.Click
        GeneracionCodigoAutomatico()
        Me.Close()
    End Sub

    Private Sub btnSalirNumeracion_Click(sender As Object, e As EventArgs) Handles btnSalirNumeracion.Click
        'GeneracionCodigoAutomatico()
        fl_datos = False
        Me.Close()
    End Sub
    Private Sub rbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rbManual.CheckedChanged
        If rbManual.Checked Then
            txtNumeracionManual.Enabled = True
            txtNumeracionManual.Text = String.Empty
            txtNumeracionManual.Focus()
        Else
            txtNumeracionManual.Enabled = False
            txtNumeracionManual.Text = String.Empty
            GeneracionCodigoAutomatico()
        End If
    End Sub

    Private Sub FrmTipoNumeracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbAutomatica.Checked = True
        GeneracionCodigoAutomatico()
    End Sub
End Class