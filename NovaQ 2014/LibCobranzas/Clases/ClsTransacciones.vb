Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibCobranzas

Public Class ClsTransacciones


    Public Class clsDescuentosArticulos
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
            _DCTO1 = 0.0
            _DCTO2 = 0.0
            _DCTO3 = 0.0
            _DCTO4 = 0.0
        End Sub

        Private _DCTO1 As Double
        Private _DCTO2 As Double
        Private _DCTO3 As Double
        Private _DCTO4 As Double
        Private _EFFECTIVE_PRICE As Double

        Public Property EFFECTIVE_PRICE As Double
            Get
                Return _EFFECTIVE_PRICE
            End Get
            Set(value As Double)
                _EFFECTIVE_PRICE = value
            End Set
        End Property

        Public Property DCTO1 As Double
            Get
                Return _DCTO1
            End Get
            Set(value As Double)
                _DCTO1 = value
            End Set
        End Property

        Public Property DCTO2 As Double
            Get
                Return _DCTO2
            End Get
            Set(value As Double)
                _DCTO2 = value
            End Set
        End Property

        Public Property DCTO3 As Double
            Get
                Return _DCTO3
            End Get
            Set(value As Double)
                _DCTO3 = value
            End Set
        End Property

        Public Property DCTO4 As Double
            Get
                Return _DCTO4
            End Get
            Set(value As Double)
                _DCTO4 = value
            End Set
        End Property

        Public Function DescuentosArticulos(ByVal CodigoArticulo As String) As DataTable
            Try
                Dim dtDescuentos As New DataTable
                dtDescuentos = SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_DESC", CodigoArticulo).Tables(0)
                If dtDescuentos.Rows.Count() <> 0 Then
                    EFFECTIVE_PRICE = IIf(String.IsNullOrEmpty(dtDescuentos.Rows(0).Item("EFFECTIVE_PRICE").ToString), 0, dtDescuentos.Rows(0).Item("EFFECTIVE_PRICE"))
                    DCTO1 = IIf(String.IsNullOrEmpty(dtDescuentos.Rows(0).Item("DescDistribuidor_Desc1").ToString), 0, dtDescuentos.Rows(0).Item("DescDistribuidor_Desc1"))
                    DCTO2 = IIf(String.IsNullOrEmpty(dtDescuentos.Rows(0).Item("DescDistribuidor_Desc2").ToString), 0, dtDescuentos.Rows(0).Item("DescDistribuidor_Desc2"))
                    DCTO3 = IIf(String.IsNullOrEmpty(dtDescuentos.Rows(0).Item("DescFarmaciaDesc3").ToString), 0, dtDescuentos.Rows(0).Item("DescFarmaciaDesc3"))
                    DCTO4 = IIf(String.IsNullOrEmpty(dtDescuentos.Rows(0).Item("DescFarmaciaDesc4").ToString), 0, dtDescuentos.Rows(0).Item("DescFarmaciaDesc4"))
                End If
                Return dtDescuentos
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
    End Class

    Public Class clsVendedores
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Private _Dni As String
        Private _Password As String
        Private _ID As String
        Private _NAME As String
        Private _NIVEL As String
        Public Function Get_Datos_vendedor(ByVal _id_vendedor As String) As DataTable
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "PED_SP_S_VENDEDOR", _id_vendedor).Tables(0)
                Return dtdetalles
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Property Dni As String
            Get
                Return _Dni
            End Get
            Set(value As String)
                _Dni = value
            End Set
        End Property

        Public Property Password As String
            Get
                Return _Password
            End Get
            Set(value As String)
                _Password = value
            End Set
        End Property


        Public Property ID As String
            Get
                Return _ID
            End Get
            Set(value As String)
                _ID = value
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

        Public Property NIVEL As String
            Get
                Return _NIVEL
            End Get
            Set(value As String)
                _NIVEL = value
            End Set
        End Property


        Public Function Get_Datos_Vendor(ByVal Documento As String, ByVal contraseña As String) As DataTable
            Try
                Dim dtAccesoUser As New DataTable
                dtAccesoUser = SqlHelper.ExecuteDataset(cn, "PED_SP_S_ORDER_VENDEDOR", Documento).Tables(0)
                If dtAccesoUser.Rows.Count() <> 0 Then
                    Dni = dtAccesoUser.Rows(0).Item("DOC_NUMBER").ToString
                    Password = dtAccesoUser.Rows(0).Item("PASS").ToString
                    NAME = dtAccesoUser.Rows(0).Item("NAME").ToString
                    ID = dtAccesoUser.Rows(0).Item("ID").ToString
                End If
                Return dtAccesoUser
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Function

        Public Function Get_Datos_Vendor_Pedido(ByVal Documento As String, ByVal contraseña As String) As DataTable
            Try
                Dim dtAccesoUser As New DataTable
                dtAccesoUser = SqlHelper.ExecuteDataset(cn, "PED_SP_S_ORDER_VENDEDOR_PEDIDO", Documento).Tables(0)
                If dtAccesoUser.Rows.Count() <> 0 Then
                    Dni = dtAccesoUser.Rows(0).Item("DOC_NUMBER").ToString
                    Password = dtAccesoUser.Rows(0).Item("PASS").ToString
                    NAME = dtAccesoUser.Rows(0).Item("NAME").ToString
                    ID = dtAccesoUser.Rows(0).Item("ID").ToString
                    NIVEL = dtAccesoUser.Rows(0).Item("NIVEL").ToString
                End If
                Return dtAccesoUser
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Function


    End Class

    Public Class clsPedidos
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Private _Dni As String
        Private _Password As String
        Private _ID As String
        Private _NAME As String



        Public Function Get_DatosIgvArticulo(ByVal CodigoArticulo As String) As DataTable
            Try
                'creando tabla Temporal
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_ORDER_PART", CodigoArticulo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function Get_DatosIgvsSistema() As DataTable
            Try
                'creando tabla Temporal
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PED_SP_S_ORDER_PARAMETER").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function



    End Class

    Public Class ORDERS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Private _NumeroCorrelativo As Double
        Private _NumeroCorrelativo_Coti As Double

        Public Property NumeroCorrelativo As Double
            Get
                Return _NumeroCorrelativo
            End Get
            Set(value As Double)
                _NumeroCorrelativo = value
            End Set
        End Property

        Public Property NumeroCorrelativo_Coti As Double
            Get
                Return _NumeroCorrelativo_Coti
            End Get
            Set(value As Double)
                _NumeroCorrelativo_Coti = value
            End Set
        End Property

        Public Sub NumeroCorrelativoPedido()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "PED_SP_CORRELATIVO_PEDIDO").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub NumeroCorrelativo_Cotizacion()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "PED_SP_CORRELATIVO_QUOTE").Tables(0)
                If dtdetalles.Rows.Count() Then
                    NumeroCorrelativo_Coti = dtdetalles.Rows(0).Item("NUMBER").ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class

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
        Private _MODIFICA_CORRELATIVO As String

        Public Property MODIFICA_CORRELATIVO As String
            Get
                Return _MODIFICA_CORRELATIVO
            End Get
            Set(value As String)
                _MODIFICA_CORRELATIVO = value
            End Set
        End Property

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

        Public Sub Get_ItemDocumentos(ByVal _TipoDocumento As String, ByVal _SerieDoc As String)
            Try
                Dim dtNumeroline As New DataTable
                dtNumeroline = SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_NUMERO_ITEM", _TipoDocumento, _SerieDoc).Tables(0)
                For i As Integer = 0 To dtNumeroline.Rows.Count() - 1
                    NUMBER_LINE = dtNumeroline.Rows(i).Item("NUMBER_LINE").ToString
                Next
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Sub

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

        Public Sub Get_NumeroGuiaRemision(ByVal _num_serie As String, ByVal _tipo_doc As String)
            Try
                Dim dtGuiaRemision As New DataTable
                'dtGuiaRemision = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "GUIA_SP_S_GUIA_REMISION_DOCUMENT_CODIGO").Tables(0)
                dtGuiaRemision = SqlHelper.ExecuteDataset(cn, "GUIA_SP_S_GUIA_REMISION_DOCUMENT_CODIGO", _num_serie, _tipo_doc).Tables(0)
                For i As Integer = 0 To dtGuiaRemision.Rows.Count() - 1
                    TYPE_DOC = dtGuiaRemision.Rows(i).Item("TYPE_DOC").ToString
                    NUMBER_SERIE = dtGuiaRemision.Rows(i).Item("NUMBER_SERIE").ToString
                    LAST_NUMBER = dtGuiaRemision.Rows(i).Item("LAST_NUMBER").ToString
                    NUMBER_LINE = dtGuiaRemision.Rows(i).Item("NUMBER_LINE").ToString
                    If dtGuiaRemision.Rows(i).Item("NO_MODIFICA_CORRELATIVO").ToString = "N" Then
                        MODIFICA_CORRELATIVO = "S"
                    Else
                        MODIFICA_CORRELATIVO = "N"
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)

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
                MsgBox(ex.Message)
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
                If dtdetalles.Rows.Count <> 0 Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("LAST_NUMBER").ToString
                Else
                    NumeroCorrelativo = 0
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub
        Public Sub Get_NumeroCorrelativoChequePagos()
            Try
                Dim dtdetalles As New DataTable
                dtdetalles = SqlHelper.ExecuteDataset(cn, "CHEQUE_PAGOS_SP_S_CORRELATIVO").Tables(0)
                If dtdetalles.Rows.Count <> 0 Then
                    NumeroCorrelativo = dtdetalles.Rows(0).Item("LAST_NUMBER").ToString
                Else
                    NumeroCorrelativo = 0
                End If
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
