Public Class FrmManufactura_Formulas_HC

    Dim Modo_consultar As Boolean = False
    Dim ManufactutraCabENT As ClsEntidades.FORMULATION
    Dim ManufactutraDetENT As ClsEntidades.FORMULATION_LINE
    Dim ManufactutraDetENT_Procesos As ClsEntidades.FORMULATION_LINE_PROCESOS
    Dim ListaDetalles As List(Of ClsEntidades.FORMULATION_LINE)
    Dim ListaDetalles_Procesos As List(Of ClsEntidades.FORMULATION_LINE_PROCESOS)

    Dim ManufactutraBl As ClsOperaciones.FORMULATION

    Dim dtdetalleArticuloPrincipal As DataTable
    Dim dtdetalleArticuloPrincipal_Procesos As DataTable
    Public _id As Integer

    Private Sub FrmManufactura_Formulas_HC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ManufactutraBl = New ClsOperaciones.FORMULATION
            ''Detalle
            ManufactutraBl = New ClsOperaciones.FORMULATION
            GenerarColummnaDataTable()
            dtdetalleArticuloPrincipal = ManufactutraBl.Modo_Edicion_Detalle_HC(_id, "")
            If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
                ConfigurarGrila()
            End If

            GenerarColummnaDataTable_Procesos()
            dtdetalleArticuloPrincipal_Procesos = ManufactutraBl.Modo_Edicion_Detalle_Procesos_HC(_id, "")
            If dtdetalleArticuloPrincipal_Procesos.Rows.Count() <> 0 Then
                ConfigurarGrila_Proceso()
            End If
            TabControl1.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrila_Proceso()
        If dtdetalleArticuloPrincipal_Procesos.Rows.Count() <> 0 Then
            dgvDetalles_procesos.DataSource = Nothing
            dgvDetalles_procesos.DataSource = dtdetalleArticuloPrincipal_Procesos
            dgvDetalles_procesos.AutoResizeColumns()
            dgvDetalles_procesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvDetalles_procesos.Columns(0).HeaderText = "Item"
            dgvDetalles_procesos.Columns(1).HeaderText = "Proceso"
            dgvDetalles_procesos.Columns(2).HeaderText = "Maquina"
        End If

    End Sub

    Private Sub ConfigurarGrila()
        If dtdetalleArticuloPrincipal.Rows.Count() <> 0 Then
            dgvDetalles.DataSource = Nothing
            dgvDetalles.DataSource = dtdetalleArticuloPrincipal
            dgvDetalles.Columns(0).Width = 40
            dgvDetalles.Columns(1).Width = 80
            dgvDetalles.Columns(2).Width = 200
            dgvDetalles.Columns(3).Width = 80
            dgvDetalles.Columns(4).Width = 80
            dgvDetalles.Columns(5).Width = 80
            dgvDetalles.Columns(6).Width = 80
            dgvDetalles.Columns(7).Width = 80
            dgvDetalles.Columns(8).Width = 80
            dgvDetalles.Columns(9).Width = 80
            dgvDetalles.Columns(10).Width = 80

            dgvDetalles.Columns(0).HeaderText = "Item"
            dgvDetalles.Columns(1).HeaderText = "Codigo"
            dgvDetalles.Columns(2).HeaderText = "Producto"
            dgvDetalles.Columns(3).HeaderText = "Unidad"
            dgvDetalles.Columns(4).HeaderText = "Cantidad"
            dgvDetalles.Columns(5).Visible = False '.HeaderText = "Cant.Teor"
            dgvDetalles.Columns(6).Visible = False 'HeaderText = "Costo"
            dgvDetalles.Columns(7).Visible = False 'HeaderText = "Equival"
            dgvDetalles.Columns(8).Visible = False 'HeaderText = "Tipo"
            dgvDetalles.Columns(9).Visible = False 'HeaderText = "%.Exceso"
            dgvDetalles.Columns(10).Visible = False 'HeaderText = "Desc.Total"
        End If
    End Sub



    Public Sub GenerarColummnaDataTable()
        Try
            dtdetalleArticuloPrincipal = New DataTable
            dtdetalleArticuloPrincipal.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal.Columns.Add("PART_ID", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCRIPTION", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("UNIT", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("QTY_TEORICA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("AVERAGE_COST", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("EQUIVALENCIA", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("TYPE", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal.Columns.Add("POR_EXCESO", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.Columns.Add("DESCARGA_TOTAL", Type.GetType("System.Double"))
            dtdetalleArticuloPrincipal.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GenerarColummnaDataTable_Procesos()
        Try
            dtdetalleArticuloPrincipal_Procesos = New DataTable
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("ITEM", Type.GetType("System.Int64"))
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("PROCESO", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_Procesos.Columns.Add("MAQUINA", Type.GetType("System.String"))
            dtdetalleArticuloPrincipal_Procesos.PrimaryKey = New DataColumn() {dtdetalleArticuloPrincipal_Procesos.Columns("ITEM")}
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class