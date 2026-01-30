Imports LibCobranzas
Public Class FrmTipoNumeracionRapido
    Public NumeracionGuiaRemision As String
    Public NumeracionFactura As String
    Public NumeracionFacturaNotaC As String
    Public NumeracionFacturaNotaD As String
    Public NumeracionFacturaCP As String
    Public NumeracionGeneral As String

    Public fl_datos As Boolean = False
    Public Almacen As String = String.Empty
    Public Serie As String = String.Empty
    Dim clsAlmacenBl As ClsTransacciones.clsAlmacen
    Dim clsGuiaRemisionBl As ClsOperaciones.WAREHOUSE_TRANS
    Dim dtdetalles As DataTable
    Public TipoNumeracion As String = String.Empty
    Public TipoDocumento As String = String.Empty
    Public Modo_edicion As Boolean = False
    Public Numero_edicion As String = ""
    Private Sub FrmTipoNumeracionRapido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TipoDocumento = "PF" Then
            GroupBox5.Visible = True
        Else
            If LibComunVar.ClsVarComun.MODIFICA_NUMERACION_FACT = "SI" Then
                GroupBox5.Visible = True
            Else
                GroupBox5.Visible = False
            End If
        End If
        
        rbAutomatica.Checked = True
        GeneracionCodigoAutomatico()
        btnAceptarNumeracion.Select()
    End Sub

    Private Function GeneracionCodigoAutomatico() As Boolean
        Dim estado As Boolean = True
        Try
            If rbManual.Checked Then
                If Trim(txtNumeracionManual.Text) = String.Empty Then
                    MsgBox("Debe ingresar una numeración", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                Else
                    txtNumeracionManual.Text = String.Format("{0:0000000}", CInt(txtNumeracionManual.Text.Trim))
                    clsGuiaRemisionBl = New ClsOperaciones.WAREHOUSE_TRANS
                    dtdetalles = New DataTable("Documentos")
                    dtdetalles = clsGuiaRemisionBl.get_VerificacionCodigoGuiaRemision(TipoDocumento, Almacen, Serie + txtNumeracionManual.Text)
                    If dtdetalles.Rows.Count() <> 0 Then
                        MsgBox("El correlativo ingresado ya existe.", MsgBoxStyle.Critical)
                        fl_datos = False
                        estado = False
                        Exit Try
                    Else
                        NumeracionGeneral = String.Empty
                        TipoNumeracion = String.Empty
                        NumeracionGeneral = Serie + txtNumeracionManual.Text
                        TipoNumeracion = "M"
                    End If
                End If
            End If
            If rbAutomatica.Checked Then
                If Modo_edicion Then
                    NumeracionGeneral = String.Empty
                    NumeracionGeneral = Numero_edicion
                    txtNumeracionManual.Text = Numero_edicion
                Else
                    If txtNumeracionManual.Text = String.Empty Then
                        clsAlmacenBl = New ClsTransacciones.clsAlmacen
                        clsAlmacenBl.Get_NumeroGuiaRemision(Serie, TipoDocumento)
                        'If clsAlmacenBl.MODIFICA_CORRELATIVO = "S" Then
                        '    GroupBox5.Visible = True
                        'Else
                        '    GroupBox5.Visible = False
                        'End If
                        NumeracionGeneral = String.Empty
                        TipoNumeracion = String.Empty
                        NumeracionGeneral = CStr(clsAlmacenBl.NUMBER_SERIE & String.Format("{0:0000000}", CInt(clsAlmacenBl.LAST_NUMBER + 1)))
                        txtNumeracionManual.Text = NumeracionGeneral
                        TipoNumeracion = "A"

                    End If
                End If
            End If
            fl_datos = True
        Catch ex As Exception
            fl_datos = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnAceptarNumeracion_Click(sender As Object, e As EventArgs) Handles btnAceptarNumeracion.Click
        If GeneracionCodigoAutomatico() = False Then
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub btnSalirNumeracion_Click(sender As Object, e As EventArgs) Handles btnSalirNumeracion.Click
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

End Class