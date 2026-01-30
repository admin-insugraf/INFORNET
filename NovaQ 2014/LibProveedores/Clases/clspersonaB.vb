Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports System.Windows.Forms

Public Class clspersonaB

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData
    Private LibData As LibConexion.ClsData

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub
    Public Function Insert(entidad As ClsPersonaEnt) As Boolean
        Dim estado As Boolean = True
        Try
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "SP_G_PERSONA", .CODIGO, .NOMBRE, .APELLIDO, .EDAD)
            End With
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
            Return estado
        End Try
        Return estado
    End Function
    Public Function MostrarDatos() As DataTable
        Dim data As New LibConexion.ClsData
        Dim dt As New DataTable
        Try
            dt = data.Run_SP_DataTable("SP_L_PERSONA")
            Return dt
        Catch ex As Exception
            Throw
        End Try
        Return dt
    End Function

    Public Function Mostrar(ByVal grilla As DataGridView) As DataTable
        Dim table As New DataTable
        Try
            For i As Integer = 0 To grilla.Columns.Count() - 1
                table.Columns.Add(grilla.Columns(i).Name)
            Next
            Dim Row As DataRow = table.NewRow
            For j As Integer = 0 To grilla.Columns.Count() - 1
                Row(grilla.Columns(j).Name) = grilla.Item(j, grilla.CurrentRow.Index).Value
            Next
            table.Rows.Add(Row)
            Mostrar = table
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_DevolverDatos(ByVal Part_id As String) As DataTable
        Dim data As New LibConexion.ClsData
        Dim dt As New DataTable
        Try
            LibData = New LibConexion.ClsData
            dt = LibData.Run_SP_DataTable("PART_SP_S_PART_QT", LibData.DatosParam("@PART_ID", SqlDbType.VarChar, 20, Part_id))
            Return dt
        Catch ex As Exception
            dt = Nothing
            Throw
        End Try
        Return dt
    End Function

End Class
