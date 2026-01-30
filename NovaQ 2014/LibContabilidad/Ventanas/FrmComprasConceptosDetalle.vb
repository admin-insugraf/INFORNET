Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmComprasConceptosDetalle
    Dim dtdetalleConceptos As DataTable
    Dim ClsBuscarBl As ClsBuscar
    Dim Dtdatos As DataTable

    Dim AsientoBl As ClsOperaciones.Asiento_Contable
    Dim Flag_modo_edicion As Boolean = False
    Private _CodigoConceptoCompra As String
    Dim Item_Edicion As Integer = 0
    Dim Listacuentas As List(Of String)

    Public Property CodigoConceptoCompra As String
        Get
            Return _CodigoConceptoCompra
        End Get
        Set(value As String)
            _CodigoConceptoCompra = value
        End Set
    End Property



    Public Sub Botonera_Estado_Inicio(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = True
        frm.Controls("btn_grabar").Enabled = False
        frm.Controls("btn_Editar").Enabled = True
        frm.Controls("btn_cancelar").Enabled = False
        frm.Controls("btn_cancelar").Enabled = False
        frm.Controls("btn_eliminar").Enabled = True
        frm.Controls("btn_salir").Enabled = True
    End Sub

    Public Sub Botonera_Estado_Cambiar(frm As Form)
        frm.Controls("btn_Nuevo").Enabled = Not frm.Controls("btn_Nuevo").Enabled
        frm.Controls("btn_grabar").Enabled = Not frm.Controls("btn_grabar").Enabled
        frm.Controls("btn_Editar").Enabled = Not frm.Controls("btn_Editar").Enabled
        frm.Controls("btn_cancelar").Enabled = Not frm.Controls("btn_cancelar").Enabled
        frm.Controls("btn_eliminar").Enabled = Not frm.Controls("btn_eliminar").Enabled
        frm.Controls("btn_salir").Enabled = Not frm.Controls("btn_salir").Enabled
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
            dgvDetalle.Columns(1).Width = 80
            dgvDetalle.Columns(2).Width = 80
            dgvDetalle.Columns(3).Width = 300
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CuentaContable()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CO_SP_S_PLANCTAS_MOV"
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

    Private Sub ConceptoCompraGenerales()
        Try
            Dim frm As New frmBuscar
            Dim sql As String = String.Empty
            sql = "CONTA_SP_S_COMPRAS_CONCEPTOS"
            frm.CadenaConsulta = sql
            frm.Titulo = "Conceptos de Compras Generales"
            frm.ShowDialog()
            If frm.Data_Matriz.Rows.Count > 0 Then
                txtcodigoConcepto.Text = frm.Data_Matriz.Rows(0).Item(0).ToString
                txtdescripcionConcepto.Text = frm.Data_Matriz.Rows(0).Item(1).ToString
            End If
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DocumentosPrincipal()
        Try
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim dtCabecera As New DataTable
            dtCabecera = AsientoBl.ConceptosComprasDetalles(CodigoConceptoCompra)
            If dtCabecera.Rows.Count() <> 0 Then
                dgvCabecera.DataSource = dtCabecera
                dgvCabecera.Columns(0).Width = 100
                dgvCabecera.Columns(1).Width = 40
                dgvCabecera.Columns(2).Width = 120
                dgvCabecera.Columns(3).Width = 200
            Else
                MsgBox("No hay informacion disponible para mostrar", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmComprasConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txtcodigoConcepto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigoConcepto.KeyDown
        If e.KeyCode = Keys.F1 Then
            ConceptoCompraGenerales()
        End If
    End Sub

    Private Sub txtcodigoConcepto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtcodigoConcepto.MouseDoubleClick
        ConceptoCompraGenerales()
    End Sub

    Private Sub btninsertar_Click(sender As Object, e As EventArgs) Handles btninsertar.Click
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
        ClsBuscarBl = New ClsBuscar
        Dtdatos = New DataTable
        Dim consulta As String = String.Empty
        consulta = "SELECT * FROM CO_COMPRAS_CONCEPTOS_DETALLE WHERE CO_CONCEPTO='" & txtcodigoConcepto.Text & "' AND CO_CUENTA ='" & txtCuentaContable.Text & "'"
        Dtdatos = ClsBuscarBl.EjecutarConsulta(consulta)
        If Dtdatos.Rows.Count() <> 0 Then
            MsgBox("Ya se agrego esta Cuenta Contable al Concepto.", MsgBoxStyle.Critical)
            txtCuentaContable.Focus()
            Exit Sub
        End If
        If Listacuentas.Contains(txtCuentaContable.Text) = False Then
            Listacuentas.Add(txtCuentaContable.Text)
        Else
            MsgBox("Ya se agrego esta Cuenta Contable a los detalles", MsgBoxStyle.Exclamation)
            txtCuentaContable.Focus()
            Exit Sub
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
                Dim CuentaContable As String = String.Empty
                Codigo = dgvDetalle.Item(0, dgvDetalle.CurrentRow.Index).Value
                CuentaContable = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value
                'Borrando los Datos
                For Each item As DataRow In dtdetalleConceptos.Select("ITEM=" & Codigo)
                    dtdetalleConceptos.BeginInit()
                    item.Delete()
                    dtdetalleConceptos.EndInit()
                    dtdetalleConceptos.AcceptChanges()
                    Listacuentas.Remove(CuentaContable)
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

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Call Botonera_Estado_Cambiar(Me)
        pnlcabecera.Visible = False
        pnlDetalleconcepto.Visible = True
        blank()
        txtcodigoConcepto.Text = CodigoConceptoCompra
        txtcodigoConcepto.Enabled = False
        ClsBuscarBl = New ClsBuscar
        Dtdatos = New DataTable("Descripcion")
        Dim consulta As String = String.Empty
        consulta = "SELECT CO_DESCRIPCION  FROM CO_COMPRAS_CONCEPTOS_CABECERA  WHERE CO_CONCEPTO='" & txtcodigoConcepto.Text & "'"
        Dtdatos = ClsBuscarBl.EjecutarConsulta(consulta)
        txtdescripcionConcepto.Text = IIf(String.IsNullOrEmpty(Dtdatos.Rows(0).Item(0).ToString), "", Dtdatos.Rows(0).Item(0).ToString)
        Flag_modo_edicion = False
        GenerarColummnaDataTable()
        Listacuentas = New List(Of String)
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        Dim ConceptoCompraEnt As New ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE
        Dim ListaDetalles As New List(Of ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE)
        AsientoBl = New ClsOperaciones.Asiento_Contable
        ClsBuscarBl = New ClsBuscar
        Dtdatos = New DataTable
        If Flag_modo_edicion = True Then
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
            ClsBuscarBl = New ClsBuscar
            Dtdatos = New DataTable
            Dim consulta As String = String.Empty
            consulta = "SELECT * FROM CO_COMPRAS_CONCEPTOS_DETALLE WHERE CO_CONCEPTO='" & txtcodigoConcepto.Text & "' AND CO_CUENTA ='" & txtCuentaContable.Text & "'"
            Dtdatos = ClsBuscarBl.EjecutarConsulta(consulta)
            If Dtdatos.Rows.Count() <> 0 Then
                MsgBox("Ya se agrego esta Cuenta Contable al Concepto.", MsgBoxStyle.Critical)
                txtCuentaContable.Focus()
                Exit Sub
            End If
            ConceptoCompraEnt = New ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE
            ConceptoCompraEnt.CO_CONCEPTO = txtcodigoConcepto.Text
            ConceptoCompraEnt.CO_ITEM = Item_Edicion
            ConceptoCompraEnt.CO_CUENTA = txtCuentaContable.Text
            ConceptoCompraEnt.CO_DESCRIPCION = txt_des_cta.Text
            ListaDetalles.Add(ConceptoCompraEnt)
        Else
            If dtdetalleConceptos.Rows.Count() = 0 Then
                MsgBox("Debe ingresar al menos un registro.", MsgBoxStyle.Information)
                txtCuentaContable.Focus()
                Exit Sub
            End If
            Dim consulta As String = String.Empty
            Dim Var_item As Integer = 0
            consulta = "SELECT  ISNULL(MAX(CO_ITEM),0)AS [Item]  FROM CO_COMPRAS_CONCEPTOS_DETALLE WHERE CO_CONCEPTO='" & txtcodigoConcepto.Text & "'"
            Dtdatos = ClsBuscarBl.EjecutarConsulta(consulta)
            Var_item = Dtdatos.Rows(0).Item(0).ToString
            For Each items As DataRow In dtdetalleConceptos.Rows
                ConceptoCompraEnt = New ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE
                ConceptoCompraEnt.CO_CONCEPTO = items("CODIGO")
                ConceptoCompraEnt.CO_ITEM = Var_item + 1
                ConceptoCompraEnt.CO_CUENTA = items("CUENTA")
                ConceptoCompraEnt.CO_DESCRIPCION = items("DESCRIPCION")
                ListaDetalles.Add(ConceptoCompraEnt)
                Var_item = ConceptoCompraEnt.CO_ITEM
            Next
        End If
        If Flag_modo_edicion = False Then
            If AsientoBl.GuardarConceptoCompraDetalle(ListaDetalles) = True Then
                MsgBox("Agregado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        Else
            If AsientoBl.ModificarConceptoCompraDetalle(ConceptoCompraEnt) = True Then
                MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
        End If
        btn_cancelar_Click(sender, e)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        Flag_modo_edicion = True
        '  AjustarTamaño(True)
        Dim Codigo As String = String.Empty
        Dim cuenta As String = String.Empty
        Dim Descripcion As String = String.Empty
        Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
        Item_Edicion = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
        cuenta = dgvCabecera.Item(2, dgvCabecera.CurrentRow.Index).Value
        Descripcion = dgvCabecera.Item(3, dgvCabecera.CurrentRow.Index).Value
        If String.IsNullOrEmpty(Codigo) Then Exit Sub
        pnlcabecera.Visible = False
        Call Botonera_Estado_Cambiar(Me)
        blank()
        txtcodigoConcepto.Text = Codigo
        txtcodigoConcepto.Enabled = False
        ClsBuscarBl = New ClsBuscar
        Dtdatos = New DataTable("Descripcion")
        Dim consulta As String = String.Empty
        consulta = "SELECT CO_DESCRIPCION  FROM CO_COMPRAS_CONCEPTOS_CABECERA  WHERE CO_CONCEPTO='" & txtcodigoConcepto.Text & "'"
        Dtdatos = ClsBuscarBl.EjecutarConsulta(consulta)
        txtdescripcionConcepto.Text = IIf(String.IsNullOrEmpty(Dtdatos.Rows(0).Item(0).ToString), "", Dtdatos.Rows(0).Item(0).ToString)
        txtCuentaContable.Text = cuenta
        txt_des_cta.Text = Descripcion
        pnlDetalleconcepto.Visible = False
        pnlcabeceraConcepto.Location = New Point(3, 18)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgvCabecera.Rows.Count = 0 Then Exit Sub
        If dgvCabecera.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("Seguro de Eliminar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Dim ConceptoCompraEnt As New ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE
            AsientoBl = New ClsOperaciones.Asiento_Contable
            Dim _Codigo As String = String.Empty
            Dim _item As Integer = 0
            _Codigo = dgvCabecera.Item(0, dgvCabecera.CurrentRow.Index).Value
            _item = dgvCabecera.Item(1, dgvCabecera.CurrentRow.Index).Value
            If String.IsNullOrEmpty(_Codigo) Or String.IsNullOrEmpty(_item) Then Exit Sub
            ConceptoCompraEnt.CO_CONCEPTO = _Codigo
            ConceptoCompraEnt.CO_ITEM = _item
            If AsientoBl.EliminarConceptoCompraDetalles(ConceptoCompraEnt) = True Then
                MsgBox("Eliminado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Hubo un error.", MsgBoxStyle.Information)
            End If
            DocumentosPrincipal()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        dgvCabecera.Focus()
        Botonera_Estado_Cambiar(Me)
        pnlcabecera.Visible = True
        pnlDetalleconcepto.Visible = True
        DocumentosPrincipal()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub dgvDetalle_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvDetalle.MouseDoubleClick
        If dgvDetalle.CurrentRow Is Nothing Then Exit Sub
        txtCuentaContable.Text = dgvDetalle.Item(2, dgvDetalle.CurrentRow.Index).Value
        txt_des_cta.Text = dgvDetalle.Item(3, dgvDetalle.CurrentRow.Index).Value
    End Sub
End Class