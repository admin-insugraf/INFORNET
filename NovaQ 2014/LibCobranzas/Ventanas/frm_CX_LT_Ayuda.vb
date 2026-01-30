Imports System.Windows.Forms

Public Class frm_CX_LT_Ayuda
    Public p_bol_aceptar As Boolean = False
    Public p_ops As Integer = 0
    Public p_ls_sel As New List(Of String)
    Public p_parametro1 As String = String.Empty
    Public p_parametro2 As String = String.Empty
    Dim dv_data As DataView

    Private Sub frm_CX_LT_Ayuda_InputLanguageChanged(sender As Object, e As InputLanguageChangedEventArgs) Handles Me.InputLanguageChanged
        txt_filtro.Focus()
    End Sub

    Private Sub frm_CX_LT_Ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case p_ops
            Case 1 'vendedores
                Me.Text = "Lista de Vendedores"
                Dim vendedorBL As New ClsOperaciones.SALES_REP
                dv_data = vendedorBL.getVendedores_ayuda().DefaultView
                vendedorBL = Nothing
            Case 2 'forma de pago
                Me.Text = "Lista de Forma de Pago"
                Dim formapaBL As New ClsOperaciones.TERMS
                dv_data = formapaBL.get_terms_ayuda().DefaultView
                formapaBL = Nothing
            Case 3 ' familias
                Me.Text = "Lista de Familias"
                Dim familiaBL As New ClsOperaciones.FAMILY
                dv_data = familiaBL.get_familias_Ayuda.DefaultView
                familiaBL = Nothing
            Case 4 ' Unidades de Medida
                Me.Text = "Lista de Unidades de Medidas"
                Dim unidadesBL As New ClsOperaciones.UNITS
                dv_data = unidadesBL.get_Unidades_ayuda.DefaultView
                unidadesBL = Nothing
            Case 5 ' Vendedor
                Me.Text = "Lista de Vendedores"
                Dim vendedorBL As New ClsOperaciones.SALES_REP
                dv_data = vendedorBL.getVendedores_ayuda.DefaultView
                vendedorBL = Nothing
            Case 6 ' Linea de Familia
                Me.Text = "Lista de Lineas de Familia"
                Dim lineasBL As New ClsOperaciones.LINES
                dv_data = lineasBL.get_Lineas_Ayuda(p_parametro1).DefaultView
                lineasBL = Nothing
            Case 7
                Me.Text = "Lista de Proveedores"
                Dim proveedorBL As New ClsOperaciones.VENDOR
                dv_data = proveedorBL.get_Proveedores_Ayuda().DefaultView
                proveedorBL = Nothing
            Case 8
                Me.Text = "Lista de Clientes"
                Dim clienteBL As New ClsOperaciones.CUSTOMER
                dv_data = clienteBL.get_Clientes_ayuda().DefaultView
                clienteBL = Nothing
            Case 9
                Me.Text = "Lista de Tramos"
                Dim tramoBL As New ClsOperaciones.TRAMOS
                dv_data = tramoBL.get_Tramos_Ayuda().DefaultView
                tramoBL = Nothing
            Case 10
                Me.Text = "Lista de Transportistas"
                Dim tramoBL As New ClsOperaciones.CARRIER
                dv_data = tramoBL.get_Transportistas_Ayuda().DefaultView
                tramoBL = Nothing
            Case 11
                Me.Text = "Lista de Proyectos"
                Dim proyectoBL As New ClsOperaciones.PROYECT
                dv_data = proyectoBL.get_Proyectos_Ayuda().DefaultView
                proyectoBL = Nothing
            Case 12
                Me.Text = "Lista de Centro de Costos"
                Dim centrocostoBL As New ClsOperaciones.CENTER_COST
                dv_data = centrocostoBL.get_CentroCostos_Ayuda().DefaultView
                centrocostoBL = Nothing
            Case 13
                Me.Text = "Lista de Tipos de Transacciones"
                Dim tiposBL As New ClsOperaciones.TRANSACTION_TYPE
                dv_data = tiposBL.get_Transacciones_Ayuda().DefaultView
                tiposBL = Nothing
            Case 14
                Me.Text = "Lista de Tipos de Articulos"
                Dim clsTipoProductoBl As New ClsOperaciones.PART_TYPE
                dv_data = clsTipoProductoBl.get_TipoArticulo().DefaultView
            Case 15
                Me.Text = "Lista Lineas De Familias"
                Dim clsLineasBl As New ClsOperaciones.LINES
                dv_data = clsLineasBl.get_MostrarLineas(p_parametro1, p_parametro2).DefaultView
        End Select
        If dv_data.Table.Rows.Count <> 0 Then
            dgv_data.DataSource = dv_data
            dgv_data.Columns(0).Width = 100
        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As Object, e As EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro.TextChanged

        If txt_filtro.Text.Trim = "" Then
            dv_data.RowFilter = ""
        Else
            If chk_empieza.Checked Then
                dv_data.RowFilter = "descripcion like '" & txt_filtro.Text.Trim & "%'"
            Else
                dv_data.RowFilter = "descripcion like '%" & txt_filtro.Text.Trim & "%'"
            End If
        End If
    End Sub

    Private Sub Aceptar()
        If dgv_data.Rows.Count = 0 Then Exit Sub
        If dgv_data.CurrentRow Is Nothing Then Exit Sub

        p_bol_aceptar = True
        p_ls_sel.Clear()
        p_ls_sel.Add(dgv_data.CurrentRow.Cells(0).Value.ToString)
        p_ls_sel.Add(dgv_data.CurrentRow.Cells(1).Value.ToString)

        Me.Close()
    End Sub

    Private Sub dgv_data_DoubleClick(sender As Object, e As EventArgs) Handles dgv_data.DoubleClick
        Call Aceptar()
    End Sub

    Private Sub dgv_data_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_data.KeyDown

        If e.KeyCode = Keys.Escape Then
            p_bol_aceptar = False
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Call Aceptar()
        End If

        If e.KeyCode = Keys.Up Then
            If dgv_data.CurrentRow.Index = 0 Then
                txt_filtro.Focus()
            End If
        End If

    End Sub

    Private Sub txt_filtro_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_filtro.KeyDown
        If e.KeyCode = Keys.Escape Then
            p_bol_aceptar = False
            Me.Close()
        End If

        If e.KeyCode = Keys.Down Then
            dgv_data.Focus()
        End If
    End Sub
End Class