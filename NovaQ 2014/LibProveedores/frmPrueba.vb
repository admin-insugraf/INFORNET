Imports System.Data
Imports System.Windows.Forms
Public Class frmPrueba

    Dim clspersonaBl As clspersonaB
    Dim clspersonaEnt As ClsPersonaEnt
    Dim dtpersona As DataTable
    Dim dtpersonaDetalles As DataTable
    Dim dtDetalles As DataTable
    Dim dtdatos As DataTable

    Private Sub GenerarColummnaDataTable()
        dtDetalles = New DataTable("DetPedido")
        dtDetalles.Columns.Add("WAREHOUSE_ID", Type.GetType("System.String"))
        dtDetalles.Columns.Add("DOCUMENT_ID", Type.GetType("System.String"))
        dtDetalles.Columns.Add("NUMBER_DOCUMENT", Type.GetType("System.String"))
        dtDetalles.Columns.Add("DATE_DOCUMENT", Type.GetType("System.String"))
        dtDetalles.Columns.Add("LOTE", Type.GetType("System.String"))
        dtDetalles.Columns.Add("QTY", Type.GetType("System.Double"))
        dtDetalles.Columns.Add("QTY_BULTOS", Type.GetType("System.Double"))
        dtDetalles.Columns.Add("ITEM", Type.GetType("System.Int16"))
    End Sub
    Private Sub LLenarDatos()
        Try
            clspersonaBl = New clspersonaB
            dtdatos = New DataTable
            dtdatos = clspersonaBl.Get_DevolverDatos(txtPartId.Text)
            If dtdatos Is Nothing Or dtdatos.Rows.Count() = 0 Then
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.DataGridView3.DataSource = dtdatos
            Actualizar(dtdatos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Actualizar(ByVal tabla As DataTable)
        For i As Integer = 0 To tabla.Rows.Count() - 1
            Dim row As DataRow = dtDetalles.NewRow
            row("PART_ID") = tabla.Rows(i).Item("PART_ID").ToString
            row("LOT_ID") = tabla.Rows(i).Item("LOT_ID").ToString
            row("QTY_ON_HAND") = tabla.Rows(i).Item("QTY_ON_HAND").ToString
            row("QTY_DESC") = 0
            row("QTY_SALDO") = 0
            row("ITEM") = i + 1
            dtDetalles.Rows.Add(row)
        Next
        If dtDetalles.Rows.Count() <> 0 Then
            CalcularTotal(dtDetalles)
        End If
        Me.DataGridView2.DataSource = dtDetalles
    End Sub
    Private Sub CalcularTotal(ByVal tabla As DataTable)
        Dim QTY_ON_HAND As Double = 0.0
        Dim Total As Double = 0.0
        Total = Me.TextBox5.Text
        Dim row() As DataRow = tabla.Select("", "ITEM asc")
        Dim Stock As Double = 0.0
        Stock = tabla.Compute("Sum(QTY_ON_HAND)", "")
        MsgBox("Stock disponible:" & Stock, MsgBoxStyle.Information)
        For i As Integer = 0 To tabla.Rows.Count() - 1
            QTY_ON_HAND = CDbl(tabla.Rows(i).Item("QTY_ON_HAND"))

            If QTY_ON_HAND > Total Then
                If row(i) IsNot Nothing Then
                    row(i)("QTY_DESC") = Total
                    row(i)("QTY_SALDO") = CDbl(row(i)("QTY_ON_HAND")) - Total
                End If
                Exit For
            Else
                Total -= QTY_ON_HAND
                If row(i) IsNot Nothing Then
                    row(i)("QTY_DESC") = CDbl(tabla.Rows(i).Item("QTY_ON_HAND"))
                    row(i)("QTY_SALDO") = 0
                End If
            End If
        Next
        tabla.AcceptChanges()
    End Sub



    Private Function GenerarColumna(ByVal grilla As DataGridView) As DataTable
        clspersonaBl = New clspersonaB
        dtpersonaDetalles = New DataTable
        Try
            dtpersonaDetalles = clspersonaBl.Mostrar(grilla)
        Catch ex As Exception
            dtpersonaDetalles = Nothing
        End Try
        Return dtpersonaDetalles
    End Function

    Private Sub MOSTRAR()
        Try
            clspersonaBl = New clspersonaB
            dtpersona = New DataTable
            dtpersona = clspersonaBl.MostrarDatos()
            If dtpersona Is Nothing Or dtpersona.Rows.Count() = 0 Then
                MsgBox("No hay informacion disponible", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.DataGridView1.DataSource = dtpersona
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub INSERTAR()
        Try
            clspersonaBl = New clspersonaB
            clspersonaEnt = New ClsPersonaEnt

            clspersonaEnt.CODIGO = Me.TextBox1.Text
            clspersonaEnt.NOMBRE = Me.TextBox2.Text
            clspersonaEnt.APELLIDO = Me.TextBox3.Text
            clspersonaEnt.EDAD = CInt(Me.TextBox4.Text)
            If clspersonaBl.Insert(clspersonaEnt) = True Then
                MsgBox("Guardado, exitosamente.", MsgBoxStyle.Information)
                MOSTRAR()
            Else
                MsgBox("Error en Almacenamiento.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MOSTRAR()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        INSERTAR()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DataGridView2.DataSource = GenerarColumna(Me.DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim frmHelp As New frmAyudaVar
        With frmHelp
            .Titulo = "Listado de productos"
            .CodAlmacen = ""
            .TipoAyuda = frmAyudaVar.STipoAyuda.Articulos
            .ShowDialog()
            If .Data_Matriz.Rows.Count > 0 Then
                Dim myFila As DataRow = dtpersonaDetalles.NewRow
                For i As Integer = 0 To dtpersonaDetalles.Columns.Count() - 1
                    myFila(dtpersonaDetalles.Columns(i).ColumnName) = .dgwDatos.Item(i, .dgwDatos.CurrentRow.Index).Value
                Next
                dtpersonaDetalles.Rows.Add(myFila)
                dtpersonaDetalles.AcceptChanges()
                Me.DataGridView2.DataSource = dtpersonaDetalles
            End If
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GenerarColummnaDataTable()
        LLenarDatos()
    End Sub
End Class