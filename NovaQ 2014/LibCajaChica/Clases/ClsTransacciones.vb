Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibCobranzas

Public Class ClsTransacciones

    Public Class PART_TYPE
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


        Public Sub NumeroCorrelativo_Tipo_Articulo()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "PART_SP_S_CORRELATIVO").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class


    Public Class clsMostrarTiposMovimiento

        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Private _TYPE_ID As String
        Private _MOV_ID As String
        Private _NAME As String
        Private _IS_VALUED As String
        Private _IS_VENDOR As String
        Private _IS_DOC_REF As String
        Private _IS_AUTHORIZED As String
        Private _IS_CCOST As String
        Private _IS_ORDER_PURCHASE As String
        Private _IS_COMMENT As String
        Private _IS_WHO As String
        Private _IS_CUSTOMER As String
        Private _IS_ORDER_MANUFACT As String
        Private _IS_ACCOUNT As String
        Private _VAR_COUNT As Double
        Private _WHO_ID As String
        Private _IS_GUIA_ANALISIS As String
        Private _WHO_ID_PART_TYPE As String



        Public Property TYPE_ID As String
            Get
                Return _TYPE_ID
            End Get
            Set(value As String)
                _TYPE_ID = value
            End Set
        End Property

        Public Property MOV_ID As String
            Get
                Return _MOV_ID
            End Get
            Set(value As String)
                _MOV_ID = value
            End Set
        End Property

        Public Property NAME As String
            Get
                Return _NAME
            End Get
            Set(value As String)
                _NAME = value
            End Set
        End Property

        Public Property IS_VALUED As String
            Get
                Return _IS_VALUED
            End Get
            Set(value As String)
                _IS_VALUED = value
            End Set
        End Property

        Public Property IS_VENDOR As String
            Get
                Return _IS_VENDOR
            End Get
            Set(value As String)
                _IS_VENDOR = value
            End Set
        End Property

        Public Property IS_DOC_REF As String
            Get
                Return _IS_DOC_REF
            End Get
            Set(value As String)
                _IS_DOC_REF = value
            End Set
        End Property

        Public Property IS_AUTHORIZED As String
            Get
                Return _IS_AUTHORIZED
            End Get
            Set(value As String)
                _IS_AUTHORIZED = value
            End Set
        End Property

        Public Property IS_CCOST As String
            Get
                Return _IS_CCOST
            End Get
            Set(value As String)
                _IS_CCOST = value
            End Set
        End Property

        Public Property IS_ORDER_PURCHASE As String
            Get
                Return _IS_ORDER_PURCHASE
            End Get
            Set(value As String)
                _IS_ORDER_PURCHASE = value
            End Set
        End Property

        Public Property IS_COMMENT As String
            Get
                Return _IS_COMMENT
            End Get
            Set(value As String)
                _IS_COMMENT = value
            End Set
        End Property

        Public Property IS_WHO As String
            Get
                Return _IS_WHO
            End Get
            Set(value As String)
                _IS_WHO = value
            End Set
        End Property

        Public Property IS_CUSTOMER As String
            Get
                Return _IS_CUSTOMER
            End Get
            Set(value As String)
                _IS_CUSTOMER = value
            End Set
        End Property

        Public Property IS_ORDER_MANUFACT As String
            Get
                Return _IS_ORDER_MANUFACT
            End Get
            Set(value As String)
                _IS_ORDER_MANUFACT = value
            End Set
        End Property

        Public Property IS_ACCOUNT As String
            Get
                Return _IS_ACCOUNT
            End Get
            Set(value As String)
                _IS_ACCOUNT = value
            End Set
        End Property

        Public Property VAR_COUNT As Double
            Get
                Return _VAR_COUNT
            End Get
            Set(value As Double)
                _VAR_COUNT = value
            End Set
        End Property

        Public Property WHO_ID As String
            Get
                Return _WHO_ID
            End Get
            Set(value As String)
                _WHO_ID = value
            End Set
        End Property

        Public Property IS_GUIA_ANALISIS As String
            Get
                Return _IS_GUIA_ANALISIS
            End Get
            Set(value As String)
                _IS_GUIA_ANALISIS = value
            End Set
        End Property

        Public Property WHO_ID_PART_TYPE As String
            Get
                Return _WHO_ID_PART_TYPE
            End Get
            Set(value As String)
                _WHO_ID_PART_TYPE = value
            End Set
        End Property


        Public Sub Get_TipoTransacciones(ByVal _TipoMov As String, ByVal _codigoTransaccion As String)
            Try
                Dim dtTransaccion As New DataTable
                dtTransaccion = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_TRANSACTION_TYPE", _TipoMov, _codigoTransaccion).Tables(0)
                If dtTransaccion.Rows.Count() <> 0 Then
                    For i As Integer = 0 To dtTransaccion.Rows.Count() - 1
                        TYPE_ID = dtTransaccion.Rows(i).Item("TYPE_ID").ToString
                        MOV_ID = dtTransaccion.Rows(i).Item("MOV_ID").ToString
                        NAME = dtTransaccion.Rows(i).Item("NAME").ToString
                        IS_VALUED = dtTransaccion.Rows(i).Item("IS_VALUED").ToString
                        IS_VENDOR = dtTransaccion.Rows(i).Item("IS_VENDOR").ToString
                        IS_DOC_REF = dtTransaccion.Rows(i).Item("IS_DOC_REF").ToString
                        IS_AUTHORIZED = dtTransaccion.Rows(i).Item("IS_AUTHORIZED").ToString
                        IS_CCOST = dtTransaccion.Rows(i).Item("IS_CCOST").ToString
                        IS_ORDER_PURCHASE = dtTransaccion.Rows(i).Item("IS_ORDER_PURCHASE").ToString
                        IS_COMMENT = dtTransaccion.Rows(i).Item("IS_COMMENT").ToString
                        IS_WHO = dtTransaccion.Rows(i).Item("IS_WHO").ToString
                        IS_CUSTOMER = dtTransaccion.Rows(i).Item("IS_CUSTOMER").ToString
                        IS_ORDER_MANUFACT = dtTransaccion.Rows(i).Item("IS_ORDER_MANUFACT").ToString
                        IS_ACCOUNT = dtTransaccion.Rows(i).Item("IS_ACCOUNT").ToString
                        VAR_COUNT = CDbl(dtTransaccion.Rows(i).Item("VAR_COUNT"))
                        WHO_ID = dtTransaccion.Rows(i).Item("WHO_ID").ToString
                        IS_GUIA_ANALISIS = dtTransaccion.Rows(i).Item("IS_GUIA_ANALISIS").ToString
                        WHO_ID_PART_TYPE = dtTransaccion.Rows(i).Item("WHO_ID_PART_TYPE").ToString
                    Next
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class

    Public Class clsAlmacen
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub
        Private _TYPE_DOC As String
        Private _NUMBER_SERIE As String
        Private _LAST_NUMBER As String
        Private _NUMBER_LINE As String

        Public Property TYPE_DOC As String
            Get
                Return _TYPE_DOC
            End Get
            Set(value As String)
                _TYPE_DOC = value
            End Set
        End Property

        Public Property NUMBER_SERIE As String
            Get
                Return _NUMBER_SERIE
            End Get
            Set(value As String)
                _NUMBER_SERIE = value
            End Set
        End Property

        Public Property LAST_NUMBER As String
            Get
                Return _LAST_NUMBER
            End Get
            Set(value As String)
                _LAST_NUMBER = value
            End Set
        End Property

        Public Property NUMBER_LINE As String
            Get
                Return _NUMBER_LINE
            End Get
            Set(value As String)
                _NUMBER_LINE = value
            End Set
        End Property

        'Public Sub Get_NumeroGuiaAnalisis()
        '    Try
        '        Dim dtguiaAnalisis As New DataTable
        '        dtguiaAnalisis = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WAREHOUSE_NUMBER_DOCUMENT_CODIGO").Tables(0)
        '        For i As Integer = 0 To dtguiaAnalisis.Rows.Count() - 1
        '            TYPE_DOC = dtguiaAnalisis.Rows(i).Item("TYPE_DOC").ToString
        '            NUMBER_SERIE = dtguiaAnalisis.Rows(i).Item("NUMBER_SERIE").ToString
        '            LAST_NUMBER = dtguiaAnalisis.Rows(i).Item("LAST_NUMBER").ToString
        '        Next
        '    Catch ex As Exception
        '        Throw
        '    End Try
        'End Sub

        Public Sub Get_NumeroGuiaAnalisis(ByVal _NUM_SERIE As String)
            Try
                Dim dtguiaAnalisis As New DataTable
                dtguiaAnalisis = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_NUMBER_DOCUMENT_CODIGO", "GA", _NUM_SERIE).Tables(0)
                For i As Integer = 0 To dtguiaAnalisis.Rows.Count() - 1
                    TYPE_DOC = dtguiaAnalisis.Rows(i).Item("TYPE_DOC").ToString
                    NUMBER_SERIE = dtguiaAnalisis.Rows(i).Item("NUMBER_SERIE").ToString
                    LAST_NUMBER = dtguiaAnalisis.Rows(i).Item("LAST_NUMBER").ToString
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Get_NumeroGuiaRemision(ByVal _serie As String)
            Try
                Dim dtGuiaRemision As New DataTable
                'dtGuiaRemision = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "GUIA_SP_S_GUIA_REMISION_DOCUMENT_CODIGO").Tables(0)
                dtGuiaRemision = SqlHelper.ExecuteDataset(cn, "GUIA_SP_S_GUIA_REMISION_DOCUMENT_CODIGO", _serie, "GS").Tables(0)
                For i As Integer = 0 To dtGuiaRemision.Rows.Count() - 1
                    TYPE_DOC = dtGuiaRemision.Rows(i).Item("TYPE_DOC").ToString
                    NUMBER_SERIE = dtGuiaRemision.Rows(i).Item("NUMBER_SERIE").ToString
                    LAST_NUMBER = dtGuiaRemision.Rows(i).Item("LAST_NUMBER").ToString
                    NUMBER_LINE = dtGuiaRemision.Rows(i).Item("NUMBER_LINE").ToString
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '------GENERACION DE PEDIDOS

        Public Sub Get_NumeroPedidos()
            Try
                Dim dtGuiaRemision As New DataTable
                dtGuiaRemision = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PED_SP_S_ORDER_DOCUMENT_CODIGO").Tables(0)
                For i As Integer = 0 To dtGuiaRemision.Rows.Count() - 1
                    TYPE_DOC = dtGuiaRemision.Rows(i).Item("TYPE_DOC").ToString
                    NUMBER_SERIE = dtGuiaRemision.Rows(i).Item("NUMBER_SERIE").ToString
                    LAST_NUMBER = dtGuiaRemision.Rows(i).Item("LAST_NUMBER").ToString
                    NUMBER_LINE = dtGuiaRemision.Rows(i).Item("NUMBER_LINE").ToString
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub



    End Class

    Public Class clsAlmacenCorrelativo
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


        Public Sub Get_NumeroCorrelativoAlmacen(ByVal codigoAlmacen As String, ByVal TipoMov As String)
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_CORRELATIVO", codigoAlmacen).Tables(0)
                If TipoMov = "I" Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("LAST_NUM_IN").ToString
                Else
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("LAST_NUM_OUT").ToString
                End If

            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class

    Public Class clsLetrasCorrelativo
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Private _NumeroCorrelativo As Double
        Private _NUMERIC_TYPE As Double

        Public Property NumeroCorrelativo As Double
            Get
                Return _NumeroCorrelativo
            End Get
            Set(value As Double)
                _NumeroCorrelativo = value
            End Set
        End Property

        Public Property NUMERIC_TYPE As Double
            Get
                Return _NUMERIC_TYPE
            End Get
            Set(value As Double)
                _NUMERIC_TYPE = value
            End Set
        End Property

        Public Sub Get_NumeroCorrelativoLetra(ByVal TipoDoc As String)
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETTER_CORRELATIVO", TipoDoc).Tables(0)
                NumeroCorrelativo = dtdetalles.Rows(0).Item("LAST_NUMBER").ToString
            Catch ex As Exception
                Throw
            End Try
        End Sub
        Public Sub Get_NumeroCorrelativoCheque()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "CHEQUE_SP_S_CORRELATIVO").Tables(0)
                NumeroCorrelativo = dtdetalles.Rows(0).Item("LAST_NUMBER").ToString
            Catch ex As Exception
                Throw
            End Try
        End Sub
        Public Sub Get_PorcentajeRetencion()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_LETTER_CONCEPTS_RETENCION").Tables(0)
                NUMERIC_TYPE = dtdetalles.Rows(0).Item("NUMERIC_TYPE").ToString
            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class

End Class
