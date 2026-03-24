Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibCobranzas

Public Class ClsTransaccionesAlm

    Public Class SOLICITANTE
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

        Public Sub NumeroCorrelativoSolicitante()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_CORRELATIVO_SOLICITANTE").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class


    Public Class AREA
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

        Public Sub NumeroCorrelativoArea()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_CORRELATIVO_AREA").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class


    Public Class REQUIREMENT
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

        Public Sub NumeroCorrelativo_Guia_Devolucion(ByVal anio As Integer)
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_CORRELATIVO_GUIA_DEVOLUCION", anio).Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                Else
                    NumeroCorrelativo = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub NumeroCorrelativoRequisicion(ByVal TIPO As String)
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_CORRELATIVO", TIPO).Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class

    Public Class PURCHASE_ORDER
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

        Public Sub Get_NumeroCorrelativoOrdenServicio()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PUR_SP_S_CORRELATIVO_ORDEN_SERVICIO").Tables(0)
                NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub


        Public Sub Get_NumeroCorrelativoOrdenCompra()
            Try
                Dim dtdetalles As New DataTable
                'dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PUR_SP_S_CORRELATIVO").Tables(0)
                NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

        Public Sub Get_NumeroCorrelativoOrdenCompraII(ByVal TYPE As String)
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "PUR_SP_S_CORRELATIVO_II", TYPE).Tables(0)
                NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

    End Class

    Public Class PURCHASE_FACT_SUPPLIER
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Private _NumeroCorrelativo As Double
        Private _NumeroCorrelativo_OrdenPago As Double

        Public Property NumeroCorrelativo As Double
            Get
                Return _NumeroCorrelativo
            End Get
            Set(value As Double)
                _NumeroCorrelativo = value
            End Set
        End Property

        Public Property NumeroCorrelativo_OrdenPago As Double
            Get
                Return _NumeroCorrelativo_OrdenPago
            End Get
            Set(value As Double)
                _NumeroCorrelativo_OrdenPago = value
            End Set
        End Property


        Public Sub Get_NumeroCorrelativoCompra(ByVal FECHA As String)
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_COMPRAS_CORRELATIVO", FECHA).Tables(0)
                NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

        Public Sub Get_NumeroCorrelativoOrdenPago(ByVal anio As String)
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_NUM_PAGO_CORRELATIVO", anio).Tables(0)
                NumeroCorrelativo_OrdenPago = CDbl(dtdetalles.Rows(0).Item("LAST_NUMBER").ToString) + 1
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

    End Class


    Public Class CARRIER
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

        Public Sub NumeroCorrelativoCarrier()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_CARRIER_CORRELATIVO").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class

    Public Class VEHICLE
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

        Public Sub NumeroCorrelativoVehicle()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_VEHICLE_CORRELATIVO").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class



    Public Class EMPRESA_TRANSPORTE
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

        Public Sub NumeroCorrelativoEmpresa_transporte()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_EMPRESA_TRANSPORTE_CORRELATIVO").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class
    Public Class TRAMAS
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

        Public Sub NumeroCorrelativoTramas()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_TRAMAS_CORRELATIVO").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class


End Class
