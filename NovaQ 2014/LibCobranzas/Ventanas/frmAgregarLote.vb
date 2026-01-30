Imports LibComunVar
Imports LibCobranzas
Imports System.Windows.Forms

Public Class frmAgregarLote
    Public idProducto As String = String.Empty
    Public idAlmacen As String = String.Empty
    Dim loteBL As ClsOperaciones.LOT
    Dim loteEnt As ClsEntidades.LOT
    Public indicador As Boolean = False

    Private Sub frmAgregarLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpfechaVencimiento.Value = ModFunciones.Ultimo_Dia_Mes(ClsVarComun.FechaSistema)
        dtpfechaFabricacion.Value = ModFunciones.Primer_Dia_Mes(ClsVarComun.FechaSistema)
        ''.mostrando datos
        txtcodigoAlmacen.Text = idAlmacen
        txtcodigoArticulo.Text = idProducto
        '...Mostrando Descripcion 
        txtdescripcionArt.Text = MostrandoDescripcion("SELECT DESCRIPTION FROM PART WHERE ID= '" & idProducto & "'")
        txtdescripcionAlm.Text = MostrandoDescripcion("SELECT NAME  FROM WAREHOUSE  WHERE ID='" & idAlmacen & "' ")
    End Sub

    Private Function MostrandoDescripcion(ByVal cadena As String) As String
        Dim resultado As String = String.Empty
        Try
            If cadena = String.Empty Then Exit Try
            Dim dtTable As New DataTable
            Dim LibData As New LibConexion.ClsData
            dtTable = LibData.Run_Query_DataTable(cadena)
            If dtTable.Rows.Count <> 0 Then
                resultado = dtTable.Rows(0).Item(0).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function

    Private Function ValidacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If CDate(dtpfechaVencimiento.Value.ToString("dd/MM/yyyy")) < CDate(dtpfechaFabricacion.Value.ToString("dd/MM/yyyy")) Then
                MessageBox.Show("El rango de fechas es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpfechaVencimiento.Focus()
                estado = False
                Exit Try
            End If
            '----------
            If txtcodigoAlmacen.Text = String.Empty Then
                MsgBox("No existe el codigo del Almacen.", MsgBoxStyle.Information)
                txtcodigoAlmacen.Focus()
                estado = False
                Exit Try
            ElseIf txtcodigoArticulo.Text = String.Empty Then
                MsgBox("No existe el codigo del Articulo.", MsgBoxStyle.Information)
                txtcodigoArticulo.Focus()
                estado = False
                Exit Try
            End If

            If txtcodigoLote.Text = String.Empty Then
                MsgBox("Debe ingresar un codigo para el Lote.", MsgBoxStyle.Information)
                txtcodigoLote.Focus()
                estado = False
                Exit Try
            Else
                loteBL = New ClsOperaciones.LOT
                Dim dtlote As New DataTable
                Dim cantidad As Integer = 0
                dtlote = loteBL.Get_Lotes_Codigo(txtcodigoAlmacen.Text, txtcodigoArticulo.Text, txtcodigoLote.Text)
                If dtlote.Rows.Count() <> 0 Then
                    cantidad = dtlote.Rows(0).Item(0)
                    If cantidad = 1 Then
                        MsgBox("El codigo de Lote ya existe.", MsgBoxStyle.Information)
                        txtcodigoLote.Focus()
                        estado = False
                        Exit Try
                    End If
                End If
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function


    Private Function GuardarLote() As Boolean
        Dim estado As Boolean = True
        Try
            loteBL = New ClsOperaciones.LOT
            loteEnt = New ClsEntidades.LOT
            loteEnt.WHO_ID = txtcodigoAlmacen.Text
            loteEnt.PART_ID = txtcodigoArticulo.Text
            loteEnt.LOT_ID = txtcodigoLote.Text
            loteEnt.QTY_ON_HAND = 0
            loteEnt.MANUFACT_DATE = dtpfechaFabricacion.Value
            loteEnt.CADUCATE_DATE = dtpfechaVencimiento.Value
            loteEnt.COMMENT = txtComentarios.Text
            loteBL.Insert(loteEnt)
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If ValidacionesGenerales() = False Then
            Exit Sub
        Else
            If GuardarLote() = True Then
                MsgBox("Guardado Exitosamente", MsgBoxStyle.Information)
                Me.Close()
            End If
        End If
    End Sub

 

    Private Sub txtComentarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentarios.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtComentarios.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        indicador = True
        Me.Hide()
    End Sub
End Class