Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibCobranzas

Public Class ClsTransacciones

    Public Class PERFIL
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Private _NumeroCorrelativo As Double

        Public Property NumeroCorrelativo As Double
            Get
                Return _NumeroCorrelativo
            End Get
            Set(value As Double)
                _NumeroCorrelativo = value
            End Set
        End Property

        Public Sub NumeroCorrelativoPerfil()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "ADM_SP_S_CORRELATIVO_PERFIL").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class

End Class
