Imports System.Windows.Forms

Public Class frmPuntosVenta
    Private cAyudas As ClsAyudas
    Private cProc As ClsBuscar
    Private dtAlmacen As DataTable
    Private dtDocSerie As DataTable
    Private dtPtoVenta As DataTable
    Private BOLNuevo As Boolean

    Private Sub ToolNuevo_Click(sender As Object, e As EventArgs) Handles ToolNuevo.Click
        BOLNuevo = True
        ToolGrabar.Enabled = True
        ToolNuevo.Enabled = False
        ToolEditar.Enabled = False
        ToolCancelar.Enabled = True
        tcPtoVenta.TabPages.Insert(1, tpDatos)
        tcPtoVenta.TabPages.Remove(tpListado)
        tcPtoVenta.SelectTab(0)
        txtCodigo.ReadOnly = False
        cbAlmacen.SelectedIndex = -1
        txtCodigo.Focus()
    End Sub

    Private Sub frmPuntosVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        tcPtoVenta.TabPages.Remove(tpDatos)
        Call CargarAlmacenes()
        Call Estructura()
        Call CargaPtoVenta()
    End Sub

    Private Sub CargaPtoVenta()
        dtPtoVenta = New DataTable
        cAyudas = New ClsAyudas
        dtPtoVenta = cAyudas.get_Pto_Venta("")
        dgwPuntosVenta.DataSource = dtPtoVenta
        dgwPuntosVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgwPuntosVenta.Columns(0).HeaderText = "Pto. Venta"
        dgwPuntosVenta.Columns(1).HeaderText = "Descripción"
        dgwPuntosVenta.Columns(2).HeaderText = "Direccion"
        dgwPuntosVenta.Columns(3).HeaderText = "Cod. Almacen"
        dgwPuntosVenta.Columns(4).HeaderText = "Des. Almacen"
        dgwPuntosVenta.Columns(3).Visible = False
        cAyudas = Nothing
    End Sub

    Private Sub CargarAlmacenes()
        cAyudas = New ClsAyudas
        dtAlmacen = New DataTable
        dtAlmacen = cAyudas.get_Almacenes
        cbAlmacen.DataSource = dtAlmacen
        cbAlmacen.ValueMember = dtTable.Columns(0).ToString
        cbAlmacen.DisplayMember = dtTable.Columns(1).ToString
        cbAlmacen.SelectedIndex = -1
        cAyudas = Nothing
    End Sub

    Private Sub ToolCancelar_Click(sender As Object, e As EventArgs) Handles ToolCancelar.Click
        Call Limpiar()
        ToolNuevo.Enabled = True
        ToolEditar.Enabled = True
        ToolGrabar.Enabled = False
        tcPtoVenta.TabPages.Remove(tpDatos)
        tcPtoVenta.TabPages.Insert(0, tpListado)
    End Sub
    Private Sub Limpiar()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtDescripcion.Clear()
        cbAlmacen.SelectedIndex = -1
        dtDocSerie.Clear()
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub ToolSalir_Click(sender As Object, e As EventArgs) Handles ToolSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim fTipoDocSerie As frmDocSerie
        fTipoDocSerie = New frmDocSerie
        With fTipoDocSerie
            .ShowDialog()
            If .TipoDoc.Trim.Length > 0 Then
                Dim myFila As DataRow = dtDocSerie.NewRow
                myFila("Documento") = .TipoDoc
                myFila("Serie") = .NumSerie
                dtDocSerie.Rows.Add(myFila)
                dtDocSerie.AcceptChanges()
            End If
        End With
    End Sub

    Private Sub Estructura()
        dtDocSerie = New DataTable("DetPedido")
        dtDocSerie.Columns.Add("Documento", Type.GetType("System.String"))
        dtDocSerie.Columns.Add("Serie", Type.GetType("System.String"))
        dgwDocumentos.DataSource = dtDocSerie
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgwDocumentos.SelectedRows.Count > 0 Then
            If MessageBox.Show("¿Seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dtDocSerie.Rows(dgwDocumentos.CurrentRow.Index).Delete()
                dtDocSerie.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub ToolEditar_Click(sender As Object, e As EventArgs) Handles ToolEditar.Click
        If dgwPuntosVenta.SelectedRows.Count > 0 Then
            Dim INTFila As Int16 = dgwPuntosVenta.CurrentRow.Index
            BOLNuevo = False
            ToolNuevo.Enabled = False
            ToolEditar.Enabled = False
            ToolGrabar.Enabled = True
            ToolCancelar.Enabled = True
            tcPtoVenta.TabPages.Insert(1, tpDatos)
            tcPtoVenta.TabPages.Remove(tpListado)
            tcPtoVenta.SelectTab(0)
            txtCodigo.Text = dgwPuntosVenta.Rows(dgwPuntosVenta.CurrentRow.Index).Cells(0).Value
            txtCodigo.ReadOnly = True
            txtDescripcion.Text = dgwPuntosVenta.Rows(dgwPuntosVenta.CurrentRow.Index).Cells(1).Value
            txtDireccion.Text = dgwPuntosVenta.Rows(dgwPuntosVenta.CurrentRow.Index).Cells(2).Value
            cbAlmacen.SelectedValue = dgwPuntosVenta.Rows(dgwPuntosVenta.CurrentRow.Index).Cells(3).Value
            cAyudas = New ClsAyudas
            dtDocSerie = cAyudas.get_Documento_Pto_Venta(txtCodigo.Text)
            dgwDocumentos.DataSource = dtDocSerie
            cAyudas = Nothing
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub ToolGrabar_Click(sender As Object, e As EventArgs) Handles ToolGrabar.Click
        Dim STRInsUpd As String = String.Empty
        If BOLNuevo = True Then
            STRInsUpd = "I"
            If txtCodigo.Text.Trim.Length = 0 Then
                MessageBox.Show("Debe ingresar un código para el punto de venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodigo.Focus()
                Exit Sub
            End If
            cAyudas = New ClsAyudas

            cAyudas = Nothing
        Else
            STRInsUpd = "U"
        End If

        If txtDescripcion.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar la descripción para el punto de venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Focus()
            Exit Sub
        ElseIf cbAlmacen.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir un almacén para el punto de venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbAlmacen.Focus()
            Exit Sub
        End If

        Dim cCabPtoVenta As ClsDocSerieTO.Cab_Pto_Venta
        Dim cDetDocSerie As New List(Of ClsDocSerieTO.Det_Doc_Serie)
        Dim cFilDocSerie As ClsDocSerieTO.Det_Doc_Serie

        cCabPtoVenta = New ClsDocSerieTO.Cab_Pto_Venta

        With cCabPtoVenta
            .CodPtoVenta = txtCodigo.Text.Trim
            .Descripcion = txtDescripcion.Text.Trim
            .Direccion = txtDireccion.Text.Trim
            .CodAlmacen = cbAlmacen.SelectedValue
        End With

        Dim INTFila As Int16
        For INTFila = 0 To dtDocSerie.Rows.Count - 1
            cFilDocSerie = New ClsDocSerieTO.Det_Doc_Serie
            With cFilDocSerie
                .TipoDoc = dtDocSerie.Rows(INTFila).Item(0).ToString
                .Serie = dtDocSerie.Rows(INTFila).Item(1).ToString
            End With
            cDetDocSerie.Add(cFilDocSerie)
        Next

        cProc = New ClsBuscar
        If cProc.Inserta_PtoVentas(cCabPtoVenta, cDetDocSerie, STRInsUpd) = True Then
            MessageBox.Show("Datos grabados correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Limpiar()
            Call ToolCancelar_Click(sender, e)
            Call CargaPtoVenta()
        End If
        cProc = Nothing

    End Sub
End Class