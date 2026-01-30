Imports LibCobranzas
Imports LibComunVar
Imports System.Windows.Forms

Public Class FrmTransaccionesArticulo
    Dim clsBusquedaBl As ClsBuscar
    Dim dtAlmacen As DataTable
    Dim monedaBL As ClsOperaciones.CURRENCY_TYPE
    Dim TransaccionBl As ClsOperaciones.TRANSACTION_TYPE
    Dim dtTransaccion As DataTable

    Dim clsReportesBl As ClsReporteGenerales
    Dim crystalBL As LibReportes.ClsReporte
    Dim dtTransaccionesArt As DataTable
    Dim dtDatosPart As DataTable
    Dim dtDatosMov As DataTable

    Private Sub TransaccionesTipo()
        Try
            TransaccionBl = New ClsOperaciones.TRANSACTION_TYPE
            dtTransaccion = New DataTable
            dtTransaccion = TransaccionBl.get_TipoTransacciones()
            If dtTransaccion.Rows.Count() <> 0 Then
                cboTipoMov.DataSource = dtTransaccion
                cboTipoMov.DisplayMember = "TYPE_ID"
                cboTipoMov.ValueMember = "TYPE_ID"
                TransaccionBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Moneda()
        monedaBL = New ClsOperaciones.CURRENCY_TYPE
        cboMoneda.DataSource = monedaBL.get_TiposCambio()
        cboMoneda.ValueMember = "CODIGO"
        cboMoneda.DisplayMember = "DESCRIPCION"
        monedaBL = Nothing
    End Sub

    Private Sub MostrandoAlmacenes()
        Try
            clsBusquedaBl = New ClsBuscar
            dtAlmacen = New DataTable
            dtAlmacen = clsBusquedaBl.Get_MostrarAlmacenes(LibComunVar.ClsVarComun.AccesoAlmacenes)
            'agregando una nueva Fila (Seleccione) --
            Dim row As DataRow = dtAlmacen.NewRow()
            row.Item("CODIGO") = ""
            row.Item("DESCRIPCION") = "(SELECCIONE UN ALMACEN)"
            dtAlmacen.Rows.InsertAt(row, 0)
            If dtAlmacen.Rows.Count() <> 0 Then
                cboAlmacen.DataSource = dtAlmacen
                cboAlmacen.DisplayMember = "DESCRIPCION"
                cboAlmacen.ValueMember = "CODIGO"
                clsBusquedaBl = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmTransaccionesArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrandoAlmacenes()
        Cargar_Moneda()
        cboTipoMov.SelectedIndex = 0
        'TransaccionesTipo()
    End Sub

    Private Sub BuscarTipoTransaccion(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            sql = "TRANS_SP_S_TRANSACTION_TYPE_TIPO"
            frmM.CadenaConsulta = sql
            frmM._Flag_Filtro = True
            If cboTipoMov.SelectedIndex = 1 Then
                frmM.Filtros1 = "I"
            ElseIf cboTipoMov.SelectedIndex = 2 Then
                frmM.Filtros1 = "S"
            End If
            frmM.Titulo = "Tipo Transaccion"
            frmM.ShowDialog()
            If frmM.Data_Matriz.Rows.Count > 0 Then
                txtcodigo.Text = frmM.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcion.Text = frmM.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frmM.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarArticulos(ByVal txtcodigo As TextBox, ByVal txtDescripcion As TextBox)
        Try
            Dim frmM As New frmBuscar
            Dim sql As String = String.Empty
            sql = "ALM_SP_S_WAREHOUSE_ARTICULO_AYUDA"
            frmM.CadenaConsulta = sql
            frmM.Titulo = "Seleccion de Articulos"
            frmM.ShowDialog()
            If frmM.Data_Matriz.Rows.Count > 0 Then
                txtcodigo.Text = frmM.Data_Matriz.Rows(0).Item(0).ToString
                txtDescripcion.Text = frmM.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frmM.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtInicioMov_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtInicioMov.MouseDoubleClick
        BuscarTipoTransaccion(txtInicioMov, txtDescripcionInicioMov)
    End Sub

    Private Sub txtFinMov_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFinMov.MouseDoubleClick
        BuscarTipoTransaccion(txtFinMov, txtDescripcionfinMov)
    End Sub

    Private Sub LimpiarArticulos()
        txtinicioArticulo.Text = String.Empty
        txtFinArticulo.Text = String.Empty
        txtdescripcionArticuloInicial.Text = String.Empty
        txtDescripcionArticulofinal.Text = String.Empty
    End Sub

    Private Sub LimpiarMovimientos()
        txtInicioMov.Text = String.Empty
        txtFinMov.Text = String.Empty
        txtDescripcionInicioMov.Text = String.Empty
        txtDescripcionfinMov.Text = String.Empty
    End Sub

    Private Sub MostrandoArticulos()

        If cboAlmacen.DataSource Is Nothing Then Exit Sub
        If cboAlmacen.SelectedIndex = 0 Then
            LimpiarArticulos()
            Exit Sub
        End If

        Try
            'LimpiarArticulos()
            If checkArticulo.Checked Then
                Dim rsql As String = String.Empty
                rsql = "SELECT ID,DESCRIPTION, UNIT_OF_MEASUREMENT FROM PART  ORDER BY ID"
                ''Mostrando data
                clsReportesBl = New ClsReporteGenerales
                dtDatosPart = New DataTable
                dtDatosPart = clsReportesBl.Get_DatosPart(rsql)

                If dtDatosPart.Rows.Count() <> 0 Then
                    ''Mostrando data del primer Articulo
                    txtinicioArticulo.Text = dtDatosPart.Rows(0).Item(0).ToString
                    txtdescripcionArticuloInicial.Text = dtDatosPart.Rows(0).Item(1).ToString

                    '---Mostrando data
                    rsql = "SELECT ID,DESCRIPTION, UNIT_OF_MEASUREMENT FROM PART  ORDER BY ID DESC"

                    clsReportesBl = New ClsReporteGenerales
                    dtDatosPart = New DataTable
                    dtDatosPart = clsReportesBl.Get_DatosPart(rsql)
                    ''Mostrando data del segundo  Articulo
                    txtFinArticulo.Text = dtDatosPart.Rows(0).Item(0).ToString
                    txtDescripcionArticulofinal.Text = dtDatosPart.Rows(0).Item(1).ToString
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrandoMovimientos()

        'If cboTipoMov.DataSource Is Nothing Then Exit Sub
        If cboTipoMov.SelectedIndex = 0 Then
            LimpiarMovimientos()
            Exit Sub
        End If

        Try
            LimpiarMovimientos()
            If chkMovimientos.Checked Then
                Dim rsql As String = String.Empty

                If cboTipoMov.SelectedIndex = 1 Then
                    rsql = "SELECT TOP 1 MOV_ID, NAME FROM dbo.TRANSACTION_TYPE ORDER BY TYPE_ID,MOV_ID "
                    ''Mostrando data
                    clsReportesBl = New ClsReporteGenerales
                    dtDatosPart = New DataTable
                    dtDatosPart = clsReportesBl.Get_DatosPart(rsql)

                    If dtDatosPart.Rows.Count() <> 0 Then
                        ''Mostrando data del primer Articulo
                        txtInicioMov.Text = dtDatosPart.Rows(0).Item(0).ToString
                        txtDescripcionInicioMov.Text = dtDatosPart.Rows(0).Item(1).ToString

                        '---Mostrando data
                        rsql = "SELECT TOP 1 MOV_ID, NAME FROM dbo.TRANSACTION_TYPE ORDER BY TYPE_ID,MOV_ID DESC"

                        clsReportesBl = New ClsReporteGenerales
                        dtDatosPart = New DataTable
                        dtDatosPart = clsReportesBl.Get_DatosPart(rsql)
                        ''Mostrando data del segundo  Articulo
                        txtFinMov.Text = dtDatosPart.Rows(0).Item(0).ToString
                        txtDescripcionfinMov.Text = dtDatosPart.Rows(0).Item(1).ToString
                    End If
                Else
                    rsql = "SELECT TOP 1 MOV_ID, NAME FROM dbo.TRANSACTION_TYPE WHERE TYPE_ID='" & IIf(cboTipoMov.SelectedIndex = 2, "I", "S") & "' ORDER BY MOV_ID "
                    ''Mostrando data
                    clsReportesBl = New ClsReporteGenerales
                    dtDatosPart = New DataTable
                    dtDatosPart = clsReportesBl.Get_DatosPart(rsql)

                    If dtDatosPart.Rows.Count() <> 0 Then
                        ''Mostrando data del primer Articulo
                        txtInicioMov.Text = dtDatosPart.Rows(0).Item(0).ToString
                        txtDescripcionInicioMov.Text = dtDatosPart.Rows(0).Item(1).ToString

                        '---Mostrando data
                        rsql = "SELECT TOP 1 MOV_ID, NAME FROM dbo.TRANSACTION_TYPE WHERE TYPE_ID='" & IIf(cboTipoMov.SelectedIndex = 2, "I", "S") & "' ORDER BY MOV_ID DESC"

                        clsReportesBl = New ClsReporteGenerales
                        dtDatosPart = New DataTable
                        dtDatosPart = clsReportesBl.Get_DatosPart(rsql)
                        ''Mostrando data del segundo  Articulo
                        txtFinMov.Text = dtDatosPart.Rows(0).Item(0).ToString
                        txtDescripcionfinMov.Text = dtDatosPart.Rows(0).Item(1).ToString
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles checkArticulo.CheckedChanged
        If checkArticulo.Checked Then
            GbArticulos.Enabled = False
            MostrandoArticulos()
        Else
            GbArticulos.Enabled = True
            LimpiarArticulos()
        End If
    End Sub

    Private Sub txtinicioArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtinicioArticulo.MouseDoubleClick
        If cboAlmacen.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un Almacen.", MsgBoxStyle.Information)
            cboAlmacen.Focus()
            Exit Sub
        End If
        BuscarArticulos(txtinicioArticulo, txtdescripcionArticuloInicial)
    End Sub

    Private Sub txtFinArticulo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtFinArticulo.MouseDoubleClick
        If cboAlmacen.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un Almacen.", MsgBoxStyle.Information)
            cboAlmacen.Focus()
            Exit Sub
        End If
        BuscarArticulos(txtFinArticulo, txtDescripcionArticulofinal)
    End Sub

    Private Sub MostrandoReporte(ByVal IDE As String, ByVal fechaINI As String, ByVal Almacen As String, ByVal TipoMov As String, ByVal Moneda As String, _
                                  ByVal Mov_inicial As String, ByVal Mov_final As String, ByVal Art_inicial As String, ByVal Art_final As String, _
                                  ByVal progreso As ProgressBar)
        Try
            clsReportesBl = New ClsReporteGenerales
            crystalBL = New LibReportes.ClsReporte
            dtTransaccionesArt = New DataTable
            dtTransaccionesArt = clsReportesBl.Get_ImprimirReporte_Transacciones_Articulo(IDE, fechaINI, Almacen, TipoMov, Moneda, _
                                                                                          Mov_inicial, Mov_final, Art_inicial, Art_final, ProgressBar1)

            Me.Cursor = Cursors.WaitCursor
            If dtTransaccionesArt.Rows.Count() <> 0 Then
                If rdb_Resumido.Checked Then
                    crystalBL.Muestra_Reporte("rpt_Inv_Doc_Alm_Trans_Art.rpt", dtTransaccionesArt, "", "", "", "@TRANS_INI;" & Mov_inicial, "@TRANS_FIN;" & Mov_final, "@ART_INI;" & Art_inicial, _
                                          "@ART_FIN;" & Art_final, "@ALM;" & cboAlmacen.Text, "@M;" & (dtpfechaInicio.Text).ToUpper)
                ElseIf rdb_Detallado.Checked Then
                    crystalBL.Muestra_Reporte("rpt_Inv_Doc_Alm_Trans_Art_Detalle.rpt", dtTransaccionesArt, "", "", "", "@TRANS_INI;" & Mov_inicial, "@TRANS_FIN;" & Mov_final, "@ART_INI;" & Art_inicial, _
                                          "@ART_FIN;" & Art_final, "@ALM;" & cboAlmacen.Text, "@M;" & (dtpfechaInicio.Text).ToUpper)
                End If
                

            Else
                MsgBox("No hay informacion disponible para Mostrar", MsgBoxStyle.Information, "Sistemas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Function Validaciones(ByRef IDE As String, ByRef fechaINI As String, ByRef Almacen As String, ByRef TipoMov As String, ByRef Moneda As String, _
                                  ByRef _Mov_inicial As String, ByRef _Mov_final As String, _
                                  ByRef Art_inicial As String, ByRef Art_final As String) As Boolean
        Dim estado As Boolean = True
        Try
            'fECHA DEL SISTEMA
            fechaINI = dtpfechaInicio.Value.ToString("dd/MM/yyyy")
            'NOMBRE DE LA PC
            'nombre de la pc
            IDE = System.Net.Dns.GetHostName()

            'Seleccionando almacen
            If cboAlmacen.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar un Almacen.", MsgBoxStyle.Information)
                cboAlmacen.Focus()
                estado = False
                Exit Try
            ElseIf cboAlmacen.SelectedIndex > 0 Then
                Almacen = cboAlmacen.SelectedValue().ToString()
            End If
            'Guardando la moneda 
            Moneda = cboMoneda.SelectedValue.ToString
            'Seleccionando TipoMov
            If cboTipoMov.SelectedIndex = 1 Then
                TipoMov = ""
            ElseIf cboTipoMov.SelectedIndex = 2 Then
                TipoMov = "I"
            ElseIf cboTipoMov.SelectedIndex = 3 Then
                TipoMov = "S"
            End If
            'Seleccionando Tipo transacciones
            If cboTipoMov.SelectedIndex <> 0 And cboTipoMov.SelectedIndex <> 1 Then
                If txtInicioMov.Text = String.Empty Then
                    estado = False
                    MsgBox("Debe seleccionar un Tipo de transaccion.", MsgBoxStyle.Information)
                    txtInicioMov.Focus()
                    Exit Try
                ElseIf txtFinMov.Text = String.Empty Then
                    estado = False
                    MsgBox("Debe seleccionar un Tipo de transaccion.", MsgBoxStyle.Information)
                    txtFinMov.Focus()
                    Exit Try
                End If
            End If
            _Mov_inicial = txtInicioMov.Text
            _Mov_final = txtFinMov.Text

            'Seleccionando ARTICULO
            If txtinicioArticulo.Text = String.Empty Then
                estado = False
                MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Information)
                txtinicioArticulo.Focus()
                Exit Try
            ElseIf txtFinArticulo.Text = String.Empty Then
                estado = False
                MsgBox("Debe seleccionar un producto.", MsgBoxStyle.Information)
                txtFinArticulo.Focus()
                Exit Try
            End If
            Art_inicial = txtinicioArticulo.Text
            Art_final = txtFinArticulo.Text
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Dim Ref_Ide As String = String.Empty
        Dim Ref_fechaINI As String = String.Empty
        Dim Ref_Almacen As String = String.Empty
        Dim Ref_TipoMov As String = String.Empty
        Dim Ref_Moneda As String = String.Empty
        Dim Ref_Mov_inicial As String = String.Empty
        Dim Ref_Mov_final As String = String.Empty
        Dim Ref_Art_inicial As String = String.Empty
        Dim Ref_Art_final As String = String.Empty
        If Validaciones(Ref_Ide, Ref_fechaINI, Ref_Almacen, Ref_TipoMov, Ref_Moneda, Ref_Mov_inicial, Ref_Mov_final, Ref_Art_inicial, Ref_Art_final) = False Then Exit Sub
        ProgressBar1.Visible = True
        MostrandoReporte(Ref_Ide, Ref_fechaINI, Ref_Almacen, Ref_TipoMov, Ref_Moneda, Ref_Mov_inicial, Ref_Mov_final, Ref_Art_inicial, Ref_Art_final, ProgressBar1)
        ProgressBar1.Visible = False
    End Sub

    Private Sub cboTipoMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMov.SelectedIndexChanged
        MostrandoMovimientos()
    End Sub

    Private Sub cboAlmacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlmacen.SelectedIndexChanged
        MostrandoArticulos()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub chkMovimientos_CheckedChanged(sender As Object, e As EventArgs) Handles chkMovimientos.CheckedChanged
        If chkMovimientos.Checked Then
            GbMovimiento.Enabled = False
            MostrandoMovimientos()
        Else
            GbMovimiento.Enabled = True
            LimpiarMovimientos()
        End If
    End Sub
End Class