Imports System.Windows.Forms
Imports System.Drawing

Public Class Frm_Configuracion_Balance_General
    Dim dtdetalleConceptos As DataTable
    Dim ClsBuscarBl As ClsBuscar
    Dim Dtdatos As DataTable

    Dim AsientoBl As ClsOperaciones.Asiento_Contable
    Dim Flag_modo_edicion As Boolean = False
    Private _CodigoConceptoCompra As String
    Dim Item_Edicion As Integer = 0
    Dim Listacuentas As List(Of String)

    Dim ConceptoCompraEnt As ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE
    Dim ListaDetalles As List(Of ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE)

    Dim ID_GRUPO_CLASE As Integer


    Private Sub Frm_Configuracion_Balance_General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Botonera_Estado_Inicio(Me)
        DocumentosPrincipal()
    End Sub

    Private Sub txtCuentaContable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = Keys.F1 Then
            CuentaContable()
        End If
    End Sub

    Private Sub txtCuentaContable_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCuentaContable.MouseDoubleClick
        CuentaContable()
    End Sub

    Private Sub btninsertar_Click(sender As Object, e As EventArgs) Handles btninsertar.Click
        If txtCuentaContable.Text = String.Empty Then
            MsgBox("Debe seleccionar una cuenta contable.", MsgBoxStyle.Exclamation)
            txtCuentaContable.Focus()
            Exit Sub
        End If

        If dtdetalleConceptos.Rows.Count > 0 Then
            For Each rows As DataRow In dtdetalleConceptos.Select("CUENTA='" & txtCuentaContable.Text.Trim & "' ")
                MsgBox("Ya se agrego esta Cuenta Contable a los detalles", MsgBoxStyle.Exclamation)
                txtCuentaContable.Focus()
                Exit Sub
            Next
        End If

        Dim row As DataRow = dtdetalleConceptos.NewRow
        Dim Item As Integer = 0
        Item = dtdetalleConceptos.Rows.Count() + 1
        row("ITEM") = Item
        row("CODIGO") = txtcodigoConcepto.Text
        row("CUENTA") = txtCuentaContable.Text
        row("DESCRIPCION") = txt_des_cta.Text
        dtdetalleConceptos.Rows.Add(row)
        dtdetalleConceptos.AcceptChanges()
        txtCuentaContable.Text = String.Empty
        txt_des_cta.Text = String.Empty
    End Sub

    Private Sub RehacerSecuencia()
        Dim i As Integer = 0
        For Each items As DataRow In dtdetalleConceptos.Rows
            i += 1
            dtdetalleConceptos.BeginInit()
            items("ITEM") = i
            dtdetalleConceptos.EndInit()
            dtdetalleConceptos.AcceptChanges()
        Next
    End Sub

    Private Sub EliminandoConcepto()
        Try
            If MessageBox.Show("Se va a eliminar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Codigo = dgvDetalle.CurrentRow.Cells("ITEM").Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleConceptos.Select("ITEM=" & Codigo)
                    dtdetalleConceptos.BeginInit()
                    item.Delete()
                    dtdetalleConceptos.EndInit()
                    dtdetalleConceptos.AcceptChanges()
                Next
                RehacerSecuencia()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ModificandoConcepto()
        Try
            If MessageBox.Show("Se va a Modificar el registro" & vbCrLf & "¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim Codigo As String = String.Empty
                Dim _CuentaC As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                _CuentaC = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value
                If Listacuentas.Contains(txtCuentaContable.Text) = False Then
                    Listacuentas.Remove(_CuentaC)
                    Listacuentas.Add(txtCuentaContable.Text)
                Else
                    MsgBox("Ya se agrego esta Cuenta Contable a los detalles", MsgBoxStyle.Exclamation)
                    txtCuentaContable.Focus()
                    Exit Sub
                End If
                For Each item As DataRow In dtdetalleConceptos.Select("ITEM=" & Codigo)
                    dtdetalleConceptos.BeginInit()
                    item("CUENTA") = txtCuentaContable.Text
                    item("DESCRIPCION") = txt_des_cta.Text
                    dtdetalleConceptos.EndInit()
                    dtdetalleConceptos.AcceptChanges()
                Next
                txtCuentaContable.Text = String.Empty
                txt_des_cta.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub blank()
        txtcodigoConcepto.Text = String.Empty
        txtdescripcionConcepto.Text = String.Empty
        txtCuentaContable.Text = String.Empty
        txt_des_cta.Text = String.Empty
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        EliminandoConcepto()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        If txtcodigoConcepto.Text = String.Empty Then
            MsgBox("Debe seleccionar un concepto.", MsgBoxStyle.Information)
            txtcodigoConcepto.Focus()
            Exit Sub
        End If
        If txtCuentaContable.Text = String.Empty Then
            MsgBox("Debe seleccionar una cuenta contable.", MsgBoxStyle.Information)
            txtCuentaContable.Focus()
            Exit Sub
        End If
        ModificandoConcepto()
    End Sub

    
    Public Property CodigoConceptoCompra As String
        Get
            Return _CodigoConceptoCompra
        End Get
        Set(value As String)
            _CodigoConceptoCompra = value
        End Set
    End Property



    Public Sub Botonera_Estado_Inicio(frm As Form)
        btnGrabar.Enabled = False
        btnConsultar.Enabled = True
        btnCancelar.Enabled = False
        btnsalir.Enabled = True
    End Sub

    Public Sub Botonera_Estado_Cambiar(frm As Form)
        btnGrabar.Enabled = Not btnGrabar.Enabled
        btnConsultar.Enabled = Not btnConsultar.Enabled
        btnCancelar.Enabled = Not btnCancelar.Enabled
        btnsalir.Enabled = Not btnsalir.Enabled
    End Sub


    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleConceptos = New DataTable
            dtdetalleConceptos.Columns.Add("ITEM", Type.GetType("System.Int16"))
            dtdetalleConceptos.Columns.Add("CODIGO", Type.GetType("System.String"))
            dtdetalleConceptos.Columns.Add("CUENTA", Type.GetType("System.String"))
            dtdetalleConceptos.Columns.Add("DESCRIPCION", Type.GetType("System.String"))

            dtdetalleConceptos.PrimaryKey = New DataColumn() {dtdetalleConceptos.Columns("ITEM")}
            dgvDetalle.DataSource = Nothing
            dgvDetalle.DataSource = dtdetalleConceptos
            dgvDetalle.Columns(0).Width = 60
            dgvDetalle.Columns(1).Visible = False
            dgvDetalle.Columns(2).Width = 80
            dgvDetalle.Columns(3).Width = 300
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CuentaContable()
        Try
            Dim frm As New FrmBuscar_CuentaContable
            Dim sql As String = String.Empty
            sql = "CO_SP_S_PLANCTAS_MOV_2"
            frm.CadenaConsulta = sql
            frm._Flag_Filtro = True
            frm.Filtros1 = Date.Now.Year
            frm.Titulo = "Plan de Cuentas Contable"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtCuentaContable.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txt_des_cta.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DocumentosPrincipal()
        Try
            Me.Cursor = Cursors.WaitCursor
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim dtCabecera As New DataTable
            dtCabecera = AsientoBl.Conceptos_Balance_general()
            If dtCabecera.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtCabecera
                dgvCabecera.AutoResizeColumns()
                dgvCabecera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                dgvCabecera.Columns("GBG_IDCLASE").Visible = False

            Else
                dgvCabecera.DataSource = Nothing
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If dtdetalleConceptos.Rows.Count = 0 Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            ConceptoCompraEnt = New ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE
            ListaDetalles = New List(Of ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE)

            AsientoBl = New ClsOperaciones.Asiento_Contable

            If txtcodigoConcepto.Text = String.Empty Then
                Me.Cursor = Cursors.Default
                MsgBox("Debe seleccionar un concepto.", MsgBoxStyle.Exclamation)
                txtcodigoConcepto.Focus()
                Exit Sub
            End If


            For Each item As DataRow In dtdetalleConceptos.Rows
                ConceptoCompraEnt = New ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE
                With ConceptoCompraEnt
                    .CO_CUENTA = item("CUENTA")
                    .CO_CONCEPTO = item("CODIGO")
                End With
                ListaDetalles.Add(ConceptoCompraEnt)
            Next

            If AsientoBl.Modificar_Cuentas_Balance_General(txtcodigoConcepto.Text, ListaDetalles) = True Then
                DocumentosPrincipal()
                MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
                btnCancelar_Click(sender, e)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Flag_modo_edicion = True
            Dim Codigo As Integer = 0
            Dim cuenta As String = String.Empty
            Dim Descripcion As String = String.Empty
            ID_GRUPO_CLASE = 0

            Codigo = dgvCabecera.CurrentRow.Cells("Codigo").Value
            Descripcion = dgvCabecera.CurrentRow.Cells("Descripcion").Value
            ID_GRUPO_CLASE = dgvCabecera.CurrentRow.Cells("GBG_IDCLASE").Value

            If String.IsNullOrEmpty(Codigo) Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Call Botonera_Estado_Cambiar(Me)
            blank()
            txtcodigoConcepto.Text = Codigo
            txtdescripcionConcepto.Text = Descripcion

            AsientoBl = New ClsOperaciones.Asiento_Contable
            GenerarColummnaDataTable()
            dtdetalleConceptos = AsientoBl.Conceptos_Balance_general_Cuentas(Codigo)
            If dtdetalleConceptos.Rows.Count() <> 0 Then
                dgvDetalle.DataSource = dtdetalleConceptos
                dgvDetalle.AutoResizeColumns()
                dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
            pnlcabecera.Visible = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvCabecera.Focus()
        Botonera_Estado_Cambiar(Me)
        pnlcabecera.Visible = True
        'DocumentosPrincipal()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class