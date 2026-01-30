Imports LibReportes
Imports System.Windows.Forms
Imports LibComunVar
Imports LibCobranzas

Public Class bwsNotaIngSal
    Private nroRegistro As Integer
    Private totalPaginas As Integer
    Private paginaActual As Integer
    Private tipoNota As String
    Private tipoDoc As String
    Dim reporteBL As ClsBuscar
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtImprimir As DataTable
    Dim clsBusquedaBl As ClsBuscar
    Dim dtv As DataView
    Dim dtData As DataTable
    Dim STRorden As String
    Dim MostrarMovimientoBl As ClsTransacciones.clsMostrarTiposMovimiento


    Private Sub bwsNotaIngSal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nroRegistro = CInt(Configuration.ConfigurationManager.AppSettings("Pagina"))
        dtpfechafinal.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaInicial.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        cboopcionesBusqueda.SelectedIndex = 0
    End Sub

    Private Sub MostrandoDatosGeneralesCabeceraAlmacen()
        Try
            If cboopcionesBusqueda.SelectedIndex = 2 Then
                If CDate(dtpfechaInicial.Value.ToString("dd/MM/yyyy")) > CDate(dtpfechafinal.Value.ToString("dd/MM/yyyy")) Then
                    MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpfechaInicial.Focus()
                    Exit Sub
                End If
            End If

            clsBusquedaBl = New ClsBuscar
            dtv = New DataView
            dtData = New DataTable
            dtData = clsBusquedaBl.get_DatosGeneralesAlmacen_E_S(dtpfechaInicial.Value.ToString("dd/MM/yyyy"), dtpfechafinal.Value.ToString("dd/MM/yyyy"), cboopcionesBusqueda.SelectedIndex, tipoNota, tipoDoc, LibComunVar.ClsVarComun.USUARIO, "")
            dgvCabeceraAlmacen.DataSource = Nothing
            If dtData.Rows.Count() <> 0 Then
                dtv = dtData.DefaultView
                dgvCabeceraAlmacen.DataSource = dtv
                dgvCabeceraAlmacen.Columns(0).Width = 70
                dgvCabeceraAlmacen.Columns(1).Width = 160
                dgvCabeceraAlmacen.Columns(2).Width = 70
                dgvCabeceraAlmacen.Columns(7).Width = 250
                STRorden = dgvCabeceraAlmacen.Columns(0).Name & "+" & dgvCabeceraAlmacen.Columns(1).Name & "+" & dgvCabeceraAlmacen.Columns(2).Name & "+" & dgvCabeceraAlmacen.Columns(3).Name
                lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
                clsBusquedaBl = Nothing
            Else
                MsgBox("No hay informacion para Mostrar", MsgBoxStyle.Information, "Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub bwsNotaIngSal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Public Sub ShowIngreso()
        tipoNota = "I"
        tipoDoc = "NI"
        Text = "Ingreso a Almacen"
        Show()
    End Sub

    Public Sub ShowSalida()
        tipoNota = "S"
        tipoDoc = "NS"
        Text = "Salida de Almacen"
        Show()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs)
        Dim lst = CType(BindingSource1.DataSource, IList(Of NotaPedidoBrowse))
        Dim frm As New frmNotaIngSal
        frm.Text = Me.Text
        frm.TipoNota = Me.tipoNota
        frm.ShowDetalle(lst(e.RowIndex).TipoDocumento, lst(e.RowIndex).NumeroDocumento)
    End Sub
    Private Sub Paginacion1_CargarLista(inicio As Integer, registros As Integer)
        Using context = AlmacenContext.CrearContext() 'New AlmacenContext()
            Dim qry = (From n In context.NotasPedido
                      Where n.TipoNota = tipoNota And n.TipoDocumento = tipoDoc
                      Order By n.Fecha Descending, n.NumeroDocumento Descending
                      Select New NotaPedidoBrowse With {
                          .IDAlmacen = n.IDAlmacen,
                          .Fecha = n.Fecha,
                          .TipoDocumento = n.TipoDocumento,
                          .NumeroDocumento = n.NumeroDocumento,
                          .Cliente = n.Cliente,
                          .IDMoneda = n.IDMoneda
                      })
            Me.BindingSource1.DataSource = qry.Skip(inicio).Take(registros).ToList()
        End Using
    End Sub

    Private Function ValidacionGeneral(ByRef idalamacen As String, ByRef documentid As String, ByRef numerodocument As String) As Boolean
        Dim estado As Boolean = True
        Try
            'Asignacion
            idalamacen = dgvCabeceraAlmacen.Item(0, dgvCabeceraAlmacen.CurrentRow.Index).Value
            documentid = dgvCabeceraAlmacen.Item(2, dgvCabeceraAlmacen.CurrentRow.Index).Value
            numerodocument = dgvCabeceraAlmacen.Item(3, dgvCabeceraAlmacen.CurrentRow.Index).Value
            'validacion
            If idalamacen = String.Empty Or documentid = String.Empty Or numerodocument = String.Empty Then
                estado = False
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Return estado
    End Function

    Private Sub imprimirAlmacen()
        Try
            reporteBL = New ClsBuscar
            crystalBL = New LibReportes.ClsReporte
            dtImprimir = New DataTable

            If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            dtImprimir = reporteBL.EjecutarReporteGuiaAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
            If dtImprimir.Rows.Count() <> 0 Then
                crystalBL.Muestra_Reporte("rpt_Mov_Almacen.rpt", "", "", "", "@almacen;" & Ref_idalamacen, "@tipo;" & Ref_documentid, "@numero;" & Ref_numerodocument)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cboopcionesBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboopcionesBusqueda.SelectedIndexChanged
        Select Case cboopcionesBusqueda.SelectedIndex
            Case 0
                gbRangofechas.Visible = False
            Case 1
                gbRangofechas.Visible = False
            Case 2
                gbRangofechas.Visible = True
        End Select
        txtFiltro.Text = String.Empty
        MostrandoDatosGeneralesCabeceraAlmacen()
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtFiltro.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim wbusqueda As String = UCase(txtFiltro.Text)
        Dim myCurrencyManager As CurrencyManager
        myCurrencyManager = CType(Me.BindingContext(dtv), CurrencyManager)
        Dim INTnewpos As Integer
        dtv.RowFilter = STRorden & " like '%" & txtFiltro.Text & "%'"
        myCurrencyManager.Position = INTnewpos
        lblCantidad.Text = "Se encontraron " & dtv.Count & " registros"
    End Sub

    Private Sub dtpfechaInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            MostrandoDatosGeneralesCabeceraAlmacen()
        End If
    End Sub

    Private Sub dtpfechafinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpfechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            MostrandoDatosGeneralesCabeceraAlmacen()
        End If
    End Sub

    Private Sub btnNuevoDocumento_Click(sender As Object, e As EventArgs) Handles btnNuevoDocumento.Click
        'Dim frmI As New frmNotaIngSal
        'frmI.Text = Me.Text
        'frmI.TipoNota = Me.tipoNota
        'If frmI.ShowNuevo() = Windows.Forms.DialogResult.OK Then
        '    cboopcionesBusqueda.SelectedIndex = 0
        '    MostrandoDatosGeneralesCabeceraAlmacen()
        'End If
        Dim frmI As New FrmMovimientoAlmacen
        frmI.Text = Me.Text
        frmI.TipoMov = tipoNota
        frmI.documentId = tipoDoc
        frmI.ShowDialog()
    End Sub

    Private Sub btnConsultarDocumento_Click(sender As Object, e As EventArgs) Handles btnConsultarDocumento.Click
        Try
            If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            'busqueda
            Dim frmM As New frmNotaIngSal
            frmM.Text = Me.Text
            frmM.TipoNota = Me.tipoNota
            frmM.ModoEdicion = True
            frmM.idAlmacen = Ref_idalamacen
            frmM.documentId = Ref_documentid
            frmM.NumeroDocumento = Ref_numerodocument
            If frmM.ShowNuevo() = Windows.Forms.DialogResult.OK Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarGuiasRemision()
        Try
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            Dim Usuario As String = String.Empty
            Usuario = LibComunVar.ClsVarComun.USUARIO
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub
            Dim almacenBL As New ClsOperaciones.WAREHOUSE_TRANS
            Me.Cursor = Cursors.WaitCursor
            almacenBL.EliminarDocumentosAlmacen(Ref_idalamacen, Ref_documentid, Ref_numerodocument, Usuario)
            Dim msj As String = String.Empty
            msj = "Documento Eliminada Correctamente, Nro Documento: " & Ref_numerodocument
            MsgBox(msj, MsgBoxStyle.Information)
            Me.Cursor = Cursors.Default
            MostrandoDatosGeneralesCabeceraAlmacen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarDocum_Click(sender As Object, e As EventArgs) Handles btnEliminarDocum.Click
        If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
        If Windows.Forms.MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            EliminarGuiasRemision()
        End If
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        imprimirAlmacen()
    End Sub

    Private Sub btnDocumentoGuiaAnalisis_Click(sender As Object, e As EventArgs) Handles btnDocumentoGuiaAnalisis.Click
        Try
            If dgvCabeceraAlmacen.CurrentRow Is Nothing Then Exit Sub
            Dim Ref_idalamacen As String = String.Empty
            Dim Ref_documentid As String = String.Empty
            Dim Ref_numerodocument As String = String.Empty
            If ValidacionGeneral(Ref_idalamacen, Ref_documentid, Ref_numerodocument) = False Then Exit Sub

            ' Verificando si posee opcion a Guia de Analisis
            Dim TipoTransaccion As String = dgvCabeceraAlmacen.Item(5, dgvCabeceraAlmacen.CurrentRow.Index).Value
            Dim codigoTipoTransaccion As String = dgvCabeceraAlmacen.Item(6, dgvCabeceraAlmacen.CurrentRow.Index).Value
            'validacion
            If TipoTransaccion = String.Empty Or codigoTipoTransaccion = String.Empty Then Exit Sub
            'consulta
            MostrarMovimientoBl = New ClsTransacciones.clsMostrarTiposMovimiento
            MostrarMovimientoBl.Get_TipoTransacciones(TipoTransaccion, codigoTipoTransaccion)
            If MostrarMovimientoBl.IS_GUIA_ANALISIS = "S" Then
                clsBusquedaBl = New ClsBuscar
                dtData = New DataTable("VerificandoGuia")
                dtData = clsBusquedaBl.get_VerificarGuiaAnalisis(Ref_idalamacen, Ref_documentid, Ref_numerodocument)
                If dtData.Rows.Count() <> 0 Then
                    If CInt(dtData.Rows(0).Item("Resultado").ToString()) = 0 Then
                        Dim frmG As New frmGuiaAnalisis
                        frmG.idAlmacen = Ref_idalamacen
                        frmG.documentId = Ref_documentid
                        frmG.NumeroDocumento = Ref_numerodocument
                        frmG.ShowDialog()
                        frmG.Close()
                    ElseIf CInt(dtData.Rows(0).Item("Resultado").ToString()) = 1 Then
                        MsgBox("Ya se genero Anteriormente una Guia de Analisis, para este Documento", MsgBoxStyle.Information)
                    End If
                End If
            Else
                MsgBox("EL Documento seleccionado, no permite la generacion de Guia de Analisis.", MsgBoxStyle.Information, "Sistemas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class