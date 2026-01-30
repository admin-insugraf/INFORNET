Imports System.Windows.Forms
Imports LibComunVar
Imports LibReportes
Imports System.Drawing
Public Class FrmRepVentasxVendedor
    Public opcion As String = String.Empty
    Public dt_tmp As DataTable
    Public dtDatosCompany As DataTable
    Private Sub FrmRepVentasxVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaInicio.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFin.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        MostrandoTipoDocumentos()
        dtpfechaInicio.Select()
    End Sub

    Private Sub MostrandoTipoDocumentos()
        Try
            chklstDocumentos.Items.Clear()
            Dim Documentos(5) As String
            Documentos(0) = "BV:BOLETA DE VENTA"
            Documentos(1) = "CP:COMPROBANTE DE PERCEPCION"
            Documentos(2) = "FT:FACTURA DE VENTA"
            Documentos(3) = "NC:NOTA DE CREDITO"
            Documentos(4) = "ND:NOTA DE DEBITO"
            Documentos(5) = "PF:PROFORMAS"
            For i As Integer = 0 To Documentos.Count() - 1
                chklstDocumentos.Items.Add(Documentos(i))
            Next
            chklstDocumentos.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim Ref_fecIni As String = String.Empty
        Dim Ref_fecFin As String = String.Empty
        Dim Ref_vendedor As String = String.Empty

        ' ---Validaciones generales
        If ValidacionesReporte(Ref_fecIni, Ref_fecFin, Ref_vendedor) = False Then Exit Sub
        ' -----Mostrando el Reporte
        MostrarReporte(Ref_fecIni, Ref_fecFin, Ref_vendedor)
    End Sub



    Private Sub MostrarReporte(ByRef _fechaInicial As String, ByRef _fechaFinal As String, _
                               ByRef _TipoVendedor As String)

        Dim reporteBL As New ClsReporteGenerales.ReportesGerenciales
        Dim crystalBL As New LibReportes.ClsReporte
        Dim NombreStore As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim idTipoDoc As String = String.Empty
            Dim i As Integer = 0
            Do While i <= chklstDocumentos.CheckedItems.Count - 1
                idTipoDoc = idTipoDoc & """" & TraerCodigo(chklstDocumentos.CheckedItems(i)) & """" & ","
                i = i + 1
            Loop
            If idTipoDoc.Length() <> 0 Then
                idTipoDoc = Mid(idTipoDoc, 1, idTipoDoc.Length - 1)
            End If
            dtDatosCompany = reporteBL.Obtener_Datos_Empresa()
            NombreStore = "SP_REP_VENTAS_VENDEDOR"
            dt_tmp = New DataTable
            dt_tmp = reporteBL.Get_ImprimirRepVentas_Vendedor(NombreStore, _fechaInicial, _fechaFinal, idTipoDoc, _TipoVendedor)
            If dt_tmp.Rows.Count() <> 0 Then
                ' crystalBL.Muestra_Reporte("rpt_registro_ventas.rpt", dt_tmp, "", "", "@FECHA_INICIAL;" & _fechaInicial, "@FECHA_FINAL;" & _fechaFinal, "@PERIODO;" & dtpfechaInicio.Value.ToString("MMMM - yyyy").ToUpper, "@TIPOS_DOC;" & idTipoDoc)
                crystalBL.Muestra_Reporte("rpt_rep_ventas_vendedor.rpt", "", "", "", "@FECHINI;" & _fechaInicial, "@FECHFIN;" & _fechaFinal, "@TIPOS_DOC;" & idTipoDoc, "@VENDEDOR;" & _TipoVendedor, "EMPRESA;" & dtDatosCompany.Rows(0).Item("REPORT_SCREEN").ToString)
            Else
                MsgBox("No hay informacion disponible para Mostrar en el Reporte", MsgBoxStyle.Information)
            End If
                
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try

        crystalBL = Nothing
        reporteBL = Nothing
    End Sub

    Private Function ValidacionesReporte(ByRef fecha_Inicial As String, ByRef fecha_Final As String, _
                                  ByRef tipo_vendedor As String) As Boolean

        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaInicio.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechaFin.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaInicio.Focus()
                estado = False
                Exit Try
            End If
            '--
            fecha_Inicial = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            fecha_Final = dtpfechaFin.Value.ToString("dd/MM/yyyy")
            ' -------------
            If CheckBox1.Checked = False Then
                If txtclienteInicial.Text = "" Then
                    MessageBox.Show("Debe elegir un Vendedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtclienteInicial.Focus()
                    estado = False
                    Exit Try
                Else
                    tipo_vendedor = txtclienteInicial.Text
                End If
            Else
                tipo_vendedor = "TODOS"
            End If
            

            If chklstDocumentos.CheckedItems.Count = 0 Then
                MessageBox.Show("Debe elegir un Tipo de Documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    
    Private Sub dtpfechaInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaInicio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaInicio.ValueChanged

    End Sub

    Private Sub dtpfechaFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpfechaFin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub dtpfechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaFin.ValueChanged

    End Sub

    Private Sub rdbsunat_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub rdbconcar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Sub ActivarCheck(ByVal opcion As Boolean)
        Dim i As Integer = 0
        If opcion Then
            Do While i <= chklstDocumentos.Items.Count - 1
                chklstDocumentos.SetItemChecked(i, True)
                i = i + 1
            Loop
        Else
            Do While i <= chklstDocumentos.Items.Count - 1
                chklstDocumentos.SetItemChecked(i, False)
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub checkTipoDoc_CheckedChanged(sender As Object, e As EventArgs) Handles checkTipoDoc.CheckedChanged
        If checkTipoDoc.Checked Then
            ActivarCheck(True)
            chklstDocumentos.Enabled = False
        Else
            ActivarCheck(False)
            chklstDocumentos.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub txtclienteInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclienteInicial.KeyDown
        If e.KeyCode = Keys.F1 Then
            Ayuda_Vendedor(txtclienteInicial, txtclienteInicialDesc)
        End If
    End Sub

    Private Sub txtclienteInicial_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtclienteInicial.MouseDoubleClick
        Ayuda_Vendedor(txtclienteInicial, txtclienteInicialDesc)
    End Sub
    Private Sub Ayuda_Vendedor(TextBox As TextBox, TextBoxDes As TextBox)
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "FACT_SP_S_RECEIVABLE_VENDEDOR"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = ""
            frm.Titulo = "Vendedor"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                TextBox.Text = frm.Data_Matriz.Rows(0).Item(0)
                TextBoxDes.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtclienteInicial.Text = ""
            txtclienteInicialDesc.Text = ""
            txtclienteInicial.Enabled = False
            txtclienteInicialDesc.Enabled = False
        Else
            txtclienteInicial.Text = ""
            txtclienteInicialDesc.Text = ""
            txtclienteInicial.Enabled = True
            txtclienteInicialDesc.Enabled = True
        End If
    End Sub
End Class