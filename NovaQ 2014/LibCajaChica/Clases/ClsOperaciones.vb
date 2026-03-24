Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibComunVar
Imports LibContabilidad
Imports System.Threading
Imports System.Windows.Forms

Public Class ClsOperaciones

    Public Class USUARIO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub
        Public Function DatosGeneralesUsuario(ByVal _CodigoUsuario As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_DATOS_USUARIO", _CodigoUsuario).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Actualizar_DatosUsuario(ByVal _CodigoUsuario As String, ByVal Pass As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ADM_SP_U_DATOS_USUARIO", _CodigoUsuario, Pass)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function NivelAcceso(ByVal _CodigoU As String) As String
            Try
                Dim dtnivel As New DataTable
                dtnivel = SqlHelper.ExecuteDataset(cn, "ADM_SP_S_NIVEL", _CodigoU).Tables(0)
                NivelAcceso = dtnivel.Rows(0).Item("NIVEL_ACCESO").ToString
                Return NivelAcceso
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



    End Class





    Public Class DEVOLUTION
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Verificacion_Anulacion(ByVal Tipodoc As String, ByVal serie As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "DEV_SP_S_VERIFICACION_ANULACION", Tipodoc, serie, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosDevolucionModoEdicion(ByVal Tipodoc As String, ByVal serie As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "DEV_SP_S_DEVOLUCION_CABECERA", Tipodoc, serie, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosDevolucionDetalleModoEdicion(ByVal Tipodoc As String, ByVal serie As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "DEV_SP_S_DEVOLUCION_DETALLE", Tipodoc, serie, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function EliminacionDevolucion(ByVal _USER As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                     ByVal _NUMBER_DOCUMENT As String) As Boolean
            Dim ESTADO As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "DEV_SP_D_DEVOLUTION", _USER, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
                'Actualizando Almacen
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                ESTADO = False
            End Try
            Return ESTADO
        End Function

        Public Function AnularDevolucion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                     ByVal _NUMBER_DOCUMENT As String) As Boolean
            Dim ESTADO As Boolean = True
            Try
                SqlHelper.ExecuteNonQuery(cn, "DEV_SP_U_DEVOLUTION", _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                ESTADO = False
            End Try
            Return ESTADO
        End Function


        Public Function GuardarDevoluciones(ent_cab As ClsEntidades.DEVOLUTION, lista As List(Of ClsEntidades.DEVOLUTION_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab

                    SqlHelper.ExecuteNonQuery(tr, "DEV_SP_I_DEVOLUCION", .DOCUMENT_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .DOCUMENT_DATE, .CADUCATE_DATE, .DR_CR, _
                                              .SALES_REP_ID, .PLACE_SALES, .NUMBER_QUOTE, .NUMBER_ORDER_PUR, .CFDESCPG, .POINT_ORIG, .POINT_BOARD, _
                                              .POINT_ARRIVAL, .RECEIVABLE_TYPE, .CUSTOMER_ID, .CUSTOMER_NAME, .CUSTOMER_ADDR, .VAT_REGISTRATION, .WAREHOUSE_ID, _
                                              .AMOUNT, .TERMS_ID, .BALANCE, .SELL_RATE, .CURRENCY_ID, .DOCUMENT_REF, .SERIE_REF, .NUMBER_REF, .NUMBER_ORDER, _
                                              .CREATE_DATE, .STATUS, .USER_ID, .COMMENT, .IS_GUIA_REC, .NUMBER_REGISTRATION, .DISCOUNT_PERCENT, _
                                              .DISCOUNT_PERCENT_SP, .CARD_ID, .NUMBER_CARD, .AMOUNT_CARD_US, .AMOUNT_CARD, .BANK_CHECK, .NUMBER_CHECK, .AMOUNT_CH_US, _
                                              .AMOUNT_CH, .VOUCHER_ID, .NUMBER_TRA, .AMOUNT_TAX, .DISCOUNTV, .DISCOUNTP, .LIST_GUIA, .IS_PRINT, .DISCOUNT_RECIVABLE, _
                                              .IS_CLOSED, .SUB_ID, .TOTAL_ERROR, .PROMISE_DAYS, .SHIPPER_TYPE, .ZONE_FREIGTH, .AMOUNT_FREIGTH, .IS_GUIA, .IS_CASH_BANK, _
                                              .TAX_TYPE, .REC_AUTO, .TRAMA_ID, .VEHICULO_ID, .EMPTRA_ID, .DOCUMENT_TYPE_COMP_PER, .SERIE_COMP_PER, .NUMBER_COMP_PER, _
                                               .COMMENT_ALMACEN, .FECHA_COMMENT_ALMACEN, .HORA_COMMENT_ALMACEN, .COMMENT_DIR, _
                                               IIf(.FECHA_COMMENT_DIR = "", DBNull.Value, .FECHA_COMMENT_DIR), _
                                               IIf(.HORA_COMMENT_DIR = "", DBNull.Value, .HORA_COMMENT_DIR), _
                                               .COMMENT_GER, _
                                               IIf(.FECHA_COMMENT_GER = "", DBNull.Value, .FECHA_COMMENT_GER), _
                                                IIf(.HORA_COMMENT_GER = "", DBNull.Value, .HORA_COMMENT_GER), _
                                               .ESTADO, .OPCION_ESTADO, .MOTIVO_DEVOLUCION_ID, .TEXTO_MOTIVO_DEVOLUCION, .DOC_DEVOLUCION, _
                                               .FIN_DEVOLUCION_ID, .TEXTO_FIN_DEVOLUCION_ID)
                End With

                'detalle de doc
                For Each d As ClsEntidades.DEVOLUTION_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "DEV_SP_I_DEVOLUTION_LINE", .DOCUMENT_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, .PRICE_SALES, .PRICE_ORI, .DISCOUNT, _
                                                  .AMOUNT_TAX, .TAX_PERCENT, .AMOUNT_US, .AMOUNT, .UNIT, .STATUS, .PART_SERIE, .WAREHOUSE_ID, .TEXT_DESCRIPTION, .DFTR, .STOCK, _
                                                  .PART_DESCRIPTION, .QTY_REF, .DISCOUNT_PERCENT, .BALANCE_PART, .DISCOUNT_CUSTOMER, .DISCOUNT_SP, .PART_LOT, .NUMBER_GUIA, .PART_TAX, _
                                                  .DISCOUNT1, .DISCOUNT2, .PERCENT1, .PERCENT2, .PRICE_LIST_ID, .SHIPPER_QTY, .BUDGET_ID, .ORDER_ID, .BRUTE_QTY, .DISCOUNT_QTY_BRUTE, _
                                                  .UM_REFERENCE, .QTY_REFERENCE, .COMISION, .OBSERVACIONES, .MOTIVO_DEVOLUCION, .FIN_DEVOLUCION_ID, .TEXTO_FIN_DEVOLUCION_ID, _
                                                  .ALMACEN_DESTINO, .TD_REF, .SERIE_REF, .NUM_DOC_REF, .OPT_APROB, "NO")
                    End With
                Next
                'Actualizando Almacen
                ' SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
                'actualizamos la numeracion
                SqlHelper.ExecuteNonQuery(tr, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", ent_cab.DOCUMENT_ID, Val(Strings.Right(ent_cab.NUMBER_DOCUMENT, 7)))
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        Public Function ActualizarDevoluciones(ent_cab As ClsEntidades.DEVOLUTION, lista As List(Of ClsEntidades.DEVOLUTION_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "DEV_SP_U_DEVOLUCION", .DOCUMENT_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .DOCUMENT_DATE, .CADUCATE_DATE, .DR_CR, _
                                              .SALES_REP_ID, .PLACE_SALES, .NUMBER_QUOTE, .NUMBER_ORDER_PUR, .CFDESCPG, .POINT_ORIG, .POINT_BOARD, _
                                              .POINT_ARRIVAL, .RECEIVABLE_TYPE, .CUSTOMER_ID, .CUSTOMER_NAME, .CUSTOMER_ADDR, .VAT_REGISTRATION, .WAREHOUSE_ID, _
                                              .AMOUNT, .TERMS_ID, .BALANCE, .SELL_RATE, .CURRENCY_ID, .DOCUMENT_REF, .SERIE_REF, .NUMBER_REF, .NUMBER_ORDER, _
                                              .CREATE_DATE, .STATUS, .USER_ID, .COMMENT, .IS_GUIA_REC, .NUMBER_REGISTRATION, .DISCOUNT_PERCENT, _
                                              .DISCOUNT_PERCENT_SP, .CARD_ID, .NUMBER_CARD, .AMOUNT_CARD_US, .AMOUNT_CARD, .BANK_CHECK, .NUMBER_CHECK, .AMOUNT_CH_US, _
                                              .AMOUNT_CH, .VOUCHER_ID, .NUMBER_TRA, .AMOUNT_TAX, .DISCOUNTV, .DISCOUNTP, .LIST_GUIA, .IS_PRINT, .DISCOUNT_RECIVABLE, _
                                              .IS_CLOSED, .SUB_ID, .TOTAL_ERROR, .PROMISE_DAYS, .SHIPPER_TYPE, .ZONE_FREIGTH, .AMOUNT_FREIGTH, .IS_GUIA, .IS_CASH_BANK, _
                                              .TAX_TYPE, .REC_AUTO, .TRAMA_ID, .VEHICULO_ID, .EMPTRA_ID, .DOCUMENT_TYPE_COMP_PER, .SERIE_COMP_PER, .NUMBER_COMP_PER, _
                                              .COMMENT_ALMACEN, _
                                              .FECHA_COMMENT_ALMACEN, _
                                              .HORA_COMMENT_ALMACEN, .COMMENT_DIR, _
                                               IIf(.FECHA_COMMENT_DIR = "", DBNull.Value, .FECHA_COMMENT_DIR), _
                                               IIf(.HORA_COMMENT_DIR = "", DBNull.Value, .HORA_COMMENT_DIR), .COMMENT_GER, _
                                              IIf(.FECHA_COMMENT_GER = "", DBNull.Value, .FECHA_COMMENT_GER), _
                                              IIf(.HORA_COMMENT_GER = "", DBNull.Value, .HORA_COMMENT_GER), .ESTADO, .OPCION_ESTADO, .MOTIVO_DEVOLUCION_ID, .TEXTO_MOTIVO_DEVOLUCION, .DOC_DEVOLUCION, _
                                              .FIN_DEVOLUCION_ID, .TEXTO_FIN_DEVOLUCION_ID)
                End With

                'detalle de doc
                Dim SQL As String = "DELETE  FROM DEVOLUTION_LINE  WHERE DOCUMENT_ID='RD' AND NUMBER_SERIE='" & ent_cab.NUMBER_SERIE & "' AND NUMBER_DOCUMENT='" & ent_cab.NUMBER_DOCUMENT & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                For Each d As ClsEntidades.DEVOLUTION_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "DEV_SP_I_DEVOLUTION_LINE", .DOCUMENT_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, .PRICE_SALES, .PRICE_ORI, .DISCOUNT, _
                                                  .AMOUNT_TAX, .TAX_PERCENT, .AMOUNT_US, .AMOUNT, .UNIT, .STATUS, .PART_SERIE, .WAREHOUSE_ID, .TEXT_DESCRIPTION, .DFTR, .STOCK, _
                                                  .PART_DESCRIPTION, .QTY_REF, .DISCOUNT_PERCENT, .BALANCE_PART, .DISCOUNT_CUSTOMER, .DISCOUNT_SP, .PART_LOT, .NUMBER_GUIA, .PART_TAX, _
                                                  .DISCOUNT1, .DISCOUNT2, .PERCENT1, .PERCENT2, .PRICE_LIST_ID, .SHIPPER_QTY, .BUDGET_ID, .ORDER_ID, .BRUTE_QTY, .DISCOUNT_QTY_BRUTE, _
                                                  .UM_REFERENCE, .QTY_REFERENCE, .COMISION, .OBSERVACIONES, .MOTIVO_DEVOLUCION, .FIN_DEVOLUCION_ID, .TEXTO_FIN_DEVOLUCION_ID, _
                                                  .ALMACEN_DESTINO, .TD_REF, .SERIE_REF, .NUM_DOC_REF, .OPT_APROB, .GENERO_NC_GUIA)
                    End With
                Next
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function


        Public Function get_DatosCabeceraDevolucion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal CLIENTE As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "DEV_SP_S_DOCUMENTO_CAB", _FECHA_INI, _FECHA_FIN, _OPCION, CLIENTE).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function get_DatosCabecera_Devolucion_Lote(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "DEV_SP_S_DOCUMENTO_CAB_LOT", _FECHA_INI, _FECHA_FIN, _OPCION, Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function get_DatosDetalleDevolucion(ByVal tipodoc As String, ByVal serie As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "DEV_SP_S_DOCUMENTO_DET", tipodoc, serie, numero).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Function get_DatosGeneralesDevolucion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "DEV_SP_S_LISTAR_DEVOLUCION", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class


    Public Class INVENTORY_COUNT
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Actualizar_Inventario_Estado(ByVal CODIGO As String, ByVal ALMACEN As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_ESTADO_AJUSTE_INV", CODIGO, ALMACEN)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function MostrandodetallesInventario(ByVal CODIGO As String, ByVal ALMACEN As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_INVENTARIO_DETALLES", CODIGO, ALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Eliminar_Inventario_conteo(ByVal CODIGO As String, ByVal ALMACEN As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_INVENTARIO_COUNT", CODIGO, ALMACEN)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function CorrelativoInventario(ByVal ALMACEN As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_CORRELATIVO", ALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function DocumentosInventarios() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_DOCUMENTOS_INVENTARIO").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GuardarCabeceraInventario(ByVal Entidades As ClsEntidades.INVENTORY_COUNT) As Boolean
            Try
                With Entidades
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_S_INVENTARIO_CAB", .ID, .WAREHOUSE_ID, .FECHA, .USER_ID, .COMMENT, .STATUS, .CONDITION, .ORDER_ID)
                End With
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Actualizar_DetallesInventario(ByVal CODIGO As String, ByVal ALMACEN As String,
                                                 ByVal dtTablaDatos As DataTable, ByVal progreso As ProgressBar) As Boolean
            Try
                Dim clsInventarioDetEnt As ClsEntidades.INVENTORY_COUNT_LINE
                'Recorriendo los datos
                If ALMACEN = "01" Then
                    Dim Cantidad() As DataRow = dtTablaDatos.Select("STOCK <> 0", "")
                    progreso.Minimum = 0
                    progreso.Maximum = Cantidad.Count()
                    If dtTablaDatos.Rows.Count() <> 0 Then
                        Dim i As Integer = 0
                        For Each item As DataRow In dtTablaDatos.Select("STOCK <> 0", "")
                            i = i + 1
                            progreso.Value = i
                            clsInventarioDetEnt = New ClsEntidades.INVENTORY_COUNT_LINE
                            With clsInventarioDetEnt
                                .ID = CODIGO
                                .WAREHOUSE_ID = ALMACEN
                                .FAMILY_ID = item("LOTE").ToString
                                .PART_ID = item("CODIGO").ToString
                                .STOCK = item("STOCK").ToString
                                .ENTER_QTY = item("CANT_ING").ToString
                                .DIF_QTY = .ENTER_QTY - .STOCK
                                .UBICATION = ""
                                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_INVENTARIO_DET", .ID, .WAREHOUSE_ID, .FAMILY_ID, .PART_ID, .STOCK, .ENTER_QTY, .DIF_QTY, .UBICATION)
                            End With
                            progreso.PerformStep()
                        Next
                    Else
                        MsgBox("No existe información a procesar.", vbInformation, "Aviso")
                        Return False
                    End If
                    progreso.Value = Cantidad.Count()
                Else
                    progreso.Minimum = 0
                    progreso.Maximum = dtTablaDatos.Rows.Count()
                    If dtTablaDatos.Rows.Count() <> 0 Then
                        Dim i As Integer = 0
                        For Each item As DataRow In dtTablaDatos.Rows
                            i = i + 1
                            progreso.Value = i
                            clsInventarioDetEnt = New ClsEntidades.INVENTORY_COUNT_LINE
                            With clsInventarioDetEnt
                                .ID = CODIGO
                                .WAREHOUSE_ID = ALMACEN
                                .FAMILY_ID = item("LOTE").ToString
                                .PART_ID = item("CODIGO").ToString
                                .STOCK = item("STOCK").ToString
                                .ENTER_QTY = item("CANT_ING").ToString
                                .DIF_QTY = .ENTER_QTY - .STOCK
                                .UBICATION = ""
                                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_INVENTARIO_DET", .ID, .WAREHOUSE_ID, .FAMILY_ID, .PART_ID, .STOCK, .ENTER_QTY, .DIF_QTY, .UBICATION)
                            End With
                            progreso.PerformStep()
                        Next
                    Else
                        MsgBox("No existe información a procesar.", vbInformation, "Aviso")
                        Return False
                    End If
                    progreso.Value = dtTablaDatos.Rows.Count()
                End If

                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Actualizar_DetallesInventario(ByVal CODIGO As String, FECHA As String, ByVal ALMACEN As String, _
                                                  ByVal PART_INI As String, ByVal PART_FIN As String, _
                                                  ByVal FAMILIA As String, ByVal TIPO_PART As String, ByVal LINEA As String, _
                                                  ByVal progreso As ProgressBar) As DataTable
            Try

                Dim clsInventarioDetEnt As ClsEntidades.INVENTORY_COUNT_LINE
                Dim dtGeneral As DataTable
                dtGeneral = New DataTable
                'Recorriendo los datos
                dtGeneral = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PART_COUNT", ALMACEN, PART_INI, PART_FIN, FAMILIA, TIPO_PART, LINEA).Tables(0)
                progreso.Minimum = 0
                progreso.Maximum = dtGeneral.Rows.Count()
                If dtGeneral.Rows.Count() <> 0 Then
                    For j As Integer = 0 To dtGeneral.Rows.Count() - 1
                        progreso.Value = j
                        clsInventarioDetEnt = New ClsEntidades.INVENTORY_COUNT_LINE
                        With clsInventarioDetEnt
                            .ID = CODIGO
                            .WAREHOUSE_ID = ALMACEN
                            .FAMILY_ID = dtGeneral.Rows(j).Item("LOTES").ToString
                            .PART_ID = dtGeneral.Rows(j).Item("CODIGO").ToString
                            .STOCK = dtGeneral.Rows(j).Item("STOCK").ToString
                            .ENTER_QTY = dtGeneral.Rows(j).Item("CANT_ING").ToString
                            .DIF_QTY = .ENTER_QTY - .STOCK
                            .UBICATION = ""
                            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_INVENTARIO_DET", .ID, .WAREHOUSE_ID, .FAMILY_ID, .PART_ID, .STOCK, .ENTER_QTY, .DIF_QTY, .UBICATION)
                        End With
                        progreso.PerformStep()
                    Next
                Else
                    MsgBox("No existe información a procesar.", vbInformation, "Aviso")
                    Exit Try
                End If
                progreso.Value = dtGeneral.Rows.Count()
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_INVENTARIO_DETALLES", CODIGO, ALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Function Guardar_Actualizar_DetalleInventario(ByVal Entidades As ClsEntidades.INVENTORY_COUNT_LINE) As DataTable
            Try
                With Entidades
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_INVENTARIO_DET", .ID, .WAREHOUSE_ID, .FAMILY_ID, .PART_ID, .STOCK, .ENTER_QTY, .DIF_QTY, .UBICATION)
                    Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_INVENTARIO_DETALLES", .ID, .WAREHOUSE_ID).Tables(0)
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Eliminar_DetalleInventario(ByVal Entidades As ClsEntidades.INVENTORY_COUNT_LINE) As DataTable
            Try
                With Entidades
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_INVENTARIO_DETALLES", .ID, .WAREHOUSE_ID, .FAMILY_ID, .PART_ID)
                    Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_INVENTARIO_DETALLES", .ID, .WAREHOUSE_ID, .FAMILY_ID, .PART_ID).Tables(0)
                End With
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

        Public Function Datos_Stock(ByVal _Articulo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_STOCK_PART", _Articulo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Function Elimina_Pedido(ByVal STRNumPedido As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "PED_SP_D_ELIMINA_PEDIDOS", STRNumPedido)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Actualiza_Status_Pedido(ByVal STRNumPedido As String, ByVal STRStatus As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "SAL_ACTUALIZA_STATUS_PEDIDO", STRNumPedido, STRStatus)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Anular_Pedido(ByVal STRNumPedido As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "PED_SP_S_ANULAR_PEDIDOS", STRNumPedido)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Modo_Edicion_Detalle(ByVal codigo As String) As DataTable
            Try
                'creando tabla Temporal
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_EDICION_DETALLE", codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function Modo_Edicion_Cabecera(ByVal codigo As String) As DataTable
            Try
                'creando tabla Temporal
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_EDICION_CABECERA", codigo).Tables(0)
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


        Public Function get_CentroCostos_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CENTER_COST_AYU").Tables(0)
        End Function

        Public Function get_DatosGeneralesPedido(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_ORDERS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GuardarPedido(entidad As ClsEntidades.ORDER, ls_det As List(Of ClsEntidades.ORDER_LINE), ByVal edicion As Boolean) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    ''Borrando cabecera
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_D_ELIMINA_PEDIDOS", entidad.ID)
                    ''
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_ORDERS", .ID, .ORDER_DATE, .CADUCATE_DATE, .SALES_ID, .PLACE_SALES, .CUSTOMER_ID, .CUSTOMER_NAME, _
                                              .CUSTOMER_ADDR, .VAT_REGISTRATION, .AMOUNT, .DISCOUNT_CUSTOMER, .DISCOUNT_SP, .TERMS, .SELL_RATE, .CURRENCY_ID, _
                                              .DOCUMENT_REF, .SERIE_REF, .NUMBER_REF, .CREATE_DATE, .STATUS, .USER_ID, .COMMENT, .NUMBER_GUIA, .NUMBER_REC, _
                             .ORDER_PURCHASE, .COMMENT1, .AMOUNT_VAT, .DISCOUNT, .DISCOUNT_AMOUNT, .REC_TYPE, .DISCOUNT_VAL, .STATUS_ORDER, .TRAMA_ID, .AMOUNT_ISC)
                End With
                ''
                For Each d As ClsEntidades.ORDER_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_ORDERS_LINE", .ID, .ITEM, .PART_ID, .PART_DESCRIPTION, .QTY, .PRICE_SALES, .PRICE_ORI, .DISCOUNT, .AMOUNT_TAX, _
                            .DISCOUNT_CUST, .DISCOUNT_SP, .PERCENT_TAX, .PERCENT_DISCOUNT, .AMOUNT_US, .AMOUNT, .STATUS, .SERIE, .WAREHOUSE_ID, .TEXT_COMMENT, .QTY_REF, .LOT, _
                            .BALANCE, .IS_PART_TAX, .LIST_ID, .UNIT, .PERCENT_ISC, .AMOUNT_ISC, .PRICE_NET)
                    End With
                Next
                tr.Commit()
                'Actualizando Correlativo PEDIDO
                If edicion = False Then
                    SqlHelper.ExecuteNonQuery(cn, "FACT_SP_S_R_CORRELATIVO", "PD")
                End If

                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
                tr.Rollback()
            End Try
        End Function

        Public Function Get_CabeceraPedido(ByVal _NUMERO_PEDIDO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_ORDERS", _NUMERO_PEDIDO).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DetallePedido(ByVal _NUMERO_PEDIDO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_ORDER_LINE", _NUMERO_PEDIDO).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


    End Class

    Public Class ORDERS_LINE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub
    End Class

    Public Class CENTER_COST
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_CentroCostos_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CENTER_COST_AYU").Tables(0)
        End Function

        Public Function get_DetallePedidos(ByVal _NUMBER_DOCUMENT As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_LINE", _NUMBER_DOCUMENT).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class

    Public Class PROYECT
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Proyectos_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_PROYECT_AYU").Tables(0)
        End Function

    End Class


    Public Class VEHICLE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function documentos_Vehiculos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_VEHICLE_PRINCIPAL").Tables(0)
        End Function

        Public Function get_Transportistas_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CARRIER_AYU").Tables(0)
        End Function

        Public Function get_Transportistas_por_Cod(codigo_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CARRIER_XID", codigo_).Tables(0)
        End Function

        Public Function Guardar_Actualizar_Vehiculo(ByVal Entidades As ClsEntidades.VEHICLE, ByVal Flag_nuevo As Boolean) As Boolean
            Try
                If Flag_nuevo = False Then
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_VEHICLE", Entidades.CODIGO)
                End If
                With Entidades
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_VEHICLE", .CODIGO, .PLACA, .MARCA, .MODELO, .CAPACIDAD)
                End With
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Vehicle(ByVal codigo As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_VEHICLE", codigo)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
    End Class

    Public Class EMPRESA_TRANSPORTE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function documentos_Empresa_Transporte() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_EMP_TRANSPORTE_PRINCIPAL").Tables(0)
        End Function

        Public Function get_Transportistas_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CARRIER_AYU").Tables(0)
        End Function

        Public Function get_Transportistas_por_Cod(codigo_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CARRIER_XID", codigo_).Tables(0)
        End Function

        Public Function Guardar_Actualizar_Empresa_Transporte(ByVal Entidades As ClsEntidades.EMPRESA_TRANSPORTE, ByVal Flag_nuevo As Boolean) As Boolean
            Try
                If Flag_nuevo = False Then
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_EMPRESA_TRANSPORTE", Entidades.CODIGO)
                End If
                With Entidades
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_EMP_TRANSPORTE", .CODIGO, .RAZON_SOCIAL, .RUC, .DIRECCION, .TELEFONO)
                End With
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Empresa_Transporte(ByVal codigo As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_EMPRESA_TRANSPORTE", codigo)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
    End Class


    Public Class TRAMAS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Documentos_Tramas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_TRAMAS_PRINCIPAL").Tables(0)
        End Function

        Public Function get_Transportistas_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CARRIER_AYU").Tables(0)
        End Function

        Public Function get_Transportistas_por_Cod(codigo_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CARRIER_XID", codigo_).Tables(0)
        End Function

        Public Function Guardar_Actualizar_Tramas(ByVal Entidades As ClsEntidades.TRAMA, ByVal Flag_nuevo As Boolean) As Boolean
            Try
                If Flag_nuevo = False Then
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_TRAMA", Entidades.ID)
                End If
                With Entidades
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_TRAMA", .ID, .DESCRIPCION)
                End With
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Tramas(ByVal codigo As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_TRAMA", codigo)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

    End Class


    Public Class CARRIER
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function documentos_transportistas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_CARRIER_PRINCIPAL").Tables(0)
        End Function
        Public Function get_Transportistas_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CARRIER_AYU").Tables(0)
        End Function

        Public Function get_Transportistas_por_Cod(codigo_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CARRIER_XID", codigo_).Tables(0)
        End Function

        Public Function Guardar_Actualizar_Transportista(ByVal Entidades As ClsEntidades.CARRIER, ByVal Flag_nuevo As Boolean) As Boolean
            Try
                If Flag_nuevo = False Then
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_CARRIER", Entidades.ID)
                End If
                With Entidades
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_U_CARRIER", .ID, .NAME_CARRIER, .ADDR, .PHONE, .VAT_REGISTRATION, .STATUS, _
                                                      .CREATE_DATE, .NAME, .VAT_REGISTRATION_COMP, .ADDR_COMP, .PHONE_COMP, .NUMBER_REGISTRATION, _
                                                      .NUMBER_LICENSE, .MODEL_VEH, .NUMBER_INSCRIP, .NUMBER_DOCUMENT)
                End With
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Public Function Eliminar_Transportista(ByVal codigo As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_CARRIER", codigo)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
    End Class


    Public Class TRAMOS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Tramos_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_TRAMOS_AYU").Tables(0)
        End Function

    End Class

    Public Class WAREHOUSE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function GuardarActualizar(ByVal Entidades As ClsEntidades.WAREHOUSE, ByVal Nuevo As Boolean)
            Try
                With Entidades
                    If Nuevo Then
                        SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_WAREHOUSE_", .ID, .NAME, .ADDR_WHO, .STATE_ID, .TYPE_PART, .PHONE, .LAST_NUM_IN, .LAST_NUM_OUT, .STATUS, .IS_DEFAULT)
                    Else
                        SqlHelper.ExecuteNonQuery(cn, "ALM_SP_I_WAREHOUSE_U", .ID, .NAME, .ADDR_WHO, .STATE_ID, .TYPE_PART, .PHONE, .LAST_NUM_IN, .LAST_NUM_OUT, .STATUS)
                    End If
                End With
            Catch ex As Exception
                Return False
                Throw
            End Try
            Return True
        End Function

        Public Function get_Almacenes_Ayuda_Lotes(ByVal ID_ALAMACEN As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_LISTA_ALMACENES_LOTES", "").Tables(0)
        End Function


        Public Function get_Almacenes_Ayuda(ByVal ID_ALAMACEN As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_LISTA_ALMACENES", ID_ALAMACEN).Tables(0)
        End Function


        Public Function get_Almacenes_Busqueda(ByVal ID_ALAMACEN As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_LISTA_ALMACENES", ID_ALAMACEN).Tables(0)
        End Function

        Public Function get_AlmacenesGenerales() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_LISTA_ALMACENES").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_GeneracionCodigoAutomatico() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_COD_ALMACEN").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_GeneracionCodigoAutomaticoLineas() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_LINES_COD_LINEA").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_EliminacionAlmacen(ByVal Codigo As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_WAREHOUSE_QUITAR", Codigo)
            Catch ex As Exception
                Return False
                Throw
            End Try
            Return True
        End Function
    End Class

    Public Class ReportesCX
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Ventas_General(fec_ini_ As String, fec_fin_ As String, ven_ini_ As String, ven_fin_ As String, cli_ini_ As String, cli_fin_ As String, prod_ini_ As String, prod_fin_ As String, mon_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "SAL_VENTAS_GENERAL", fec_ini_, fec_fin_, ven_ini_, ven_fin_, cli_ini_, cli_fin_, prod_ini_, prod_fin_, mon_).Tables(0)
        End Function

        Public Sub Registrar_Cod_Tmp(tipo_ As String, pc_ As String, ls_cod_tmp As List(Of String))
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "DELETE FROM CX_TB_COD_TMP WHERE PC = '" & pc_ & "' AND AUX = '" & tipo_ & "'")
            For Each s As String In ls_cod_tmp
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "INSERT INTO CX_TB_COD_TMP(CODIGO,PC,AUX)VALUES('" & s & "','" & pc_ & "','" & tipo_ & "')")
            Next
        End Sub

        Public Function get_Saldos_x_Cliente(todos_ As Boolean, pc_ As String) As DataTable
            Dim dt_tmp As DataTable = Nothing
            If todos_ Then
                dt_tmp = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_SALDO_ALL").Tables(0)
            Else
                dt_tmp = SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALDO_X_CLI", pc_).Tables(0)
            End If
            Return dt_tmp
        End Function

        Public Function get_Planilla_x_fecha(fec_ini_ As String, fec_fin_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_PLANILLA_X_FEC", fec_ini_, fec_fin_).Tables(0)
        End Function

    End Class

    Public Class UNITS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Unidades_ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_UNITS_AYU").Tables(0)
        End Function

    End Class

    Public Class TRANSACTION_TYPE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.TRANSACTION_TYPE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_TRANSACTION_TYPE", .TYPE_ID, .MOV_ID, .NAME, .IS_VALUED, .IS_VENDOR, .IS_DOC_REF, .IS_AUTHORIZED, _
                                          .IS_CCOST, .IS_ORDER_PURCHASE, .IS_COMMENT, .IS_WHO, .IS_CUSTOMER, .IS_ORDER_MANUFACT, _
                                          .IS_ACCOUNT, .VAR_COUNT, .WHO_ID, .IS_GUIA_ANALISIS, .WHO_ID_PART_TYPE, .LOTE_A_FABRICAR)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.TRANSACTION_TYPE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_TRANSACTION_TYPE", .TYPE_ID, .MOV_ID, .NAME, .IS_VALUED, .IS_VENDOR, .IS_DOC_REF, .IS_AUTHORIZED, _
                                          .IS_CCOST, .IS_ORDER_PURCHASE, .IS_COMMENT, .IS_WHO, .IS_CUSTOMER, .IS_ORDER_MANUFACT, _
                                          .IS_ACCOUNT, .VAR_COUNT, .WHO_ID, .IS_GUIA_ANALISIS, .WHO_ID_PART_TYPE, .LOTE_A_FABRICAR)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.TRANSACTION_TYPE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_TRANSACTION_TYPE", .TYPE_ID, .MOV_ID)
            End With
        End Sub

        Public Function get_Transacciones() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_TRANSACTION_TYPE").Tables(0)
        End Function

        Public Function VerificarCodigoTransacciones(ByVal TYPE_ID As String, MOV_ID As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TRANSACTION_TYPE_VERF_COD", TYPE_ID, MOV_ID).Tables(0)
        End Function

        Public Function get_TipoTransacciones() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "TRANS_SP_S_TRANSACTION_TYPE").Tables(0)
        End Function


        Public Function get_Transacciones_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_TRANS_TYPE_AYU").Tables(0)
        End Function

        '--GUIA DE REMISION
        Public Function get_TransaccionesTipo() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "GUIA_SP_S_GUIA_REMISION_AYUDA").Tables(0)
        End Function

        Public Function get_NumeroSeriesGuia() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "GUIA_SP_S_NUM_SERIE_GUIA_REMISION_AYUDA").Tables(0)
        End Function

        '---INVENTARIOS
        Public Function get_InventarioTransaccionesTipo(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "GUIA_SP_S_GUIA_REMISION_TIPO_TRANS", Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        'INGRESOS POR ORDEN DE COMPRA
        Public Function get_TransaccionesTipoOC() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_I_WAREHOUSE_TRANS_MOV_I_OC").Tables(0)
        End Function

    End Class
    Public Class LINEA_MEDICA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub
        Public Function get_LineasMedicas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LIN_MED_SP_S_LINEA_MEDICA").Tables(0)
        End Function

        Public Function get_LineasMedicasII() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LIN_MED_SP_S_LINEA_MEDICA_II").Tables(0)
        End Function

    End Class

    Public Class MARK
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub



    End Class




    Public Class LINES
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.LINES)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_LINES", entidad.FAMILY_ID, entidad.ID, entidad.NAME, entidad.CODIGO_PART_TYPE, entidad.CODIGO, entidad.IS_SHOW_FACT_GUIA)
        End Sub

        Public Sub Update(entidad As ClsEntidades.LINES)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_LINES", entidad.FAMILY_ID, entidad.ID, entidad.NAME, entidad.CODIGO_PART_TYPE, entidad.CODIGO, entidad.IS_SHOW_FACT_GUIA)
        End Sub

        Public Sub Delete(entidad As ClsEntidades.LINES)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_LINES", entidad.FAMILY_ID, entidad.ID)
        End Sub

        Public Function get_Lineas(familia As ClsEntidades.FAMILY) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_LINES", familia.ID).Tables(0)
        End Function

        Public Function get_Lineas_Ayuda(familia_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_LINES", familia_).Tables(0)
        End Function


        Public Function get_MostrarLineas(ByVal _codigoFamilia As String, ByVal _codigoTipoArticulo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LIN_SP_S_LINE", _codigoFamilia, _codigoTipoArticulo).Tables(0)
        End Function


        Public Function get_MostrarLineasFamilia(ByVal _codigoFamilia As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LINEA_SP_S_LINEAS", _codigoFamilia).Tables(0)
        End Function

    End Class

    Public Class FAMILY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.FAMILY)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_FAMILY", entidad.ID, entidad.NAME)
        End Sub

        Public Sub Update(entidad As ClsEntidades.FAMILY)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_FAMILY", entidad.ID, entidad.NAME)
        End Sub

        Public Sub Delete(entidad As ClsEntidades.FAMILY)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_FAMILY", entidad.ID)
        End Sub

        Public Function get_familias() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_FAMILY").Tables(0)
        End Function

        Public Function get_familias_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_FAMILY_AYU").Tables(0)
        End Function

        Public Function get_MostrarFamilias() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "FAM_SP_S_FAMILY").Tables(0)
        End Function


    End Class

    Public Class COMPANY_TYPE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_TiposCompanis() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_COMPANY_TYPE").Tables(0)
        End Function
    End Class

    Public Class DOCUMENT_TYPE_PERSON
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Documentos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_DOCUMENT_TYPE_PERSON").Tables(0)
        End Function

    End Class

    Public Class VENDOR
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.VENDOR)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_VENDOR", .ID, .NAME, .VAT_REGISTRATION, .ADDR, .PHONE, .EMAIL, .WEBSITE, .CONTACT, _
                                          .DOCUMENT_TYPE_PERSON_ID, .TYPE_COMPANY, .ACCOUNT_LOCAL, .ACCOUNT_EXTERNAL, .USER, .CREATE_DATE)
                Dim sql As String = String.Empty
                sql = " INSERT INTO dbo.ANNEXED (ID, TYPE, VAT_REGISTRATION, NAME, REFERENCE) VALUES ( '" & .ID & "', '2', '" & .VAT_REGISTRATION & "', '" & .NAME & "', 'A')"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.VENDOR)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_VENDOR", .ID, .NAME, .VAT_REGISTRATION, .ADDR, .PHONE, .EMAIL, .WEBSITE, .CONTACT, _
                                          .DOCUMENT_TYPE_PERSON_ID, .TYPE_COMPANY, .ACCOUNT_LOCAL, .ACCOUNT_EXTERNAL, .USER, .CREATE_DATE)
                Dim sql As String = String.Empty
                sql = "Update dbo.ANNEXED  SET VAT_REGISTRATION = '" & .VAT_REGISTRATION & "', NAME= '" & .NAME & "' WHERE ID='" & .ID & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.VENDOR)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_VENDOR", .ID)
            End With
        End Sub


        Public Function Proveedores() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_VENDORS").Tables(0)
        End Function


        Public Function get_Proveedores() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_VENDOR").Tables(0)
        End Function

        Public Function get_Proveedores_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_VENDOR_AYU").Tables(0)
        End Function

    End Class

    Public Class LOT
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Lotes_Almacen(ByVal PART As String, ByVal LOT As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOT_SP_S_LOT_COD_ALMACEN", PART, LOT).Tables(0)
        End Function


        Public Sub Guardando_Update_Lotes(entidad As ClsEntidades.LOT)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_LOT_LOTE", .WHO_ID, .PART_ID, .LOT_ID, .QTY_ON_HAND, IIf(.MANUFACT_DATE = "", DBNull.Value, .MANUFACT_DATE),
                                          IIf(.CADUCATE_DATE = "", DBNull.Value, .CADUCATE_DATE), .COMMENT, .INFORME_ENSAYO, .ACTA_MUESTREO, .N_PROTOCOLO, .REGISTRO_SANITARIO)
            End With
        End Sub

        Public Sub Insert(entidad As ClsEntidades.LOT)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_LOT", .WHO_ID, .PART_ID, .LOT_ID, .QTY_ON_HAND, .MANUFACT_DATE, .CADUCATE_DATE, .COMMENT)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.LOT)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_LOT", .WHO_ID, .PART_ID, .LOT_ID, .QTY_ON_HAND, .MANUFACT_DATE, .CADUCATE_DATE, .COMMENT)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.LOT)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_LOT", .WHO_ID, .PART_ID)
            End With
        End Sub

        Public Function get_Lotes() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_LOT").Tables(0)
        End Function

        Public Function get_Lote_x_Articulo(alm_ As String, arti_ As String) As DataTable
            Dim query As String = "SELECT LOT_ID AS 'CODIGO', QTY_ON_HAND  AS 'CANTIDAD' FROM LOT WHERE WHO_ID = '" & alm_ & "' AND PART_ID = '" & arti_ & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function Get_Lotes_Codigo(ByVal WHO_ID As String, ByVal PART_ID As String, ByVal LOT_ID As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOT_SP_S_LOT_COD", WHO_ID, PART_ID, LOT_ID).Tables(0)
        End Function

        Public Function Get_LotesCodigoAlmacen(ByVal WHO_ID As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_LOTE_CODIGO_ALMACEN_AYUDA", WHO_ID).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Eliminar(ByVal WHO_ID As String, ByVal PART_ID As String, ByVal LOT_ID As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "LOT_SP_D_LOT", WHO_ID, PART_ID, LOT_ID)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function


        Public Function VerificarCodigoLote(ByVal WHO_ID As String, ByVal PART_ID As String, ByVal LOT_ID As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LOT_SP_S_LOT_VERF_COD", WHO_ID, PART_ID, LOT_ID).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class

    Public Class WAREHOUSE_TRANS_LINE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub



        Public Function get_Detalle_Guia(alm_ As String, doc_ As String, num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_GRD_X_ID", alm_, doc_, num_).Tables(0)
        End Function

        Public Function get_DetalleAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE", alm_, doc_, num_).Tables(0)
        End Function

        Public Function get_DetalleAlmacenEdicion(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_EDICION", alm_, doc_, num_).Tables(0)
        End Function


        Public Function get_GuiaFtsinDescargoDetalle(ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_SIN_DESCARGO_DET", DOCUMENT_ID, NUMBER_DOCUMENT).Tables(0)
        End Function

        'INGRESOS POR ORDEN DE COMPRAS

        Public Function get_WarehouseOrdencompraDet(ByVal NUMBER_DOCUMENT As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PURCHASE_ORDER_DET", NUMBER_DOCUMENT).Tables(0)
        End Function


    End Class

    Public Class WAREHOUSE_TRANS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Private LibData As LibConexion.ClsData
        Private drDatos As SqlClient.SqlDataReader

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Function Tipo_documento_manual(ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_TIPO_DOC_MANUAL", codigo).Tables(0)
        End Function


        Public Function get_NumeroSeriesGuia() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WAREHOUSE_NUMBER_SERIE_GA").Tables(0)
        End Function


        '***** TODAS LAS GUIAS 
        Public Sub Guardar_All_Guias(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), ByVal TipoNumeracionGuia As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .INTERFACEE, .UPDATE_DATE, .MOV_OPTION_ID)
                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT)
                    End With
                Next
                tr.Commit()
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", entidad.DOCUMENT_ID, Val(Strings.Right(entidad.NUMBER_DOCUMENT, 7)))
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub


        Public Sub Guardar_All_Guias_Edicion(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), ByVal TipoNumeracionGuia As String, _
                                             Optional ByVal MODO_EDITAR As Boolean = False, Optional ByVal REF_ALMACEN As String = "", Optional REF_TIPO_DOC As String = "", Optional REF_NUMERO_DOC As String = "")
            If MODO_EDITAR = True Then
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_ELIMINAR_DOCUMENTOS", REF_ALMACEN, REF_TIPO_DOC, REF_NUMERO_DOC)
            End If
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .INTERFACEE, .UPDATE_DATE, .MOV_OPTION_ID)
                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT)
                    End With
                Next
                tr.Commit()
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", entidad.DOCUMENT_ID, Val(Strings.Right(entidad.NUMBER_DOCUMENT, 7)), Strings.Left(entidad.NUMBER_DOCUMENT, 3))
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub




        'Public Function EliminandoGuiaAnalisis( )
        '    Try
        '        With entidad
        '            SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
        '                                      .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
        '                                      .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
        '                                      .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .INTERFACEE)
        '        End With
        '        For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
        '            With d
        '                SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
        '                                          .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
        '                                          .WAREHOUSE_REF, .ACCOUNT)
        '            End With
        '        Next
        '        tr.Commit()
        '        SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", entidad.DOCUMENT_ID, Val(Strings.Right(entidad.NUMBER_DOCUMENT, 7)))
        '        'Actualizando Almacen
        '        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
        '    Catch ex As Exception
        '        tr.Rollback()
        '    End Try
        'End Function

        Public Sub Insert(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), ByVal TipoNumeracionGuia As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, "", .INTERFACEE)
                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT)
                    End With
                Next
                tr.Commit()
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", entidad.DOCUMENT_ID, Val(Strings.Right(entidad.NUMBER_DOCUMENT, 7)))
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub

        Public Function get_Guias_x_Fechas(fec1_ As String, fec2_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_GR_X_FEC", fec1_, fec2_).Tables(0)
        End Function

        Public Function get_CabeceraAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS", alm_, doc_, num_).Tables(0)
        End Function

        Public Function get_Bultos(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_BULTOS", alm_, doc_, num_).Tables(0)
        End Function

        Public Function get_GuiaFtsinDescargoCabecera(ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_SIN_DESCARGO_CAB", DOCUMENT_ID, NUMBER_DOCUMENT).Tables(0)
        End Function


        Public Sub Guardar(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE))
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_G_A", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, .TYPE_TRANS, .TRANS_ID, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .DOC_ID_REF, .NUM_ID_REF, .UPDATE_DATE, .HOUR, .USER_ID, .CUSTOMER_ID, .CUSTOMER_NAME, .STATUS_GUIA, .PRINTER_STATUS, .PROJECT_ID, .WAREHOUSE_REF, .STATUS_CONTROL)
                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_GA", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, .PART_DESCRIPTION, .NUMBER_LOT, .PROJECT_ID, .QT_BULTOS, .OPT_ENTREGA, .NUM_PROTOCOLOS, .NUMBER_ANALIS, .QTY_BULTOS_ANALIZADOS, .QTY_REF)
                    End With
                Next
                tr.Commit()
                'Actualizando Correlativo Guia Analisis
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_TRANS_NUM_DOCUMENT_GA", Strings.Left(entidad.NUMBER_DOCUMENT, 3))
                'Actualizando Almacen
                'SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_POR_ARTICULO", entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT)
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub

        Public Sub Actualizar_Analisis_Bultos(entidad As ClsEntidades.WAREHOUSE_TRANS_LINE_BULTOS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE_BULTOS), ByVal _ALMACEN_GA As String, ByVal _DOCUMENT_ID_GA As String, ByVal _NUMBER_DOCUMENT_GA As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE_BULTOS In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_TRANS_LINE_BULTOS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .PART_ID, .LOTE, .ITEM, .QTY_ANALISIS, _ALMACEN_GA, _DOCUMENT_ID_GA, _NUMBER_DOCUMENT_GA)
                    End With
                Next
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub
        Public Sub Update_CorrelativoMuestraAnalisis()
            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "ALM_SP_S_WAREHOUSE_TRANS")
        End Sub

        Public Function get_DatosGeneralesAlmacen(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                 ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID).Tables(0)
        End Function

        Public Function get_Obtener_Correlativo_GA(ByVal _number_document As String, ByVal _document_id As String, ByVal _warehouse_id As Integer, _
                                                 ByVal _part_id As String, ByVal _lote As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WTLB_CORRELATIVO_NUM_ANALISIS", _number_document, _document_id, _warehouse_id, _part_id, _lote).Tables(0)
        End Function

        Public Function EliminarDocumentosAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String, ByVal User As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_WH_DOC_ELIMINADOS", alm_, doc_, num_, User)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", alm_)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Function

        'Guia de Remision
        Public Function get_DocumentosGuiaRemision() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "GUIA_SP_S_GUIA_REMISION_DOCUMENTOS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Function get_VerificacionCodigoGuiaRemision(ByVal TIPO_DOC As String, ByVal WAREHOUSE_ID As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_VERIFICAR_COD", _
                                dataBL.DatosParam("@TIPO_DOC", SqlDbType.VarChar, 2, TIPO_DOC),
                                dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                dataBL.DatosParam("@NUMBER_DOCUMENT", SqlDbType.VarChar, 10, NUMBER_DOCUMENT))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DatosGeneralesGuiaRemision(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                               ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ACCESOALMACEN As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ACCESOALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DatosGeneralesGuiaTransferencia(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                       ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ACCESOALMACEN As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "GUIA_WAREHOUSE_TRANS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ACCESOALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DatosGeneralesGuiaTransferencia_Materia_Prima(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                               ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ACCESOALMACEN As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "GUIA_WAREHOUSE_TRANS_PRINCIPAL_MATERIA_PRIMA", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ACCESOALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DatosGeneralesIngresoOc(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                             ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ACCESOALMACEN As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_PRINCIPAL_OC_II", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ACCESOALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Sub EliminarGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_ELIMINAR_DOCUMENTOS", alm_, doc_, num_)
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", doc_, Val(Strings.Right(num_, 7)), Strings.Left(num_, 3))
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", alm_)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub



        Public Sub EliminarGuiaRemisionII(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String, ByVal num_orden_compra As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_ELIMINAR_DOCUMENTOS_II", alm_, doc_, num_)
                'Actualizando estado Oc
                Dim dtOrdenC As DataTable
                dtOrdenC = New DataTable
                dtOrdenC = SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT ID FROM PURCHASE_ORDER WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'").Tables(0)
                If dtOrdenC.Rows.Count() <> 0 Then
                    dtOrdenC = New DataTable
                    dtOrdenC = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PURCHASE_ORDER_DET_II", num_orden_compra).Tables(0)
                    If dtOrdenC.Rows.Count() <> 0 Then
                        If CDbl(dtOrdenC.Rows(0).Item("CANT_OC")) > CDbl(dtOrdenC.Rows(0).Item("SALDO")) Then
                            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='03' WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'")
                        Else
                            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='02' WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'")
                        End If
                    Else
                        SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='02' WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'")
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

        Public Sub AnularGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_TRANS_ESTADO", alm_, doc_, num_)
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", doc_, Val(Strings.Right(num_, 7)), Strings.Left(num_, 3))
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", alm_)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub AnularGuiaRemisionII(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String, ByVal num_orden_compra As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_TRANS_ESTADO", alm_, doc_, num_)
                'Actualizando estado Oc
                Dim dtOrdenC As DataTable
                dtOrdenC = New DataTable
                dtOrdenC = SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT ID FROM PURCHASE_ORDER WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'").Tables(0)
                If dtOrdenC.Rows.Count() <> 0 Then
                    dtOrdenC = New DataTable
                    dtOrdenC = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PURCHASE_ORDER_DET_II", num_orden_compra).Tables(0)
                    If dtOrdenC.Rows.Count() <> 0 Then
                        If CDbl(dtOrdenC.Rows(0).Item("CANT_OC")) > CDbl(dtOrdenC.Rows(0).Item("SALDO")) Then
                            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='03' WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'")
                        Else
                            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='02' WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'")
                        End If
                    Else
                        SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='02' WHERE ID='" & num_orden_compra & "' AND TYPE ='OC'")
                    End If
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub GuardarInventarioAlmacen(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), Optional ByVal Lote_Fabricar As String = "")
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .UPDATE_DATE, .NUM_ORDER_MANUFACT)

                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN, .AVERAGE_COST, .CURRENCY_ID)
                    End With
                Next
                ''Actualizando ..
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WH_LOTE_FABRICAR", entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT, Lote_Fabricar)
                'Actualizando Correlativo de Almacen
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad.WAREHOUSE_ID, entidad.TYPE_TRANS)
                tr.Commit()
                'Actualizando Almacen
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_POR_ARTICULO", entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT)
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub


        Public Sub GuardarInventarioAlmacenII(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), Optional ByVal Lote_Fabricar As String = "")
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .UPDATE_DATE, .NUM_ORDER_MANUFACT)

                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN, .AVERAGE_COST, .CURRENCY_ID)
                    End With
                Next
                ''Actualizando ..
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WH_LOTE_FABRICAR", entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT, Lote_Fabricar)
                'Actualizando Correlativo de Almacen
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad.WAREHOUSE_ID, entidad.TYPE_TRANS)
                tr.Commit()
                'Actualizando Almacen
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_POR_ARTICULO", entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT)
                'Actualizando estado Oc
                Dim dtOrdenC As DataTable
                dtOrdenC = New DataTable
                dtOrdenC = SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT * FROM PURCHASE_ORDER WHERE ID='" & entidad.NUMBER_PURCHASE & "' AND TYPE ='OC'").Tables(0)
                If dtOrdenC.Rows.Count() <> 0 Then
                    dtOrdenC = New DataTable
                    dtOrdenC = SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PURCHASE_ORDER_DET", entidad.NUMBER_PURCHASE).Tables(0)
                    If dtOrdenC.Rows.Count() <> 0 Then
                        SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='03' WHERE ID='" & entidad.NUMBER_PURCHASE & "' AND TYPE ='OC'")
                    Else
                        SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE PURCHASE_ORDER SET STATUS_ID='04' WHERE ID='" & entidad.NUMBER_PURCHASE & "' AND TYPE ='OC'")
                    End If
                End If
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        ' ---iNGRESO ORDEN DE COMPRA--

        Public Sub GuardarAlmacen(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), ByVal TipoMov As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, 0, .UPDATE_DATE, .MOV_OPTION_ID)

                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT)
                    End With
                Next
                'Actualizando Correlativo de Almacen
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad.WAREHOUSE_ID, TipoMov)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
                ''ACTUALIZAR SI EXISTE EN PARTQTY Y LOT 
                SqlHelper.ExecuteNonQuery(tr, "SP_U_PART_QTY_LOT", entidad.NUMBER_DOCUMENT, entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub

        Public Sub GuardarAlmacen_II(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), ByVal TipoMov As String, _
                                  ByVal Tipo_ns As String, ByVal numero_ns As String, almacen_ns As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, 0, .UPDATE_DATE, .MOV_OPTION_ID)

                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT)
                    End With
                Next
                ''Actualizando
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_TRANF_DOC_REF", entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT, entidad.WAREHOUSE_ID, Tipo_ns, numero_ns, almacen_ns)
                'Actualizando Correlativo de Almacen
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad.WAREHOUSE_ID, TipoMov)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
                ''ACTUALIZAR SI EXISTE EN PARTQTY Y LOT 
                SqlHelper.ExecuteNonQuery(tr, "SP_U_PART_QTY_LOT", entidad.NUMBER_DOCUMENT, entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub

        ''INGRESOS POR ORDEN DE COMPRA

        Public Function get_WarehouseOrdencompraCab(ByVal NUMBER_DOCUMENT As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PURCHASE_ORDER_CAB", NUMBER_DOCUMENT).Tables(0)
        End Function


        '----FACTURACION

        Public Function get_VerificacionCodigoFactura(ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_RECEIVABLE_VERIFICAR_COD", _
                                dataBL.DatosParam("@NUMBER_SERIE", SqlDbType.VarChar, 3, NUMBER_SERIE),
                                dataBL.DatosParam("@NUMBER_DOCUMENT", SqlDbType.VarChar, 7, NUMBER_DOCUMENT))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function

        '------NOTA DE CREDITO
        Public Function get_VerificacionCodigoNotaCredito(ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_R_VERIFICAR_COD_NC", _
                                dataBL.DatosParam("@NUMBER_SERIE", SqlDbType.VarChar, 3, NUMBER_SERIE),
                                dataBL.DatosParam("@NUMBER_DOCUMENT", SqlDbType.VarChar, 7, NUMBER_DOCUMENT))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function

        '------NOTA DE DEBITO
        Public Function get_VerificacionCodigoNotaDebito(ByVal NUMBER_SERIE As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_R_VERIFICAR_COD_ND", _
                                dataBL.DatosParam("@NUMBER_SERIE", SqlDbType.VarChar, 3, NUMBER_SERIE),
                                dataBL.DatosParam("@NUMBER_DOCUMENT", SqlDbType.VarChar, 7, NUMBER_DOCUMENT))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function

        '-------COMPROBANTE DE PERCEPCION
        Public Function get_VerificacionCodigoComprobantePercepcion(ByVal WAREHOUSE_ID As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_R_VERIFICAR_COD_CP", _
                                dataBL.DatosParam("@NUMBER_SERIE", SqlDbType.VarChar, 3, WAREHOUSE_ID),
                                dataBL.DatosParam("@NUMBER_DOCUMENT", SqlDbType.VarChar, 7, NUMBER_DOCUMENT))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function



        '' GENERACION DESPACHO

        Public Function VerificarDespacho(ByVal _Almacen As String, ByVal _NumeroDocumento As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "GUIA_SP_U_R_GENER_DESPACHO_VERF", _Almacen, _NumeroDocumento).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GenerarDespacho(ByVal _Almacen As String, ByVal _NumeroDocumento As String, ByVal _Fecha As String, ByVal _Hora As String, ByVal _Usuario As String) As Boolean
            Dim estado As Boolean = True
            Try
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_U_R_GENER_DESPACHO", _Almacen, _NumeroDocumento, _Fecha, _Hora, _Usuario)
            Catch ex As Exception
                estado = False
                Throw
            End Try
            Return estado
        End Function


        Public Function GenerarDespachoVarios(ByVal DTDOCUMENTOS As DataTable, ByVal _Fecha As String, ByVal _Hora As String, ByVal _Usuario As String) As Boolean
            Dim estado As Boolean = True
            Try
                For Each rows As DataRow In DTDOCUMENTOS.Select("SEL=TRUE")
                    SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_U_R_GENER_DESPACHO", rows("WAREHOUSE_ID").ToString, rows("NUMBER_DOCUMENT").ToString, _Fecha, _Hora, _Usuario)
                Next
            Catch ex As Exception
                estado = False
                Throw
            End Try
            Return estado
        End Function

        '---------CONTROL DE CALIDAD


        Public Function get_DetalleAlmacen_CONTROL(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_CONTROL", alm_, doc_, num_).Tables(0)
        End Function

        Public Function get_CabeceraAlmacen_CONTROL(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_CONTROL", alm_, doc_, num_).Tables(0)
        End Function


    End Class




    Public Class PART_TYPE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub



        'Sub ciclico()
        '    Try
        '        Dim hilo As New Thread(New ThreadStart(AddressOf actualizar_grids))
        '        If hilo.IsAlive = False Then
        '            hilo.Start()
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End Sub


        'Sub actualizar_grids()
        '    Control.CheckForIllegalCrossThreadCalls = False
        '    Try
        '        Dim sql = ""
        '        sql = "select * from part"
        '        Dim dtdetalles_todos As New DataTable
        '        dtdetalles_todos = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_MARK").Tables(0)
        '    Catch ex As Exception
        '        Debug.Print(ex.Message)
        '    Finally

        '    End Try
        '    Try
        '        Application.DoEvents()
        '        System.Threading.Thread.Sleep(20000) ' Sleep for 20 second
        '    Catch ex As Exception
        '        Debug.Print(ex.Message)
        '    Finally
        '        ciclico()
        '    End Try
        'End Sub



        Public Function Insert_Update(ByVal entidades As ClsEntidades.PART_TYPE, ByVal modo_editar As Boolean) As Boolean
            If modo_editar = False Then
                SqlHelper.ExecuteNonQuery(cn, "PART_SP_D_TIPO_ARTICULO", entidades.ID)
            End If
            With entidades
                SqlHelper.ExecuteNonQuery(cn, "PART_SP_I_TIPO_ARTICULO", .ID, .NAME, .CODIGO, .CUENTA_CONTABLE)
            End With
        End Function

        Public Function Delete(ByVal Codigo As String) As Boolean
            SqlHelper.ExecuteNonQuery(cn, "PART_SP_D_TIPO_ARTICULO", Codigo)
        End Function


        Public Function Get_Tipos_Articulos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_TIPOS_ARTICULOS").Tables(0)
        End Function

        Public Function Get_Desc_cuenta_contable(ByVal _codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_CUENTA_CONTABLE", _codigo).Tables(0)
        End Function

        Public Function get_ClaseArticulo() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_MARK").Tables(0)
        End Function


        Public Function RetornaConsulta(ByVal consulta As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
        End Function

        Public Function get_TipoArticulo() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_TYPE").Tables(0)
        End Function
    End Class

    Public Class PART
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Private LibData As LibConexion.ClsData
        Private drDatos As SqlClient.SqlDataReader

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Function ListarPart_Detalle_Lineas(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_DETALLE_LINEAS", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Throw
            End Try
        End Function


        Public Function ListarClaseTerapeutica() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_VALID_CLIENTE_RUC").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Throw
            End Try
        End Function



        Public Function ValidarCliente_Ruc(ByVal _codigoCliente As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_VALID_CLIENTE_RUC", _codigoCliente).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function




        Public Function ValidarProveedor(ByVal _codigoProveedor As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_VALID_VENDOR_CODIGO", _codigoProveedor).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function




        Public Function ValidarProveedor_Ruc(ByVal _codigoProveedor As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_S_VALID_VENDOR_RUC", _codigoProveedor).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function VerificacionArticuloCodigo(ByVal codigo As String, ByVal tipoMov As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_ARTICULO_MANUAL", codigo, tipoMov).Tables(0)
        End Function


        Public Function VerificacionArticuloCodigo_pedido(ByVal Almacen As String, ByVal Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_PRODUCTOS_VERIFICAR_COD_EXIS", Almacen, Codigo).Tables(0)
        End Function




        Public Function get_articulos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_PART").Tables(0)
        End Function

        Public Function get_articulos_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_PART_AYUDA").Tables(0)
        End Function

        Public Function get_articulos_Ayuda_Lote() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_PART_AYUDA_LOTE").Tables(0)
        End Function

        Public Sub Insert(entidad As ClsEntidades.PART, ByVal LISTA As CheckedListBox)
            Try
                With entidad
                    LibData = New LibConexion.ClsData
                    LibData.Run_Store_Procedure("CX_SP_I_PART_II", _
                    LibData.DatosParam("@P_ID", SqlDbType.VarChar, 7, .ID), _
                    LibData.DatosParam("@P_ID_FAB", SqlDbType.VarChar, 40, .ID_FAB), _
                    LibData.DatosParam("@DESCRIPTION", SqlDbType.VarChar, 255, .DESCRIPTION), _
                    LibData.DatosParam("@DESCRIPTION_OPT", SqlDbType.VarChar, 255, .DESCRIPTION_OPT), _
                    LibData.DatosParam("@P_FAMILY", SqlDbType.VarChar, 40, .FAMILY), _
                    LibData.DatosParam("@P_MODEL", SqlDbType.VarChar, 40, .MODEL), _
                    LibData.DatosParam("@P_UNIT_OF_MEASUREMENT", SqlDbType.VarChar, 40, .UNIT_OF_MEASUREMENT), _
                    LibData.DatosParam("@P_SERIES", SqlDbType.VarChar, 40, .SERIES), _
                    LibData.DatosParam("@UNIT_PRICE", SqlDbType.Float, 0, .UNIT_PRICE), _
                    LibData.DatosParam("@DISCOUNT", SqlDbType.Float, 0, .DISCOUNT), _
                    LibData.DatosParam("@PRICE_BUY", SqlDbType.VarChar, 40, .PRICE_BUY), _
                    LibData.DatosParam("@VENDOR_ID_PART", SqlDbType.VarChar, 40, .VENDOR_ID_PART), _
                    LibData.DatosParam("@CREATE_DATE", SqlDbType.SmallDateTime, 0, .CREATE_DATE), _
                    LibData.DatosParam("@P_IS_STOCKED", SqlDbType.VarChar, 40, .IS_STOCKED), _
                    LibData.DatosParam("@CREATE_USER", SqlDbType.VarChar, 40, .CREATE_USER), _
                    LibData.DatosParam("@STATUS", SqlDbType.VarChar, 1, .STATUS), _
                    LibData.DatosParam("@CURRENCY_ID", SqlDbType.VarChar, 2, .CURRENCY_ID), _
                    LibData.DatosParam("@TYPE_PART", SqlDbType.VarChar, 2, .TYPE_PART), _
                    LibData.DatosParam("@P_IS_LOT", SqlDbType.VarChar, 40, .IS_LOT), _
                    LibData.DatosParam("@WEIGHT", SqlDbType.Float, 0, .WEIGHT), _
                    LibData.DatosParam("@CST_POR", SqlDbType.Float, 0, .CST_POR), _
                    LibData.DatosParam("@P_VAT_POR", SqlDbType.Float, 0, .VAT_POR), _
                    LibData.DatosParam("@HOUR_UPDATE", SqlDbType.SmallDateTime, 0, .HOUR_UPDATE), _
                    LibData.DatosParam("@P_IS_VAT", SqlDbType.Bit, 0, .IS_VAT), _
                    LibData.DatosParam("@ORIGEN", SqlDbType.Char, 1, .ORIGEN), _
                    LibData.DatosParam("@P_ACCOUNT_INTERNAL_ID", SqlDbType.VarChar, 40, .ACCOUNT_INTERNAL_ID), _
                    LibData.DatosParam("@P_ACCOUNT_INV", SqlDbType.VarChar, 40, .ACCOUNT_INV), _
                    LibData.DatosParam("@P_ACCOUNT_PAY", SqlDbType.VarChar, 40, .ACCOUNT_PAY), _
                    LibData.DatosParam("@P_ISCPOR", SqlDbType.Float, 0, .ISCPOR), _
                    LibData.DatosParam("@P_TIPOISC", SqlDbType.Int, 0, .TIPOISC), _
                    LibData.DatosParam("@PRESS_VENTA", SqlDbType.VarChar, 255, .PRESS_VENTA), _
                    LibData.DatosParam("@PRESS_MUESTRA_MEDICA", SqlDbType.VarChar, 255, .PRESS_MUESTRA_MEDICA), _
                    LibData.DatosParam("@LINEA_MEDICA", SqlDbType.VarChar, 2, .LINEA_MEDICA), _
                    LibData.DatosParam("@NOMBRE_COMERCIAL", SqlDbType.VarChar, 255, .NOMBRE_COMERCIAL), _
                    LibData.DatosParam("@ID_ANTERIOR", SqlDbType.VarChar, 20, .ID_ANTERIOR), _
                    LibData.DatosParam("@TIPO_ARTICULO", SqlDbType.Int, 1, .TIPO_ARTICULO), _
                    LibData.DatosParam("@PRESS_COMERCIAL", SqlDbType.VarChar, 250, .PRESS_COMERCIAL), _
                    LibData.DatosParam("@CLASS_PART", SqlDbType.VarChar, 2, .CLASS_PART), _
                    LibData.DatosParam("@REG_SANIT", SqlDbType.VarChar, 10, .REG_SANIT), _
                    LibData.DatosParam("@VIGENCIA_REG_SANIT", SqlDbType.VarChar, 99, .VIGENCIA_REG_SANIT), _
                    LibData.DatosParam("@VIGENCIA_LOTE", SqlDbType.VarChar, 99, .VIGENCIA_LOTE))
                End With

                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_PART_II_IMAGEN", entidad.ID, entidad.IMAGEN)

                Dim i As Integer = 0
                'Do While i <= LISTA.CheckedItems.Count - 1
                '    LISTA.CheckedItems(i).ToString()
                '    SqlHelper.ExecuteNonQuery(cn, "PART_SP_I_PART_DETALLE_LINEAS", entidad.ID, TraerCodigo(LISTA.CheckedItems(i)), TraerDescripcion(LISTA.CheckedItems(i)), LibComunVar.ClsVarComun.USUARIO, Date.Now)
                '    i = i + 1
                'Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


        Public Function TraerDescripcion(ByVal cadena As String) As String
            Dim resul As String = ""
            Try
                If InStr(cadena, ":") = 0 Then
                    resul = ""
                Else
                    If cadena.Length > 0 Then
                        resul = Mid(cadena, InStr(cadena, ":") + 1, cadena.Length)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.InnerException, MsgBoxStyle.Critical)
            End Try
            Return resul

        End Function
        Public Function TraerCodigo(ByVal cadena As String) As String
            Dim resul As String = ""
            Try
                If InStr(cadena, ":") = 0 Then
                    resul = ""
                Else
                    If cadena.Length > 0 Then
                        resul = Mid(cadena, 1, InStr(cadena, ":") - 1)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.InnerException, MsgBoxStyle.Critical)
            End Try
            Return resul
        End Function

        Public Sub Update(entidad As ClsEntidades.PART, ByVal LISTA As CheckedListBox)
            With entidad
                LibData = New LibConexion.ClsData
                LibData.Run_Store_Procedure("CX_SP_U_PART", _
                LibData.DatosParam("@P_ID", SqlDbType.VarChar, 7, .ID), _
                LibData.DatosParam("@P_ID_FAB", SqlDbType.VarChar, 40, .ID_FAB), _
                LibData.DatosParam("@DESCRIPTION", SqlDbType.VarChar, 255, .DESCRIPTION), _
                LibData.DatosParam("@DESCRIPTION_OPT", SqlDbType.VarChar, 255, .DESCRIPTION_OPT), _
                LibData.DatosParam("@P_FAMILY", SqlDbType.VarChar, 40, .FAMILY), _
                LibData.DatosParam("@P_MODEL", SqlDbType.VarChar, 40, .MODEL), _
                LibData.DatosParam("@P_UNIT_OF_MEASUREMENT", SqlDbType.VarChar, 40, .UNIT_OF_MEASUREMENT), _
                LibData.DatosParam("@P_SERIES", SqlDbType.VarChar, 40, .SERIES), _
                LibData.DatosParam("@UNIT_PRICE", SqlDbType.Float, 0, .UNIT_PRICE), _
                LibData.DatosParam("@DISCOUNT", SqlDbType.Float, 0, .DISCOUNT), _
                LibData.DatosParam("@PRICE_BUY", SqlDbType.VarChar, 40, .PRICE_BUY), _
                LibData.DatosParam("@VENDOR_ID_PART", SqlDbType.VarChar, 40, .VENDOR_ID_PART), _
                LibData.DatosParam("@CREATE_DATE", SqlDbType.SmallDateTime, 0, .CREATE_DATE), _
                LibData.DatosParam("@P_IS_STOCKED", SqlDbType.VarChar, 40, .IS_STOCKED), _
                LibData.DatosParam("@CREATE_USER", SqlDbType.VarChar, 40, .CREATE_USER), _
                LibData.DatosParam("@STATUS", SqlDbType.VarChar, 1, .STATUS), _
                LibData.DatosParam("@CURRENCY_ID", SqlDbType.VarChar, 2, .CURRENCY_ID), _
                LibData.DatosParam("@TYPE_PART", SqlDbType.VarChar, 2, .TYPE_PART), _
                LibData.DatosParam("@P_IS_LOT", SqlDbType.VarChar, 40, .IS_LOT), _
                LibData.DatosParam("@WEIGHT", SqlDbType.Float, 0, .WEIGHT), _
                LibData.DatosParam("@CST_POR", SqlDbType.Float, 0, .CST_POR), _
                LibData.DatosParam("@P_VAT_POR", SqlDbType.Float, 0, .VAT_POR), _
                LibData.DatosParam("@HOUR_UPDATE", SqlDbType.SmallDateTime, 0, .HOUR_UPDATE), _
                LibData.DatosParam("@P_IS_VAT", SqlDbType.Bit, 0, .IS_VAT), _
                LibData.DatosParam("@ORIGEN", SqlDbType.Char, 1, .ORIGEN), _
                LibData.DatosParam("@P_ACCOUNT_INTERNAL_ID", SqlDbType.VarChar, 40, .ACCOUNT_INTERNAL_ID), _
                LibData.DatosParam("@P_ACCOUNT_INV", SqlDbType.VarChar, 40, .ACCOUNT_INV), _
                LibData.DatosParam("@P_ACCOUNT_PAY", SqlDbType.VarChar, 40, .ACCOUNT_PAY), _
                LibData.DatosParam("@P_ISCPOR", SqlDbType.Float, 0, .ISCPOR), _
                LibData.DatosParam("@P_TIPOISC", SqlDbType.Int, 0, .TIPOISC), _
                LibData.DatosParam("@PRESS_VENTA", SqlDbType.VarChar, 255, .PRESS_VENTA), _
                LibData.DatosParam("@PRESS_MUESTRA_MEDICA", SqlDbType.VarChar, 255, .PRESS_MUESTRA_MEDICA), _
                LibData.DatosParam("@LINEA_MEDICA", SqlDbType.VarChar, 2, .LINEA_MEDICA), _
                LibData.DatosParam("@NOMBRE_COMERCIAL", SqlDbType.VarChar, 255, .NOMBRE_COMERCIAL), _
                LibData.DatosParam("@ID_ANTERIOR", SqlDbType.VarChar, 20, .ID_ANTERIOR), _
                LibData.DatosParam("@TIPO_ARTICULO", SqlDbType.Int, 1, .TIPO_ARTICULO), _
                LibData.DatosParam("@PRESS_COMERCIAL", SqlDbType.VarChar, 250, .PRESS_COMERCIAL), _
                LibData.DatosParam("@CLASS_PART", SqlDbType.VarChar, 2, .CLASS_PART), _
                LibData.DatosParam("@REG_SANIT", SqlDbType.VarChar, 10, .REG_SANIT), _
                LibData.DatosParam("@VIGENCIA_REG_SANIT", SqlDbType.VarChar, 99, .VIGENCIA_REG_SANIT), _
                LibData.DatosParam("@VIGENCIA_LOTE", SqlDbType.VarChar, 99, .VIGENCIA_LOTE))
            End With
            'Borrando data
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_PART_II_IMAGEN", entidad.ID, entidad.IMAGEN)
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "DELETE FROM LINEA_MEDICA_DETALLE WHERE PART_ID ='" & entidad.ID & "'")
            Dim i As Integer = 0
            Do While i <= LISTA.CheckedItems.Count - 1
                LISTA.CheckedItems(i).ToString()
                SqlHelper.ExecuteNonQuery(cn, "PART_SP_I_PART_DETALLE_LINEAS", entidad.ID, TraerCodigo(LISTA.CheckedItems(i)), TraerDescripcion(LISTA.CheckedItems(i)), LibComunVar.ClsVarComun.USUARIO, Date.Now)
                i = i + 1
            Loop
        End Sub

        Public Sub Delete(entidad As ClsEntidades.PART)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_PART", .ID)
            End With
        End Sub

        Public Function get_MostrarArticulostodos(ByVal _codigoFamilia As String, ByVal _codigoTipoArticulo As String, _
                                          ByVal _codigoLine As String, ByVal opcion_part As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART", _codigoFamilia, _codigoTipoArticulo, _codigoLine, opcion_part).Tables(0)
        End Function

        Public Function get_ObtnerCodigoPart(ByVal _codigoFamilia As String, ByVal _codigoTipoArticulo As String, _
                                          ByVal _codigoLine As String) As List(Of String)
            Dim lista As New List(Of String)
            Dim CodigoArticulo As String = String.Empty
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cn, "PART_SP_S_PART_CODIGO", _codigoFamilia, _codigoTipoArticulo, _codigoLine)
            If drr.HasRows Then
                drr.Read()
                CodigoArticulo = drr(0).ToString
                lista.Add(CodigoArticulo)
            End If
            drr.Close()
            Return lista
        End Function

        Public Function Update_ObtnerCodigoPart(ByVal _codigoFamilia As String, ByVal _codigoTipoArticulo As String, _
                                          ByVal _codigoLine As String)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cn, "PART_SP_U_PART_CODIGO", _codigoFamilia, _codigoTipoArticulo, _codigoLine)

        End Function

        Public Sub InsertandoArticuloTodosAlmacenes(ByVal _codigoArticulo As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "PART_SP_I_PART_ALL_WAREHOUSE", _codigoArticulo)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub InsertandoArticuloTodosAlmaceneslotes(ByVal _codigoArticulo As String, ByVal CodigoNuevo As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "PART_SP_I_MUESTRA_GRANEL", _codigoArticulo, CodigoNuevo)
            Catch ex As Exception
                Throw
            End Try
        End Sub



        Public _codigoFamilia As String

        Public Property codigoFamilia() As String
            Get
                Return _codigoFamilia
            End Get
            Set(ByVal value As String)
                _codigoFamilia = value
            End Set
        End Property

        Public Function get_CodigoMuestras(ByVal STRCodigo As String, _
                                           ByVal TipoArticulo As String, _
                                           ByVal Familia As String, _
                                           ByVal Linea As String) As List(Of String)
            Dim lista As New List(Of String)
            Try
                LibData = New LibConexion.ClsData
                drDatos = LibData.Run_SP_DataReader("PART_SP_S_PART_MUESTRAS", _
                                            LibData.DatosParam("@codigo", SqlDbType.VarChar, 10, STRCodigo),
                                             LibData.DatosParam("@TYPE_PART", SqlDbType.VarChar, 2, TipoArticulo),
                                              LibData.DatosParam("@FAMILY", SqlDbType.VarChar, 10, Familia),
                                               LibData.DatosParam("@MODEL", SqlDbType.VarChar, 8, Linea))
                If drDatos.Read Then
                    lista.Add(drDatos.Item(0))
                    lista.Add(drDatos.Item(1))
                    lista.Add(drDatos.Item(2))
                    lista.Add(drDatos.Item(3))
                    lista.Add(drDatos.Item(4))
                    lista.Add(drDatos.Item(5))
                End If
                drDatos.Close()
                LibData.Dispose()
            Catch ex As Exception
                lista = Nothing
            End Try
            Return lista
        End Function

        Public Structure EstructuraMuestas
            Dim indiceMuestra As Integer
            Dim valorMuestra As String
            Dim indiceGranel As Integer
            Dim valorGranel As String
        End Structure

        Public Function get_EdiciondeArticulos(ByVal STRcodigo As String) As DataTable
            LibData = New LibConexion.ClsData
            Dim dtEdicion As New DataTable
            dtEdicion = LibData.Run_SP_DataTable("PART_SP_S_PART_BUSCAR", _
                                 LibData.DatosParam("@ID", SqlDbType.VarChar, 20, STRcodigo))
            Return dtEdicion
        End Function
        Public Function get_Imagen_Producto(_cod_prod As String) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_BUSCAR", _cod_prod)
        End Function
        'GUIA DE REMISION
        Dim dtdatosGenerales As New DataTable



        Public Sub GenerarColummnValidacionLotesGenerales()
            Try
                dtdatosGenerales = New DataTable
                dtdatosGenerales.Columns.Add("Lote", Type.GetType("System.String"))
                dtdatosGenerales.Columns.Add("Cantidad", Type.GetType("System.Double"))
                dtdatosGenerales.Columns.Add("Vcto.", Type.GetType("System.String"))
                dtdatosGenerales.Columns.Add("Observaciones", Type.GetType("System.String"))
                dtdatosGenerales.Columns.Add("Informe de Ensayo", Type.GetType("System.String"))
                dtdatosGenerales.Columns.Add("Acta de Muestreo", Type.GetType("System.String"))
                dtdatosGenerales.Columns.Add("N° Protocolo", Type.GetType("System.String"))
                dtdatosGenerales.Columns.Add("Reg. Sanitario", Type.GetType("System.String"))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub GenerarColummnValidacionLotesGeneralesII()
            Try
                dtdatosGenerales = New DataTable
                dtdatosGenerales.Columns.Add("LOTE", Type.GetType("System.String"))
                dtdatosGenerales.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
                dtdatosGenerales.Columns.Add("VENCIMIENTO", Type.GetType("System.String"))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function Datos_Lotes_articulo(ByVal WAREHOUSE_ID As String, ByVal PART_ID As String) As DataTable
            Try
                Dim query As String = ""
                query = "SELECT LOT_ID AS [LOTE],QTY_ON_HAND AS [CANTIDAD] ,CADUCATE_DATE AS [VENCIMIENTO] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                 & "ORDER BY CADUCATE_DATE asc"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function





        Public Function Fact_ArticuloLote(ByVal WAREHOUSE_ID As String, ByVal PART_ID As String, ByVal dtDetallesLotes As DataTable, _
                                   Optional ByVal _TipoDocumento As String = "", Optional ByVal Flag_Factura_Directa As Boolean = False, Optional ByVal ModoEdicion As Boolean = False, _
                                    Optional ByVal _LOTE As String = "", Optional ByVal _CANTIDAD As Double = 0) As DataTable
            Try
                Dim query As String = String.Empty
                Dim dtdetalles As New DataTable("DatosLotes")
                query = String.Empty
                Dim indicador As Boolean = False
                If Flag_Factura_Directa = False Then
                    query = String.Empty
                    'query = "SELECT LOT_ID AS [LOTE],QTY_ON_HAND AS [CANTIDAD] ,CADUCATE_DATE AS [VENCIMIENTO] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                    '& "  AND QTY_ON_HAND > 0  ORDER BY CADUCATE_DATE asc"
                    query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,convert(varchar,CADUCATE_DATE,103) AS [Vcto.],COMMENT as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario]  FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                 & "ORDER BY LOT_ID "
                    Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
                Else
                    If _TipoDocumento = String.Empty Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,convert(varchar,CADUCATE_DATE,103) AS [Vcto.],COMMENT as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario]  FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                              & "  AND QTY_ON_HAND>0  ORDER BY LOT_ID "
                        Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
                    ElseIf _TipoDocumento <> "NC" Then
                        query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,convert(varchar,CADUCATE_DATE,103) AS [Vcto.],COMMENT as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario]  FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                              & " AND QTY_ON_HAND>0  ORDER BY LOT_ID"
                    ElseIf _TipoDocumento = "NC" Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,convert(varchar,CADUCATE_DATE,103) AS [Vcto.],COMMENT as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario]  FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                              & "  ORDER BY LOT_ID"
                        Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
                    End If
                End If
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
                For Each item As DataRow In dtDetallesLotes.Select("CODIGO='" & PART_ID & "'")
                    indicador = True
                Next
                If indicador = False Then Return dtdetalles
                If dtdetalles.Rows.Count() <> 0 Then
                    GenerarColummnValidacionLotesGenerales()
                    Dim row As DataRow
                    For i As Integer = 0 To dtdetalles.Rows.Count() - 1
                        row = dtdatosGenerales.NewRow
                        row("CANTIDAD") = dtdetalles.Rows(i).Item(1).ToString
                        row("LOTE") = dtdetalles.Rows(i).Item(0).ToString
                        row("Vcto.") = dtdetalles.Rows(i).Item(2).ToString
                        row("Observaciones") = dtdetalles.Rows(i).Item(3).ToString
                        row("Informe de Ensayo") = dtdetalles.Rows(i).Item(4).ToString
                        row("Acta de Muestreo") = dtdetalles.Rows(i).Item(5).ToString
                        row("N° Protocolo") = dtdetalles.Rows(i).Item(6).ToString
                        row("Reg. Sanitario") = dtdetalles.Rows(i).Item(7).ToString
                        dtdatosGenerales.Rows.Add(row)
                        dtdatosGenerales.AcceptChanges()
                    Next
                    For Each item As DataRow In dtDetallesLotes.Select("CODIGO='" & PART_ID & "'")
                        For Each rows As DataRow In dtdatosGenerales.Rows
                            If rows("LOTE") = item("LOTE") Then
                                If (rows("CANTIDAD") - item("CANTIDAD")) = 0 Then
                                    dtdatosGenerales.BeginInit()
                                    rows.Delete()
                                    dtdatosGenerales.EndInit()
                                    dtdatosGenerales.AcceptChanges()
                                    If ModoEdicion = True Then
                                        If item("LOTE") = _LOTE Then
                                            row = dtdatosGenerales.NewRow
                                            row("CANTIDAD") = 0
                                            row("LOTE") = _LOTE
                                            dtdatosGenerales.Rows.Add(row)
                                            dtdatosGenerales.AcceptChanges()
                                        End If
                                    End If
                                    Exit For
                                End If
                                dtdatosGenerales.BeginInit()
                                rows("CANTIDAD") = rows("CANTIDAD") - item("CANTIDAD")
                                dtdatosGenerales.EndInit()
                                dtdatosGenerales.AcceptChanges()
                            End If
                        Next
                    Next
                End If
                If ModoEdicion = True Then
                    For Each rows As DataRow In dtdatosGenerales.Select("LOTE='" & _LOTE & "'")
                        dtdatosGenerales.BeginInit()
                        rows("CANTIDAD") = rows("CANTIDAD") + _CANTIDAD
                        dtdatosGenerales.EndInit()
                        dtdatosGenerales.AcceptChanges()
                    Next
                End If
                Return dtdatosGenerales
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloLote(ByVal WAREHOUSE_ID As String, ByVal PART_ID As String, ByVal LOT As String, _
                                         Optional ByVal _TipoDocumento As String = "", Optional ByVal flag_guia_Facturar As Boolean = False) As DataTable
            Try
                If LOT = String.Empty Then LOT = "''"
                Dim query As String = String.Empty

                If flag_guia_Facturar = True Then
                    query = String.Empty
                    query = "SELECT LOT_ID AS [LOTE],QTY_ON_HAND AS [CANTIDAD] ,CADUCATE_DATE AS [VENCIMIENTO] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                    & "  AND QTY_ON_HAND>0  ORDER BY CADUCATE_DATE asc"
                Else
                    If _TipoDocumento = String.Empty Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [LOTE],QTY_ON_HAND AS [CANTIDAD] ,isnull(CADUCATE_DATE,'') AS [VENCIMIENTO] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                        & " AND QTY_ON_HAND>0  ORDER BY CADUCATE_DATE asc"
                        '& " AND LOT_ID NOT IN (" & LOT & ") AND QTY_ON_HAND>0  ORDER BY CADUCATE_DATE asc"


                    ElseIf _TipoDocumento <> "NC" Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [LOTE],QTY_ON_HAND AS [CANTIDAD] ,CADUCATE_DATE AS [VENCIMIENTO] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                        & " AND LOT_ID NOT IN (" & LOT & ") AND QTY_ON_HAND>0  ORDER BY CADUCATE_DATE asc"
                    ElseIf _TipoDocumento = "NC" Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [LOTE],QTY_ON_HAND AS [CANTIDAD] ,CADUCATE_DATE AS [VENCIMIENTO] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                        & " AND LOT_ID NOT IN (" & LOT & ") ORDER BY CADUCATE_DATE asc"
                    End If
                End If
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function get_ArticuloLoteII(ByVal WAREHOUSE_ID As String, ByVal PART_ID As String, ByVal dtDetallesLotes As DataTable, _
                                 Optional ByVal _TipoDocumento As String = "", Optional ByVal flag_guia_Facturar As Boolean = False, _
                                 Optional ByVal ModoEdicion As Boolean = False, _
                                  Optional ByVal _LOTE As String = "", Optional ByVal _CANTIDAD As Double = 0) As DataTable
            Try
                Dim query As String = String.Empty
                Dim dtdetalles As New DataTable("DatosLotes")
                query = String.Empty
                Dim indicador As Boolean = False

                If flag_guia_Facturar = True Then
                    query = String.Empty
                    query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,CADUCATE_DATE AS [Vcto.],comment as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                    & "  AND QTY_ON_HAND>0  ORDER BY LOT_ID asc"
                Else
                    If _TipoDocumento = String.Empty Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,CADUCATE_DATE AS [Vcto.],comment as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                   & "  AND QTY_ON_HAND>0  ORDER BY LOT_ID asc"
                    ElseIf _TipoDocumento <> "NC" Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,CADUCATE_DATE AS [Vcto.],comment as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                        & "  AND QTY_ON_HAND>0  ORDER BY LOT_ID asc"
                    ElseIf _TipoDocumento = "NC" Then
                        query = String.Empty
                        query = "SELECT LOT_ID AS [Lote],QTY_ON_HAND AS [Cantidad] ,CADUCATE_DATE AS [Vcto.],comment as [Observaciones],INFORME_ENSAYO [Informe de Ensayo], ACTA_MUESTREO [Acta de Muestreo], N_PROTOCOLO [N° Protocolo], REGISTRO_SANITARIO [Reg. Sanitario] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                        & " ORDER BY LOT_ID asc"
                    End If
                End If
                dtdetalles = SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
                For Each item As DataRow In dtDetallesLotes.Select("CODIGO='" & PART_ID & "'")
                    indicador = True
                Next
                If indicador = False Then Return dtdetalles
                If dtdetalles.Rows.Count() <> 0 Then
                    GenerarColummnValidacionLotesGeneralesII()
                    Dim row As DataRow
                    For i As Integer = 0 To dtdetalles.Rows.Count() - 1
                        row = dtdatosGenerales.NewRow
                        row("CANTIDAD") = dtdetalles.Rows(i).Item(1).ToString
                        row("LOTE") = dtdetalles.Rows(i).Item(0).ToString
                        row("VENCIMIENTO") = dtdetalles.Rows(i).Item(2).ToString
                        dtdatosGenerales.Rows.Add(row)
                        dtdatosGenerales.AcceptChanges()
                    Next
                    Dim Fech As String = String.Empty
                    For Each item As DataRow In dtDetallesLotes.Select("CODIGO='" & PART_ID & "'")
                        For Each rows As DataRow In dtdatosGenerales.Rows
                            If rows("LOTE") = item("LOTE") Then
                                Fech = rows("VENCIMIENTO")
                                If (rows("CANTIDAD") - item("CANTIDAD")) = 0 Then
                                    dtdatosGenerales.BeginInit()
                                    rows.Delete()
                                    dtdatosGenerales.EndInit()
                                    dtdatosGenerales.AcceptChanges()
                                    If ModoEdicion = True Then
                                        If item("LOTE") = _LOTE Then
                                            row = dtdatosGenerales.NewRow
                                            row("CANTIDAD") = 0
                                            row("LOTE") = _LOTE
                                            row("VENCIMIENTO") = Fech
                                            dtdatosGenerales.Rows.Add(row)
                                            dtdatosGenerales.AcceptChanges()
                                        End If
                                    End If
                                    Exit For
                                End If
                                dtdatosGenerales.BeginInit()
                                rows("CANTIDAD") = rows("CANTIDAD") - item("CANTIDAD")
                                dtdatosGenerales.EndInit()
                                dtdatosGenerales.AcceptChanges()
                            End If
                        Next
                    Next
                End If
                If ModoEdicion = True Then
                    For Each rows As DataRow In dtdatosGenerales.Select("LOTE='" & _LOTE & "'")
                        dtdatosGenerales.BeginInit()
                        rows("CANTIDAD") = rows("CANTIDAD") + _CANTIDAD
                        dtdatosGenerales.EndInit()
                        dtdatosGenerales.AcceptChanges()
                    Next
                End If
                Return dtdatosGenerales
            Catch ex As Exception
                Throw
            End Try
        End Function




        Public Function get_UltimoLote(ByVal WAREHOUSE_ID As String, ByVal PART_ID As String) As DataTable
            Try
                Dim query As String = String.Empty
                query = String.Empty
                query = "SELECT TOP 1 B.NUMBER_LOT FROM dbo.WAREHOUSE_TRANS a INNER JOIN dbo.WAREHOUSE_TRANS_LINE b ON a.WAREHOUSE_ID=b.WAREHOUSE_ID " _
                    & " AND a.DOCUMENT_ID=b.DOCUMENT_ID AND a.NUMBER_DOCUMENT=b.NUMBER_DOCUMENT WHERE b.PART_ID='" & PART_ID & "' AND a.STATUS_GUIA<>'A' AND  A.WAREHOUSE_ID='" & WAREHOUSE_ID & "'" _
                    & " GROUP BY B.NUMBER_LOT, A.NUMBER_DOCUMENT ORDER BY A.NUMBER_DOCUMENT DESC"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Function get_ArticuloLoteOrdenCompra(ByVal WAREHOUSE_ID As String, ByVal PART_ID As String, ByVal LOT As String) As DataTable
            Try
                If LOT = String.Empty Then LOT = "''"
                Dim query As String = String.Empty
                query = String.Empty
                query = "SELECT QTY_ON_HAND AS [CANTIDAD], LOT_ID AS [LOTE] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                & " AND LOT_ID NOT IN (" & LOT & ") ORDER BY CADUCATE_DATE asc"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        '----INVENTARIOS
        Public Function get_InventarioVerificacionArticuloCodigo(ByVal WAREHOUSE_ID As String, ByVal ID As String, ByVal TipoArticulo As String, Optional ByVal _TipoDocumento As String = "") As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                If _TipoDocumento = "I" Then
                    dtTable = dataBL.Run_SP_DataTable("ALM_SP_S_WAREHOUSE_PRODUCTO_VER_I", _
                    dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID), _
                    dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID), _
                    dataBL.DatosParam("@TYPE_PART", SqlDbType.VarChar, 2, TipoArticulo))
                ElseIf _TipoDocumento = "S" Then
                    dtTable = dataBL.Run_SP_DataTable("ALM_SP_S_WAREHOUSE_PRODUCTO_VER_S", _
                    dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID), _
                    dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID), _
                      dataBL.DatosParam("@TYPE_PART", SqlDbType.VarChar, 2, TipoArticulo))
                End If
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function get_InventarioArticuloLote(ByVal WAREHOUSE_ID As String, ByVal PART_ID As String, ByVal LOT As String, _
                                  Optional ByVal _TipoDocumento As String = "") As DataTable
            Try
                If LOT = String.Empty Then LOT = "''"
                Dim query As String = String.Empty
                If _TipoDocumento = "S" Then
                    query = String.Empty
                    'query = "SELECT QTY_ON_HAND AS [CANTIDAD], LOT_ID AS [LOTE] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                    '& " AND LOT_ID NOT IN (" & LOT & ") AND QTY_ON_HAND > 0  ORDER BY CADUCATE_DATE ASC"
                    query = "SELECT QTY_ON_HAND AS [CANTIDAD], LOT_ID AS [LOTE] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                    & " AND QTY_ON_HAND > 0  ORDER BY CADUCATE_DATE ASC"
                ElseIf _TipoDocumento = "I" Then
                    query = String.Empty
                    'query = "SELECT QTY_ON_HAND AS [CANTIDAD], LOT_ID AS [LOTE] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "'" _
                    '& " AND LOT_ID NOT IN (" & LOT & ") ORDER BY CADUCATE_DATE ASC"
                    query = "SELECT QTY_ON_HAND AS [CANTIDAD], LOT_ID AS [LOTE] FROM LOT WHERE WHO_ID='" & WAREHOUSE_ID & "' AND PART_ID='" & PART_ID & "' ORDER BY CADUCATE_DATE ASC"
                End If
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_VerificacionArticuloCodigoGuia(ByVal WAREHOUSE_ID As String, ByVal ID As String, Optional ByVal FacturaExistencia As Boolean = False) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                If FacturaExistencia = True Then
                    dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_PRODUCTOS_VERIFICAR_COD", _
                           dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 20, WAREHOUSE_ID),
                           dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                    dataBL.Dispose()
                Else
                    dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_PRODUCTOS_VERIFICAR_COD_POS", _
                                            dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                            dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                    dataBL.Dispose()
                End If
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_VerificacionArticuloCodigo(ByVal WAREHOUSE_ID As String, ByVal ID As String, Optional ByVal FacturaExistencia As Boolean = False) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                If FacturaExistencia = True Then
                    dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_PRODUCTOS_VERIFICAR_COD_EXIS", _
                           dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 20, WAREHOUSE_ID),
                           dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                    dataBL.Dispose()
                Else
                    dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_PRODUCTOS_VERIFICAR_COD_POS", _
                                            dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                            dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                    dataBL.Dispose()
                End If
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function get_VerificacionArticuloCodigoFactura(ByVal WAREHOUSE_ID As String, ByVal ID As String, _
                                                              Optional ByVal FacturaDirecta As Boolean = False, _
                                                              Optional ByVal _TipoDoc As String = "", _
                                                              Optional ByVal Pedido As Boolean = False, _
                                                              Optional ByVal Parts As String = "") As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                If FacturaDirecta = False Then
                    dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_PRODUCTOS_VERIFICAR_COD_EXIS", _
                           dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 20, WAREHOUSE_ID),
                           dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                    dataBL.Dispose()
                Else
                    If _TipoDoc = "NC" Or _TipoDoc = "ND" Then
                        dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_PRODUCTOS_VERIFICAR_COD", _
                                            dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                            dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                        dataBL.Dispose()
                    Else
                        If Pedido = True Then
                            dtTable = dataBL.Run_SP_DataTable("PART_SP_S_PRODUCTOS_VERIFICAR_COD_POS_PED", _
                                                                dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                                                dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID),
                                                                dataBL.DatosParam("@PARTS", SqlDbType.VarChar, 99, Parts)
                                                                )
                            dataBL.Dispose()
                        Else
                            dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_PRODUCTOS_VERIFICAR_COD_POS", _
                                                                  dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                                                  dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                            dataBL.Dispose()
                        End If

                    End If
                End If
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function get_VerificacionArticuloCodigoFact(ByVal WAREHOUSE_ID As String, ByVal ID As String, Optional ByVal FacturaExistencia As Boolean = False, Optional ByVal _TipoDoc As String = "") As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                If FacturaExistencia = True Then
                    dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_PRODUCTOS_VERIFICAR_COD_EXIS", _
                           dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 20, WAREHOUSE_ID),
                           dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                    dataBL.Dispose()
                Else
                    If _TipoDoc = "NC" Then
                        dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_PRODUCTOS_VERIFICAR_COD", _
                                            dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                            dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                        dataBL.Dispose()
                    Else
                        dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_PRODUCTOS_VERIFICAR_COD_POS", _
                                       dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                       dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                        dataBL.Dispose()
                    End If
                End If
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Function get_VerificacionArticuloServicio(ByVal ID As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("FACT_SP_S_PRODUCTOS_VERIFICAR_COD_SERV", _
                                       dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function


        'INGRESO POR ORDEN DE COMPRA
        Public Function get_VerificacionArticuloCodigoOC(ByVal WAREHOUSE_ID As String, ByVal ID As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("ALM_SP_S_OC_PRODUCTOS_COD", _
                                dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function

        'GENERACION DE PEDIDOS  

        Public Function get_VerificacionArticuloCodigoPedido(ByVal WAREHOUSE_ID As String, ByVal ID As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("PED_SP_S_ORDERS_PART_VERIFICAR_COD", _
                                dataBL.DatosParam("@WAREHOUSE_ID", SqlDbType.VarChar, 2, WAREHOUSE_ID),
                                dataBL.DatosParam("@ID", SqlDbType.VarChar, 20, ID))
                dataBL.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloMarca() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_MARCA").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ListaPrecios() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_LISTA_PRECIOS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloMarcaDescuento() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_MARCA_DESC").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function get_ArticuloGenerico() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_GENERICO").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloGenericoDescuento() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_GENERICO_DESC").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloMuestraMedica() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_M_MEDICA").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloMuestraMedicaDescuento() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_M_MEDICA_DESC").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloMaquila() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_MAQUILA").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ArticuloMaquilaDescuento() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_PROD_MAQUILA_DESC").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Sub get_VerificacionPrecio(ByVal _codigoArticulo As String, ByVal _Usuario As String, ByVal _Precio As Double)
            Dim trs As SqlTransaction
            trs = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(trs, "PART_SP_S_PART_PROD_PRECIO", _codigoArticulo, _Usuario, _Precio)
                trs.Commit()
                trs.Dispose()
            Catch ex As Exception
                trs.Rollback()
                Throw
            End Try
        End Sub


        Public Sub ActualizarProductos(ByVal CODIGO_ART As String, ByVal DESCRIPCION As String, ByVal PRESENTACION As String, ByVal HORA As String, _
                                           ByVal USUARIO As String, ByVal TIPO_ART As String, ByVal MAQUILA As Integer)
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "PART_SP_U_PART_ACT_ART", CODIGO_ART, DESCRIPCION, PRESENTACION, HORA, USUARIO, TIPO_ART, MAQUILA)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                Throw
            End Try
        End Sub

        Public Sub ActualizacionProductos(ByVal HORA As String, ByVal USUARIO As String, ByVal DATOS As DataTable, ByVal progreso As ProgressBar, ByVal IndicadorMaquila As Integer)
            Dim trs As SqlTransaction
            trs = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim CODIGO_ART As String = String.Empty
                Dim DESCRIPCION As String = String.Empty
                Dim PRESENTACION As String = String.Empty
                Dim PRECIO As String = String.Empty
                Dim MARCA As String = String.Empty
                progreso.Minimum = 0
                progreso.Maximum = DATOS.Rows.Count()
                If DATOS.Rows.Count() <> 0 Then
                    For i As Integer = 0 To DATOS.Rows.Count() - 1
                        CODIGO_ART = String.Empty
                        DESCRIPCION = String.Empty
                        PRESENTACION = String.Empty
                        PRECIO = String.Empty
                        MARCA = String.Empty
                        CODIGO_ART = DATOS.Rows(i).Item(0).ToString
                        DESCRIPCION = DATOS.Rows(i).Item(1).ToString
                        PRESENTACION = DATOS.Rows(i).Item(2).ToString
                        If String.IsNullOrEmpty(DATOS.Rows(i).Item(4).ToString) Then
                            PRECIO = 0.0
                        Else
                            PRECIO = DATOS.Rows(i).Item(4).ToString
                        End If
                        MARCA = DATOS.Rows(i).Item(5).ToString
                        progreso.Value = i
                        If IndicadorMaquila = 0 Then
                            SqlHelper.ExecuteNonQuery(trs, "PART_SP_U_PART_ACT_ART", CODIGO_ART, DESCRIPCION, PRESENTACION, HORA, USUARIO, MARCA, 0)
                        Else
                            SqlHelper.ExecuteNonQuery(trs, "PART_SP_U_PART_ACT_ART", CODIGO_ART, DESCRIPCION, PRESENTACION, HORA, USUARIO, MARCA, 1)
                        End If
                        '-----Precio Articulo
                        SqlHelper.ExecuteNonQuery(trs, "PART_SP_S_PART_PROD_PRECIO", CODIGO_ART, USUARIO, CDbl(PRECIO))
                        progreso.PerformStep()
                    Next
                End If
                progreso.Value = 0
                trs.Commit()
                trs.Dispose()
            Catch ex As Exception
                trs.Rollback()
                Throw
            End Try
        End Sub

        Public Sub ActualizacionProductosDescuentos(ByVal USUARIO As String, ByVal DATOS As DataTable, ByVal progreso As ProgressBar)
            Dim trs As SqlTransaction
            trs = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim CODIGO_ART As String = String.Empty
                Dim DESC1 As String = String.Empty
                Dim DESC2 As String = String.Empty
                Dim DESC3 As String = String.Empty
                Dim DESC4 As String = String.Empty
                progreso.Minimum = 0
                progreso.Maximum = DATOS.Rows.Count()
                If DATOS.Rows.Count() <> 0 Then
                    For i As Integer = 0 To DATOS.Rows.Count() - 1
                        CODIGO_ART = String.Empty
                        DESC1 = String.Empty
                        DESC2 = String.Empty
                        DESC3 = String.Empty
                        DESC4 = String.Empty
                        CODIGO_ART = DATOS.Rows(i).Item(0).ToString
                        If String.IsNullOrEmpty(DATOS.Rows(i).Item(3).ToString) Then
                            DESC1 = 0.0
                        Else
                            DESC1 = DATOS.Rows(i).Item(3)
                        End If
                        If String.IsNullOrEmpty(DATOS.Rows(i).Item(4).ToString) Then
                            DESC2 = 0.0
                        Else
                            DESC2 = DATOS.Rows(i).Item(4)
                        End If
                        If String.IsNullOrEmpty(DATOS.Rows(i).Item(5).ToString) Then
                            DESC3 = 0.0
                        Else
                            DESC3 = DATOS.Rows(i).Item(5)
                        End If
                        If String.IsNullOrEmpty(DATOS.Rows(i).Item(6).ToString) Then
                            DESC4 = 0.0
                        Else
                            DESC4 = DATOS.Rows(i).Item(6)
                        End If

                        progreso.Value = i
                        '-----Descuentos de articulos
                        SqlHelper.ExecuteNonQuery(trs, "PART_SP_I_U_PART_PROD_DESCUENTO", CODIGO_ART, USUARIO, CDbl(DESC1), CDbl(DESC2), CDbl(DESC3), CDbl(DESC4))
                        progreso.PerformStep()
                    Next
                End If
                progreso.Value = 0
                trs.Commit()
                trs.Dispose()
            Catch ex As Exception
                trs.Rollback()
                Throw
            End Try
        End Sub

        Public Function DescuentosCliente(ByVal CodigoCliente As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_DESC_CLIENTE", CodigoCliente).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        'Public Function RetornarStockProductos(ByVal _ListaCodigoAlmacen As List(Of String), ByVal Todos As Integer) As DataTable
        '    Dim trs As SqlTransaction
        '    Dim dtdetalle As DataTable
        '    Dim Consulta As String
        '    Dim CodigoAlm As String = String.Empty
        '    trs = cn.BeginTransaction(IsolationLevel.Serializable)
        '    Try
        '        If Todos = 0 Then
        '            SqlHelper.ExecuteNonQuery(trs, "ACT_QTY_LOTE_2010_AL", _ListaCodigoAlmacen.Item(0).ToString)
        '            CodigoAlm = "'" + _ListaCodigoAlmacen.Item(0).ToString + "'"
        '        Else
        '            For i As Integer = 0 To _ListaCodigoAlmacen.Count() - 1
        '                SqlHelper.ExecuteNonQuery(trs, "ACT_QTY_LOTE_2010", _ListaCodigoAlmacen.Item(i).ToString)
        '                CodigoAlm += "'" + _ListaCodigoAlmacen.Item(i).ToString + "',"
        '            Next
        '            CodigoAlm = Strings.Left(CodigoAlm, Len(CodigoAlm) - 1)
        '        End If
        '        dtdetalle = New DataTable
        '        dtdetalle = SqlHelper.ExecuteDataset(trs, CommandType.StoredProcedure, "PART_SP_S_PART_CONCEPTO").Tables(0)
        '        Consulta = String.Empty
        '        If dtdetalle.Rows.Count() <> 0 Then
        '            Consulta = "select P.ID,P.DESCRIPTION,CONVERT(decimal(15,6),N.QTY_ON_HAND),P.UNIT_OF_MEASUREMENT," & _
        '         "CAST(CONVERT(decimal(15,2),P.WEIGHT) AS VARCHAR(30))+ ' ' + P.REFERENCE AS PRESENT," & _
        '         "CONVERT(decimal(15,4),N.QTY_REFERENCE),P.REFERENCE,P.ID_FAB," & _
        '         "CONVERT(decimal(15,4),N.COST_AVG),CONVERT(decimal(15,4),N.COST_AVG_US)," & _
        '         "CONVERT(decimal(15,4),N.LAST_PRICE),CONVERT(decimal(15,4),N.LAST_RECEIVED_DATE),P.FAMILY " & _
        '         "from PART P, PART_QTY N where P.ID=N.PART_ID and N.WAREHOUSE_ID in (" & CodigoAlm & ") AND P.STATUS<>'F' ORDER BY P.ID"
        '        Else
        '            If Todos = 0 Then
        '                Consulta = "select P.ID,P.NOMBRE_COMERCIAL,P.PRESS_COMERCIAL,P.UNIT_OF_MEASUREMENT,P.DESCRIPTION_OPT,CONVERT(decimal(15,6),N.QTY_ON_HAND)," & _
        '                   "CAST(CONVERT(decimal(15,2),P.WEIGHT) AS VARCHAR(30))+ ' ' + P.REFERENCE AS PRESENT,CONVERT(decimal(15,4),N.COST_AVG) " & _
        '                   ",CONVERT(decimal(15,4),N.COST_AVG_US),N.LAST_PRICE " & _
        '                   "," & FORMATO_FECHA_SQL("LAST_RECEIVED_DATE") & ",P.FAMILY " & _
        '                   "from PART P, PART_QTY N where P.ID =N.PART_ID and N.WAREHOUSE_ID in (" & CodigoAlm & ") AND P.STATUS<>'F' AND N.QTY_ON_HAND<>0 ORDER BY P.ID"
        '            ElseIf Todos = 1 Then
        '                Consulta = "select P.ID,P.NOMBRE_COMERCIAL,P.PRESS_COMERCIAL,P.UNIT_OF_MEASUREMENT,P.DESCRIPTION_OPT,sum(CONVERT(decimal(15,6),N.QTY_ON_HAND))," & _
        '                 "CAST(CONVERT(decimal(15,2),P.WEIGHT) AS VARCHAR(30))+ ' ' + P.REFERENCE AS PRESENT,sum(CONVERT(decimal(15,4),N.COST_AVG)) " & _
        '                 ",sum(CONVERT(decimal(15,4),N.COST_AVG_US)),sum(N.LAST_PRICE) " & _
        '                 "," & FORMATO_FECHA_SQL("LAST_RECEIVED_DATE") & ",P.FAMILY " & _
        '                 "from PART P, PART_QTY N where P.ID =N.PART_ID and N.WAREHOUSE_ID in (" & CodigoAlm & ") AND P.STATUS<>'F' AND N.QTY_ON_HAND<>0 GROUP BY P.ID,P.NOMBRE_COMERCIAL,P.DESCRIPTION_OPT,P.UNIT_OF_MEASUREMENT,P.PRESS_COMERCIAL,P.FAMILY,P.WEIGHT,P.REFERENCE,LAST_RECEIVED_DATE ORDER BY P.ID"
        '            End If
        '        End If
        '        'Retornando la Data
        '        Return SqlHelper.ExecuteDataset(trs, CommandType.Text, Consulta).Tables(0)
        '        trs.Commit()
        '        trs.Dispose()
        '    Catch ex As Exception
        '        trs.Rollback()
        '        Throw
        '    End Try
        'End Function

        Public Function RetornarStockProductos(ByVal _ListaCodigoAlmacen As List(Of String), ByVal Todos As Integer) As DataTable
            Dim dtdetalle As DataTable
            Dim Consulta As String
            Dim CodigoAlm As String = String.Empty
            Try
                If Todos = 0 Then
                    If _ListaCodigoAlmacen.Item(0).ToString = "26" Then
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_I", _ListaCodigoAlmacen.Item(0).ToString)
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_II", _ListaCodigoAlmacen.Item(0).ToString)
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_III", _ListaCodigoAlmacen.Item(0).ToString)
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_IV", _ListaCodigoAlmacen.Item(0).ToString)
                        CodigoAlm = "'" + _ListaCodigoAlmacen.Item(0).ToString + "'"
                    Else
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", _ListaCodigoAlmacen.Item(0).ToString)
                        CodigoAlm = "'" + _ListaCodigoAlmacen.Item(0).ToString + "'"
                    End If
                Else
                    SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010", "LUSA")
                    Consulta = String.Empty
                    dtdetalle = New DataTable
                    Consulta = "select * from Warehouse"
                    dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
                    If dtdetalle.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtdetalle.Rows.Count() - 1
                            CodigoAlm += "'" + dtdetalle.Rows(i).Item(0).ToString + "',"
                        Next
                        CodigoAlm = Strings.Left(CodigoAlm, Len(CodigoAlm) - 1)
                    End If
                End If
                dtdetalle = New DataTable
                dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PART_SP_S_PART_CONCEPTO").Tables(0)
                Consulta = String.Empty
                If dtdetalle.Rows.Count() <> 0 Then
                    Consulta = "select P.ID,P.DESCRIPTION,CONVERT(decimal(15,6),N.QTY_ON_HAND),P.UNIT_OF_MEASUREMENT," & _
                 "CAST(CONVERT(decimal(15,2),P.WEIGHT) AS VARCHAR(30))+ ' ' + P.REFERENCE AS PRESENT," & _
                 "CONVERT(decimal(15,4),N.QTY_REFERENCE),P.REFERENCE,P.ID_FAB," & _
                 "CONVERT(decimal(15,4),N.COST_AVG),CONVERT(decimal(15,4),N.COST_AVG_US)," & _
                 "CONVERT(decimal(15,4),N.LAST_PRICE),CONVERT(decimal(15,4),N.LAST_RECEIVED_DATE),P.FAMILY " & _
                 "from PART P, PART_QTY N where P.ID=N.PART_ID and N.WAREHOUSE_ID in (" & CodigoAlm & ") AND P.STATUS<>'F' ORDER BY P.ID"
                Else
                    If Todos = 0 Then
                        Consulta = "select P.ID,P.NOMBRE_COMERCIAL,P.PRESS_COMERCIAL,P.UNIT_OF_MEASUREMENT,P.DESCRIPTION_OPT,CONVERT(decimal(15,6),N.QTY_ON_HAND)," & _
                           "CAST(CONVERT(decimal(15,2),P.WEIGHT) AS VARCHAR(30))+ ' ' + P.REFERENCE AS PRESENT,CONVERT(decimal(15,4),N.COST_AVG) " & _
                           ",CONVERT(decimal(15,4),N.COST_AVG_US),N.LAST_PRICE " & _
                           "," & FORMATO_FECHA_SQL("LAST_RECEIVED_DATE") & ",P.FAMILY " & _
                           "from PART P, PART_QTY N where P.ID =N.PART_ID and N.WAREHOUSE_ID in (" & CodigoAlm & ") AND P.STATUS<>'F' AND N.QTY_ON_HAND<>0 ORDER BY P.ID"
                    ElseIf Todos = 1 Then
                        Consulta = "select P.ID,P.NOMBRE_COMERCIAL,P.PRESS_COMERCIAL,P.UNIT_OF_MEASUREMENT,P.DESCRIPTION_OPT,sum(CONVERT(decimal(15,6),N.QTY_ON_HAND))," & _
                         "CAST(CONVERT(decimal(15,2),P.WEIGHT) AS VARCHAR(30))+ ' ' + P.REFERENCE AS PRESENT,sum(CONVERT(decimal(15,4),N.COST_AVG)) " & _
                         ",sum(CONVERT(decimal(15,4),N.COST_AVG_US)),sum(N.LAST_PRICE) " & _
                         ",P.FAMILY from PART P, PART_QTY N where P.ID =N.PART_ID and N.WAREHOUSE_ID in (" & CodigoAlm & ") AND P.STATUS<>'F' AND N.QTY_ON_HAND<>0 GROUP BY P.ID,P.NOMBRE_COMERCIAL,P.DESCRIPTION_OPT,P.UNIT_OF_MEASUREMENT,P.PRESS_COMERCIAL,P.FAMILY,P.WEIGHT,P.REFERENCE ORDER BY P.ID"
                    End If
                End If
                'Retornando la Data
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function FORMATO_FECHA_SQL(ByVal Campo As String) As String
            FORMATO_FECHA_SQL = "(CASE WHEN LEN(CONVERT(VARCHAR(2),DAY(" & Campo & ")))=1 THEN" & _
                       "'0'+CONVERT(VARCHAR(2),DAY(" & Campo & "))Else CONVERT(VARCHAR(2),DAY(" & Campo & "))END )+'/'+" & _
                      " (CASE WHEN LEN(CONVERT(VARCHAR(2),MONTH(" & Campo & ")))=1 THEN '0'+CONVERT(VARCHAR(2),MONTH(" & Campo & "))Else" & _
                      " CONVERT(VARCHAR(2),MONTH(" & Campo & "))END )+'/'+ CONVERT(VARCHAR(4),YEAR(" & Campo & "))"
            Return FORMATO_FECHA_SQL
        End Function

        Public Function ConsultarArticuloLibre(ByVal _codigoPart As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_VERF_LIBRE", _codigoPart).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function ConsultarArticuloLote(ByVal _codigoPart As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_VERF", _codigoPart).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function ConsultarArticuloSerie(ByVal _codigoPart As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_VERF_SERIE", _codigoPart).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function DetalleArticuloLote(ByVal _codigoPart As String, ByVal _Almacen As String, ByVal Todos As Boolean) As DataTable
            Try
                If Todos = True Then
                    Dim consulta As String = String.Empty
                    Dim CodigoAlm As String = String.Empty
                    Dim dtdetalle As DataTable
                    consulta = "select * from Warehouse"
                    dtdetalle = New DataTable
                    dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
                    If dtdetalle.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtdetalle.Rows.Count() - 1
                            CodigoAlm = CodigoAlm & """" & dtdetalle.Rows(i).Item(0).ToString & """" & ","
                        Next
                        CodigoAlm = Strings.Left(CodigoAlm, Len(CodigoAlm) - 1)
                        Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_DATOS", _codigoPart, CodigoAlm).Tables(0)
                    End If
                Else
                    Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_DATOS", _codigoPart, _Almacen).Tables(0)
                End If

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function DetalleArticuloLibre(ByVal _codigoPart As String, ByVal _Almacen As String, ByVal Todos As Boolean) As DataTable
            Try
                If Todos = True Then
                    Dim consulta As String = String.Empty
                    Dim CodigoAlm As String = String.Empty
                    Dim dtdetalle As DataTable
                    consulta = "select * from Warehouse"
                    dtdetalle = New DataTable
                    dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
                    If dtdetalle.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtdetalle.Rows.Count() - 1
                            CodigoAlm = CodigoAlm & """" & dtdetalle.Rows(i).Item(0).ToString & """" & ","
                        Next
                        CodigoAlm = Strings.Left(CodigoAlm, Len(CodigoAlm) - 1)
                        Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_DATOS_LIBRESv2", _codigoPart, CodigoAlm).Tables(0)
                    End If
                Else
                    Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_DATOS_LIBRESv2", _codigoPart, _Almacen).Tables(0)
                End If

            Catch ex As Exception
                Throw
            End Try
        End Function




        Public Function DatosUsuarios(ByVal _codigoUsuario As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_USUARIO_NIVEL", _codigoUsuario).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class




    Public Class CURRENCY_EXCHANGE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_tipoCambio(entidad As ClsEntidades.CURRENCY_EXCHANGE) As Double
            Return SqlHelper.ExecuteScalar(cn, "CX_SP_S_CURRENCY_EXCHANGE_XFEC", CDate(entidad.CURRENCY_DATE), entidad.CURRENCY_ID)
        End Function

        Public Function get_TipoCambioPeriodo(ByVal _ANIO As String, ByVal _MES As String, Optional ByVal _DIA As String = "") As DataTable
            Try
                If String.IsNullOrEmpty(_DIA) Then
                    Return SqlHelper.ExecuteDataset(cn, "ADM_LISTA_TIPO_CAMBIO", _ANIO, _MES).Tables(0)
                Else
                    Return SqlHelper.ExecuteDataset(cn, "ADM_LISTA_TIPO_CAMBIO_ESPECIFICO", _ANIO, _MES, _DIA).Tables(0)
                End If

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_VerificarTipoCambio(ByVal _ANIO As String, ByVal _MES As String, ByVal _DIA As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_LISTA_TIPO_CAMBIO_ESPECIFICO", _ANIO, _MES, _DIA).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Guardar(entidad As ClsEntidades.CURRENCY_EXCHANGE) As Boolean
            Dim estado As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ADM_SP_I_CURRENCY_EXCHANGE", .CURRENCY_ID, .CURRENCY_DATE, .BUY_RATE, .BUY_EQUIV, .SELL_RATE, .SELL_EQUIV)
                End With
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                estado = False
            End Try
            Return estado
        End Function


        Public Function Modificar(entidad As ClsEntidades.CURRENCY_EXCHANGE) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim estado As Boolean = True
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ADM_SP_U_CURRENCY_EXCHANGE", .CURRENCY_ID, .CURRENCY_DATE, .BUY_RATE, .SELL_RATE)
                End With
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                estado = False
            End Try
            Return estado
        End Function


        '' PROGRAMACION DE CIERRES MENSUALES

        Public Function get_VerificarProgCierreVentasMensual(ByVal _ANIO As String, ByVal _MES As String, ByVal _DIA As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_PROG_CIERRE_VENTAS_MENSUAL_ESPECIFICO", _ANIO, _MES, _DIA).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_ProgCierreVentasMensual(ByVal _ANIO As String, ByVal _MES As String, Optional ByVal _DIA As String = "") As DataTable
            Try
                If String.IsNullOrEmpty(_DIA) Then
                    Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_PROG_CIERRE_VENTAS_MENSUAL", _ANIO, _MES).Tables(0)
                Else
                    Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_PROG_CIERRE_VENTAS_MENSUAL_ESPECIFICO", _ANIO, _MES, _DIA).Tables(0)
                End If

            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class




    Public Class NUMBER_DOCUMENT
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Update(entidad As ClsEntidades.NUMBER_DOCUMENT)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_NUMBER_DOCUMENT", .TYPE_DOC, .NUMBER_SERIE, .LAST_NUMBER)
            End With
        End Sub

        Public Function get_Correlativos(entidad As ClsEntidades.NUMBER_DOCUMENT) As String
            Return SqlHelper.ExecuteScalar(cn, "CX_SP_S_NUMBER_DOCUMENT_XCORRE", entidad.TYPE_DOC, entidad.NUMBER_SERIE)
        End Function
    End Class

    Public Class DOCUMENT_PLACE_SALES
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Series(entidad As ClsEntidades.SALES_PLACE) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_DOCUMENT_PLACE_SALES_XSER", entidad.SALES_PLACE_ID).Tables(0)
        End Function

        Public Function get_almacen_x_ptovta(entidad As ClsEntidades.SALES_PLACE) As String
            Dim query As String = "SELECT WAREHOUSE_ID FROM SALES_PLACE WHERE SALES_PLACE_ID = '" & entidad.SALES_PLACE_ID & "'"
            Return SqlHelper.ExecuteScalar(cn, CommandType.Text, query)
        End Function

    End Class

    Public Class SALES_PLACE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_PuntosVentas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_SALES_PLACE").Tables(0)
        End Function
    End Class

    Public Class RECEIVABLE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Get_ManualProveedor(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_PROVEDOR_M", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Documentos_Detalle_devoluciones(ByVal Tipo As String, ByVal Numero As String, ByVal Almacen As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_DEVOLUCION_DETALLE", Tipo, Numero, Almacen).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Documentos_Referencia_NotaC(ByVal Tipo As String, ByVal Serie As String, ByVal Numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_DOCUMENTOS_REFERENCIA_NC", Tipo, Serie, Numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Muestra_cabecera_pedido(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_EDICION_CABECERA", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Muestra_detalles_pedido(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_DETALLE_PEDIDO", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function




        Public Function Modo_Edicion_Cabecera_Configuracion(ByVal Tipo As String, ByVal Serie As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_CONFIG_DOCUMENTOS_EDICION", Tipo, Serie).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Muestra_consulta(ByVal _Cadena As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Cadena).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Ejecuta_consulta(ByVal _Cadena As String) As Boolean
            Dim Resultado As Integer = 0
            Try
                Resultado = SqlHelper.ExecuteNonQuery(cn, CommandType.Text, _Cadena)
                If Resultado = 1 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Verificacion_Serie_Documento(ByVal Tipo As String, ByVal Serie As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_CONFIG_VERIF_SERIE", Tipo, Serie).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Mostrar_Configuracion_Documentos() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ADM_SP_CONFIG_DOCUMENTOS_PRINCIPAL").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function CorrelativosFaltantes(ByVal _FechaInicial As String, ByVal _FechaFinal As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LISTAR_NUMEROS_NO_INGRESADOS", _FechaInicial, _FechaFinal).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function VerificarDespachoRelacionDoc(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_CUSTOMER_BALANCE_DESP_VERF", _TipoDoc, _serie, _NumeroDoc).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function RelacionDocumentosmensual(ByVal Anno As String, ByVal mes As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RELACION_DOC_MES", Anno, mes).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function RelacionDocumentosTotales() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RELACION_DOC_TOTALES").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function RelacionDocumentosmensualGuias(ByVal Anno As String, ByVal mes As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RELACION_DOC_MES_GUIAS", Anno, mes).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function RelacionDocumentosmensualGuiasTotales() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RELACION_DOC_TOTALES_GUIAS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function RelacionDocumentosReferencia(ByVal Tipodoc As String, ByVal Serie As String, ByVal Numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_DATOS_DOC_REF", Tipodoc, Serie, Numero).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Montos_Documentos_Referencia(ByVal Tipodoc As String, ByVal Serie As String, ByVal Numero As String, ByVal Customer As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_DOC_REF_MONTOS", Tipodoc, Serie, Numero, Customer).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Verificacion_Existencia_Doc_Ref(ByVal Tipodoc As String, ByVal Serie As String, ByVal Numero As String, ByVal Customer As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_VERIFICACION_NOTA_CREDITO", Tipodoc, Serie, Numero, Customer).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function ValidarFechaVentas(ByVal Mes As String, ByVal año As String, ByVal opcion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_VALIDAR_FECHA_VENTA", Mes, año, opcion).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub GuardarCierre_Ventas(ByVal _MES As String, ByVal _ANIO As String, ByVal _APP As String, ByVal _USER As String, ByVal _PC As String, ByVal _OPCION As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "CLI_SP_S_GUARDAR_CIERRE_VENTAS", _MES, _ANIO, _APP, _USER, _PC, _OPCION)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub


        Public Sub Insert(ent_cab As ClsEntidades.RECEIVABLE, lista As List(Of ClsEntidades.RECEIVABLE_LINE), ent_saldo As ClsEntidades.CUSTOMER_BALANCE, entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), ent_numeracion As ClsEntidades.NUMBER_DOCUMENT)
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_RECEIVABLE", .DOCUMENT_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .DOCUMENT_DATE, .CADUCATE_DATE, .DR_CR, .SALES_REP_ID, .PLACE_SALES, .NUMBER_QUOTE, .NUMBER_ORDER_PUR, .CFDESCPG, .POINT_ORIG, .POINT_BOARD, .POINT_ARRIVAL, .RECEIVABLE_TYPE, .CUSTOMER_ID, .CUSTOMER_NAME, .CUSTOMER_ADDR, .VAT_REGISTRATION, .WAREHOUSE_ID, .AMOUNT, .TERMS_ID, .BALANCE, .SELL_RATE, .CURRENCY_ID, .DOCUMENT_REF, .SERIE_REF, .NUMBER_REF, .NUMBER_ORDER, .CREATE_DATE, .LAST_MODIFIED, .STATUS, .USER_ID, .COMMENT, .IS_GUIA_REC, .NUMBER_REGISTRATION, .DISCOUNT_PERCENT, .DISCOUNT_PERCENT_SP, .CARD_ID, .NUMBER_CARD, .AMOUNT_CARD_US, .AMOUNT_CARD, .BANK_CHECK, .NUMBER_CHECK, .AMOUNT_CH_US, .AMOUNT_CH, .VOUCHER_ID, .NUMBER_TRA, .AMOUNT_TAX, .DISCOUNTV, .DISCOUNTP, .LIST_GUIA, .IS_PRINT, .DISCOUNT_RECIVABLE, .IS_CLOSED, .SUB_ID, .TOTAL_ERROR, .PROMISE_DAYS, .SHIPPER_TYPE, .ZONE_FREIGTH, .AMOUNT_FREIGTH, .IS_GUIA, .IS_CASH_BANK, .TAX_TYPE, .REC_AUTO, .TRAMA_ID, .VEHICULO_ID, .EMPTRA_ID, .ISC)
                End With

                'cartera de cleintes - saldos
                With ent_saldo
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_CUSTOMER_BALANCE", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOC_DATE, .CADUCATE_DATE, .DOCUMENT_REF, .NUMBER_REF, .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, .USER_ID, .ACCOUNT, .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, .BANK_DESCRIPTION, .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .CUST_AUTO, .SERIE_AUX, .NUM_DOC_AUX)
                End With

                'detalle de doc
                For Each d As ClsEntidades.RECEIVABLE_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_RECEIVABLE_LINE", .DOCUMENT_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, .PRICE_SALES, .PRICE_ORI, .DISCOUNT, .AMOUNT_TAX, .TAX_PERCENT, .AMOUNT_US, .AMOUNT, .UNIT, .STATUS, .PART_SERIE, .WAREHOUSE_ID, .TEXT_DESCRIPTION, .DFTR, .STOCK, .PART_DESCRIPTION, .QTY_REF, .DISCOUNT_PERCENT, .BALANCE_PART, .DISCOUNT_CUSTOMER, .DISCOUNT_SP, .PART_LOT, .NUMBER_GUIA, .PART_TAX, .DISCOUNT1, .DISCOUNT2, .PERCENT1, .PERCENT2, .PRICE_LIST_ID, .SHIPPER_QTY, .BUDGET_ID, .ORDER_ID, .BRUTE_QTY, .DISCOUNT_QTY_BRUTE, .UM_REFERENCE, .QTY_REFERENCE, .COMISION, .TIPOISC, .ISCPOR, .ISC)
                    End With
                Next

                'cabecera de almacen
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT)
                End With

                'detalle de almacen
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT)
                    End With
                Next

                'actulizamos la numeracion
                With ent_numeracion
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_U_NUMBER_DOCUMENT", .TYPE_DOC, .NUMBER_SERIE, .LAST_NUMBER)
                End With

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
            End Try

        End Sub

        ''FACTURACION 


        Public Function Guardar_Lista_Detalle_Referencias(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String, ByVal DT_DETALLE_DOC_REF As DataTable) As Boolean
            Try
                Dim LibData As New LibConexion.ClsData
                For Each item As DataRow In DT_DETALLE_DOC_REF.Rows
                    LibData.Run_Store_Procedure("FACT_SP_I_DETALLE_DOC_REF", _
                                LibData.DatosParam("@DOCUMENT_ID  ", SqlDbType.VarChar, 2, _DOCUMENT_ID), _
                                LibData.DatosParam("@NUMBER_SERIE", SqlDbType.VarChar, 3, _NUMBER_SERIE), _
                                LibData.DatosParam("@NUMBER_DOCUMENT", SqlDbType.VarChar, 7, Strings.Right(_NUMBER_DOCUMENT, 7)), _
                                LibData.DatosParam("@TIPO_DOC  ", SqlDbType.VarChar, 2, item("TIPO_DOC")), _
                                LibData.DatosParam("@SERIE_DOC", SqlDbType.VarChar, 3, item("SERIE_DOC")), _
                                LibData.DatosParam("@NUMBER_DOC", SqlDbType.VarChar, 7, item("NUM_DOC")), _
                                 LibData.DatosParam("@FECHA_DOC  ", SqlDbType.VarChar, 20, IIf(String.IsNullOrEmpty(item("FECHA_DOC")), DBNull.Value, item("FECHA_DOC"))), _
                                LibData.DatosParam("@MONTO", SqlDbType.Float, 0, item("MONTO")), _
                                LibData.DatosParam("@IGV", SqlDbType.Float, 0, item("IGV")))
                Next
                LibData.Dispose()
                'For Each item As DataRow In DT_DETALLE_DOC_REF.Rows
                '    SqlHelper.ExecuteNonQuery(cn, "FACT_SP_S_RECEIVABLE_PRINCIPAL", _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT, item("TIPO_DOC"), item("SERIE_DOC"), item("NUM_DOC"), IIf(String.IsNullOrEmpty(item("FECHA_DOC")), DBNull.Value, item("FECHA_DOC")), item("MONTO"), item("IGV"))
                'Next
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function get_DatosGeneralesFacturacion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                                      ByVal _TIPODOCUMENTO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _TIPODOCUMENTO).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_CabecearaFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE", _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        

        Public Function get_PuntoVenta_Default() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_SALES_PLACE_DEFAULT").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Function get_Cliente_Default() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_CUSTOMER_DEFAULT").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function get_DetalleFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_LINE", _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_VerificacionComprobanteP(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
            Try
                Dim LibData As New LibConexion.ClsData
                Dim dtTable As New DataTable
                dtTable = LibData.Run_SP_DataTable("FACT_SP_S_R_VERIF_COMPROBANTE_P", _
                            LibData.DatosParam("@DOCUMENT_ID", SqlDbType.VarChar, 2, _DOCUMENT_ID), _
                            LibData.DatosParam("@NUMBER_SERIE", SqlDbType.VarChar, 3, _NUMBER_SERIE), _
                            LibData.DatosParam("@NUMBER_DOCUMENT", SqlDbType.VarChar, 7, _NUMBER_DOCUMENT))
                LibData.Dispose()
                Return dtTable
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function GuardarComprobantePercepcion(ByVal DOCUMENT_ID As String, ByVal NUMBER_SERIE As String, NUMBER_DOCUMENT As String, _
                                                ByVal NUMERO_CP As String, ByVal TIPO_NUMERACION As String, ByVal MONTO As Double, _
                                                ByVal PorcentPercepcion As Double) As Boolean
            Dim estado As Boolean = True
            Try
                SqlHelper.ExecuteNonQuery(cn, "FACT_SP_S_R_COMPROBANTE_P", DOCUMENT_ID, NUMBER_SERIE, NUMBER_DOCUMENT, NUMERO_CP, TIPO_NUMERACION, MONTO, PorcentPercepcion)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", "CP", Val(Strings.Right(NUMERO_CP, 7)))
            Catch ex As Exception
                estado = False
            End Try
            Return estado
        End Function


        Public Function GuardarGuiaSalida_Facturacion(ByVal GuiaCab As ClsEntidades.WAREHOUSE_TRANS, ByVal listaGuiaD As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), _
                                        ByVal TipoNumeracionGuia As String) As Boolean
            Dim estado As Boolean = True
            Dim trs As SqlTransaction
            trs = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'cabecera de almacen Guia  
                With GuiaCab
                    SqlHelper.ExecuteNonQuery(trs, "FACT_SP_I_R_WAREHOUSE_TRANS_FACT_II", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, _
                    .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .TYPE_GUIA, .CARRIER_ID, _
                    .CARRIER_NAME, .CARRIER_ADDR, .AMOUNT, .COMMENT, .WAREHOUSE_REF, .NUMBER_PURCHASE, .INTERFACEE, .NUMBER_ORDER, .TRAMA_ID, .VEHICULO_ID, .EMPTRA_ID, .ADDR_DLV)
                End With

                'detalle de almacen
                For Each GuiaDet As ClsEntidades.WAREHOUSE_TRANS_LINE In listaGuiaD
                    With GuiaDet
                        SqlHelper.ExecuteNonQuery(trs, "FACT_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, _
                                                  .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .AVERAGE_COST, .AMOUNT_TAX, .AMOUNT_US, .AMOUNT, .STATUS, _
                                                  .TRANS_ID, .CURRENCY_ID, .TYPE_EXCHANGE, .PRICE_SALES, .TAX_PERCENT, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT)
                    End With
                Next
                SqlHelper.ExecuteNonQuery(trs, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", GuiaCab.DOCUMENT_ID, Val(Strings.Right(GuiaCab.NUMBER_DOCUMENT, 7)), Strings.Left(GuiaCab.NUMBER_DOCUMENT, 3))
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(trs, "ACT_QTY_LOTE_2010_AL", GuiaCab.WAREHOUSE_ID)
                trs.Commit()
                trs.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
                trs.Rollback()
                estado = False
            End Try
            Return estado
        End Function

        Public Function GuardarGuiaSalida(ByVal GuiaCab As ClsEntidades.WAREHOUSE_TRANS, ByVal listaGuiaD As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), _
                                           ByVal TipoNumeracionGuia As String) As Boolean
            Dim estado As Boolean = True
            Dim trs As SqlTransaction
            trs = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'cabecera de almacen Guia
                With GuiaCab
                    SqlHelper.ExecuteNonQuery(trs, "FACT_SP_I_R_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, _
                    .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .TYPE_GUIA, .CARRIER_ID, _
                    .CARRIER_NAME, .CARRIER_ADDR, .AMOUNT, .COMMENT, .WAREHOUSE_REF, .NUMBER_PURCHASE, .INTERFACEE)
                End With

                'detalle de almacen
                For Each GuiaDet As ClsEntidades.WAREHOUSE_TRANS_LINE In listaGuiaD
                    With GuiaDet
                        SqlHelper.ExecuteNonQuery(trs, "FACT_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, _
                                                  .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .AVERAGE_COST, .AMOUNT_TAX, .AMOUNT_US, .AMOUNT, .STATUS, _
                                                  .TRANS_ID, .CURRENCY_ID, .TYPE_EXCHANGE, .PRICE_SALES, .TAX_PERCENT, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT)
                    End With
                Next
                SqlHelper.ExecuteNonQuery(trs, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", GuiaCab.DOCUMENT_ID, Val(Strings.Right(GuiaCab.NUMBER_DOCUMENT, 7)))
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(trs, "ACT_QTY_LOTE_2010_AL", GuiaCab.WAREHOUSE_ID)
                trs.Commit()
                trs.Dispose()
            Catch ex As Exception
                trs.Rollback()
                estado = False
            End Try
            Return estado
        End Function

        Public Function Get_estadocuentacliente(ByVal _opcion As String) As DataTable
            Try
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_REP_CLIEN_PEND_DOC", _opcion)
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_ESTADO_CUENTA").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GuardarFactura(ent_cab As ClsEntidades.RECEIVABLE, lista As List(Of ClsEntidades.RECEIVABLE_LINE), ent_saldo As ClsEntidades.CUSTOMER_BALANCE, _
                                  entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE), _
                                  ByVal TipoNumeracionDocum As String, ByVal TipoDocumento As String, _
                                  Optional ByVal FacturaGuiaVenta As Boolean = False, Optional ByVal NumerosGuias As String = "", _
                                  Optional ByVal FacturaSinDescargo As Boolean = False, _
                                  Optional ByVal FacturarPedido As Boolean = False, _
                                  Optional ByVal Modo_Editar As Boolean = False,
                                  Optional ByVal Ref_DOCUMENT_ID As String = "", _
                                  Optional ByVal Ref_NUMBER_SERIE As String = "", _
                                  Optional ByVal Ref_NUMBER_DOCUMENT As String = "", _
                                  Optional ByVal Ref_ALMACEN As String = "", _
                                  Optional ByVal FLAG_DEV As Boolean = False, _
                                  Optional ByVal TIPO_DEV As String = "", _
                                  Optional ByVal NUM_DEV As String = "") As Boolean
            If Modo_Editar = True Then
                '+++Borrando los datos de la Facturacion
                SqlHelper.ExecuteNonQuery(cn, "FACT_SP_D_RECEIVABLE_ELIMINACION", LibComunVar.ClsVarComun.USUARIO, Ref_DOCUMENT_ID, Ref_NUMBER_SERIE, Ref_NUMBER_DOCUMENT)
                '++++++
            End If
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab

                    SqlHelper.ExecuteNonQuery(tr, "FACT_SP_I_RECEIVABLE", .DOCUMENT_ID, .NUMBER_SERIE, Right(.NUMBER_DOCUMENT, 7), .DOCUMENT_DATE, .CADUCATE_DATE, .DR_CR, _
                                              .SALES_REP_ID, .PLACE_SALES, .NUMBER_QUOTE, .NUMBER_ORDER_PUR, .CFDESCPG, .POINT_ORIG, .POINT_BOARD, _
                                              .POINT_ARRIVAL, .RECEIVABLE_TYPE, .CUSTOMER_ID, .CUSTOMER_NAME, .CUSTOMER_ADDR, .VAT_REGISTRATION, .WAREHOUSE_ID, _
                                              .AMOUNT, .TERMS_ID, .BALANCE, .SELL_RATE, .CURRENCY_ID, .DOCUMENT_REF, .SERIE_REF, .NUMBER_REF, .NUMBER_ORDER, _
                                              .CREATE_DATE, .STATUS, .USER_ID, .COMMENT, .IS_GUIA_REC, .NUMBER_REGISTRATION, .DISCOUNT_PERCENT, _
                                              .DISCOUNT_PERCENT_SP, .CARD_ID, .NUMBER_CARD, .AMOUNT_CARD_US, .AMOUNT_CARD, .BANK_CHECK, .NUMBER_CHECK, .AMOUNT_CH_US, _
                                              .AMOUNT_CH, .VOUCHER_ID, .NUMBER_TRA, .AMOUNT_TAX, .DISCOUNTV, .DISCOUNTP, .LIST_GUIA, .IS_PRINT, .DISCOUNT_RECIVABLE, _
                                              .IS_CLOSED, .SUB_ID, .TOTAL_ERROR, .PROMISE_DAYS, .SHIPPER_TYPE, .ZONE_FREIGTH, .AMOUNT_FREIGTH, .IS_GUIA, .IS_CASH_BANK, _
                                              .TAX_TYPE, .REC_AUTO, .TRAMA_ID, .VEHICULO_ID, .EMPTRA_ID, .ISC, .DOCUMENT_TYPE_COMP_PER, .SERIE_COMP_PER, .NUMBER_COMP_PER, _
                                              .ESTADO_DESPACHO, .PERCENT_DETRAC, .AMOUNT_DETRAC, .MOV_OPTION_ID)
                End With

                'cartera de clientes - saldos
                With ent_saldo
                    SqlHelper.ExecuteNonQuery(tr, "FACT_SP_I_CUSTOMER_BALANCE", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOC_DATE, .CADUCATE_DATE, .DOCUMENT_REF, .NUMBER_REF, _
                                              .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, .USER_ID, .ACCOUNT, _
                                              .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, .BANK_DESCRIPTION, _
                                              .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .CUST_AUTO, .SERIE_AUX, .NUM_DOC_AUX, .PERCENT_DETRAC, .AMOUNT_DETRAC)
                End With

                'detalle de doc

                '++++DEVOLUCIONES
                If FLAG_DEV = True Then
                    If TIPO_DEV <> "" And NUM_DEV <> "" Then
                        Dim SQL As String = ""
                        SQL = "UPDATE DEVOLUTION SET ESTADO='NOTA DE CREDITO', OPCION_ESTADO='4'  WHERE DOCUMENT_ID = '" & TIPO_DEV & "'  AND NUMBER_DOCUMENT ='" & NUM_DEV & "'"
                        SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                    End If
                End If
                For Each d As ClsEntidades.RECEIVABLE_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "FACT_SP_I_RECEIVABLE_LINE", .DOCUMENT_ID, .NUMBER_SERIE, Right(.NUMBER_DOCUMENT, 7), .ITEM, .PART_ID, .QTY, .PRICE_SALES, .PRICE_ORI, .DISCOUNT, _
                                                  .AMOUNT_TAX, .TAX_PERCENT, .AMOUNT_US, .AMOUNT, .UNIT, .STATUS, .PART_SERIE, .WAREHOUSE_ID, .TEXT_DESCRIPTION, .DFTR, .STOCK, .PART_DESCRIPTION, .QTY_REF, .DISCOUNT_PERCENT, .BALANCE_PART, .DISCOUNT_CUSTOMER, .DISCOUNT_SP, .PART_LOT, .NUMBER_GUIA, .PART_TAX, .DISCOUNT1, .DISCOUNT2, .PERCENT1, .PERCENT2, .PRICE_LIST_ID, .SHIPPER_QTY, .BUDGET_ID, .ORDER_ID, .BRUTE_QTY, .DISCOUNT_QTY_BRUTE, .UM_REFERENCE, .QTY_REFERENCE, .COMISION, .TIPOISC, .ISCPOR, .ISC)
                        '++++DEVOLUCIONES DETALLES
                        If FLAG_DEV = True Then
                            If TIPO_DEV <> "" And NUM_DEV <> "" Then
                                Dim SQL As String = ""
                                SQL = "UPDATE DEVOLUTION_LINE SET  GENERO_NC_GUIA='SI'  WHERE DOCUMENT_ID = '" & TIPO_DEV & "'  AND NUMBER_DOCUMENT ='" & NUM_DEV & "' AND  ITEM='" & d.ITEM_INI & "'"
                                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                            End If
                        End If
                    End With
                Next
                If FacturaSinDescargo = False Then
                    If FacturaGuiaVenta = False Then
                        'Almacen FT
                        'cabecera de almacen
                        With entidad
                            SqlHelper.ExecuteNonQuery(tr, "FACT_SP_I_R_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, _
                            .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .TYPE_GUIA, .CARRIER_ID, _
                            .CARRIER_NAME, .CARRIER_ADDR, .AMOUNT, .COMMENT, .WAREHOUSE_REF, .NUMBER_PURCHASE, .INTERFACEE)
                        End With

                        'detalle de almacen
                        For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                            With d
                                SqlHelper.ExecuteNonQuery(tr, "FACT_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, _
                                                          .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .AVERAGE_COST, .AMOUNT_TAX, .AMOUNT_US, .AMOUNT, .STATUS, _
                                                          .TRANS_ID, .CURRENCY_ID, .TYPE_EXCHANGE, .PRICE_SALES, .TAX_PERCENT, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT)
                            End With
                        Next
                    End If
                    ''Actualizando las Guias  de Remision
                    If FacturaGuiaVenta = True Then
                        SqlHelper.ExecuteNonQuery(tr, "FACT_SP_U_R_DOC_REF", ent_cab.DOCUMENT_ID, ent_cab.NUMBER_SERIE & ent_cab.NUMBER_DOCUMENT, ent_cab.DOCUMENT_DATE, _
                                                  String.Format("{0:HH:mm:ss}", DateTime.Now), ent_cab.USER_ID, NumerosGuias)
                    End If
                    'Actualizando Almacen
                    SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
                End If
                'actualizamos la numeracion
                SqlHelper.ExecuteNonQuery(tr, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", ent_cab.DOCUMENT_ID, Val(Strings.Right(ent_cab.NUMBER_DOCUMENT, 7)), ent_cab.NUMBER_SERIE)
                'Actualizando el estado de pedido
                If FacturarPedido = True Then
                    If ent_cab.NUMBER_ORDER <> String.Empty Then
                        SqlHelper.ExecuteNonQuery(tr, CommandType.Text, "UPDATE ORDERS SET STATUS='F' WHERE ID ='" & ent_cab.NUMBER_ORDER & "'")
                    End If
                End If
                ''
                If FLAG_DEV = True Then
                    If TIPO_DEV <> "" And NUM_DEV <> "" Then
                        SqlHelper.ExecuteNonQuery(tr, "FACT_SP_U_DEVOLUTION", TIPO_DEV, NUM_DEV)
                    End If
                End If
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        ''''''NOTA DE CREDITO
        Public Function get_DetalleFacturacionNotaCredito(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_LINE_NC", _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DetalleFacturacionGuiasRemision(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_DOCUMENT As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_LINE_GUIA", _DOCUMENT_ID, _NUMBER_DOCUMENT).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function EliminacionFacturacion(ByVal _USER As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                         ByVal _NUMBER_DOCUMENT As String, ByVal _ALMACEN As String) As Boolean
            Dim ESTADO As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "FACT_SP_D_RECEIVABLE_ELIMINACION", _USER, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
                SqlHelper.ExecuteNonQuery(tr, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", _DOCUMENT_ID, Val(_NUMBER_DOCUMENT), _NUMBER_SERIE)
                tr.Commit()
                tr.Dispose()
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", _ALMACEN)
            Catch ex As Exception
                tr.Rollback()
                ESTADO = False
                Throw
            End Try
            Return ESTADO
        End Function

        Public Function EliminacionFacturacionComprobanteP(ByVal _USER As String, ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                      ByVal _NUMBER_DOCUMENT As String) As Boolean
            Dim ESTADO As Boolean = True
            Try
                SqlHelper.ExecuteNonQuery(cn, "FACT_SP_D_RECEIVABLE_ELIMINACION_CP", _USER, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", _DOCUMENT_ID, Val(_NUMBER_DOCUMENT), _NUMBER_SERIE)
            Catch ex As Exception
                ESTADO = False
                Throw
            End Try
            Return ESTADO
        End Function

        Public Function AnulacionFacturacion(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                             ByVal _NUMBER_DOCUMENT As String, ByVal _ALMACEN As String) As Boolean
            Dim ESTADO As Boolean = True
            Try
                SqlHelper.ExecuteNonQuery(cn, "FACT_SP_S_RECEIVABLE_ANULACION", _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", _DOCUMENT_ID, Val(_NUMBER_DOCUMENT), _NUMBER_SERIE)
                'Actualizando Almacen
                If _ALMACEN <> String.Empty Then
                    SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", _ALMACEN)
                End If

            Catch ex As Exception
                ESTADO = False
                Throw
            End Try
            Return ESTADO
        End Function

        Public Function AnulacionFacturacionComprobanteP(ByVal _DOCUMENT_ID As String, ByVal _NUMBER_SERIE As String, _
                                            ByVal _NUMBER_DOCUMENT As String) As Boolean
            Dim ESTADO As Boolean = True
            Try
                SqlHelper.ExecuteNonQuery(cn, "FACT_SP_S_RECEIVABLE_ANULACION_CP", _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT)
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS", _DOCUMENT_ID, Val(_NUMBER_DOCUMENT), _NUMBER_SERIE)
            Catch ex As Exception
                ESTADO = False
                Throw
            End Try
            Return ESTADO
        End Function

        '---Verificacion Documetos a  Anular
        Public Function Get_VerificacionDocumentos(ByVal NombreStore As String, ByVal tipodoc_ As String, ByVal serie_ As String, ByVal num_ As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, NombreStore, tipodoc_, serie_, num_).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Get_ManualPuntoVenta(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_PUNTO_VENTA_M", Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_Validacion_CP_Det(ByVal tipo_doc As String, ByVal serie_doc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_NUMBER_DOCUMENT", tipo_doc, serie_doc).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_Validacion_Cobro(ByVal tipo_doc As String, ByVal serie_doc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_REF_COBRO", tipo_doc, serie_doc).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_Validacion_Pago(ByVal tipo_doc As String, ByVal serie_doc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_REF_PAGO", tipo_doc, serie_doc).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_CLIENTE_M", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ManualVendedor(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_VENDEDOR", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ManualFormaPago(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "SAL_HLP_FIND_FORMA_COBRO", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Get_ManualTransportista(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_TRANSPORTISTA_M", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ClienteDocumento(ByVal _CodigoCliente As String, ByVal _Almacen As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_DOC_CLIENTE", _CodigoCliente, _Almacen).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Documento_pedido() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_DOCUMENTOS_PEDIDOS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ClienteDocumento_Representante_Medico(ByVal _CodigoCliente As String, ByVal _Almacen As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WH_DOC_REP_MEDICO", _CodigoCliente, _Almacen).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ClienteDetallesDocumento(ByVal _NumeroDocumentos As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_DET_DOC_CLIENTE", _NumeroDocumentos).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Get_Cabecera_primera_guia_datos(ByVal _NumeroDocumentos As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_CABECERA_PRIMERA_GUIA", _NumeroDocumentos).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function Get_ClienteDetallesDocumento_Rep_Medico(ByVal Tipodoc As String, ByVal _NumeroDocumentos As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_WAREHOUSE_REP_MEDICO", Tipodoc, _NumeroDocumentos).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Get_ALmacenPuntoVenta(ByVal _NumeroDocumentos As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_DET_DOC_CLIENTE", _NumeroDocumentos).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        '' GENERACION DESPACHO

        Public Function VerificarDespacho(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_CUSTOMER_BALANCE_DESP_VERF", _TipoDoc, _serie, _NumeroDoc).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GenerarDespacho(ByVal _Tipodoc As String, ByVal _NumeroDocumento As String, ByVal _Fecha As String, ByVal _Usuario As String) As Boolean
            Dim estado As Boolean = True
            Try
                SqlHelper.ExecuteNonQuery(cn, "FACT_SP_U_R_GENER_DESPACHO", _Tipodoc, _NumeroDocumento, _Fecha, _Usuario)
            Catch ex As Exception
                estado = False
                Throw
            End Try
            Return estado
        End Function

        Public Function GenerarDespachoVarios(ByVal DTDOCUMENTOS As DataTable, ByVal _Fecha As String, ByVal _Usuario As String) As Boolean
            Dim estado As Boolean = True
            Try
                For Each rows As DataRow In DTDOCUMENTOS.Select("SEL=TRUE")
                    SqlHelper.ExecuteNonQuery(cn, "FACT_SP_U_R_GENER_DESPACHO", rows("DOCUMENT_ID").ToString, rows("NUMBER_SERIE").ToString & rows("NUMBER_DOCUMENT").ToString, _Fecha, _Usuario)
                Next
            Catch ex As Exception
                estado = False
                Throw
            End Try
            Return estado
        End Function

        Public Function get_Ult_num_voucher(subd_ As String, ayo_ As Integer, mes_ As Integer) As String
            Dim Correlativo As String = String.Empty
            Try
                Correlativo = SqlHelper.ExecuteScalar(cn, "CO_SP_S_CORRELATIVO", subd_, ayo_, mes_)
                Correlativo = mes_ & Correlativo
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Correlativo
        End Function

        Public Function Contabilizar(ByVal _TipoDoc As String, ByVal _serie As String, ByVal _NumeroDoc As String) As Boolean
            Try
                Dim dt_cab As DataTable
                dt_cab = New DataTable
                Dim AsientoCabeceraEnt As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
                Dim AsientoDetalleEnt As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                Dim ls_det As List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)
                Dim cta40igv As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_IGV FROM CO_TB_PARAMETROS").ToString()
                Dim cta40isc As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_ISC FROM CO_TB_PARAMETROS").ToString()
                Dim cta40igv_cp As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_IGV_CP FROM CO_TB_PARAMETROS").ToString()

                If cta40igv = "" Then
                    MsgBox("No esta configurado la cuenta del IGV.", MsgBoxStyle.Information)
                    Return False
                    Throw New SyntaxErrorException("No esta configurado la cuenta del IGV")
                ElseIf cta40isc = "" Then
                    MsgBox("No esta configurado la cuenta del ISC.", MsgBoxStyle.Information)
                    Return False
                    Throw New SyntaxErrorException("No esta configurado la cuenta del ISC")
                ElseIf cta40igv_cp = "" Then
                    MsgBox("No esta configurado la cuenta del IGV del C.P.", MsgBoxStyle.Information)
                    Return False
                    Throw New SyntaxErrorException("No esta configurado la cuenta del IGV del C.P.")
                End If
                dt_cab = SqlHelper.ExecuteDataset(cn, "CO_SP_S_COMPROBA_VENTAS_MANUAL", _TipoDoc, _serie, _NumeroDoc).Tables(0)
                If dt_cab.Rows.Count() <> 0 Then
                    For i As Integer = 0 To dt_cab.Rows.Count - 1
                        Dim ruc As String = dt_cab.Rows(i)("CUSTOMER_ID").ToString()
                        Dim td As String = dt_cab.Rows(i)("DOCUMENT_ID").ToString()
                        Dim sd As String = dt_cab.Rows(i)("NUMBER_SERIE").ToString()
                        Dim nd As String = dt_cab.Rows(i)("NUMBER_DOCUMENT").ToString()
                        Dim fd As String = dt_cab.Rows(i)("DOCUMENT_DATE").ToString()
                        Dim vd As String = dt_cab.Rows(i)("CADUCATE_DATE").ToString()
                        Dim cta12_Sol As String = dt_cab.Rows(i)("CTA12_SOLES").ToString()
                        Dim cta12_Dol As String = dt_cab.Rows(i)("CTA12_DOLAR").ToString()
                        Dim mon As Integer = dt_cab.Rows(i)("CURRENCY_ID")

                        Dim _CodigoCliente As String = String.Empty
                        Dim _CuentaCliente As String = String.Empty
                        Dim Dtverificar As New DataTable
                        _CodigoCliente = dt_cab.Rows(i)("CUSTOMER_ID").ToString()
                        If td <> "CP" Then
                            Dtverificar = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C_CONTAB", _CodigoCliente).Tables(0)
                            If Dtverificar.Rows.Count <> 0 Then
                                _CuentaCliente = String.Empty
                                If String.IsNullOrEmpty(Dtverificar.Rows(0).Item("ACCOUNT").ToString) Then
                                    MsgBox("No se configuro la Cuenta Contable para el Cliente." & vbCrLf & " Cliente : " & td, MsgBoxStyle.Critical)
                                    Return False
                                Else
                                    cta12_Sol = Dtverificar.Rows(0).Item("ACCOUNT").ToString
                                End If
                            Else
                                MsgBox("No se configuro ninguna Cuenta Contable para el Cliente." & vbCrLf & " Cliente : " & td, MsgBoxStyle.Critical)
                                Return False
                            End If
                        Else
                            Dtverificar = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C", td).Tables(0)
                            If Dtverificar.Rows.Count <> 0 Then
                                _CuentaCliente = String.Empty

                                If String.IsNullOrEmpty(Dtverificar.Rows(0).Item("ACCOUNT").ToString) Then
                                    MsgBox("No se configuro la Cuenta Contable para el documento a contabilizar." & vbCrLf & " Documento : " & td, MsgBoxStyle.Critical)
                                    Return False
                                Else
                                    cta12_Sol = Dtverificar.Rows(0).Item("ACCOUNT").ToString
                                End If
                            Else
                                MsgBox("No se configuro ninguna Cuenta Contable al Documento." & vbCrLf & " Documento : " & td, MsgBoxStyle.Critical)
                                Return False
                            End If
                        End If

                            Dim igv As Double = dt_cab.Rows(i)("AMOUNT_TAX")
                            Dim total As Double = dt_cab.Rows(i)("AMOUNT")
                            Dim anulado As Boolean = IIf(dt_cab.Rows(i)("STATUS") = "A", True, False)
                            Dim tc As Double = dt_cab.Rows(i)("SELL_RATE")
                            'Dim tc As Double = ClsVarComun.TCVenta
                            Dim monto_isc As Double = dt_cab.Rows(i)("ISC")

                            If td = "CP" Then
                                igv = total * (monto_isc / 100)
                                total = igv
                                monto_isc = 0
                            End If
                            'el proce 'CO_SP_S_EXIS_COMPROBA_VENTAS' funciona para ventas y compras
                            Dim Indicador As Integer = 0
                        Indicador = SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_COMPROBA_VENTAS", td, sd, nd, ruc)
                            If Indicador = 0 Then
                                AsientoCabeceraEnt = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
                                ls_det = New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

                                With AsientoCabeceraEnt
                                    .AC_ID = 0
                                    .AC_IDSUBDIARIO = "02"
                                    .AC_NUM_VOUCHER = get_Ult_num_voucher("02", Date.Now().Year, Date.Now().Month)
                                    .AC_ANHO = Date.Now.Year
                                    .AC_MES = Date.Now.Month
                                    .AC_FEC_VOUCHER = Date.Now
                                    .AC_IDMONEDA = mon
                                .AC_DEBE = IIf(mon = 1, IIf(anulado, 0, total), IIf(anulado, 0, total) * tc)
                                .AC_HABER = IIf(mon = 1, IIf(anulado, 0, total), IIf(anulado, 0, total) * tc)
                                    .AC_ESTADO = IIf(anulado, 0, 1)
                                    .AC_GLOSA_VOU = dt_cab.Rows(i)("CUSTOMER_NAME").ToString
                                    .AC_ES_INTERFACE = 1
                                    .AC_RUC = ruc
                                    .AC_TIPO_DOC = td
                                    .AC_SER_DOC = sd '.PadLeft(5, Char.Parse("0"))
                                    .AC_NUM_DOC = nd '.PadLeft(15, Char.Parse("0"))
                                    .AC_FEC_DOC = fd
                                    .AC_FEC_DOC_VENCE = vd
                                    .AC_POR_IGV = 0
                                .AC_VAL_IGV = IIf(mon = 1, IIf(anulado, 0, igv), IIf(anulado, 0, igv) * tc)
                                .AC_TOTAL_DOC = IIf(mon = 1, IIf(anulado, 0, total), IIf(anulado, 0, total) * tc)
                                .AC_TIPO_CAMBIO = tc
                                    .AC_GLOSA_TRANSACCION = dt_cab.Rows(i)("COMMENT").ToString
                                    .AC_DESTINO = ""
                                    .AC_POR_ISC = 0
                                    .AC_ISC = 0 'dt_cab.Rows(i)("ISC").ToString
                                    .AC_POR_DETRAC = IIf(dt_cab.Rows(i)("PERCENT_DETRAC").ToString = "", 0, dt_cab.Rows(i)("PERCENT_DETRAC").ToString)
                                .AC_FEC_PLE = ""
                                If td = "NC" Then
                                    Dtverificar = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_REF_NC", td, sd, nd).Tables(0)
                                    If Dtverificar.Rows.Count > 0 Then
                                        .AC_TIPO_DOC_REF = Dtverificar.Rows(0)("TIPO_DOC").ToString
                                        .AC_SER_DOC_REF = Dtverificar.Rows(0)("SERIE_DOC").ToString
                                        .AC_NUM_DOC_REF = Dtverificar.Rows(0)("NUMBER_DOC").ToString
                                        .AC_FEC_DOC_REF = Dtverificar.Rows(0)("FECHA_DOC").ToString
                                    Else
                                        Dtverificar.Clear()
                                        Dtverificar = Nothing
                                        Dtverificar = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_REF_RECEIVABLE_NC", td, sd, nd).Tables(0)
                                        If Dtverificar.Rows.Count > 0 Then
                                            .AC_TIPO_DOC_REF = Dtverificar.Rows(0)("TIPO_DOC").ToString
                                            .AC_SER_DOC_REF = Dtverificar.Rows(0)("SERIE_DOC").ToString
                                            .AC_NUM_DOC_REF = Dtverificar.Rows(0)("NUMBER_DOC").ToString
                                            .AC_FEC_DOC_REF = Dtverificar.Rows(0)("FECHA_DOC").ToString
                                        Else
                                            .AC_TIPO_DOC_REF = ""
                                            .AC_SER_DOC_REF = ""
                                            .AC_NUM_DOC_REF = ""
                                            .AC_FEC_DOC_REF = ""
                                        End If
                                    End If
                                Else
                                    .AC_TIPO_DOC_REF = ""
                                    .AC_SER_DOC_REF = ""
                                    .AC_NUM_DOC_REF = ""
                                    .AC_FEC_DOC_REF = ""
                                End If
                                    
                                    .AC_DETRAC = IIf(dt_cab.Rows(i)("AMOUNT_DETRAC").ToString = "", 0, dt_cab.Rows(i)("AMOUNT_DETRAC").ToString)
                                    .AC_DUA = 0
                                End With

                                '//Detalle , cuenta 70, for por cada articulo del detalle y su cuenta 70 de la misma tabla de articulos.

                                Dim monto70 As Double = 0
                                Dim monto70_Ori As Double = 0
                                Dim total70 As Double = 0
                                Dim cant As Double = 0
                                Dim precio As Double = 0
                                Dim dtDetallesAsientoContable As DataTable
                                dtDetallesAsientoContable = New DataTable

                                If td <> "CP" Then
                                    dtDetallesAsientoContable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_DETALLE_COMPRO", td, sd, nd).Tables(0)
                                Else
                                    dtDetallesAsientoContable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_DETALLE_COMPRO_CP", "", "", "").Tables(0)
                                End If
                                If dtDetallesAsientoContable.Rows.Count() <> 0 Then
                                    For Each drrr As DataRow In dtDetallesAsientoContable.Rows
                                        cant = Double.Parse(drrr("valor_venta").ToString())
                                        'precio = Double.Parse(drrr("PRICE_ORI").ToString())
                                        Dim _CodigoPart As String = String.Empty
                                        Dim _CuentaPart As String = String.Empty
                                        Dim DtverificarPart As New DataTable
                                        '_CodigoPart = drrr("PART_ID")
                                        'DtverificarPart = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_ARTICULO_C_C", _CodigoPart).Tables(0)
                                        If dtDetallesAsientoContable.Rows.Count <> 0 Then
                                            If String.IsNullOrEmpty(dtDetallesAsientoContable.Rows(0).Item("ACCOUNT_INTERNAL_ID").ToString) Then
                                                MsgBox("No se configuro la Cuenta Contable de la Linea." & vbCrLf & " Linea de Articulo : " & dtDetallesAsientoContable.Rows(0).Item("NAME").ToString, MsgBoxStyle.Critical)
                                                Return False
                                            Else
                                                _CuentaPart = dtDetallesAsientoContable.Rows(0).Item("ACCOUNT_INTERNAL_ID").ToString
                                            End If
                                        Else
                                            MsgBox("No se configuro ninguna Cuenta Contable de la Linea." & vbCrLf & "Linea de Articulo : " & dtDetallesAsientoContable.Rows(0).Item("NAME").ToString, MsgBoxStyle.Critical)
                                            Return False
                                        End If

                                        monto70 = Math.Round(IIf(mon = 1, cant, cant * tc), 2)
                                        'monto70 = Math.Round(IIf(mon = 1, cant * precio, (cant * precio)), 2)
                                        monto70_Ori = Math.Round(cant, 2)
                                        total70 = total70 + monto70
                                        AsientoDetalleEnt = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                                        AsientoDetalleEnt.AD_IDCAB = 0
                                        AsientoDetalleEnt.AD_SECUENCIA = ls_det.Count + 1
                                        AsientoDetalleEnt.AD_CUENTA = _CuentaPart
                                        AsientoDetalleEnt.AD_TANEXO = 0
                                        AsientoDetalleEnt.AD_IDANEXO = ""
                                        AsientoDetalleEnt.AD_TDOC = td
                                        AsientoDetalleEnt.AD_SDOC = sd
                                        AsientoDetalleEnt.AD_NDOC = nd
                                        AsientoDetalleEnt.AD_FDOC = fd
                                        AsientoDetalleEnt.AD_VDOC = vd
                                        If td = "NC" Then
                                            AsientoDetalleEnt.AD_DEBE = Math.Abs(IIf(anulado, 0, monto70))
                                            AsientoDetalleEnt.AD_HABER = 0
                                        Else
                                            AsientoDetalleEnt.AD_DEBE = 0
                                            AsientoDetalleEnt.AD_HABER = Math.Abs(IIf(anulado, 0, monto70))
                                        End If
                                        AsientoDetalleEnt.AD_TCAM = tc
                                        AsientoDetalleEnt.AD_SEC_ORI_DES = 0
                                        AsientoDetalleEnt.AD_IDCC = ""
                                        AsientoDetalleEnt.AD_ES_DESTINO = 0
                                        AsientoDetalleEnt.AD_IDMEDIOPAGO = ""
                                        AsientoDetalleEnt.AD_MONTO_ORI = IIf(anulado, 0, monto70_Ori)
                                        AsientoDetalleEnt.AD_PORCE_DESTINO = 0
                                        AsientoDetalleEnt.AD_ES_CONCI = 0
                                        AsientoDetalleEnt.AD_ANHO_CONI = 0
                                        AsientoDetalleEnt.AD_MES_CONCI = 0
                                        AsientoDetalleEnt.AD_ES_INAFECTO = 0
                                        AsientoDetalleEnt.AD_IDMONEDA = mon
                                        AsientoDetalleEnt.AD_TDOC_REF = ""
                                        AsientoDetalleEnt.AD_SDOC_REF = ""
                                        AsientoDetalleEnt.AD_NDOC_REF = ""
                                        AsientoDetalleEnt.AD_FDOC_REF = ""
                                        AsientoDetalleEnt.AD_VDOC_REF = ""
                                        AsientoDetalleEnt.AD_GLOSA = AsientoCabeceraEnt.AC_GLOSA_VOU
                                        ls_det.Add(AsientoDetalleEnt)
                                    Next
                                End If

                                Dim diferencia As Double = 0

                                'If Not anulado Then
                                '    If (total70 + igv) <> total Then
                                '        diferencia = Math.Abs((total70 + igv) - total)
                                '        diferencia = Math.Round(diferencia, 2)
                                '    End If

                                '    If diferencia <> 0 Then
                                '        If total > (total70 + igv) Then
                                '            monto70 = monto70 + diferencia
                                '        Else
                                '            monto70 = monto70 - diferencia
                                '        End If
                                '        If td = "NC" Then
                                '            ls_det(ls_det.Count - 1).AD_DEBE = Math.Abs(IIf(anulado, 0, monto70))
                                '            ls_det(ls_det.Count - 1).AD_HABER = 0
                                '        Else
                                '            If td <> "CP" Then
                                '                ls_det(ls_det.Count - 1).AD_DEBE = 0
                                '                ls_det(ls_det.Count - 1).AD_HABER = Math.Abs(IIf(anulado, 0, monto70))
                                '            End If
                                '        End If
                                '    End If
                                'End If
                                '//cuenta del IGV
                                If igv > 0 Then
                                    AsientoDetalleEnt = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                                    With AsientoDetalleEnt
                                        .AD_IDCAB = 0
                                        .AD_SECUENCIA = ls_det.Count + 1
                                        If td <> "CP" Then
                                            .AD_CUENTA = cta40igv
                                        Else
                                            .AD_CUENTA = cta40igv_cp
                                        End If
                                        .AD_TANEXO = 0
                                        .AD_IDANEXO = ""
                                        .AD_TDOC = td
                                        .AD_SDOC = sd
                                        .AD_NDOC = nd
                                        .AD_FDOC = fd
                                        .AD_VDOC = vd
                                        If td = "NC" Then
                                        .AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, IIf(anulado, 0, igv), IIf(anulado, 0, igv) * tc), 2))
                                            '.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, igv, igv), 2))
                                            .AD_HABER = 0
                                        Else
                                            .AD_DEBE = 0
                                        .AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, IIf(anulado, 0, igv), IIf(anulado, 0, igv) * tc), 2))
                                            '.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, igv, igv), 2))
                                        End If
                                        .AD_TCAM = tc
                                        .AD_SEC_ORI_DES = 0
                                        .AD_IDCC = ""
                                        .AD_ES_DESTINO = 0
                                        .AD_IDMEDIOPAGO = ""
                                        .AD_MONTO_ORI = IIf(anulado, 0, igv)
                                        .AD_PORCE_DESTINO = 0
                                        .AD_ES_CONCI = 0
                                        .AD_ANHO_CONI = 0
                                        .AD_MES_CONCI = 0
                                        .AD_ES_INAFECTO = 0
                                        .AD_IDMONEDA = mon
                                        .AD_TDOC_REF = ""
                                        .AD_SDOC_REF = ""
                                        .AD_NDOC_REF = ""
                                        .AD_FDOC_REF = ""
                                        .AD_VDOC_REF = ""
                                        .AD_GLOSA = AsientoCabeceraEnt.AC_GLOSA_VOU
                                    End With
                                    ls_det.Add(AsientoDetalleEnt)
                                End If

                                '//cuenta del ISC 40
                                If monto_isc > 0 Then

                                    AsientoDetalleEnt = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                                    AsientoDetalleEnt.AD_IDCAB = 0
                                    AsientoDetalleEnt.AD_SECUENCIA = ls_det.Count + 1
                                    AsientoDetalleEnt.AD_CUENTA = cta40isc
                                    AsientoDetalleEnt.AD_TANEXO = 0
                                    AsientoDetalleEnt.AD_IDANEXO = ""
                                    AsientoDetalleEnt.AD_TDOC = ""
                                    AsientoDetalleEnt.AD_SDOC = ""
                                    AsientoDetalleEnt.AD_NDOC = ""
                                    AsientoDetalleEnt.AD_FDOC = ""
                                    AsientoDetalleEnt.AD_VDOC = ""
                                    If td = "NC" Then
                                    AsientoDetalleEnt.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, IIf(anulado, 0, monto_isc), IIf(anulado, 0, monto_isc) * tc), 2))
                                        'AsientoDetalleEnt.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, monto_isc, monto_isc), 2))
                                        AsientoDetalleEnt.AD_HABER = 0
                                    Else
                                        AsientoDetalleEnt.AD_DEBE = 0
                                    AsientoDetalleEnt.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, IIf(anulado, 0, monto_isc), IIf(anulado, 0, monto_isc) * tc), 2))
                                        'AsientoDetalleEnt.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, monto_isc, monto_isc), 2))

                                    End If
                                    AsientoDetalleEnt.AD_TCAM = tc
                                    AsientoDetalleEnt.AD_SEC_ORI_DES = 0
                                    AsientoDetalleEnt.AD_IDCC = ""
                                    AsientoDetalleEnt.AD_ES_DESTINO = 0
                                    AsientoDetalleEnt.AD_IDMEDIOPAGO = ""
                                    AsientoDetalleEnt.AD_MONTO_ORI = IIf(anulado, 0, monto_isc)
                                    AsientoDetalleEnt.AD_PORCE_DESTINO = 0
                                    AsientoDetalleEnt.AD_ES_CONCI = 0
                                    AsientoDetalleEnt.AD_ANHO_CONI = 0
                                    AsientoDetalleEnt.AD_MES_CONCI = 0
                                    AsientoDetalleEnt.AD_ES_INAFECTO = 0
                                    AsientoDetalleEnt.AD_IDMONEDA = mon
                                    AsientoDetalleEnt.AD_TDOC_REF = ""
                                    AsientoDetalleEnt.AD_SDOC_REF = ""
                                    AsientoDetalleEnt.AD_NDOC_REF = ""
                                    AsientoDetalleEnt.AD_FDOC_REF = ""
                                    AsientoDetalleEnt.AD_VDOC_REF = ""
                                    AsientoDetalleEnt.AD_GLOSA = AsientoCabeceraEnt.AC_GLOSA_VOU
                                    ls_det.Add(AsientoDetalleEnt)
                                End If
                                ' //cuenta del cliente 12
                                AsientoDetalleEnt = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET

                                AsientoDetalleEnt.AD_IDCAB = 0
                                AsientoDetalleEnt.AD_SECUENCIA = ls_det.Count + 1
                                AsientoDetalleEnt.AD_CUENTA = IIf(mon = 1, cta12_Sol, cta12_Sol)
                                AsientoDetalleEnt.AD_TANEXO = 1
                                AsientoDetalleEnt.AD_IDANEXO = ruc
                                AsientoDetalleEnt.AD_TDOC = td
                                AsientoDetalleEnt.AD_SDOC = sd '.PadLeft(5, Char.Parse("0"))
                                AsientoDetalleEnt.AD_NDOC = nd '.PadLeft(15, Char.Parse("0"))
                                AsientoDetalleEnt.AD_FDOC = fd
                                AsientoDetalleEnt.AD_VDOC = vd
                                If td = "NC" Then
                                    AsientoDetalleEnt.AD_DEBE = 0
                                AsientoDetalleEnt.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, IIf(anulado, 0, total), IIf(anulado, 0, total) * tc), 2))
                                    'AsientoDetalleEnt.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, total, total), 2))
                                Else
                                AsientoDetalleEnt.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, IIf(anulado, 0, total), IIf(anulado, 0, total) * tc), 2))
                                    'AsientoDetalleEnt.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, total, total), 2))
                                    AsientoDetalleEnt.AD_HABER = 0
                                End If
                                AsientoDetalleEnt.AD_TCAM = tc
                                AsientoDetalleEnt.AD_SEC_ORI_DES = 0
                                AsientoDetalleEnt.AD_IDCC = ""
                                AsientoDetalleEnt.AD_ES_DESTINO = 0
                                AsientoDetalleEnt.AD_IDMEDIOPAGO = ""
                                AsientoDetalleEnt.AD_MONTO_ORI = IIf(anulado, 0, total)
                                AsientoDetalleEnt.AD_PORCE_DESTINO = 0
                                AsientoDetalleEnt.AD_ES_CONCI = 0
                                AsientoDetalleEnt.AD_ANHO_CONI = 0
                                AsientoDetalleEnt.AD_MES_CONCI = 0
                                AsientoDetalleEnt.AD_ES_INAFECTO = 0
                                AsientoDetalleEnt.AD_IDMONEDA = mon
                                AsientoDetalleEnt.AD_TDOC_REF = ""
                                AsientoDetalleEnt.AD_SDOC_REF = ""
                                AsientoDetalleEnt.AD_NDOC_REF = ""
                                AsientoDetalleEnt.AD_FDOC_REF = ""
                                AsientoDetalleEnt.AD_VDOC_REF = ""
                                AsientoDetalleEnt.AD_GLOSA = AsientoCabeceraEnt.AC_GLOSA_VOU
                                ls_det.Add(AsientoDetalleEnt)
                                ''Guardando las Cuentas Contables
                                GuardarContabilizar(AsientoCabeceraEnt, ls_det, False)
                            Else
                                MsgBox("El documento ya fue enviado a Contablidad.", MsgBoxStyle.Information)
                                Return False
                                Throw New SyntaxErrorException("El documento ya fue enviado a Contablidad.")
                            End If
                    Next
                Else
                    MsgBox("No hay informacion disponible para procesar, verifique el Documento.", MsgBoxStyle.Information)
                    Return False
                    Throw New SyntaxErrorException("No hay informacion disponible para procesar, verifique el Documento.")
                End If
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Sub GuardarContabilizar(ByRef c As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB, _
                                       ld As List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET), _
                                       edicion_ As Boolean)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                If edicion_ Then
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_D_ASIENTO_CAB", c.AC_ID, c.AC_IDSUBDIARIO, c.AC_ANHO, c.AC_MES)
                End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CONTABLE_CAB", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
             c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
             c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_RUC, c.AC_TIPO_DOC, c.AC_SER_DOC, c.AC_NUM_DOC, c.AC_FEC_DOC, c.AC_FEC_DOC_VENCE, c.AC_POR_IGV,
             c.AC_VAL_IGV, c.AC_TOTAL_DOC, c.AC_TIPO_CAMBIO, c.AC_GLOSA_TRANSACCION, c.AC_DESTINO, c.AC_POR_ISC, c.AC_ISC, c.AC_POR_DETRAC, c.AC_FEC_PLE,
             c.AC_TIPO_DOC_REF, c.AC_SER_DOC_REF, c.AC_NUM_DOC_REF, c.AC_FEC_DOC_REF, c.AC_DETRAC, c.AC_DUA, c.AC_OP_INAFECTA, c.AC_OP_GRAVADA, c.AC_ID_REGCOMPRA)
                c.AC_ID = idcab



                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ld
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next

                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_RECEIVABLE_CONTAB", c.AC_TIPO_DOC, c.AC_SER_DOC, c.AC_NUM_DOC, c.AC_ID, c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER)

                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub



    End Class

    Public Class CURRENCY_TYPE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Monedas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CURRENCY_TYPE").Tables(0)
        End Function


        Public Function get_TiposCambio() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_TIPOC").Tables(0)
        End Function

    End Class

    Public Class TYPE_RECEIVE_PAY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Conceptos_Cobranza(ByVal _Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_BANK_MANUAL", _Codigo).Tables(0)
        End Function



        Public Sub Insert_Pago_proveedores(entidad As ClsEntidades.TYPE_RECEIVE_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_I_TYPE_RECEIVE_PAY", .TYPE, .RECEIVE_ID, .DESCRIPTION, .CURRENCY_ID, .ACCOUNT, .VENDOR_ID, .BANK_ID, .USER_ID, CDate(.DATEE), CDate(.EFFECTIVE_DATE), .IS_CHECK_DIF, .IS_APPL, .TRANS_TYPE, .IS_CREDIT_CARD)
            End With
        End Sub

        Public Sub Update_Pago_proveedores(entidad As ClsEntidades.TYPE_RECEIVE_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_U_TYPE_RECEIVE_PAY", .TYPE, .RECEIVE_ID, .DESCRIPTION, .CURRENCY_ID, .ACCOUNT, .VENDOR_ID, .BANK_ID, .USER_ID, CDate(.DATEE), CDate(.EFFECTIVE_DATE), .IS_CHECK_DIF, .IS_APPL, .TRANS_TYPE, .IS_CREDIT_CARD)
            End With
        End Sub

        Public Sub Delete_Pago_proveedores(entidad As ClsEntidades.TYPE_RECEIVE_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_D_TYPE_RECEIVE_PAY", .RECEIVE_ID)
            End With
        End Sub

        Public Function get_Conceptos_Pago_Proveedor() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_TYPE_RECEIVE_PAY").Tables(0)
        End Function

        Public Function get_Tipos_PagosProveedor() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT RECEIVE_ID AS 'COD',RECEIVE_ID+' - '+DESCRIPTION AS 'DES' FROM TYPE_RECEIVE_PAY").Tables(0)
        End Function


        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT RECEIVE_ID AS 'COD',RECEIVE_ID+' - '+DESCRIPTION AS 'DES' FROM TYPE_RECEIVE").Tables(0)
        End Function

        Public Sub get_Tipo_x_Cod(ByRef entidad As ClsEntidades.TYPE_RECEIVE)
            Dim query As String = "SELECT TYPE,RECEIVE_ID,DESCRIPTION,CURRENCY_ID,ACCOUNT,VENDOR_ID,BANK_ID,USER_ID,DATE,EFFECTIVE_DATE,IS_CHECK_DIF,IS_APPL,TRANS_TYPE,isnull(IS_CREDIT_CARD,0) as 'IS_CREDIT_CARD' FROM TYPE_RECEIVE_PAY WHERE RECEIVE_ID = '" & entidad.RECEIVE_ID & "'"
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cn, CommandType.Text, query)
            If drr.HasRows Then
                drr.Read()
                With entidad
                    .TYPE = drr("TYPE")
                    .RECEIVE_ID = drr("RECEIVE_ID")
                    .DESCRIPTION = drr("DESCRIPTION")
                    .CURRENCY_ID = drr("CURRENCY_ID")
                    .ACCOUNT = drr("ACCOUNT")
                    .VENDOR_ID = IIf(drr("VENDOR_ID"), 1, 0)
                    .BANK_ID = IIf(drr("BANK_ID"), 1, 0)
                    .USER_ID = drr("USER_ID")
                    .DATEE = drr("DATE")
                    .EFFECTIVE_DATE = drr("EFFECTIVE_DATE")
                    .IS_CHECK_DIF = IIf(drr("IS_CHECK_DIF"), 1, 0)
                    .IS_APPL = IIf(drr("IS_APPL"), 1, 0)
                    .TRANS_TYPE = drr("TRANS_TYPE")
                    .IS_CREDIT_CARD = IIf(drr("IS_CREDIT_CARD"), 1, 0)
                End With
            End If

            drr.Close()
            drr = Nothing

        End Sub


    End Class

    Public Class TYPE_RECEIVE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Conceptos_Cobranza(ByVal _Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_BANK_MANUAL", _Codigo).Tables(0)
        End Function


        Public Function Conceptos_Cobranza_Pago(ByVal _Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_BANK_MANUAL_PAY", _Codigo).Tables(0)
        End Function


        Public Sub Insert(entidad As ClsEntidades.TYPE_RECEIVE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_I_TYPE_RECEIVE", .TYPE, .RECEIVE_ID, .DESCRIPTION, .CURRENCY_ID, .ACCOUNT, .VENDOR_ID, .BANK_ID, .USER_ID, CDate(.DATEE), CDate(.EFFECTIVE_DATE), .IS_CHECK_DIF, .IS_APPL, .TRANS_TYPE, .IS_CREDIT_CARD)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.TYPE_RECEIVE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_U_TYPE_RECEIVE", .TYPE, .RECEIVE_ID, .DESCRIPTION, .CURRENCY_ID, .ACCOUNT, .VENDOR_ID, .BANK_ID, .USER_ID, CDate(.DATEE), CDate(.EFFECTIVE_DATE), .IS_CHECK_DIF, .IS_APPL, .TRANS_TYPE, .IS_CREDIT_CARD)
            End With
        End Sub

        Public Sub Update_Status_Letter(entidad As ClsEntidades.STATUS_LETTER)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_U_STATUS_LETTER", .STATUS_ID, .CURRENCY_ID, .ACCOUNT, .IS_GENERA_ASIENTO, .DESCRIPTION)
            End With
        End Sub
        Public Sub Update_Status_Letter_Pay(entidad As ClsEntidades.STATUS_LETTER)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_U_STATUS_LETTER_PAY", .STATUS_ID, .CURRENCY_ID, .ACCOUNT, .IS_GENERA_ASIENTO, .DESCRIPTION)
            End With
        End Sub
        Public Sub Insert_Status_Letter(entidad As ClsEntidades.STATUS_LETTER)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_I_STATUS_LETTER", .STATUS_ID, .CURRENCY_ID, .DESCRIPTION, .ACCOUNT, .EVENTO, .IS_GENERA_ASIENTO)
            End With
        End Sub

        Public Sub Insert_Status_Letter_Pay(entidad As ClsEntidades.STATUS_LETTER)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_I_STATUS_LETTER_PAY", .STATUS_ID, .CURRENCY_ID, .DESCRIPTION, .ACCOUNT, .EVENTO, .IS_GENERA_ASIENTO)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.TYPE_RECEIVE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_D_TYPE_RECEIVE", .RECEIVE_ID)
            End With
        End Sub
        Public Sub Delete_Situacion_Letras(entidad As ClsEntidades.STATUS_LETTER)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_D_STATUS_LETTER", .STATUS_ID, .CURRENCY_ID)
            End With
        End Sub
        Public Sub Delete_Situacion_Letras_Pay(entidad As ClsEntidades.STATUS_LETTER)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_S_D_STATUS_LETTER_PAY", .STATUS_ID, .CURRENCY_ID)
            End With
        End Sub
        Public Function get_Conceptos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_TYPE_RECEIVE").Tables(0)
        End Function

        Public Function get_Situacion_Letras() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_STATUS_LETTER").Tables(0)
        End Function
        Public Function get_Situacion_Letras_Pagos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_STATUS_LETTER_PAY").Tables(0)
        End Function
        Public Function get_Valida_Cod_Situacion_Letter(ByVal _codigo As String, ByVal _moneda As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_STATUS_LETTER_VALIDADOR", _codigo, _moneda).Tables(0)
        End Function
        Public Function get_Valida_Cod_Situacion_Letter_Pay(ByVal _codigo As String, ByVal _moneda As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_STATUS_LETTER_PAY_VALIDADOR", _codigo, _moneda).Tables(0)
        End Function
        Public Function get_Tipos_PagosProveedor() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT RECEIVE_ID AS 'COD',RECEIVE_ID+' - '+DESCRIPTION AS 'DES' FROM TYPE_RECEIVE_PAY").Tables(0)
        End Function


        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT RECEIVE_ID AS 'COD',RECEIVE_ID+' - '+DESCRIPTION AS 'DES' FROM TYPE_RECEIVE").Tables(0)
        End Function

        Public Sub get_Tipo_x_Cod(ByRef entidad As ClsEntidades.TYPE_RECEIVE)
            Dim query As String = "SELECT TYPE,RECEIVE_ID,DESCRIPTION,CURRENCY_ID,ACCOUNT,VENDOR_ID,BANK_ID,USER_ID,DATE,EFFECTIVE_DATE,IS_CHECK_DIF,IS_APPL,TRANS_TYPE,isnull(IS_CREDIT_CARD,0) as 'IS_CREDIT_CARD' FROM TYPE_RECEIVE WHERE RECEIVE_ID = '" & entidad.RECEIVE_ID & "'"
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cn, CommandType.Text, query)
            If drr.HasRows Then
                drr.Read()
                With entidad
                    .TYPE = drr("TYPE")
                    .RECEIVE_ID = drr("RECEIVE_ID")
                    .DESCRIPTION = drr("DESCRIPTION")
                    .CURRENCY_ID = drr("CURRENCY_ID")
                    .ACCOUNT = drr("ACCOUNT")
                    .VENDOR_ID = IIf(drr("VENDOR_ID"), 1, 0)
                    .BANK_ID = IIf(drr("BANK_ID"), 1, 0)
                    .USER_ID = drr("USER_ID")
                    .DATEE = drr("DATE")
                    .EFFECTIVE_DATE = drr("EFFECTIVE_DATE")
                    .IS_CHECK_DIF = IIf(drr("IS_CHECK_DIF"), 1, 0)
                    .IS_APPL = IIf(drr("IS_APPL"), 1, 0)
                    .TRANS_TYPE = drr("TRANS_TYPE")
                    .IS_CREDIT_CARD = IIf(drr("IS_CREDIT_CARD"), 1, 0)
                End With
            End If
            drr.Close()
            drr = Nothing

        End Sub


        Public Sub get_Tipo_x_Cod_Pago(ByRef entidad As ClsEntidades.TYPE_RECEIVE)
            Dim query As String = "SELECT TYPE,RECEIVE_ID,DESCRIPTION,CURRENCY_ID,ACCOUNT,VENDOR_ID,BANK_ID,USER_ID,DATE,EFFECTIVE_DATE,IS_CHECK_DIF,IS_APPL,TRANS_TYPE,isnull(IS_CREDIT_CARD,0) as 'IS_CREDIT_CARD' FROM TYPE_RECEIVE_PAY WHERE RECEIVE_ID = '" & entidad.RECEIVE_ID & "'"
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cn, CommandType.Text, query)
            If drr.HasRows Then
                drr.Read()
                With entidad
                    .TYPE = drr("TYPE")
                    .RECEIVE_ID = drr("RECEIVE_ID")
                    .DESCRIPTION = drr("DESCRIPTION")
                    .CURRENCY_ID = drr("CURRENCY_ID")
                    .ACCOUNT = drr("ACCOUNT")
                    .VENDOR_ID = IIf(drr("VENDOR_ID"), 1, 0)
                    .BANK_ID = IIf(drr("BANK_ID"), 1, 0)
                    .USER_ID = drr("USER_ID")
                    .DATEE = drr("DATE")
                    .EFFECTIVE_DATE = drr("EFFECTIVE_DATE")
                    .IS_CHECK_DIF = IIf(drr("IS_CHECK_DIF"), 1, 0)
                    .IS_APPL = IIf(drr("IS_APPL"), 1, 0)
                    .TRANS_TYPE = drr("TRANS_TYPE")
                    .IS_CREDIT_CARD = IIf(drr("IS_CREDIT_CARD"), 1, 0)
                End With
            End If
            drr.Close()
            drr = Nothing

        End Sub


    End Class

    Public Class SALES_REP
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Sub Insert(entidad As ClsEntidades.SALES_REP)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_SALES_REP", .ID, .NAME, .ADDR, .PHONE, .EMAIL, .VAT_REGISTRATION, _
                                          CDate(.DATE_ADMISSION), .STATUS, .USER, .CREATE_DATE, .COD_CLI)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.SALES_REP)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_SALES_REP", .ID, .NAME, .ADDR, .PHONE, .EMAIL, .VAT_REGISTRATION, _
                                          .DATE_ADMISSION, .STATUS, .USER, .CREATE_DATE, .COD_CLI)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.SALES_REP)
            With entidad
                Dim RES As Integer
                RES = SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_SALES_REP", .ID)
                MsgBox(RES)
            End With
        End Sub

        Public Sub EliminarVendedor(ByVal Codigo As String)
            SqlHelper.ExecuteNonQuery(cn, "VEN_SP_D_SALES_REP", Codigo)
        End Sub

        Public Function getVendedores() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALES_REP").Tables(0)
        End Function

        Public Function getVendedores_ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALES_REP_AYU").Tables(0)
        End Function

        Public Function get_CodigoVendedor(ByVal _password As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "VEN_SP_S_SALES_REP_CODIGO_V", _password).Tables(0)
        End Function
    End Class

    Public Class TERMS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.TERMS)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_TERMS", .ID, .NAME, .NET_DAYS)
            End With
        End Sub

        Public Sub Insert_Concepto_Caja_chica(entidad As ClsEntidades.TRANSACTION_TYPE_CAJA_CHICA)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_I_CONCEPTOS", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Sub Insert_Documento_Caja_chica(entidad As ClsEntidades.DOCUMENT_TYPE_CAJA_CHICA)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_I_DOCUMENTOS", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Function Insert_Personal_Caja_chica(entidad As ClsEntidades.PERSONAL) As Boolean
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_I_PERSONAL", .TYPE_ID, .NAME, .DNI)
                End With
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            
        End Function

        Public Sub Update_Concepto_Caja_Chica(entidad As ClsEntidades.TRANSACTION_TYPE_CAJA_CHICA)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_U_CONCEPTOS", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Sub Update_Documento_Caja_Chica(entidad As ClsEntidades.DOCUMENT_TYPE_CAJA_CHICA)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_U_DOCUMENTOS", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Function Update_Personal_Caja_Chica(entidad As ClsEntidades.PERSONAL) As Boolean
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_U_PERSONAL", .TYPE_ID, .NAME, .DNI)
                End With
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            
        End Function

        Public Sub Update(entidad As ClsEntidades.TERMS)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_TERMS", .ID, .NAME, .NET_DAYS)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.TERMS)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_TERMS", .ID, .NAME, .NET_DAYS)
            End With
        End Sub

        Public Sub Delete_Concepto_CajaChica(entidad As ClsEntidades.TRANSACTION_TYPE_CAJA_CHICA)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_D_CONCEPTOS", .TYPE_ID)
            End With
        End Sub

        Public Sub Delete_Documento_CajaChica(entidad As ClsEntidades.DOCUMENT_TYPE_CAJA_CHICA)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_D_DOCUMENTOS", .TYPE_ID)
            End With
        End Sub


        Public Sub Delete_Personal_CajaChica(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CCAJA_CHICA_SP_D_PERSONAL", .TYPE_ID)
            End With
        End Sub

        Public Function get_terms_x_id(entidad As ClsEntidades.TERMS) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TERMS_XID", entidad.ID).Tables(0)
        End Function

        Public Function get_terms() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TERMS").Tables(0)
        End Function

        Public Function get_Conceptos_Caja_Chica() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_S_CONCEPTOS").Tables(0)
        End Function

        Public Function get_ValidarCodigo_Concepto_CajaChica(ByVal _codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_S_CONCEPTOS_VALIDAR", _codigo).Tables(0)
        End Function

        Public Function get_Codigo_Personal_CajaChica() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_S_PERSONAL_OBTENER_CODIGO").Tables(0)
        End Function

        Public Function get_ValidarCodigo_Documentos_CajaChica(ByVal _codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_S_DOCUMENTOS_VALIDAR", _codigo).Tables(0)
        End Function

        Public Function get_Documentos_Caja_Chica() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_S_DOCUMENTOS").Tables(0)
        End Function

        Public Function get_Personal_Caja_Chica() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCAJA_CHICA_SP_S_PERSONAL").Tables(0)
        End Function

        Public Function get_terms_ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TERMS_AYU").Tables(0)
        End Function

        Public Function GeneracionCodigoFormaPago(ByVal Tipo As String, Optional ByVal codigoFormaP As String = "") As DataTable
            Try
                If Tipo = "A" Then
                    Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PAGO_SP_S_TERMS_CODIGO_A").Tables(0)
                ElseIf Tipo = "M" Then
                    Return SqlHelper.ExecuteDataset(cn, "PAGO_SP_S_TERMS_CODIGO_M", codigoFormaP).Tables(0)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class

    Public Class TERMS_PAY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.TERMS_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_TERMS_PAY", .ID, .NAME, .NET_DAYS)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.TERMS_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_TERMS_PAY", .ID, .NAME, .NET_DAYS)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.TERMS_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_TERMS_PAY", .ID, .NAME, .NET_DAYS)
            End With
        End Sub

        Public Function get_terms_x_id(entidad As ClsEntidades.TERMS_PAY) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TERMS_XID_PAY", entidad.ID).Tables(0)
        End Function

        Public Function get_terms() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TERMS_PAY").Tables(0)
        End Function

        Public Function get_terms_ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TERMS_AYU_PAY").Tables(0)
        End Function

        Public Function GeneracionCodigoFormaPago(ByVal Tipo As String, Optional ByVal codigoFormaP As String = "") As DataTable
            Try
                If Tipo = "A" Then
                    Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PAGO_SP_S_TERMS_CODIGO_A_PAGO").Tables(0)
                ElseIf Tipo = "M" Then
                    Return SqlHelper.ExecuteDataset(cn, "PAGO_SP_S_TERMS_CODIGO_M_PAGO", codigoFormaP).Tables(0)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class


    Public Class LETTER_EXCHANGE_PAY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function MuestraDescripcion(ByVal Consulta As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
        End Function

        Public Function Get_DocumentosAnticipos(ByVal _Codigo As String, ByVal _Codigo_Documento As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_AN_CUSTOMER_BALANCE_PAY", _Codigo, _Codigo_Documento).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Function InsertDetallesLetra(ByRef entidad As ClsEntidades.LETTER_PAY) As Boolean
            Dim estado As Boolean = True
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_LETTER_DATOS_ADICIONALES_PAY", .LETTER_ID, .BANK_ID, .COMMENT, .STATUS_ACT, .STATUS_LAST, .PLACE_SHIP, .GUARANTOR_NAME, .GUARANTOR_PHONE, _
                                              .GUARANTOR_ADDR, .GUARANTOR_NAME2, .GUARANTOR_ADDR2, .GUARANTOR_PHONE2, .LETTER_ORIG, .NUMBER_ACCOUNT, .NUMBER_BANK, .TYPE_DOC, .CREATE_DATE, .UPDATE_DATE)
                End With
            Catch ex As Exception
                estado = False
            End Try
            Return estado
        End Function



        Public Function Insert(ByRef entidad As ClsEntidades.LETTER_EXCHANGE_PAY, ls_det As List(Of ClsEntidades.LETTER_EXCHANGE_LINE_PAY), _
                             ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String,
                             ByVal PorcPercepcion As Double, ByVal Flag_Retencion As Boolean) As Boolean
            Dim estado As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_LETTER_EXCHANGE_PAY", .ID, .DATE_EXCHANGE, .VOUCHER_ID, .CREATE_DATE, .USER_ID, .STATUS, .ACCEPT_DATE, _
                                              .SELL_RATE, .CURRENCY_ID, .CUSTOMER_ID, .COMMENT)
                End With
                If ls_det.Count > 0 Then
                    For Each l As ClsEntidades.LETTER_EXCHANGE_LINE_PAY In ls_det
                        With l
                            SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_LETTER_EXCHANGE_LINE_PAY", .ID, .ITEM, .TYPE_DOC, .NUMBER_DOC, .AMOUNT, .CADUCATE_DATE, .IS_ORIG, .OPCION)
                        End With
                    Next
                End If
                Dim MontoD As Double = 0
                Dim TYPE_DOC As String = ""
                Dim NUMBER_DOC As String = ""
                Dim MonedaDoc As String = String.Empty

                For Each row As DataRow In Tabla.Select("Sel=True")
                    If MonedaLetra = "MN" Then
                        If row("Mon") = "MN" Then
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                            Else
                                MontoD = row("MontoCanjear")
                            End If
                        Else
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                                MontoD = (MontoD - Math.Round(MontoD * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                MontoD = MontoD / LibComunVar.ClsVarComun.TCVenta
                            Else
                                MontoD = (row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                                MontoD = MontoD / LibComunVar.ClsVarComun.TCVenta
                            End If
                        End If
                    Else
                        If row("Mon") = "ME" Then
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                            Else
                                MontoD = row("MontoCanjear")
                            End If
                        Else

                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                                MontoD = (MontoD - Math.Round(MontoD * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                MontoD = MontoD * LibComunVar.ClsVarComun.TCVenta
                            Else
                                MontoD = (row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                                MontoD = MontoD * LibComunVar.ClsVarComun.TCVenta
                            End If
                        End If
                    End If
                    SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_S_LETTER_EX_ACT_SAL_PAY", entidad.CUSTOMER_ID, row("TipoDoc").ToString, row("NumDoc").ToString, row("Monto").ToString - MontoD)
                Next
                'Actualizando correlativo
                SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "LP", entidad.ID)
                'SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "IP", NumMaximo)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                estado = False
            End Try
            Return estado
        End Function

        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_CLIENTE_M_PAY", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosPendientes(ByVal _Codigo As String, ByVal _Opcion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETTER_EX_DOC_PEND_PAY", _Codigo, _Opcion).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_VerificacionNumeracionLetra(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETTER_EX_COD_M_PAY", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosPlanilla(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_PRINCIPAL_PAY", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosLetras(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETRA_PRINCIPAL_PAY", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalesLetter(ByVal _CodigoPlanilla As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = " SELECT * FROM LETTER_PAY WHERE LETTER_ID='" & _CodigoPlanilla & "' AND STATUS_ACT='' AND  STATUS_LAST=''"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalesAval(ByVal _CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "SELECT * FROM GUARANTOR WHERE CUSTOMER_ID='" & _CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Get_AdicionalDatosLetra(ByVal _CodigoPlanilla As String, ByVal CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "Select ID,DATE_EXCHANGE,STATUS,SELL_RATE,CURRENCY_ID,CUSTOMER_ID From LETTER_EXCHANGE_PAY where ID='" & _CodigoPlanilla & "' and CUSTOMER_ID='" & CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalDatosCliente(ByVal _CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "Select * From VENDOR where ID='" & _CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalDatosLetraDetalle(ByVal _CodigoPlanilla As String, ByVal _CodigoLetra As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "Select ID,TYPE_DOC,AMOUNT,CADUCATE_DATE,NUMBER_DOC From LETTER_EXCHANGE_LINE_PAY where ID='" & _CodigoPlanilla & "' and TYPE_DOC='LT' and NUMBER_DOC='" & _CodigoLetra & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function InsercionTablaTemporal(ByVal _Consulta As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "LETRA_SP_S_TABLA_IMPRIM_PAY")
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, _Consulta)
                Return True
            Catch ex As Exception
                Return False
                Throw
            End Try
        End Function

        Public Function DatosAdicionalesDireccion(ByVal _CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "SELECT C.ADDR+' - '+A.NOMBRE +' - '+D.NOMBRE+' - '+B.NOMBRE AS DIRECCION,*" _
                       & "FROM CUSTOMER C  INNER JOIN dbo.UBIGEO A ON C.STATE_ID=A.CODDIS   AND C.DEPARTMENT=A.CODDPTO AND C.PROVINCE=A.CODPROV " _
                       & "INNER JOIN dbo.UBIGEO B ON C.DEPARTMENT=B.CODDPTO  AND B.CODPROV='00' AND B.CODDIS='00' INNER JOIN dbo.UBIGEO D ON C.PROVINCE=D.CODPROV  " _
                       & "AND C.DEPARTMENT=D.CODDPTO AND D.CODDIS='00' WHERE ID='" & _CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function EjecutarReporteLetras() As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "select * From  T_Temporal_Letras_Pagos"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function CambioEstadoLetra(ByVal CodigoPlanilla) As Boolean
            Dim estado As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim Dt_documento_detalle As DataTable
                Dim dtasientoContable As New DataTable
                dtasientoContable = SqlHelper.ExecuteDataset(tr, "CONTA_SP_S_VERIF_CONTA_LP", CodigoPlanilla).Tables(0)
                If dtasientoContable.Rows().Count() <> 0 Then
                    MsgBox("La Planilla N° " & CodigoPlanilla & " se encuentra contabilizada, Eliminar contabilizacion.!", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                End If
                Dim consulta As String = ""
                Dim Dt_documento As New DataTable
                consulta = "SELECT B.TYPE_DOC, B.NUMBER_DOC,A.CUSTOMER_ID  FROM LETTER_EXCHANGE_PAY AS A INNER JOIN LETTER_EXCHANGE_LINE_PAY B ON A.ID=B.ID WHERE B.ID='" & CodigoPlanilla & "' AND IS_ORIG='N'"
                Dt_documento = SqlHelper.ExecuteDataset(tr, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto
                        Dt_documento_detalle = New DataTable
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(tr, "CONTA_SP_S_VALIDAR_PAGO_P", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("DOCUMENT_ID").ToString & "-" & row("NUMBER_DOC").ToString & " se realizo el pago, no se puede eliminar letra.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                End If
                consulta = String.Empty
                consulta = "SELECT B.TYPE_DOC, B.NUMBER_DOC,A.CUSTOMER_ID,B.AMOUNT  FROM LETTER_EXCHANGE_PAY AS A INNER JOIN LETTER_EXCHANGE_LINE_PAY B ON A.ID=B.ID WHERE B.ID='" & CodigoPlanilla & "' AND IS_ORIG='S'"
                Dt_documento = SqlHelper.ExecuteDataset(tr, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Devolviendo el monto de canjeado
                        consulta = String.Empty
                        'consulta = "UPDATE dbo.CUSTOMER_BALANCE_PAY SET AMOUNT_BALANCE=(AMOUNT_BALANCE + '" & CDbl(row("AMOUNT")) & "'), SALDO=(SALDO + '" & CDbl(row("AMOUNT")) & "') " _
                        consulta = "UPDATE dbo.CUSTOMER_BALANCE_PAY SET AMOUNT_BALANCE=(AMOUNT_BALANCE + '" & CDbl(row("AMOUNT")) & "') " _
                        & " WHERE CUSTOMER_ID='" & row("CUSTOMER_ID").ToString & "' AND DOCUMENT_ID='" & row("TYPE_DOC").ToString & "' AND NUMBER_DOC='" & row("NUMBER_DOC").ToString & "'"
                        SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)
                    Next
                End If
                consulta = String.Empty
                consulta = "DELETE FROM dbo.CUSTOMER_BALANCE_PAY WHERE NUMBER_REF='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)

                consulta = String.Empty
                consulta = "DELETE A FROM dbo.LETTER_PAY A INNER JOIN dbo.LETTER_EXCHANGE_LINE_PAY B ON  A.LETTER_ID=B.NUMBER_DOC AND B.IS_ORIG='N' WHERE B.ID='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)

                consulta = String.Empty
                consulta = "UPDATE  LETTER_EXCHANGE_PAY SET STATUS='P', ACCEPT_DATE=GETDATE() WHERE ID='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                estado = False
                MsgBox(ex.Message)
                tr.Rollback()
            End Try
            Return estado
        End Function
        Public Function CambioEstadoLetraCobranza(ByVal CodigoPlanilla) As Boolean
            Dim estado As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim Dt_documento_detalle As DataTable
                Dim dtasientoContable As New DataTable
                dtasientoContable = SqlHelper.ExecuteDataset(tr, "CONTA_SP_S_VERIF_CONTA_L", CodigoPlanilla).Tables(0)
                If dtasientoContable.Rows().Count() <> 0 Then
                    MsgBox("La Planilla N° " & CodigoPlanilla & " se encuentra contabilizada, Eliminar contabilizacion.!", MsgBoxStyle.Critical)
                    estado = False
                    Exit Try
                End If
                Dim consulta As String = ""
                Dim Dt_documento As New DataTable
                consulta = "SELECT B.TYPE_DOC, B.NUMBER_DOC,A.CUSTOMER_ID  FROM LETTER_EXCHANGE AS A INNER JOIN LETTER_EXCHANGE_LINE B ON A.ID=B.ID WHERE B.ID='" & CodigoPlanilla & "' AND IS_ORIG='N'"
                Dt_documento = SqlHelper.ExecuteDataset(tr, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto
                        Dt_documento_detalle = New DataTable
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(tr, "CONTA_SP_S_VALIDAR_COBRO_P", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("DOCUMENT_ID").ToString & "-" & row("NUMBER_DOC").ToString & " se realizo el cobro, no se puede actualizar estado de letra.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                End If
                consulta = String.Empty
                consulta = "SELECT B.TYPE_DOC, B.NUMBER_DOC,A.CUSTOMER_ID,B.AMOUNT  FROM LETTER_EXCHANGE AS A INNER JOIN LETTER_EXCHANGE_LINE B ON A.ID=B.ID WHERE B.ID='" & CodigoPlanilla & "' AND IS_ORIG='S'"
                Dt_documento = SqlHelper.ExecuteDataset(tr, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Devolviendo el monto de canjeado
                        consulta = String.Empty
                        'consulta = "UPDATE dbo.CUSTOMER_BALANCE_PAY SET AMOUNT_BALANCE=(AMOUNT_BALANCE + '" & CDbl(row("AMOUNT")) & "'), SALDO=(SALDO + '" & CDbl(row("AMOUNT")) & "') " _
                        consulta = "UPDATE dbo.CUSTOMER_BALANCE SET AMOUNT_BALANCE=(AMOUNT_BALANCE + '" & CDbl(row("AMOUNT")) & "') " _
                        & " WHERE CUSTOMER_ID='" & row("CUSTOMER_ID").ToString & "' AND DOCUMENT_ID='" & row("TYPE_DOC").ToString & "' AND NUMBER_DOC='" & row("NUMBER_DOC").ToString & "'"
                        SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)
                    Next
                End If
                consulta = String.Empty
                consulta = "DELETE FROM dbo.CUSTOMER_BALANCE WHERE NUMBER_REF='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)

                consulta = String.Empty
                consulta = "DELETE A FROM dbo.LETTER A INNER JOIN dbo.LETTER_EXCHANGE_LINE B ON  A.LETTER_ID=B.NUMBER_DOC AND B.IS_ORIG='N' WHERE B.ID='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)

                consulta = String.Empty
                consulta = "UPDATE  LETTER_EXCHANGE SET STATUS='P', ACCEPT_DATE=GETDATE() WHERE ID='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, consulta)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                estado = False
                MsgBox(ex.Message)
                tr.Rollback()
            End Try
            Return estado
        End Function

        Public Function GeneracionAceptacionLetra(ByVal CodigoPlanilla) As Boolean
            Dim estado As Boolean = True
            Try
                Dim Cadena As String = String.Empty
                Dim dtDetalleCab As DataTable
                Dim dtDetalleDet As DataTable
                Dim dtDetalleDoc As DataTable
                Dim dtActualizar As DataTable
                Dim dtdetalle As DataTable
                Dim DTDETALLESTATUSLETRA As DataTable
                Dim EntidadCliente As ClsEntidades.CUSTOMER_BALANCE
                Dim LetterEnt As ClsEntidades.LETTER
                dtDetalleCab = New DataTable("CabeceraLetra")
                Cadena = "UPDATE  LETTER_EXCHANGE_PAY SET STATUS='A', ACCEPT_DATE=GETDATE() WHERE ID='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, Cadena)
                Cadena = String.Empty
                Cadena = "Select * from LETTER_EXCHANGE_PAY WHERE ID='" & CodigoPlanilla & "'"
                dtDetalleCab = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                If dtDetalleCab.Rows.Count() <> 0 Then
                    Dim MonDoc As String = dtDetalleCab.Rows(0).Item("CURRENCY_ID").ToString
                    'Actualizando los Documentos
                    Cadena = String.Empty
                    Cadena = "Select * from LETTER_EXCHANGE_LINE_PAY WHERE ID='" & CodigoPlanilla & "' AND IS_ORIG='S'"
                    dtDetalleDoc = New DataTable()
                    dtDetalleDoc = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                    If dtDetalleDoc.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtDetalleDoc.Rows.Count() - 1
                            dtActualizar = New DataTable
                            Cadena = String.Empty
                            Cadena = "SELECT * FROM CUSTOMER_BALANCE_PAY WHERE CUSTOMER_ID='" & dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString & "'" _
                                & " AND DOCUMENT_ID='" & dtDetalleDoc.Rows(i).Item("TYPE_DOC").ToString & "' AND NUMBER_DOC='" & dtDetalleDoc.Rows(i).Item("NUMBER_DOC").ToString & "'"
                            dtActualizar = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                            If dtActualizar.Rows.Count() <> 0 Then
                                Dim TipoD As String = dtActualizar.Rows(0).Item("DOCUMENT_ID").ToString
                                Dim Moneda As String = dtActualizar.Rows(0).Item("CURRENCY_ID").ToString
                                Dim MontodoC As Double = dtDetalleDoc.Rows(i).Item("AMOUNT")
                                If TipoD <> "NC" Then
                                    If Moneda = "ME" Then
                                        If MonDoc = "ME" Then
                                            MontodoC = MontodoC
                                        Else
                                            MontodoC = MontodoC / ClsVarComun.TCVenta
                                        End If
                                    ElseIf Moneda = "MN" Then
                                        If MonDoc = "MN" Then
                                            MontodoC = MontodoC
                                        Else
                                            MontodoC = MontodoC * ClsVarComun.TCVenta
                                        End If
                                    End If
                                Else
                                    If Moneda = "ME" Then
                                        If MonDoc = "ME" Then
                                            MontodoC = (Math.Abs(MontodoC)) * -1
                                        Else
                                            MontodoC = (Math.Abs(MontodoC / ClsVarComun.TCVenta)) * -1
                                        End If
                                    ElseIf Moneda = "MN" Then
                                        If MonDoc = "MN" Then
                                            MontodoC = (Math.Abs(MontodoC)) * -1
                                        Else
                                            MontodoC = (Math.Abs(MontodoC * ClsVarComun.TCVenta)) * -1
                                        End If
                                    End If
                                End If
                                Cadena = String.Empty
                                'Cadena = "UPDATE  CUSTOMER_BALANCE_PAY SET AMOUNT_BALANCE=(AMOUNT_BALANCE - " & MontodoC & ") , SALDO=(SALDO - " & MontodoC & ") WHERE CUSTOMER_ID='" & dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString & "'" _
                                Cadena = "UPDATE  CUSTOMER_BALANCE_PAY SET AMOUNT_BALANCE=(AMOUNT_BALANCE - " & MontodoC & ") WHERE CUSTOMER_ID='" & dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString & "'" _
                                & " AND DOCUMENT_ID='" & dtDetalleDoc.Rows(i).Item("TYPE_DOC").ToString & "' AND NUMBER_DOC='" & dtDetalleDoc.Rows(i).Item("NUMBER_DOC").ToString & "'"
                                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, Cadena)
                            End If
                        Next
                    End If
                    Cadena = String.Empty
                    Cadena = "Select * from LETTER_EXCHANGE_LINE_PAY WHERE ID='" & CodigoPlanilla & "' AND IS_ORIG='N'"
                    dtDetalleDet = New DataTable("DetalleLetra")
                    dtDetalleDet = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                    If dtDetalleDet.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtDetalleDet.Rows.Count() - 1
                            dtdetalle = New DataTable
                            EntidadCliente = New ClsEntidades.CUSTOMER_BALANCE
                            With EntidadCliente
                                .CUSTOMER_ID = dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString
                                .DOCUMENT_ID = dtDetalleDet.Rows(i).Item("TYPE_DOC").ToString
                                .NUMBER_DOC = dtDetalleDet.Rows(i).Item("NUMBER_DOC").ToString
                                .DOC_DATE = Date.Now()
                                .CADUCATE_DATE = dtDetalleDet.Rows(i).Item("CADUCATE_DATE").ToString
                                .DOCUMENT_REF = "CJ"
                                .NUMBER_REF = CodigoPlanilla
                                'Cadena = String.Empty
                                'Cadena = "Select * from VENDOR WHERE ID='" & .CUSTOMER_ID & "'"
                                'dtdetalle = New DataTable
                                'dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                                ''If dtdetalle.Rows.Count() <> 0 Then
                                ''    .SALES_ID = IIf(String.IsNullOrEmpty(dtdetalle.Rows(0).Item("SALES_ID")), "", dtdetalle.Rows(0).Item("SALES_ID").ToString)
                                ''Else
                                ''    .SALES_ID = ""
                                ''End If
                                .SALES_ID = "0000"
                                .AMOUNT = IIf(String.IsNullOrEmpty(dtDetalleDet.Rows(i).Item("AMOUNT")), 0, dtDetalleDet.Rows(i).Item("AMOUNT").ToString)
                                .AMOUNT_BALANCE = IIf(String.IsNullOrEmpty(dtDetalleDet.Rows(i).Item("AMOUNT")), 0, dtDetalleDet.Rows(i).Item("AMOUNT").ToString)
                                .CURRENCY_ID = dtDetalleCab.Rows(0).Item("CURRENCY_ID").ToString
                                .SELL_RATE = CDbl(dtDetalleCab.Rows(0).Item("SELL_RATE").ToString)
                                .IS_DR_CR = 0
                                .STATUS = "V"
                                .CREATE_DATE = Date.Now.ToShortDateString
                                .LAST_MODIFIED = Date.Now.ToShortDateString
                                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                                .ACCOUNT = ""
                                .AMOUNT_COMM = 0
                                .TYPE_REC = 0
                                .REFERENCE_DATE = Date.Now.ToShortDateString
                                .IS_CHECK_DIF = 0
                                .AMOUNT_BALANCE_INI = dtDetalleDet.Rows(i).Item("AMOUNT").ToString
                                .TERMS = 0
                                .PLACE_SALES = ""
                                .BANK_ID = 0
                                .BANK_DESCRIPTION = 0
                                .AMOUNT_PER = 0
                                .PERCENT_PER = 0
                                .ACCOUNT_PER = 0
                                .CUST_AUTO = 0
                                .SERIE_AUX = "000"
                                .NUM_DOC_AUX = .NUMBER_DOC
                                .PERCENT_DETRAC = 0
                                .AMOUNT_DETRAC = 0
                                .SALDO = IIf(String.IsNullOrEmpty(dtDetalleDet.Rows(i).Item("AMOUNT")), 0, dtDetalleDet.Rows(i).Item("AMOUNT").ToString)
                            End With
                            With EntidadCliente
                                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_I_CUSTOMER_BALANCE_PAY", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOC_DATE, .CADUCATE_DATE, .DOCUMENT_REF, .NUMBER_REF, _
                                    .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, .USER_ID, .ACCOUNT, _
                                    .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, .BANK_DESCRIPTION, _
                                    .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .CUST_AUTO, .SERIE_AUX, .NUM_DOC_AUX, .PERCENT_DETRAC, .AMOUNT_DETRAC, .SALDO)
                            End With
                            Cadena = String.Empty
                            Cadena = "Select * from LETTER_PAY where LETTER_ID='" & dtDetalleDet.Rows(i).Item("NUMBER_DOC") & "'"
                            dtdetalle = New DataTable
                            dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                            If dtdetalle.Rows.Count() <> 0 Then
                                LetterEnt = New ClsEntidades.LETTER
                                LetterEnt.LETTER_ID = dtDetalleDet.Rows(i).Item("NUMBER_DOC").ToString
                                LetterEnt.BANK_ID = dtdetalle.Rows(0).Item("BANK_ID").ToString
                                LetterEnt.COMMENT = ""
                                LetterEnt.STATUS_ACT = "CR"
                                LetterEnt.STATUS_LAST = "CR"
                                LetterEnt.PLACE_SHIP = ""
                                LetterEnt.GUARANTOR_NAME = dtdetalle.Rows(0).Item("GUARANTOR_NAME").ToString
                                LetterEnt.GUARANTOR_PHONE = dtdetalle.Rows(0).Item("GUARANTOR_PHONE").ToString
                                LetterEnt.GUARANTOR_ADDR = dtdetalle.Rows(0).Item("GUARANTOR_ADDR").ToString
                                LetterEnt.GUARANTOR_NAME2 = ""
                                LetterEnt.GUARANTOR_ADDR2 = ""
                                LetterEnt.GUARANTOR_PHONE2 = ""
                                LetterEnt.LETTER_ORIG = ""
                                LetterEnt.NUMBER_ACCOUNT = ""
                                LetterEnt.NUMBER_BANK = ""
                                LetterEnt.TYPE_DOC = ""
                                LetterEnt.CREATE_DATE = Date.Now() & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now)
                                LetterEnt.UPDATE_DATE = ""
                            Else
                                LetterEnt = New ClsEntidades.LETTER
                                LetterEnt.LETTER_ID = dtDetalleDet.Rows(i).Item("NUMBER_DOC").ToString
                                LetterEnt.BANK_ID = ""
                                LetterEnt.COMMENT = ""

                                Cadena = String.Empty
                                Cadena = "SELECT B.STATUS_ID FROM dbo.CO_TB_ASIENTO_DET A INNER JOIN dbo.STATUS_LETTER_PAY B ON A.AD_CUENTA=B.ACCOUNT AND CASE WHEN A.AD_IDMONEDA=1 THEN 'MN' ELSE 'ME' END=B.CURRENCY_ID WHERE AD_NDOC='" & LetterEnt.LETTER_ID & "' AND AD_TDOC='LT'"
                                DTDETALLESTATUSLETRA = New DataTable
                                DTDETALLESTATUSLETRA = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                                If DTDETALLESTATUSLETRA.Rows.Count > 0 Then
                                    LetterEnt.STATUS_ACT = DTDETALLESTATUSLETRA.Rows(0).Item("STATUS_ID").ToString
                                    LetterEnt.STATUS_LAST = DTDETALLESTATUSLETRA.Rows(0).Item("STATUS_ID").ToString
                                Else
                                    LetterEnt.STATUS_ACT = "CR"
                                    LetterEnt.STATUS_LAST = "CR"
                                End If
                                LetterEnt.PLACE_SHIP = ""
                                LetterEnt.GUARANTOR_NAME = ""
                                LetterEnt.GUARANTOR_PHONE = ""
                                LetterEnt.GUARANTOR_ADDR = ""
                                LetterEnt.GUARANTOR_NAME2 = ""
                                LetterEnt.GUARANTOR_ADDR2 = ""
                                LetterEnt.GUARANTOR_PHONE2 = ""
                                LetterEnt.LETTER_ORIG = ""
                                LetterEnt.NUMBER_ACCOUNT = ""
                                LetterEnt.NUMBER_BANK = ""
                                LetterEnt.TYPE_DOC = ""
                                LetterEnt.CREATE_DATE = Date.Now() & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now)
                                LetterEnt.UPDATE_DATE = ""
                            End If
                            With LetterEnt
                                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_LETTER_GUARDAR_DATOS_PAGOS", .LETTER_ID, .BANK_ID, .COMMENT, .STATUS_ACT, .STATUS_LAST, .PLACE_SHIP, .GUARANTOR_NAME, .GUARANTOR_PHONE, _
                                                          .GUARANTOR_ADDR, .GUARANTOR_NAME2, .GUARANTOR_ADDR2, .GUARANTOR_PHONE2, .LETTER_ORIG, .NUMBER_ACCOUNT, .NUMBER_BANK, .TYPE_DOC, _
                                                          .CREATE_DATE, .UPDATE_DATE)
                            End With
                        Next
                    End If
                End If
            Catch ex As Exception
                estado = False
            End Try
            Return estado
        End Function

        Public Function DocumentoLetrasAceptadas() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_ACEPTADAS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GeneracionCambioEstadoLetra(ByVal LETTER_ID As String, ByVal BANK_ID As String, ByVal COMMENT As String, _
                                                    ByVal STATUS_ACT As String, ByVal NUMBER_ACCOUNT As String, ByVal NUMBER_BANK As String, ByVal UPDATE_DATE As String) As Boolean
            Dim estado As Boolean = True
            Try
                SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_CAMBIO_ESTADO_LETRA", LETTER_ID, BANK_ID, COMMENT, STATUS_ACT, NUMBER_ACCOUNT, NUMBER_BANK, UPDATE_DATE & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now))
            Catch ex As Exception
                estado = False
                Throw
            End Try
            Return estado
        End Function

        Public Function VerificacionClienteVendedor(ByVal Consulta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function MostrandoClientesDocPendientes() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_REP_CLIENTES_PEND_PAY").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function MostrandoClientesManejoDocumento() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_REP_CLIENTE_MANEJO_DOC_PAY").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function MostrandoClientesManejoDocumentoDetalles(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIENTE_MANEJO_DOC_DET_PAY", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Get_ManualVendedor(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_VENDEDOR", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GuardandoCarteraClientes(ByVal EntidadCliente As LibContabilidad.ClsEntidades.CUSTOMER_BALANCE_PAY) As Boolean
            Try
                With EntidadCliente
                    SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_I_CUSTOMER_BALANCE_PAY", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOC_DATE, .CADUCATE_DATE, .DOCUMENT_REF, .NUMBER_REF, _
                        .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, .USER_ID, .ACCOUNT, _
                        .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, .BANK_DESCRIPTION, _
                        .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .CUST_AUTO, .SERIE_AUX, .NUM_DOC_AUX, .PERCENT_DETRAC, .AMOUNT_DETRAC, .SALDO)
                End With
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function VerificacionNumeracion(ByVal _CodigoCliente As String, ByVal _TipoDoc As String, ByVal _Numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VERF_CODIGO_PAY", _CodigoCliente, _TipoDoc, _Numero).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function EliminacionPlanilla(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Try
                Dim res As Integer = 0
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_D_U_LETTER_PAY", _CodigoPlanilla, _Usuario)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function ActualizandoCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String, _
                                                    ByVal DOC_DATE As String, ByVal CADUCATE_DATE As String, ByVal SALES_ID As String, _
                                                    ByVal CURRENCY_ID As String, ByVal SELL_RATE As String, ByVal USER_ID As String, _
                                                    ByVal AMOUNT As String, ByVal SALDO As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_U_CUSTOMER_BALANCE_PAY", CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC, DOC_DATE, CADUCATE_DATE, SALES_ID, _
                                                                            CURRENCY_ID, SELL_RATE, USER_ID, AMOUNT, SALDO)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function EliminacionCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_D_CUSTOMER_BALANCE_PAY ", CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function



    End Class


    Public Class LETTER_EXCHANGE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub



        Public Function Contabilizar_Caja_Cambio_Estado(ByVal ID_LETRA As String, ByVal Fecha As Date, ByVal NUMERACION As String, _
                                                        ByVal MONEDA As String, ByVal CUENTA_CONTABLE As String) As Boolean
            Dim _ESTADO As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
            Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

            Try
                Dim dtDetallesLetra As DataTable
                dtDetallesLetra = New DataTable
                dtDetallesLetra = SqlHelper.ExecuteDataset(tr, "LETRAS_SP_S_DETALLE_LETRA", ID_LETRA).Tables(0)
                If dtDetallesLetra.Rows.Count() <> 0 Then

                    Dim mon As Integer = 0
                    Dim monto, TipoC As Double
                    Dim ruc, tdoc, ndoc As String
                    Dim f_emision, f_vencimiento As Date
                    mon = IIf(dtDetallesLetra.Rows(0)("MONEDA").ToString() = "MN", 1, 2)
                    monto = Math.Round(Double.Parse(dtDetallesLetra.Rows(0)("MONTO").ToString()), 2)
                    ruc = dtDetallesLetra.Rows(0)("RUC").ToString()
                    tdoc = dtDetallesLetra.Rows(0)("TIPO_DOC").ToString()
                    ndoc = dtDetallesLetra.Rows(0)("NRO_DOC").ToString()
                    TipoC = dtDetallesLetra.Rows(0)("TIPO_CAMBIO").ToString()
                    f_emision = dtDetallesLetra.Rows(0)("EMISION").ToString()
                    f_vencimiento = dtDetallesLetra.Rows(0)("VENCIMIENTO").ToString()
                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "09"
                        .AC_NUM_VOUCHER = NUMERACION
                        .AC_ANHO = Fecha.Year
                        .AC_MES = Fecha.Month
                        .AC_FEC_VOUCHER = Date.Now()
                        .AC_IDMONEDA = mon
                        .AC_DEBE = monto
                        .AC_HABER = monto
                        .AC_ESTADO = 2
                        .AC_GLOSA_VOU = "ACTUALIZACION ESTADO DE LETRA"
                        .AC_ES_INTERFACE = 1
                        .AC_IDPLANILLA = ""
                        .AC_ID_LETRA = ID_LETRA
                    End With
                    For i As Integer = 0 To 1
                        detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = i + 1
                        If i = 0 Then
                            detalle.AD_CUENTA = dtDetallesLetra.Rows(i)("ACCOUNT")
                        ElseIf i = 1 Then
                            detalle.AD_CUENTA = CUENTA_CONTABLE
                        End If
                        If detalle.AD_CUENTA = "" Then
                            MsgBox("El estado de la Letra no posee cuenta contable.", MsgBoxStyle.Critical, "Sistemas")
                            _ESTADO = False
                            Exit Function
                        End If
                        detalle.AD_TANEXO = 1
                        detalle.AD_IDANEXO = ruc
                        detalle.AD_TDOC = tdoc
                        detalle.AD_SDOC = "00000"
                        detalle.AD_NDOC = ndoc
                        detalle.AD_FDOC = f_emision
                        detalle.AD_VDOC = f_vencimiento
                        'If MONEDA = "ME" Then
                        '    If mon = "2" Then
                        '        monto = monto
                        '    Else
                        '        monto = monto / ClsVarComun.TCVenta
                        '    End If
                        'ElseIf MONEDA = "MN" Then
                        '    If mon = "1" Then
                        '        monto = monto
                        '    Else
                        '        monto = monto * ClsVarComun.TCVenta
                        '    End If
                        'End If
                        If i = 0 Then
                            detalle.AD_DEBE = 0
                            detalle.AD_HABER = monto
                            detalle.AD_IDMONEDA = mon
                        ElseIf i = 1 Then
                            detalle.AD_DEBE = monto
                            detalle.AD_HABER = 0
                            detalle.AD_IDMONEDA = IIf(MONEDA = "MN", 1, 2)
                        End If
                        detalle.AD_TCAM = TipoC
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = monto
                        detalle.AD_PORCE_DESTINO = 0
                        detalle.AD_ES_CONCI = 0
                        detalle.AD_ANHO_CONI = 0
                        detalle.AD_MES_CONCI = 0
                        detalle.AD_ES_INAFECTO = 0
                        detalle.AD_TDOC_REF = tdoc
                        detalle.AD_SDOC_REF = "00000"
                        detalle.AD_NDOC_REF = ndoc
                        detalle.AD_FDOC_REF = f_emision
                        detalle.AD_VDOC_REF = f_vencimiento
                        detalle.AD_GLOSA = ""
                        ls_det.Add(detalle)
                    Next
                End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(tr, "CO_SP_I_ASIENTO_CAB", cab.AC_IDSUBDIARIO, cab.AC_NUM_VOUCHER, cab.AC_ANHO, cab.AC_MES, cab.AC_FEC_VOUCHER, cab.AC_IDMONEDA, cab.AC_DEBE, cab.AC_HABER, cab.AC_ESTADO, cab.AC_GLOSA_VOU,
                                                                                          cab.AC_ES_INTERFACE, cab.AC_IDPLANILLA, cab.AC_ID_LETRA)
                cab.AC_ID = idcab

                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ls_det
                    SqlHelper.ExecuteNonQuery(tr, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                _ESTADO = False
                MsgBox(ex.Message)
            End Try
            Return _ESTADO
        End Function

        Public Function Contabilizar_Caja_Cambio_Estado_Grupal(ls_det_LT_GRUPAL As List(Of ClsEntidades.LETRAS_CAMBIO_GRUPAL), ByVal ID_LETRA As String, ByVal Fecha As Date, ByVal NUMERACION As String, _
                                                        ByVal MONEDA As String, ByVal CUENTA_CONTABLE As String) As Boolean
            Dim _ESTADO As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
            Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

            Try
                Dim dtDetallesLetra As DataTable
                dtDetallesLetra = New DataTable
                'dtDetallesLetra = SqlHelper.ExecuteDataset(tr, "LETRAS_SP_S_DETALLE_LETRA", ID_LETRA).Tables(0)
                'If dtDetallesLetra.Rows.Count() <> 0 Then

                Dim mon As Integer = 0
                Dim monto As Double
                
                With cab
                    .AC_ID = 0
                    .AC_IDSUBDIARIO = "09"
                    .AC_NUM_VOUCHER = NUMERACION
                    .AC_ANHO = Fecha.Year
                    .AC_MES = Fecha.Month
                    .AC_FEC_VOUCHER = Date.Now()
                    .AC_IDMONEDA = MONEDA
                    .AC_DEBE = monto
                    .AC_HABER = monto
                    .AC_ESTADO = 2
                    .AC_GLOSA_VOU = "ACTUALIZACION ESTADO DE LETRA"
                    .AC_ES_INTERFACE = 1
                    .AC_IDPLANILLA = ""
                    .AC_ID_LETRA = ID_LETRA
                End With
                For i As Integer = 0 To ls_det_LT_GRUPAL.Count - 1
                    detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                    detalle.AD_IDCAB = 0
                    detalle.AD_SECUENCIA = i + 1
                    detalle.AD_CUENTA = ls_det_LT_GRUPAL(i).CUENTA
                    
                    If ls_det_LT_GRUPAL(i).CUENTA = "" Then
                        MsgBox("El estado de la Letra no posee cuenta contable.", MsgBoxStyle.Critical, "Sistemas")
                        _ESTADO = False
                        Exit Function
                    End If
                    detalle.AD_TANEXO = 1
                    detalle.AD_IDANEXO = ls_det_LT_GRUPAL(i).RUC
                    detalle.AD_TDOC = ls_det_LT_GRUPAL(i).TIPO_DOC
                    detalle.AD_SDOC = ls_det_LT_GRUPAL(i).SERIE_DOC
                    detalle.AD_NDOC = ls_det_LT_GRUPAL(i).NUMERO_DOC
                    detalle.AD_FDOC = ls_det_LT_GRUPAL(i).FEC_DOC
                    detalle.AD_VDOC = ls_det_LT_GRUPAL(i).FEC_VEN_DOC
                    If i Mod 2 = 0 Then
                        detalle.AD_DEBE = 0
                        detalle.AD_HABER = ls_det_LT_GRUPAL(i).MONTO_DOC
                        detalle.AD_IDMONEDA = ls_det_LT_GRUPAL(i).TIPO_MONEDA
                    ElseIf i Mod 2 = 1 Then
                        detalle.AD_DEBE = ls_det_LT_GRUPAL(i).MONTO_DOC
                        detalle.AD_HABER = 0
                        detalle.AD_IDMONEDA = ls_det_LT_GRUPAL(i).TIPO_MONEDA
                    End If
                    detalle.AD_TCAM = ls_det_LT_GRUPAL(i).TC
                    detalle.AD_SEC_ORI_DES = 0
                    detalle.AD_IDCC = ""
                    detalle.AD_ES_DESTINO = 0
                    detalle.AD_IDMEDIOPAGO = ""
                    detalle.AD_MONTO_ORI = ls_det_LT_GRUPAL(i).MONTO_DOC
                    detalle.AD_PORCE_DESTINO = 0
                    detalle.AD_ES_CONCI = 0
                    detalle.AD_ANHO_CONI = 0
                    detalle.AD_MES_CONCI = 0
                    detalle.AD_ES_INAFECTO = 0
                    detalle.AD_TDOC_REF = ls_det_LT_GRUPAL(i).TIPO_DOC
                    detalle.AD_SDOC_REF = ls_det_LT_GRUPAL(i).SERIE_DOC
                    detalle.AD_NDOC_REF = ls_det_LT_GRUPAL(i).NUMERO_DOC
                    detalle.AD_FDOC_REF = ls_det_LT_GRUPAL(i).FEC_DOC
                    detalle.AD_VDOC_REF = ls_det_LT_GRUPAL(i).FEC_VEN_DOC
                    detalle.AD_GLOSA = ""
                    ls_det.Add(detalle)
                Next
                'End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(tr, "CO_SP_I_ASIENTO_CAB", cab.AC_IDSUBDIARIO, cab.AC_NUM_VOUCHER, cab.AC_ANHO, cab.AC_MES, cab.AC_FEC_VOUCHER, cab.AC_IDMONEDA, cab.AC_DEBE, cab.AC_HABER, cab.AC_ESTADO, cab.AC_GLOSA_VOU,
                                                                                          cab.AC_ES_INTERFACE, cab.AC_IDPLANILLA, cab.AC_ID_LETRA)
                cab.AC_ID = idcab

                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ls_det
                    SqlHelper.ExecuteNonQuery(tr, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                _ESTADO = False
                MsgBox(ex.Message)
            End Try
            Return _ESTADO
        End Function

        Public Function Contabilizar_Caja_Cambio_Estado_Letras_Pagos(ByVal ID_LETRA As String, ByVal Fecha As Date, ByVal NUMERACION As String, _
                                                        ByVal MONEDA As String, ByVal CUENTA_CONTABLE As String) As Boolean
            Dim _ESTADO As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
            Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
            Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

            Try
                Dim dtDetallesLetra As DataTable
                dtDetallesLetra = New DataTable
                dtDetallesLetra = SqlHelper.ExecuteDataset(tr, "LETRAS_SP_S_DETALLE_LETRA_PAY", ID_LETRA).Tables(0)
                If dtDetallesLetra.Rows.Count() <> 0 Then

                    Dim mon As Integer = 0
                    Dim monto, TipoC As Double
                    Dim ruc, tdoc, ndoc As String
                    Dim f_emision, f_vencimiento As Date
                    mon = IIf(dtDetallesLetra.Rows(0)("MONEDA").ToString() = "MN", 1, 2)
                    monto = Math.Round(Double.Parse(dtDetallesLetra.Rows(0)("MONTO").ToString()), 2)
                    ruc = dtDetallesLetra.Rows(0)("RUC").ToString()
                    tdoc = dtDetallesLetra.Rows(0)("TIPO_DOC").ToString()
                    ndoc = dtDetallesLetra.Rows(0)("NRO_DOC").ToString()
                    TipoC = dtDetallesLetra.Rows(0)("TIPO_CAMBIO").ToString()
                    f_emision = dtDetallesLetra.Rows(0)("EMISION").ToString()
                    f_vencimiento = dtDetallesLetra.Rows(0)("VENCIMIENTO").ToString()
                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "10"
                        .AC_NUM_VOUCHER = NUMERACION
                        .AC_ANHO = Fecha.Year
                        .AC_MES = Fecha.Month
                        .AC_FEC_VOUCHER = Date.Now()
                        .AC_IDMONEDA = mon
                        .AC_DEBE = monto
                        .AC_HABER = monto
                        .AC_ESTADO = 2
                        .AC_GLOSA_VOU = "ACTUALIZACION ESTADO DE LETRA"
                        .AC_ES_INTERFACE = 1
                        .AC_IDPLANILLA = ""
                        .AC_ID_LETRA = ID_LETRA
                    End With
                    For i As Integer = 0 To 1
                        detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = i + 1
                        If i = 0 Then
                            detalle.AD_CUENTA = dtDetallesLetra.Rows(i)("ACCOUNT")
                        ElseIf i = 1 Then
                            detalle.AD_CUENTA = CUENTA_CONTABLE
                        End If
                        If detalle.AD_CUENTA = "" Then
                            MsgBox("El estado de la Letra no posee cuenta contable.", MsgBoxStyle.Critical, "Sistemas")
                            _ESTADO = False
                            Exit Function
                        End If
                        detalle.AD_TANEXO = 1
                        detalle.AD_IDANEXO = ruc
                        detalle.AD_TDOC = tdoc
                        detalle.AD_SDOC = "00000"
                        detalle.AD_NDOC = ndoc
                        detalle.AD_FDOC = f_emision
                        detalle.AD_VDOC = f_vencimiento
                        'If MONEDA = "ME" Then
                        '    If mon = "2" Then
                        '        monto = monto
                        '    Else
                        '        monto = monto / ClsVarComun.TCVenta
                        '    End If
                        'ElseIf MONEDA = "MN" Then
                        '    If mon = "1" Then
                        '        monto = monto
                        '    Else
                        '        monto = monto * ClsVarComun.TCVenta
                        '    End If
                        'End If
                        If i = 0 Then
                            detalle.AD_DEBE = 0
                            detalle.AD_HABER = monto
                            detalle.AD_IDMONEDA = mon
                        ElseIf i = 1 Then
                            detalle.AD_DEBE = monto
                            detalle.AD_HABER = 0
                            detalle.AD_IDMONEDA = IIf(MONEDA = "MN", 1, 2)
                        End If
                        detalle.AD_TCAM = TipoC
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = monto
                        detalle.AD_PORCE_DESTINO = 0
                        detalle.AD_ES_CONCI = 0
                        detalle.AD_ANHO_CONI = 0
                        detalle.AD_MES_CONCI = 0
                        detalle.AD_ES_INAFECTO = 0
                        detalle.AD_TDOC_REF = tdoc
                        detalle.AD_SDOC_REF = "00000"
                        detalle.AD_NDOC_REF = ndoc
                        detalle.AD_FDOC_REF = f_emision
                        detalle.AD_VDOC_REF = f_vencimiento
                        detalle.AD_GLOSA = ""
                        ls_det.Add(detalle)
                    Next
                End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(tr, "CO_SP_I_ASIENTO_CAB", cab.AC_IDSUBDIARIO, cab.AC_NUM_VOUCHER, cab.AC_ANHO, cab.AC_MES, cab.AC_FEC_VOUCHER, cab.AC_IDMONEDA, cab.AC_DEBE, cab.AC_HABER, cab.AC_ESTADO, cab.AC_GLOSA_VOU,
                                                                                          cab.AC_ES_INTERFACE, cab.AC_IDPLANILLA, cab.AC_ID_LETRA)
                cab.AC_ID = idcab

                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ls_det
                    SqlHelper.ExecuteNonQuery(tr, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                _ESTADO = False
                MsgBox(ex.Message)
            End Try
            Return _ESTADO
        End Function

        Public Function ConsultandoDocAnulacion(ByVal _codigo As String, ByVal USUARIO As String) As Boolean
            Dim estado As Boolean = True
            Try
                Dim Dt_documento As New DataTable
                Dim Dt_documento_detalle As DataTable
                Dim consulta As String = ""
                consulta = "SELECT A.TYPE_DOC,A.NUMBER_DOC,B.CUSTOMER_ID  FROM LETTER_EXCHANGE_LINE A INNER JOIN LETTER_EXCHANGE B ON A.ID =B.ID   WHERE A.ID='" & _codigo & "' AND A.IS_ORIG='N' "
                Dt_documento = SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VALIDAR_CANJE_LETRAS", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("TYPE_DOC").ToString & "-" & row("NUMBER_DOC").ToString & " no se puede anular.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                    'Consultanto Pagos
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VALIDAR_PAGO", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("TYPE_DOC").ToString & "-" & row("NUMBER_DOC").ToString & " se realizo el pago, no se puede anular el cheque.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                    ''ANULANDO LA LETRA
                    SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_D_U_LETTER_ANULAR", _codigo, USUARIO)
                End If
            Catch ex As Exception
                estado = False
                MsgBox(ex.Message)
            End Try
            Return estado
        End Function

        Public Function ConsultandoDocAnulacionCheque(ByVal _codigo As String, ByVal USUARIO As String) As Boolean
            Dim estado As Boolean = True
            Try
                Dim Dt_documento As New DataTable
                Dim Dt_documento_detalle As DataTable
                Dim consulta As String = ""
                consulta = "SELECT A.TYPE_DOC,A.NUMBER_DOC,B.CUSTOMER_ID  FROM LETTER_EXCHANGE_LINE A INNER JOIN LETTER_EXCHANGE B ON A.ID =B.ID   WHERE A.ID='" & _codigo & "' AND A.IS_ORIG='N' "
                Dt_documento = SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VALIDAR_CANJE_LETRAS", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("TYPE_DOC").ToString & "-" & row("NUMBER_DOC").ToString & " no se puede anular.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                    'Consultanto Pagos
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VALIDAR_PAGO", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("TYPE_DOC").ToString & "-" & row("NUMBER_DOC").ToString & " se realizo el pago, no se puede anular el cheque.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                    ''ANULANDO LA LETRA
                    SqlHelper.ExecuteNonQuery(cn, "CHEQUE_SP_D_U_ANULAR", _codigo, USUARIO)
                End If
            Catch ex As Exception
                estado = False
                MsgBox(ex.Message)
            End Try
            Return estado
        End Function

        Public Function ConsultandoDocAnulacion_Pagos(ByVal _codigo As String, ByVal USUARIO As String) As Boolean
            Dim estado As Boolean = True
            Try
                Dim Dt_documento As New DataTable
                Dim Dt_documento_detalle As DataTable
                Dim consulta As String = ""
                consulta = "SELECT A.TYPE_DOC,A.NUMBER_DOC,B.CUSTOMER_ID  FROM LETTER_EXCHANGE_LINE_PAY A INNER JOIN LETTER_EXCHANGE_PAY B ON A.ID =B.ID   WHERE A.ID='" & _codigo & "' AND A.IS_ORIG='N' "
                Dt_documento = SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VALIDAR_CANJE_LETRAS_PAGOS", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("TYPE_DOC").ToString & "-" & row("NUMBER_DOC").ToString & " no se puede anular.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                    'Consultanto Pagos
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VALIDAR_PAGO_PAGOS", row("TYPE_DOC").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("TYPE_DOC").ToString & "-" & row("NUMBER_DOC").ToString & " se realizo el pago, no se puede anular la letra.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                    ''ANULANDO LA LETRA
                    SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_D_U_LETTER_ANULAR_PAGOS", _codigo, USUARIO)
                End If
            Catch ex As Exception
                estado = False
                MsgBox(ex.Message)
            End Try
            Return estado
        End Function


        Public Function InsertDetallesLetra(ByRef entidad As ClsEntidades.LETTER) As Boolean
            Dim estado As Boolean = True
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_LETTER_DATOS_ADICIONALES", .LETTER_ID, .BANK_ID, .COMMENT, .STATUS_ACT, .STATUS_LAST, .PLACE_SHIP, .GUARANTOR_NAME, .GUARANTOR_PHONE, _
                                              .GUARANTOR_ADDR, .GUARANTOR_NAME2, .GUARANTOR_ADDR2, .GUARANTOR_PHONE2, .LETTER_ORIG, .NUMBER_ACCOUNT, .NUMBER_BANK, .TYPE_DOC, .CREATE_DATE, .UPDATE_DATE)
                End With
            Catch ex As Exception
                estado = False
            End Try
            Return estado
        End Function



        Public Function Insert(ByRef entidad As ClsEntidades.LETTER_EXCHANGE, ls_det As List(Of ClsEntidades.LETTER_EXCHANGE_LINE), _
                             ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String,
                             ByVal PorcPercepcion As Double, ByVal Flag_Retencion As Boolean) As Boolean
            Dim estado As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_LETTER_EXCHANGE", .ID, .DATE_EXCHANGE, .VOUCHER_ID, .CREATE_DATE, .USER_ID, .STATUS, .ACCEPT_DATE, _
                                              .SELL_RATE, .CURRENCY_ID, .CUSTOMER_ID, .COMMENT)
                End With
                If ls_det.Count > 0 Then
                    For Each l As ClsEntidades.LETTER_EXCHANGE_LINE In ls_det
                        With l
                            SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_LETTER_EXCHANGE_LINE", .ID, .ITEM, .TYPE_DOC, .NUMBER_DOC, .AMOUNT, .CADUCATE_DATE, .IS_ORIG, .OPCION)
                        End With
                    Next
                End If
                Dim MontoD As Double = 0
                Dim TYPE_DOC As String = ""
                Dim NUMBER_DOC As String = ""
                Dim MonedaDoc As String = String.Empty

                For Each row As DataRow In Tabla.Select("Sel=True")
                    If MonedaLetra = "MN" Then
                        If row("Mon") = "MN" Then
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                            Else
                                MontoD = row("MontoCanjear")
                            End If
                        Else
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                                MontoD = (MontoD - Math.Round(MontoD * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                MontoD = MontoD / LibComunVar.ClsVarComun.TCVenta
                            Else
                                MontoD = (row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                                MontoD = MontoD / LibComunVar.ClsVarComun.TCVenta
                            End If
                        End If
                    Else
                        If row("Mon") = "ME" Then
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                            Else
                                MontoD = row("MontoCanjear")
                            End If
                        Else

                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                                MontoD = (MontoD - Math.Round(MontoD * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                MontoD = MontoD * LibComunVar.ClsVarComun.TCVenta
                            Else
                                MontoD = (row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                                MontoD = MontoD * LibComunVar.ClsVarComun.TCVenta
                            End If
                        End If
                    End If
                    SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_S_LETTER_EX_ACT_SAL", entidad.CUSTOMER_ID, row("TipoDoc").ToString, row("NumDoc").ToString, row("Monto").ToString - MontoD)
                Next
                'Actualizando correlativo
                SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "LT", entidad.ID)
                If IsNumeric(NumMaximo) Then
                    SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "LL", NumMaximo)
                End If
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
                tr.Rollback()
                estado = False
            End Try
            Return estado
        End Function

        Public Function InsertCheque(ByRef entidad As ClsEntidades.CHECK_EXCHANGE, ls_det As List(Of ClsEntidades.CHECK_EXCHANGE_LINE), _
                             ByVal Tabla As DataTable, ByVal TipoNumeracion As String, ByVal NumMaximo As String, ByVal MonedaLetra As String,
                             ByVal PorcPercepcion As Double, ByVal Flag_Retencion As Boolean) As Boolean
            Dim estado As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_CHECK_EXCHANGE", .ID, .DATE_EXCHANGE, .CREATE_DATE, .USER_ID, .CUSTOMER_ID, _
                                              .SELL_RATE, .AMOUNT, .CURRENCY_ID, .SALES_ID, .STATUS, .COMMENT)
                End With
                If ls_det.Count > 0 Then
                    For Each l As ClsEntidades.CHECK_EXCHANGE_LINE In ls_det
                        With l
                            SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_CHECK_EXCHANGE_LINE", .ID, .ITEM, .TYPE_DOC, .NUMBER_DOC, .DATEE, .CURRENCY_ID, .AMOUNT, .AMOUNT_BALANCE, .AMOUNT_ACT, .BANK_DESCRIPTION, .BANK_ID, .CADUCATE_DATE, .NUMBER_TYPE, .IS_ORIG, .OPCION)
                        End With
                    Next
                End If
                Dim MontoD As Double = 0
                Dim TYPE_DOC As String = ""
                Dim NUMBER_DOC As String = ""
                Dim MonedaDoc As String = String.Empty

                For Each row As DataRow In Tabla.Select("Sel=True")
                    If MonedaLetra = "MN" Then
                        If row("Mon") = "MN" Then
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                            Else
                                MontoD = row("MontoCanjear")
                            End If
                        Else
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                                MontoD = (MontoD - Math.Round(MontoD * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                MontoD = MontoD / LibComunVar.ClsVarComun.TCVenta
                            Else
                                MontoD = (row("MontoCanjear") * LibComunVar.ClsVarComun.TCVenta)
                                MontoD = MontoD / LibComunVar.ClsVarComun.TCVenta
                            End If
                        End If
                    Else
                        If row("Mon") = "ME" Then
                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") - Math.Round(row("MontoCanjear") * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                            Else
                                MontoD = row("MontoCanjear")
                            End If
                        Else

                            If Flag_Retencion = True Then
                                MontoD = (row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                                MontoD = (MontoD - Math.Round(MontoD * PorcPercepcion / 100, 2, MidpointRounding.AwayFromZero))
                                MontoD = MontoD * LibComunVar.ClsVarComun.TCVenta
                            Else
                                MontoD = (row("MontoCanjear") / LibComunVar.ClsVarComun.TCVenta)
                                MontoD = MontoD * LibComunVar.ClsVarComun.TCVenta
                            End If
                        End If
                    End If
                    SqlHelper.ExecuteNonQuery(tr, "CHEQUE_SP_S_EX_ACT_SAL", entidad.CUSTOMER_ID, row("TipoDoc").ToString, row("NumDoc").ToString, row("Monto").ToString - MontoD)
                Next
                'Actualizando correlativo
                'SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "LT", entidad.ID)
                'If IsNumeric(NumMaximo) Then
                '    SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "LL", NumMaximo)
                'End If
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
                tr.Rollback()
                estado = False
            End Try
            Return estado
        End Function

        Public Function Get_ManualClientes(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_CLIENTE_M", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosPendientes(ByVal _Codigo As String, ByVal _Opcion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETTER_EX_DOC_PEND", _Codigo, _Opcion).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosPendientesCheques(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CHEQUE_SP_S_EX_DOC_PEND", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_VerificacionNumeracionLetra(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETTER_EX_COD_M", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosPlanilla(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_PLANILLA_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosPlanillaCheques(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CHEQUE_SP_S_PLANILLA_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosLetras(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETRA_PRINCIPAL", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosCheques(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CHEQUE_SP_S_LETRA_PRINCIPAL", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalesLetter(ByVal _CodigoPlanilla As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = " SELECT * FROM LETTER WHERE LETTER_ID='" & _CodigoPlanilla & "' AND STATUS_ACT='' AND  STATUS_LAST=''"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalesAval(ByVal _CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "SELECT * FROM GUARANTOR WHERE CUSTOMER_ID='" & _CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Get_AdicionalDatosLetra(ByVal _CodigoPlanilla As String, ByVal CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "Select ID,DATE_EXCHANGE,STATUS,SELL_RATE,CURRENCY_ID,CUSTOMER_ID From LETTER_EXCHANGE where ID='" & _CodigoPlanilla & "' and CUSTOMER_ID='" & CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalDatosCliente(ByVal _CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "Select * From CUSTOMER where ID='" & _CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_AdicionalDatosLetraDetalle(ByVal _CodigoPlanilla As String, ByVal _CodigoLetra As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "Select ID,TYPE_DOC,AMOUNT,CADUCATE_DATE,NUMBER_DOC From LETTER_EXCHANGE_LINE where ID='" & _CodigoPlanilla & "' and TYPE_DOC='LT' and NUMBER_DOC='" & _CodigoLetra & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function InsercionTablaTemporal(ByVal _Consulta As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "LETRA_SP_S_TABLA_IMPRIM")
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, _Consulta)
                Return True
            Catch ex As Exception
                Return False
                Throw
            End Try
        End Function

        Public Function DatosAdicionalesDireccion(ByVal _CodigoCliente As String) As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "SELECT C.ADDR+' - '+A.NOMBRE +' - '+D.NOMBRE+' - '+B.NOMBRE AS DIRECCION,*" _
                       & "FROM CUSTOMER C  INNER JOIN dbo.UBIGEO A ON C.STATE_ID=A.CODDIS   AND C.DEPARTMENT=A.CODDPTO AND C.PROVINCE=A.CODPROV " _
                       & "INNER JOIN dbo.UBIGEO B ON C.DEPARTMENT=B.CODDPTO  AND B.CODPROV='00' AND B.CODDIS='00' INNER JOIN dbo.UBIGEO D ON C.PROVINCE=D.CODPROV  " _
                       & "AND C.DEPARTMENT=D.CODDPTO AND D.CODDIS='00' WHERE ID='" & _CodigoCliente & "'"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function EjecutarReporteLetras() As DataTable
            Try
                Dim Cadena As String = String.Empty
                Cadena = "select * From  T_Temporal_Letras"
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GeneracionAceptacionLetra(ByVal CodigoPlanilla) As Boolean
            Dim estado As Boolean = True
            Try
                Dim Cadena As String = String.Empty
                Dim dtDetalleCab As DataTable
                Dim dtDetalleDet As DataTable
                Dim dtDetalleDoc As DataTable
                Dim dtActualizar As DataTable
                Dim DTDETALLESTATUSLETRA As DataTable
                Dim dtdetalle As DataTable
                Dim EntidadCliente As ClsEntidades.CUSTOMER_BALANCE
                Dim LetterEnt As ClsEntidades.LETTER
                dtDetalleCab = New DataTable("CabeceraLetra")
                Cadena = "UPDATE  LETTER_EXCHANGE SET STATUS='A', ACCEPT_DATE=GETDATE() WHERE ID='" & CodigoPlanilla & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, Cadena)
                Cadena = String.Empty
                Cadena = "Select * from LETTER_EXCHANGE WHERE ID='" & CodigoPlanilla & "'"
                dtDetalleCab = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                If dtDetalleCab.Rows.Count() <> 0 Then
                    Dim MonDoc As String = dtDetalleCab.Rows(0).Item("CURRENCY_ID").ToString
                    'Actualizando los Documentos
                    Cadena = String.Empty
                    Cadena = "Select * from LETTER_EXCHANGE_LINE WHERE ID='" & CodigoPlanilla & "' AND IS_ORIG='S'"
                    dtDetalleDoc = New DataTable()
                    dtDetalleDoc = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                    If dtDetalleDoc.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtDetalleDoc.Rows.Count() - 1
                            dtActualizar = New DataTable
                            Cadena = String.Empty
                            Cadena = "SELECT * FROM CUSTOMER_BALANCE WHERE CUSTOMER_ID='" & dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString & "'" _
                                & " AND DOCUMENT_ID='" & dtDetalleDoc.Rows(i).Item("TYPE_DOC").ToString & "' AND NUMBER_DOC='" & dtDetalleDoc.Rows(i).Item("NUMBER_DOC").ToString & "'"
                            dtActualizar = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                            If dtActualizar.Rows.Count() <> 0 Then
                                Dim TipoD As String = dtActualizar.Rows(0).Item("DOCUMENT_ID").ToString
                                Dim Moneda As String = dtActualizar.Rows(0).Item("CURRENCY_ID").ToString
                                Dim MontodoC As Double = dtDetalleDoc.Rows(i).Item("AMOUNT")
                                If TipoD <> "NC" Then
                                    If Moneda = "ME" Then
                                        If MonDoc = "ME" Then
                                            MontodoC = MontodoC
                                        Else
                                            MontodoC = MontodoC / ClsVarComun.TCVenta
                                        End If
                                    ElseIf Moneda = "MN" Then
                                        If MonDoc = "MN" Then
                                            MontodoC = MontodoC
                                        Else
                                            MontodoC = MontodoC * ClsVarComun.TCVenta
                                        End If
                                    End If
                                Else
                                    If Moneda = "ME" Then
                                        If MonDoc = "ME" Then
                                            MontodoC = (Math.Abs(MontodoC)) * -1
                                        Else
                                            MontodoC = (Math.Abs(MontodoC / ClsVarComun.TCVenta)) * -1
                                        End If
                                    ElseIf Moneda = "MN" Then
                                        If MonDoc = "MN" Then
                                            MontodoC = (Math.Abs(MontodoC)) * -1
                                        Else
                                            MontodoC = (Math.Abs(MontodoC * ClsVarComun.TCVenta)) * -1
                                        End If
                                    End If
                                End If
                                Cadena = String.Empty
                                Cadena = "UPDATE  CUSTOMER_BALANCE SET AMOUNT_BALANCE=(AMOUNT_BALANCE - " & MontodoC & ") WHERE CUSTOMER_ID='" & dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString & "'" _
                                & " AND DOCUMENT_ID='" & dtDetalleDoc.Rows(i).Item("TYPE_DOC").ToString & "' AND NUMBER_DOC='" & dtDetalleDoc.Rows(i).Item("NUMBER_DOC").ToString & "'"
                                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, Cadena)
                            End If
                        Next
                    End If
                    Cadena = String.Empty
                    Cadena = "Select * from LETTER_EXCHANGE_LINE WHERE ID='" & CodigoPlanilla & "' AND IS_ORIG='N'"
                    dtDetalleDet = New DataTable("DetalleLetra")
                    dtDetalleDet = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                    If dtDetalleDet.Rows.Count() <> 0 Then
                        For i As Integer = 0 To dtDetalleDet.Rows.Count() - 1
                            dtdetalle = New DataTable
                            EntidadCliente = New ClsEntidades.CUSTOMER_BALANCE
                            With EntidadCliente
                                .CUSTOMER_ID = dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString
                                .DOCUMENT_ID = dtDetalleDet.Rows(i).Item("TYPE_DOC").ToString
                                .NUMBER_DOC = dtDetalleDet.Rows(i).Item("NUMBER_DOC").ToString
                                .DOC_DATE = Date.Now()
                                .CADUCATE_DATE = dtDetalleDet.Rows(i).Item("CADUCATE_DATE").ToString
                                .DOCUMENT_REF = "CJ"
                                .NUMBER_REF = CodigoPlanilla
                                Cadena = String.Empty
                                Cadena = "Select * from CUSTOMER WHERE ID='" & .CUSTOMER_ID & "'"
                                dtdetalle = New DataTable
                                dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                                If dtdetalle.Rows.Count() <> 0 Then
                                    .SALES_ID = IIf(String.IsNullOrEmpty(dtdetalle.Rows(0).Item("SALES_ID")), "", dtdetalle.Rows(0).Item("SALES_ID").ToString)
                                Else
                                    .SALES_ID = ""
                                End If
                                .AMOUNT = IIf(String.IsNullOrEmpty(dtDetalleDet.Rows(i).Item("AMOUNT")), 0, dtDetalleDet.Rows(i).Item("AMOUNT").ToString)
                                .AMOUNT_BALANCE = IIf(String.IsNullOrEmpty(dtDetalleDet.Rows(i).Item("AMOUNT")), 0, dtDetalleDet.Rows(i).Item("AMOUNT").ToString)
                                .CURRENCY_ID = dtDetalleCab.Rows(0).Item("CURRENCY_ID").ToString
                                .SELL_RATE = CDbl(dtDetalleCab.Rows(0).Item("SELL_RATE").ToString)
                                .IS_DR_CR = 0
                                .STATUS = "V"
                                .CREATE_DATE = Date.Now.ToShortDateString
                                .LAST_MODIFIED = Date.Now.ToShortDateString
                                .USER_ID = LibComunVar.ClsVarComun.USUARIO
                                .ACCOUNT = ""
                                .AMOUNT_COMM = 0
                                .TYPE_REC = 0
                                .REFERENCE_DATE = Date.Now.ToShortDateString
                                .IS_CHECK_DIF = 0
                                .AMOUNT_BALANCE_INI = dtDetalleDet.Rows(i).Item("AMOUNT").ToString
                                .TERMS = 0
                                .PLACE_SALES = ""
                                .BANK_ID = 0
                                .BANK_DESCRIPTION = 0
                                .AMOUNT_PER = 0
                                .PERCENT_PER = 0
                                .ACCOUNT_PER = 0
                                .CUST_AUTO = 0
                                .SERIE_AUX = "000"
                                .NUM_DOC_AUX = .NUMBER_DOC
                                .PERCENT_DETRAC = 0
                                .AMOUNT_DETRAC = 0
                                .SALDO = IIf(String.IsNullOrEmpty(dtDetalleDet.Rows(i).Item("AMOUNT")), 0, dtDetalleDet.Rows(i).Item("AMOUNT").ToString)
                            End With
                            With EntidadCliente
                                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_I_CUSTOMER_BALANCE", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOC_DATE, .CADUCATE_DATE, .DOCUMENT_REF, .NUMBER_REF, _
                                    .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, .USER_ID, .ACCOUNT, _
                                    .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, .BANK_DESCRIPTION, _
                                    .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .CUST_AUTO, .SERIE_AUX, .NUM_DOC_AUX, .PERCENT_DETRAC, .AMOUNT_DETRAC, .SALDO)
                            End With
                            Cadena = String.Empty
                            Cadena = "Select * from LETTER where LETTER_ID='" & dtDetalleDet.Rows(i).Item("NUMBER_DOC") & "'"
                            dtdetalle = New DataTable
                            dtdetalle = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                            If dtdetalle.Rows.Count() <> 0 Then
                                LetterEnt = New ClsEntidades.LETTER
                                LetterEnt.LETTER_ID = dtDetalleDet.Rows(i).Item("NUMBER_DOC").ToString
                                LetterEnt.BANK_ID = dtdetalle.Rows(0).Item("BANK_ID").ToString
                                LetterEnt.COMMENT = ""
                                LetterEnt.STATUS_ACT = "CR"
                                LetterEnt.STATUS_LAST = "CR"
                                LetterEnt.PLACE_SHIP = ""
                                LetterEnt.GUARANTOR_NAME = dtdetalle.Rows(0).Item("GUARANTOR_NAME").ToString
                                LetterEnt.GUARANTOR_PHONE = dtdetalle.Rows(0).Item("GUARANTOR_PHONE").ToString
                                LetterEnt.GUARANTOR_ADDR = dtdetalle.Rows(0).Item("GUARANTOR_ADDR").ToString
                                LetterEnt.GUARANTOR_NAME2 = ""
                                LetterEnt.GUARANTOR_ADDR2 = ""
                                LetterEnt.GUARANTOR_PHONE2 = ""
                                LetterEnt.LETTER_ORIG = ""
                                LetterEnt.NUMBER_ACCOUNT = ""
                                LetterEnt.NUMBER_BANK = ""
                                LetterEnt.TYPE_DOC = ""
                                LetterEnt.CREATE_DATE = Date.Now() & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now)
                                LetterEnt.UPDATE_DATE = ""
                            Else
                                LetterEnt = New ClsEntidades.LETTER
                                LetterEnt.LETTER_ID = dtDetalleDet.Rows(i).Item("NUMBER_DOC").ToString
                                LetterEnt.BANK_ID = ""
                                LetterEnt.COMMENT = ""
                                Cadena = String.Empty
                                Cadena = "SELECT B.STATUS_ID FROM dbo.CO_TB_ASIENTO_DET A INNER JOIN dbo.STATUS_LETTER B ON A.AD_CUENTA=B.ACCOUNT AND CASE WHEN A.AD_IDMONEDA=1 THEN 'MN' ELSE 'ME' END=B.CURRENCY_ID WHERE AD_NDOC='" & LetterEnt.LETTER_ID & "' AND AD_TDOC='LT'"
                                DTDETALLESTATUSLETRA = New DataTable
                                DTDETALLESTATUSLETRA = SqlHelper.ExecuteDataset(cn, CommandType.Text, Cadena).Tables(0)
                                If DTDETALLESTATUSLETRA.Rows.Count > 0 Then
                                    LetterEnt.STATUS_ACT = DTDETALLESTATUSLETRA.Rows(0).Item("STATUS_ID").ToString
                                    LetterEnt.STATUS_LAST = DTDETALLESTATUSLETRA.Rows(0).Item("STATUS_ID").ToString
                                Else
                                    LetterEnt.STATUS_ACT = "CR"
                                    LetterEnt.STATUS_LAST = "CR"
                                End If
                                
                                LetterEnt.PLACE_SHIP = ""
                                LetterEnt.GUARANTOR_NAME = ""
                                LetterEnt.GUARANTOR_PHONE = ""
                                LetterEnt.GUARANTOR_ADDR = ""
                                LetterEnt.GUARANTOR_NAME2 = ""
                                LetterEnt.GUARANTOR_ADDR2 = ""
                                LetterEnt.GUARANTOR_PHONE2 = ""
                                LetterEnt.LETTER_ORIG = ""
                                LetterEnt.NUMBER_ACCOUNT = ""
                                LetterEnt.NUMBER_BANK = ""
                                LetterEnt.TYPE_DOC = ""
                                LetterEnt.CREATE_DATE = Date.Now() & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now)
                                LetterEnt.UPDATE_DATE = ""
                            End If
                            With LetterEnt
                                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_S_LETTER_GUARDAR_DATOS", .LETTER_ID, .BANK_ID, .COMMENT, .STATUS_ACT, .STATUS_LAST, .PLACE_SHIP, .GUARANTOR_NAME, .GUARANTOR_PHONE, _
                                                          .GUARANTOR_ADDR, .GUARANTOR_NAME2, .GUARANTOR_ADDR2, .GUARANTOR_PHONE2, .LETTER_ORIG, .NUMBER_ACCOUNT, .NUMBER_BANK, .TYPE_DOC, _
                                                          .CREATE_DATE, .UPDATE_DATE)
                            End With
                        Next
                    End If
                End If
            Catch ex As Exception
                estado = False
            End Try
            Return estado
        End Function

        Public Function DocumentoLetrasAceptadas() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_ACEPTADAS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function DocumentoLetrasAceptadasPagos() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_ACEPTADAS_PAGOS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GeneracionCambioEstadoLetra(ByVal LETTER_ID As String, ByVal BANK_ID As String, ByVal COMMENT As String, _
                                                    ByVal STATUS_ACT As String, ByVal NUMBER_ACCOUNT As String, ByVal NUMBER_BANK As String, ByVal UPDATE_DATE As String, ByVal _opcion As String) As Boolean
            Dim estado As Boolean = True
            Try
                If _opcion = "cambio" Then
                    SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_CAMBIO_ESTADO_LETRA", LETTER_ID, BANK_ID, COMMENT, STATUS_ACT, NUMBER_ACCOUNT, NUMBER_BANK, UPDATE_DATE & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now))
                ElseIf _opcion = "actualizacion" Then
                    SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_ACTUALIZACION_ESTADO_LETRA", LETTER_ID, NUMBER_BANK)
                End If

            Catch ex As Exception
                estado = False
                Throw
            End Try
            Return estado
        End Function

        Public Function GeneracionCambioEstadoLetraPago(ByVal LETTER_ID As String, ByVal BANK_ID As String, ByVal COMMENT As String, _
                                                    ByVal STATUS_ACT As String, ByVal NUMBER_ACCOUNT As String, ByVal NUMBER_BANK As String, ByVal UPDATE_DATE As String, ByVal _opcion As String) As Boolean
            Dim estado As Boolean = True
            Try
                If _opcion = "cambio" Then
                    SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_CAMBIO_ESTADO_LETRA_PAY", LETTER_ID, BANK_ID, COMMENT, STATUS_ACT, NUMBER_ACCOUNT, NUMBER_BANK, UPDATE_DATE & " - " & String.Format("{0:HH:mm:ss}", DateTime.Now))
                ElseIf _opcion = "actualizacion" Then
                    SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_ACTUALIZACION_ESTADO_LETRA_PAY", LETTER_ID, NUMBER_BANK)
                End If

            Catch ex As Exception
                estado = False
                Throw
            End Try
            Return estado
        End Function

        Public Function VerificacionClienteVendedor(ByVal Consulta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function MostrandoClientesDocPendientes() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_REP_CLIENTES_PEND").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function MostrandoProveedoresDocPendientes() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_REP_CLIENTES_PEND_PAY").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function MostrandoVendedorDocPendientes() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_REP_VENDEDOR_PEND").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Function MostrandoClientesManejoDocumento() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_REP_CLIENTE_MANEJO_DOC").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function MostrandoClientesManejoDocumentoDetalles(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_REP_CLIENTE_MANEJO_DOC_DET", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function Get_ManualVendedor(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_VENDEDOR", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosAnticipos(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_AN_CUSTOMER_BALANCE", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function GuardandoCarteraClientes(ByVal EntidadCliente As ClsEntidades.CUSTOMER_BALANCE) As Boolean
            Try
                With EntidadCliente
                    SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_I_CUSTOMER_BALANCE", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOC_DATE, .CADUCATE_DATE, .DOCUMENT_REF, .NUMBER_REF, _
                        .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, .USER_ID, .ACCOUNT, _
                        .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, .BANK_DESCRIPTION, _
                        .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .CUST_AUTO, .SERIE_AUX, .NUM_DOC_AUX, .PERCENT_DETRAC, .AMOUNT_DETRAC, .SALDO)
                End With
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function VerificacionNumeracion(ByVal _CodigoCliente As String, ByVal _TipoDoc As String, ByVal _Numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_VERF_CODIGO", _CodigoCliente, _TipoDoc, _Numero).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function EliminacionPlanilla(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Try
                Dim res As Integer = 0
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_D_U_LETTER", _CodigoPlanilla, _Usuario)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function EliminacionPlanillaCheque(ByVal _CodigoPlanilla As String, ByVal _Usuario As String) As Boolean
            Try
                Dim res As Integer = 0
                SqlHelper.ExecuteNonQuery(cn, "CHEQUE_SP_D_U_CHECK", _CodigoPlanilla, _Usuario)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Public Function ActualizandoCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String, _
                                                    ByVal DOC_DATE As String, ByVal CADUCATE_DATE As String, ByVal SALES_ID As String, _
                                                    ByVal CURRENCY_ID As String, ByVal SELL_RATE As String, ByVal USER_ID As String, _
                                                    ByVal AMOUNT As Double, ByVal SALDO As Double) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_U_CUSTOMER_BALANCE", CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC, DOC_DATE, CADUCATE_DATE, SALES_ID, _
                                                                            CURRENCY_ID, SELL_RATE, USER_ID, AMOUNT, SALDO)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function EliminacionCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "LETRA_SP_D_CUSTOMER_BALANCE", CUSTOMER_ID, DOCUMENT_ID, NUMBER_DOC)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function



    End Class

    Public Class DOCUMENT_TYPE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub



        Public Function get_DocumentosNC() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT TYPE_ID AS 'COD', NAME AS 'DES' FROM DOCUMENT_TYPE WHERE TYPE_ID IN ('NC','CR')").Tables(0)
        End Function

        Public Function get_Documentos_CajaChica() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT TYPE_ID AS 'COD', NAME AS 'DES' FROM DOCUMENT_TYPE_CAJA_CHICA").Tables(0)
        End Function

        Public Function get_Conceptos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT TYPE_ID AS 'COD', NAME AS 'DES' FROM TRANSACTION_TYPE_CAJA_CHICA").Tables(0)
        End Function

        Public Function get_Personal() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT TYPE_ID AS 'COD', NAME AS 'DES' FROM PERSONAL").Tables(0)
        End Function

        Public Function get_Documentos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT TYPE_ID AS 'COD', NAME AS 'DES' FROM DOCUMENT_TYPE").Tables(0)
        End Function

        Public Function get_Tipo_Doc_Prov() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_DOCUMENT_TYPE_PERSON").Tables(0)
        End Function

        Public Function get_Documentos_xCmb() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT TYPE_ID AS 'COD',TYPE_ID + ' - ' + NAME AS 'DES' FROM DOCUMENT_TYPE order by 1").Tables(0)
        End Function

    End Class

    Public Class ACCOUNT_BANK
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.ACCOUNT_BANK)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_ACCOUNT_BANK", .BANK_ID, .ACCOUNT_BANK_ID, .ACCOUNT_BANK_DES, .NUMBER_ACCOUNT, _
                                          .CURRENCY_ID, .TYPE_DOC, .TYPE_ANNEX)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.ACCOUNT_BANK)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_ACCOUNT_BANK", .BANK_ID, .ACCOUNT_BANK_ID, .ACCOUNT_BANK_DES, .NUMBER_ACCOUNT, _
                                          .CURRENCY_ID, .TYPE_DOC, .TYPE_ANNEX)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.ACCOUNT_BANK)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_ACCOUNT_BANK", .BANK_ID, .ACCOUNT_BANK_ID)
            End With
        End Sub

        Public Function get_Cuentas_Corrientes(banco_ As String) As DataTable
            Dim query As String = "SELECT ACCOUNT_BANK_ID AS 'COD',ACCOUNT_BANK_DES+'-'+NUMBER_ACCOUNT+'-'+CURRENCY_ID AS 'DES' FROM ACCOUNT_BANK WHERE BANK_ID = '" & banco_ & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Cuentas_Corrientes_2(banco_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_ACCOUNT_BANK", banco_).Tables(0)
        End Function

    End Class


    Public Class ACCOUNT_BANK_PAY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.ACCOUNT_BANK_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_ACCOUNT_BANK_PAY", .BANK_ID, .ACCOUNT_BANK_ID, .ACCOUNT_BANK_DES, .NUMBER_ACCOUNT, .CURRENCY_ID, .TYPE_DOC)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.ACCOUNT_BANK_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_ACCOUNT_BANK_PAY", .BANK_ID, .ACCOUNT_BANK_ID, .ACCOUNT_BANK_DES, .NUMBER_ACCOUNT, .CURRENCY_ID, .TYPE_DOC)
            End With
        End Sub

        Public Sub Delete(entidad As ClsEntidades.ACCOUNT_BANK_PAY)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_ACCOUNT_BANK_PAY ", .BANK_ID, .ACCOUNT_BANK_ID)
            End With
        End Sub

        Public Function get_Cuentas_Corrientes(banco_ As String) As DataTable
            Dim query As String = "SELECT ACCOUNT_BANK_ID AS 'COD',ACCOUNT_BANK_DES+'-'+NUMBER_ACCOUNT+'-'+CURRENCY_ID AS 'DES' FROM ACCOUNT_BANK_PAY WHERE BANK_ID = '" & banco_ & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Cuentas_Corrientes_2(banco_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_ACCOUNT_BANK_PAY", banco_).Tables(0)
        End Function

    End Class


    Public Class BANK_PAY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function ConceptosCobranza() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "").Tables(0)
        End Function

        Public Sub Insert(entidad As ClsEntidades.BANK_PAY)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_BANK_PAY", entidad.ID, entidad.NAME, entidad.RECEIVE_ID)
        End Sub

        Public Sub Update(entidad As ClsEntidades.BANK_PAY)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_BANK_PAY ", entidad.ID, entidad.NAME, entidad.RECEIVE_ID)
        End Sub

        Public Sub Delete(entidad As ClsEntidades.BANK_PAY)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_BANK_PAY", entidad.ID)
        End Sub

        Public Function get_Bancos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_BANK_PAY").Tables(0)
        End Function

    End Class


    Public Class BANK
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function ConceptosCobranza() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "").Tables(0)
        End Function

        Public Sub Insert(entidad As ClsEntidades.BANK)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_BANK", entidad.ID, entidad.NAME, entidad.RECEIVE_ID)
        End Sub

        Public Sub Update(entidad As ClsEntidades.BANK)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_BANK", entidad.ID, entidad.NAME, entidad.RECEIVE_ID)
        End Sub

        Public Sub Delete(entidad As ClsEntidades.BANK)
            SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_BANK", entidad.ID)
        End Sub

        Public Function get_Bancos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_BANK").Tables(0)
        End Function

    End Class

    Public Class CUSTOMER_BALANCE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(entidad As ClsEntidades.CUSTOMER_BALANCE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_CUSTOMER_BALANCE", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOC_DATE, .CADUCATE_DATE, .DOCUMENT_REF, .NUMBER_REF, .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, .USER_ID, .ACCOUNT, .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, .BANK_DESCRIPTION, .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .CUST_AUTO, .SERIE_AUX, .NUM_DOC_AUX)
            End With
        End Sub

        Public Function get_Documentos_Pendientes_x_Clientes(ruc_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALDO_X_CLIENTE", ruc_).Tables(0)
        End Function

        Public Function get_Letras_x_Situacion(situacion As String, moneda As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_LETRAS_X_ESTADO", situacion, moneda).Tables(0)
        End Function

        Public Function get_Letras_x_Situacion_Grupal(situacion As String, moneda As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_LETRAS_X_ESTADO_GRUPAL", situacion, moneda).Tables(0)
        End Function

        Public Function get_Documentos_Pendientes_x_Clientes_Pago_Proveedores(ByVal Ruc As Boolean, ByVal _Filtro As String, Optional ByVal _Fecha As String = "") As DataTable
            If Ruc = True Then
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALDO_X_CLIENTE_PAY", _Filtro).Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALDO_X_CLIENTE_PAY_COMPROBANTE", _Filtro, _Fecha).Tables(0)
            End If
        End Function

        Public Function get_Documentos_Pendientes_x_Pago_Proveedores_x_fecha(ByVal _Fecha_ini As String, ByVal _Fecha_fin As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALDO_X_CLIENTE_PAY_X_FECHA", _Fecha_ini, _Fecha_fin).Tables(0)
        End Function
    End Class

    Public Class CUSTOMER
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub
        Public Function Ejecuta_consulta(ByVal _Cadena As String) As Boolean
            Dim Resultado As Integer = 0
            Try
                Resultado = SqlHelper.ExecuteNonQuery(cn, CommandType.Text, _Cadena)
                If Resultado = 1 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Public Function Validacion_Ruc_Proveedor(ByVal _ruc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PROV_SP_S_CONSULTA_RUC", _ruc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function
        Public Function Validacion_Ruc(ByVal _ruc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CONSULTA_RUC", _ruc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function Validacion_Ruc_Principal(ByVal _ruc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CONSULTA_RUC_PRINC", _ruc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function



        Public Function ValidacionCliente(ByVal _codigo As String, ByVal _ruc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_VERIF_RUC", _codigo, _ruc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function



        Public Sub Insert(entidad As ClsEntidades.CUSTOMER)
            Try
                With entidad   'CX_SP_I_CUSTOMER
                    SqlHelper.ExecuteNonQuery(cn, "CLI_SP_I_CUSTOMER_II", .ID, .NAME, .ADDR, .PHONE, .VAT_REGISTRATION, .NUMBER_DOC, .DISCOUNT_PERCENT, _
                                            .TERMS_TYPE, .STATUS, .OPEN_DATE, .CONTACT, .STATE_ID, .CREATE_USER, .CREATE_DATE, .MODIFY_DATE, .TYPE_PRICE, _
                                            .SALES_ID, .SELL_ZONE, .COUNTRY, .DEPARTMENT, .PROVINCE, .ADDR_DLV, .CURRENCY_CREDIT_LIMIT, .CREDIT_LIMIT_US, _
                                            .CREDIT_LIMIT, .BALANCE, .BALANCE_US, .OBSERV, .TOTAL_LETTER, .TOTAL_RECEIVABLE, .TOTAL_CHECK, .TOTAL_LETTER_PROTESTED, _
                                            .CUSTOMER_TYPE, .BUSINESS_TYPE, .TERRITORY, .ROUTE, .SEGMENT, .SEGMENT_LOCATION, .BANK_ID, .ACCOUNT_NO, .DATE_REVIEW, _
                                            .HOUR_VISIT, .ATTENTION_TYPE, .FAX_NUMBER, .EMAIL, .WEBSITE, .COMMENT, .IS_PRIMARY, .RETENTION, .DOCUMENT_TYPE_PERSON_ID, _
                                            .TYPE_COMPANY, .ACCOUNT_LOCAL, .ACCOUNT_EXTERNAL, .TYPE_DISCOUNT, .NAME_COMERTIAL, .FLAG_PRINCIPAL)
                    If .FLAG_PRINCIPAL = "1" Then
                        SqlHelper.ExecuteNonQuery(cn, "CLI_SP_U_TIPO_CLIENTE", .VAT_REGISTRATION)
                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

        Public Sub Update(entidad As ClsEntidades.CUSTOMER)
            With entidad   'CX_SP_U_CUSTOMER
                SqlHelper.ExecuteNonQuery(cn, "CLI_SP_U_CUSTOMER_II", .ID, .NAME, .ADDR, .PHONE, .VAT_REGISTRATION, .NUMBER_DOC, .DISCOUNT_PERCENT, .TERMS_TYPE, .STATUS, .OPEN_DATE, _
                                        .CONTACT, .STATE_ID, .CREATE_USER, .CREATE_DATE, .MODIFY_DATE, .TYPE_PRICE, .SALES_ID, .SELL_ZONE, .COUNTRY, .DEPARTMENT, .PROVINCE, _
                                        .ADDR_DLV, .CURRENCY_CREDIT_LIMIT, .CREDIT_LIMIT_US, .CREDIT_LIMIT, .BALANCE, .BALANCE_US, .OBSERV, .TOTAL_LETTER, .TOTAL_RECEIVABLE, _
                                        .TOTAL_CHECK, .TOTAL_LETTER_PROTESTED, .CUSTOMER_TYPE, .BUSINESS_TYPE, .TERRITORY, .ROUTE, .SEGMENT, .SEGMENT_LOCATION, .BANK_ID, _
                                        .ACCOUNT_NO, .DATE_REVIEW, .HOUR_VISIT, .ATTENTION_TYPE, .FAX_NUMBER, .EMAIL, .WEBSITE, .COMMENT, .IS_PRIMARY, .RETENTION, _
                                        .DOCUMENT_TYPE_PERSON_ID, .TYPE_COMPANY, .ACCOUNT_LOCAL, .ACCOUNT_EXTERNAL, .TYPE_DISCOUNT, .NAME_COMERTIAL, .FLAG_PRINCIPAL)
                If .FLAG_PRINCIPAL = "1" Then
                    SqlHelper.ExecuteNonQuery(cn, "CLI_SP_U_TIPO_CLIENTE", .VAT_REGISTRATION)
                End If
            End With

        End Sub

        Public Sub Delete(entidad As ClsEntidades.CUSTOMER)
            SqlHelper.ExecuteDataset(cn, "CX_SP_D_CUSTOMER_XID", entidad.ID)
        End Sub

        Public Function get_Clientes_mt() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CUSTOMER").Tables(0)
        End Function


        Public Function GeneracionCodigoCliente(ByVal _TipoCliente As String, ByVal _Departamento As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_CUSTOMER_CODIGO", _TipoCliente, _Departamento).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function get_Clientes() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT ID as 'CI_ID',NAME as 'CI_NAME' FROM CUSTOMER ORDER BY NAME").Tables(0)
        End Function

        Public Function get_Clientes_ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CUSTOMER_AYU").Tables(0)
        End Function

        Public Sub get_Clientes_x_DocPer(ByRef entidad As ClsEntidades.CUSTOMER)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CX_SP_S_CUSTOMER_XID", entidad.ID)
            If drr.HasRows Then
                drr.Read()
                With entidad
                    .NAME = drr("NAME").ToString
                    .ADDR = drr("ADDR").ToString
                    .PHONE = drr("PHONE").ToString
                    .VAT_REGISTRATION = drr("VAT_REGISTRATION").ToString
                    .NUMBER_DOC = drr("NUMBER_DOC").ToString
                    .DISCOUNT_PERCENT = drr("DISCOUNT_PERCENT")
                    .TERMS_TYPE = drr("TERMS_TYPE").ToString
                    .STATUS = drr("STATUS").ToString
                    .OPEN_DATE = drr("OPEN_DATE").ToString
                    .CONTACT = drr("CONTACT").ToString
                    .STATE_ID = drr("STATE_ID").ToString
                    .CREATE_USER = drr("CREATE_USER").ToString
                    .CREATE_DATE = drr("CREATE_DATE").ToString
                    .MODIFY_DATE = drr("MODIFY_DATE").ToString
                    .TYPE_PRICE = drr("TYPE_PRICE").ToString
                    .SALES_ID = drr("SALES_ID").ToString
                    .SELL_ZONE = drr("SELL_ZONE").ToString
                    .COUNTRY = drr("COUNTRY").ToString
                    .DEPARTMENT = drr("DEPARTMENT").ToString
                    .PROVINCE = drr("PROVINCE").ToString
                    .ADDR_DLV = drr("ADDR_DLV").ToString
                    .CURRENCY_CREDIT_LIMIT = drr("CURRENCY_CREDIT_LIMIT").ToString
                    .CREDIT_LIMIT_US = IIf(String.IsNullOrEmpty(drr("CREDIT_LIMIT_US").ToString), 0, drr("CREDIT_LIMIT_US"))
                    .CREDIT_LIMIT = IIf(String.IsNullOrEmpty(drr("CREDIT_LIMIT").ToString), 0, drr("CREDIT_LIMIT"))
                    .BALANCE = IIf(String.IsNullOrEmpty(drr("BALANCE").ToString), 0, drr("BALANCE"))
                    .BALANCE_US = IIf(String.IsNullOrEmpty(drr("BALANCE_US").ToString), 0, drr("BALANCE_US"))
                    .OBSERV = drr("OBSERV").ToString
                    .TOTAL_LETTER = drr("TOTAL_LETTER")
                    .TOTAL_RECEIVABLE = drr("TOTAL_RECEIVABLE")
                    .TOTAL_CHECK = drr("TOTAL_CHECK")
                    .TOTAL_LETTER_PROTESTED = drr("TOTAL_LETTER_PROTESTED")
                    .CUSTOMER_TYPE = drr("CUSTOMER_TYPE").ToString
                    .BUSINESS_TYPE = drr("BUSINESS_TYPE").ToString
                    .TERRITORY = drr("TERRITORY").ToString
                    .ROUTE = drr("ROUTE").ToString
                    .SEGMENT = drr("SEGMENT").ToString
                    .SEGMENT_LOCATION = drr("SEGMENT_LOCATION").ToString
                    .BANK_ID = drr("BANK_ID").ToString
                    .ACCOUNT_NO = drr("ACCOUNT_NO").ToString
                    .DATE_REVIEW = drr("DATE_REVIEW").ToString
                    .HOUR_VISIT = drr("HOUR_VISIT").ToString
                    .ATTENTION_TYPE = drr("ATTENTION_TYPE").ToString
                    .FAX_NUMBER = drr("FAX_NUMBER").ToString
                    .EMAIL = drr("EMAIL").ToString
                    .WEBSITE = drr("WEBSITE").ToString
                    .COMMENT = drr("COMMENT").ToString
                    .IS_PRIMARY = drr("IS_PRIMARY").ToString
                    .RETENTION = drr("RETENTION").ToString
                    .DOCUMENT_TYPE_PERSON_ID = drr("DOCUMENT_TYPE_PERSON_ID").ToString
                    .TYPE_COMPANY = drr("TYPE_COMPANY").ToString
                    .ACCOUNT_LOCAL = drr("ACCOUNT_LOCAL").ToString
                    .ACCOUNT_EXTERNAL = drr("ACCOUNT_EXTERNAL").ToString
                    .TYPE_DISCOUNT = drr("TYPE_DISCOUNT").ToString
                    .NAME_COMERTIAL = drr("NAME_COMERTIAL").ToString
                    .FLAG_PRINCIPAL = drr("FLAG_PRINCIPAL").ToString
                End With
                entidad.HasRows = True
            End If
            drr.Close()
        End Sub

    End Class

    Public Class RECEIVABLE_LIST
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function EliminarPlanilla(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_D_PLANILLA_DATOS", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function
        Public Sub Eliminar_CajaChica(ByVal _id As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "CCAJA_CHICA_SP_D_PLANILLA_DATOS", _id)

                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function VerificarCuentaContableCliente(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function VerificarCuentaContableClienteTipoDoc(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C_CONTAB", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function VerificarCuentaContableEstadoInicialletra(ByVal Codigo As String, ByVal Moneda As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_STATUS_LETTER_C_C", Codigo, Moneda).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function



        Public Function DatosAsientoCabecera(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_CABECERA_ASIENTO", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function DatosAsientoDetalle(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_DETALLE_ASIENTO", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function ManualClienteCodigo(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CLIENTES_CODIGO_MANUAL", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function ManualClienteRuc(ByVal Ruc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CLIENTES_RUC_MANUAL", Ruc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function ManualTipoDocumento(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TIPO_DOC_M", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Sub Insert(entidad As ClsEntidades.RECEIVABLE_LIST, bol_nuevo As Boolean, ByRef numero As String)

            'obtenemos el id de la planilla ,
            If bol_nuevo Then
                entidad.ID = SqlHelper.ExecuteScalar(cn, "CX_SP_S_RECEIVABLE_ID") ''   , entidad.DATE_PLA)
            End If
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_RECEIVABLE_LIST", .ID, .DATE_PLA, .AMOUNT, .AMOUNT_US, .AMOUNT_CH_DIF, .AMOUNT_CH_DIF_US, .VOUCHER_ID, .STATUS, .CREATE_DATE, .USER_ID, .SALES_ID, .VOUCHER_ID_US, .SELL_RATE)
            End With
            numero = entidad.ID
        End Sub

        Public Function Obtener_correlativo_CajaChica(ByVal correlativo As String) As String

            correlativo = SqlHelper.ExecuteScalar(cn, "CX_SP_S_RECEIVABLE_CAJA_CHICA_ID") ''   , entidad.DATE_PLA)
            Return correlativo
        End Function

        Public Sub InsertCajaChica(entidad As ClsEntidades.RECEIVABLE_CAJA_CHICA, bol_nuevo As Boolean, ByRef numero As String)

            'obtenemos el id de la planilla ,
            If bol_nuevo Then
                entidad.ID = SqlHelper.ExecuteScalar(cn, "CX_SP_S_RECEIVABLE_CAJA_CHICA_ID") ''   , entidad.DATE_PLA)
            End If
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_RECEIVABLE_CAJA_CHICA", .ID, .DATE_PLA, .AMOUNT, .AMOUNT_US, .AMOUNT_CH_DIF, .AMOUNT_CH_DIF_US, .VOUCHER_ID, .STATUS, .CREATE_DATE, .USER_ID, .SALES_ID, .VOUCHER_ID_US, .SELL_RATE, .SALDO_INICIAL, .INGRESOS, .EGRESOS, .SALDO_FINAL, .SALDO_INICIAL_ME, .INGRESOS_ME, .EGRESOS_ME, .SALDO_FINAL_ME)
            End With
            numero = entidad.ID
        End Sub

        Public Function get_planilla_x_fecha(fecha1 As String, fecha2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_RECEIVABLE_XDATE", fecha1, fecha2).Tables(0)
        End Function

        Public Function get_planilla_x_fecha_caja_chica(fecha1 As String, fecha2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_RECEIVABLE_CAJA_CHICA_XDATE", fecha1, fecha2).Tables(0)
        End Function

        Public Function get_Ult_num_voucher(subd_ As String, ayo_ As Integer, mes_ As String) As String
            Dim Correlativo As String = String.Empty
            Try
                Correlativo = SqlHelper.ExecuteScalar(cn, "CO_SP_S_CORRELATIVO", subd_, ayo_, mes_)
                Correlativo = mes_ & Correlativo
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Correlativo
        End Function




        Public Function DetallesLetras(ByVal ID_PLANILLA As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_LETRAS_DET", ID_PLANILLA).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function


        Public Function Contabilizar_Caja_Letra(ByVal Cod_planilla As String, ByVal DT_DATOS_ASIENTO As DataTable, ByVal _Numero As String, ByVal _Fecha As Date) As Boolean
            Dim estado As Boolean = True
            Try
                Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
                Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

                With cab
                    .AC_ID = 0
                    .AC_IDSUBDIARIO = "09"
                    .AC_NUM_VOUCHER = _Numero
                    .AC_ANHO = _Fecha.Year
                    .AC_MES = _Fecha.Month
                    .AC_FEC_VOUCHER = Date.Now()
                    .AC_IDMONEDA = 1
                    .AC_DEBE = DT_DATOS_ASIENTO.Compute("sum(AD_DEBE)", "")
                    .AC_HABER = DT_DATOS_ASIENTO.Compute("sum(AD_HABER)", "")
                    .AC_ESTADO = 2
                    .AC_GLOSA_VOU = "ACEPTACION DE LETRAS"
                    .AC_ES_INTERFACE = 1
                    .AC_IDPLANILLA = ""
                    .AC_ID_LETRA = Cod_planilla
                End With
                '________________________________________ D E T A L L E S _____________________________________

                Dim monto As Double = 0
                Dim mon As Integer = 1
                Dim tc As Double = 0
                Dim cta12_Clientes As String = "1231"
                Dim Is_orig As String = String.Empty

                'Recorremos de la planilla

                If DT_DATOS_ASIENTO.Rows.Count() <> 0 Then
                    For j As Integer = 0 To DT_DATOS_ASIENTO.Rows.Count - 1
                        '//_________ C U E N T A  12   D E  C L I E N T E S _____________)_________________
                        ' //buscamos la cuenta contable
                        detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = j + 1
                        detalle.AD_CUENTA = DT_DATOS_ASIENTO.Rows(j)("AD_CUENTA").ToString()
                        detalle.AD_TANEXO = DT_DATOS_ASIENTO.Rows(j)("AD_TANEXO").ToString()
                        detalle.AD_IDANEXO = DT_DATOS_ASIENTO.Rows(j)("AD_IDANEXO").ToString()
                        detalle.AD_TDOC = DT_DATOS_ASIENTO.Rows(j)("AD_TDOC").ToString()
                        detalle.AD_SDOC = DT_DATOS_ASIENTO.Rows(j)("AD_SDOC").ToString()
                        detalle.AD_NDOC = DT_DATOS_ASIENTO.Rows(j)("AD_NDOC").ToString()
                        detalle.AD_FDOC = DT_DATOS_ASIENTO.Rows(j)("AD_FDOC").ToString()
                        detalle.AD_VDOC = DT_DATOS_ASIENTO.Rows(j)("AD_VDOC").ToString()
                        detalle.AD_DEBE = Math.Abs(Math.Round(DT_DATOS_ASIENTO.Rows(j)("AD_DEBE"), 3))
                        detalle.AD_HABER = Math.Abs(Math.Round(DT_DATOS_ASIENTO.Rows(j)("AD_HABER"), 3))
                        detalle.AD_TCAM = DT_DATOS_ASIENTO.Rows(j)("AD_TCAM").ToString()
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(DT_DATOS_ASIENTO.Rows(j)("AD_MONTO_ORI"), 3)
                        detalle.AD_PORCE_DESTINO = 0
                        detalle.AD_ES_CONCI = 0
                        detalle.AD_ANHO_CONI = 0
                        detalle.AD_MES_CONCI = 0
                        detalle.AD_ES_INAFECTO = 0
                        detalle.AD_IDMONEDA = DT_DATOS_ASIENTO.Rows(j)("AD_IDMONEDA").ToString()
                        detalle.AD_TDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_TDOC_REF").ToString()
                        detalle.AD_SDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_SDOC_REF").ToString()
                        detalle.AD_NDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_NDOC_REF").ToString()
                        detalle.AD_FDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_FDOC_REF").ToString()
                        detalle.AD_VDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_VDOC_REF").ToString()
                        detalle.AD_GLOSA = ""
                        ls_det.Add(detalle)
                    Next
                    Guardar_Contabilizar_Caja_Cobranzas(cab, ls_det, False)
                Else
                    MsgBox("La planilla no posee registros para llevar a Contabilidad.", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                estado = False
            End Try
            Return estado
        End Function



        Public Function Contabilizar_Caja_Cobranzas(ByVal ID_PLANILLA As String, ByVal Fecha As Date, ByVal NUMERACION As String) As Boolean
            Dim _ESTADO As Boolean = True
            Try
                If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_PLANILLA", "03", ID_PLANILLA) = 0 Then
                    Dim total_movi As Double = 0
                    Dim dic_cta10 As New Dictionary(Of String, Double)
                    Dim dic_cta10_ori As New Dictionary(Of String, Double)

                    Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
                    Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                    Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "03"
                        .AC_NUM_VOUCHER = NUMERACION
                        .AC_ANHO = Fecha.Year
                        .AC_MES = Format(Fecha.Month, "00")
                        .AC_FEC_VOUCHER = Fecha
                        .AC_IDMONEDA = 1
                        .AC_DEBE = 0
                        .AC_HABER = 0
                        .AC_ESTADO = 1
                        .AC_GLOSA_VOU = "PLANILLA DE COBRANZA : " & ID_PLANILLA & ""
                        .AC_ES_INTERFACE = 1
                        .AC_IDPLANILLA = ID_PLANILLA
                        .AC_ID_LETRA = ""
                    End With
                    '________________________________________ D E T A L L E S _____________________________________

                    Dim monto As Double = 0
                    Dim mon As Integer = 1
                    Dim tc As Double = 0
                    Dim cta12_Clientes As String = "121201"

                    'Recorremos de la planilla
                    Dim dt_detalles As DataTable
                    dt_detalles = New DataTable

                    Dim dtTipoCamb As New DataTable
                    Dim dtTipoAnex As New DataTable
                    Dim _Consulta As String = String.Empty
                    Dim _TipoCambio_Ref As Double = 0.0
                    Dim FechaIngr As Date

                    dt_detalles = SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA_ING_DET", ID_PLANILLA).Tables(0)
                    If dt_detalles.Rows.Count() <> 0 Then
                        For j As Integer = 0 To dt_detalles.Rows.Count - 1
                            ' //_________ C U E N T A  10   D E  C A J A ______________________________
                            Dim _CodigoCliente As String = String.Empty
                            Dim _CuentaCliente As String = String.Empty
                            Dim Dtverificar As New DataTable
                            _CodigoCliente = dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString()
                            monto = (Double.Parse(dt_detalles.Rows(j)("AMOUNT").ToString()))
                            detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                            mon = 1

                            _TipoCambio_Ref = dt_detalles.Rows(j)("SELL_RATE").ToString()
                            cta12_Clientes = _CuentaCliente
                            If dic_cta10.ContainsKey(dt_detalles.Rows(j)("ACCOUNT").ToString()) Then
                                dic_cta10(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(IIf(mon = 1, monto, monto * _TipoCambio_Ref), 2)
                                dic_cta10_ori(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(monto, 2)
                            Else
                                dic_cta10.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(IIf(mon = 1, monto, monto * _TipoCambio_Ref), 2))
                                dic_cta10_ori.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(monto, 2))
                            End If
                            detalle.AD_IDCAB = 0
                            detalle.AD_SECUENCIA = ls_det.Count + 1
                            detalle.AD_CUENTA = dt_detalles.Rows(j)("ACCOUNT").ToString()

                            _Consulta = String.Empty
                            _Consulta = "SELECT ISNULL(PC_IDTIPO_ANEXO,0) [PC_IDTIPO_ANEXO]  FROM CO_TB_PLANCTAS WHERE PC_NUM_CTA ='" & dt_detalles.Rows(j)("ACCOUNT").ToString() & "'"
                            dtTipoAnex = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                            If dtTipoAnex.Rows.Count() <> 0 Then
                                detalle.AD_TANEXO = dtTipoAnex.Rows(0).Item("PC_IDTIPO_ANEXO")
                            Else
                                detalle.AD_TANEXO = 0
                            End If
                            detalle.AD_IDANEXO = dt_detalles.Rows(j)("TYPE_ANNEX").ToString()
                            detalle.AD_TDOC = dt_detalles.Rows(j)("DOC_REF").ToString()
                            detalle.AD_SDOC = ""
                            detalle.AD_NDOC = dt_detalles.Rows(j)("NUM_REF").ToString()
                            detalle.AD_FDOC = Fecha
                            detalle.AD_VDOC = ""
                            '''''                        
                            If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" Then
                                detalle.AD_DEBE = monto
                                detalle.AD_HABER = 0
                            Else
                                detalle.AD_DEBE = Math.Round(monto * _TipoCambio_Ref, 2)
                                detalle.AD_HABER = 0
                            End If
                            ''''''
                            detalle.AD_TCAM = Val(dt_detalles.Rows(j)("SELL_RATE").ToString)
                            detalle.AD_SEC_ORI_DES = 0
                            detalle.AD_IDCC = ""
                            detalle.AD_ES_DESTINO = 0
                            detalle.AD_IDMEDIOPAGO = ""
                            detalle.AD_MONTO_ORI = IIf(dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN", Math.Abs(monto), Math.Abs(monto)) 'detalle.AD_HABER)
                            detalle.AD_PORCE_DESTINO = 0
                            detalle.AD_ES_CONCI = 0
                            detalle.AD_ANHO_CONI = 0
                            detalle.AD_MES_CONCI = 0
                            detalle.AD_ES_INAFECTO = 0
                            detalle.AD_IDMONEDA = 1
                            detalle.AD_TDOC_REF = ""
                            detalle.AD_SDOC_REF = ""
                            detalle.AD_NDOC_REF = ""
                            detalle.AD_FDOC_REF = ""
                            detalle.AD_VDOC_REF = ""
                            detalle.AD_GLOSA = ""
                            ls_det.Add(detalle)
                            total_movi += detalle.AD_DEBE + detalle.AD_HABER

                            '//_________ C U E N T A  12   D E  C L I E N T E S ______________________________

                            Dim ruc As String = dt_detalles.Rows(j)("VAT_REGISTRATION").ToString()
                            Dim tdoc As String = dt_detalles.Rows(j)("DOCUMET_ID").ToString()
                            Dim sdoc As String = dt_detalles.Rows(j)("NUMBER_SERIE").ToString()
                            Dim ndoc As String = dt_detalles.Rows(j)("NUMBER_DOCUMENT").ToString()
                            Dim subd As String = "02" '//ventas
                            Dim tanexo As Integer = 1 '//clientes

                            If dt_detalles.Rows(j)("TYPE_DOC").ToString().Equals("HO") Then
                                subd = "02"
                                tanexo = 1
                            End If
                            ' //buscamos la cuenta contable
                            Dim drrr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CO_SP_S_CTA_PROVISION", subd, ruc, tdoc, sdoc, ndoc)
                            If drrr.HasRows Then
                                drrr.Read()
                                cta12_Clientes = drrr("RESULTADO").ToString()
                            End If
                            drrr.Close()
                            If cta12_Clientes.Equals(String.Empty) Then cta12_Clientes = _CuentaCliente
                            detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                            detalle.AD_IDCAB = 0
                            detalle.AD_SECUENCIA = ls_det.Count + 1
                            detalle.AD_CUENTA = cta12_Clientes
                            detalle.AD_TANEXO = tanexo
                            detalle.AD_IDANEXO = ruc
                            detalle.AD_TDOC = tdoc
                            detalle.AD_SDOC = sdoc.PadLeft(5, Char.Parse("0"))
                            detalle.AD_NDOC = ndoc.PadLeft(15, Char.Parse("0"))

                            'otengo la cuenta de la letra
                            If tdoc = "LT" Then
                                detalle.AD_SDOC = "000"
                                detalle.AD_NDOC = dt_detalles.Rows(j)("NUMBER_DOC").ToString()
                                _Consulta = "SELECT B.ACCOUNT FROM dbo.LETTER A INNER JOIN dbo.STATUS_LETTER B ON A.STATUS_LAST=B.STATUS_ID INNER JOIN DBO.CUSTOMER_BALANCE C ON A.LETTER_ID=C.NUMBER_DOC AND C.DOCUMENT_ID='LT' AND B.CURRENCY_ID=C.CURRENCY_ID WHERE LETTER_ID='" & detalle.AD_NDOC & "'"
                                dtTipoCamb = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                                If dtTipoCamb.Rows.Count > 0 Then
                                    detalle.AD_CUENTA = dtTipoCamb.Rows(0).Item("ACCOUNT").ToString
                                Else
                                    MsgBox("Debe configurar la cuenta del estado de la letra que desea contabilizar.", MsgBoxStyle.Critical, "Sistemas")
                                    _ESTADO = False
                                    Exit Function
                                End If
                                dtTipoCamb.Clear()
                                dtTipoCamb = Nothing
                            Else
                                If tdoc = "AN" Then
                                    dtTipoCamb = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C_AN", tdoc, dt_detalles.Rows(j)("CURRENCY_ID").ToString()).Tables(0)
                                    If dtTipoCamb.Rows.Count <> 0 Then
                                        detalle.AD_CUENTA = dtTipoCamb.Rows(0).Item("ACCOUNT").ToString
                                    Else
                                        MsgBox("Debe configurar la cuenta para el documento " + tdoc + " que desea contabilizar.", MsgBoxStyle.Critical, "Sistemas")
                                        _ESTADO = False
                                        Exit Function
                                    End If
                                    dtTipoCamb.Clear()
                                    dtTipoCamb = Nothing
                                ElseIf tdoc <> "CP" Then
                                    dtTipoCamb = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C_CONTAB", _CodigoCliente).Tables(0)
                                    If dtTipoCamb.Rows.Count <> 0 Then
                                        detalle.AD_CUENTA = dtTipoCamb.Rows(0).Item("ACCOUNT").ToString
                                    Else
                                        MsgBox("Debe configurar la cuenta para el Cliente " + tdoc + " que desea contabilizar.", MsgBoxStyle.Critical, "Sistemas")
                                        _ESTADO = False
                                        Exit Function
                                    End If
                                    dtTipoCamb.Clear()
                                    dtTipoCamb = Nothing
                                Else
                                    dtTipoCamb = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C", tdoc).Tables(0)
                                    If dtTipoCamb.Rows.Count <> 0 Then
                                        detalle.AD_CUENTA = dtTipoCamb.Rows(0).Item("ACCOUNT").ToString
                                    Else
                                        MsgBox("Debe configurar la cuenta para el documento " + tdoc + " que desea contabilizar.", MsgBoxStyle.Critical, "Sistemas")
                                        _ESTADO = False
                                        Exit Function
                                    End If
                                    dtTipoCamb.Clear()
                                    dtTipoCamb = Nothing
                                End If
                            End If
                            
                            'fin de la otengo la cuenta de la letra

                            detalle.AD_FDOC = ""
                            detalle.AD_VDOC = ""
                            _Consulta = "SELECT * FROM dbo.CUSTOMER_BALANCE WHERE CUSTOMER_ID='" & dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString & "' AND DOCUMENT_ID='" & dt_detalles.Rows(j)("TYPE_DOC").ToString & "' AND	NUMBER_DOC='" & dt_detalles.Rows(j)("NUMBER_DOC").ToString & "'"
                            dtTipoCamb = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                            If tdoc = "NC" Then
                                If dt_detalles.Rows(j)("CURRENCY_ID").ToString = dtTipoCamb.Rows(0).Item("CURRENCY_ID") Then
                                    'detalle.AD_DEBE = Math.Abs(monto)
                                    'detalle.AD_HABER = 0
                                    'detalle.AD_MONTO_ORI = monto
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" Then
                                        detalle.AD_DEBE = Math.Abs(monto)
                                        detalle.AD_HABER = 0
                                        detalle.AD_MONTO_ORI = monto
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" Then
                                        monto = ((monto * dtTipoCamb.Rows(0).Item("SELL_RATE"))) '_TipoCambio_Ref))
                                        detalle.AD_DEBE = Math.Abs(monto)
                                        detalle.AD_HABER = 0
                                        detalle.AD_MONTO_ORI = monto
                                    End If
                                Else
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "ME" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto / IIf(_TipoCambio_Ref = 0, 1, _TipoCambio_Ref))) * CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString)
                                        detalle.AD_DEBE = Math.Abs(monto)
                                        detalle.AD_HABER = 0
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "MN" Then
                                        detalle.AD_MONTO_ORI = monto
                                        'monto = ((monto * _TipoCambio_Ref)) / IIf(CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString) = 0, 1, CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString))
                                        monto = ((monto)) * IIf(CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString) = 0, 1, CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString))
                                        detalle.AD_DEBE = Math.Abs(monto)
                                        detalle.AD_HABER = 0
                                    End If
                                End If
                            Else
                                If dt_detalles.Rows(j)("CURRENCY_ID").ToString = dtTipoCamb.Rows(0).Item("CURRENCY_ID") Then
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" Then
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = monto
                                        detalle.AD_MONTO_ORI = monto
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" Then
                                        monto = ((monto * dtTipoCamb.Rows(0).Item("SELL_RATE")))
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = monto
                                        detalle.AD_MONTO_ORI = monto
                                    End If
                                Else
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "ME" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto / IIf(_TipoCambio_Ref = 0, 1, _TipoCambio_Ref))) * CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString)
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = monto
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "MN" Then
                                        detalle.AD_MONTO_ORI = monto
                                        'monto = ((monto * _TipoCambio_Ref)) / IIf(CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString) = 0, 1, CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString))
                                        monto = ((monto)) * IIf(CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString) = 0, 1, CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString))
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = monto
                                    End If
                                End If
                            End If

                            detalle.AD_TCAM = CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString)
                            detalle.AD_SEC_ORI_DES = 0
                            detalle.AD_IDCC = ""
                            detalle.AD_ES_DESTINO = 0
                            detalle.AD_IDMEDIOPAGO = ""

                            detalle.AD_PORCE_DESTINO = 0
                            detalle.AD_ES_CONCI = 0
                            detalle.AD_ANHO_CONI = 0
                            detalle.AD_MES_CONCI = 0
                            detalle.AD_ES_INAFECTO = 0
                            detalle.AD_IDMONEDA = mon
                            detalle.AD_TDOC_REF = ""
                            detalle.AD_SDOC_REF = ""
                            detalle.AD_NDOC_REF = ""
                            detalle.AD_FDOC_REF = ""
                            detalle.AD_VDOC_REF = ""
                            detalle.AD_GLOSA = ""
                            ls_det.Add(detalle)
                        Next
                        '//ACTUALIZAMOS LOS TOTALES
                        cab.AC_DEBE = total_movi
                        cab.AC_HABER = total_movi
                        '//Grabamos el voucher por ID planilla
                        Guardar_Contabilizar_Caja_Cobranzas(cab, ls_det, False)
                    Else
                        MsgBox("La planilla no posee registros para llevar a Contabilidad.", MsgBoxStyle.Critical)
                        _ESTADO = False
                    End If
                Else
                    MsgBox("El documento ya fue enviado a  Contabilidad.", MsgBoxStyle.Information)
                    _ESTADO = False
                End If
            Catch ex As Exception
                _ESTADO = False
                MsgBox(ex.Message)
            End Try
            Return _ESTADO
        End Function


        Public Function Guardar_Contabilizar_Caja_Cobranzas(ByRef c As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB, ld As List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET), edicion_ As Boolean)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                If edicion_ Then
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_D_ASIENTO_CAB", c.AC_ID, c.AC_IDSUBDIARIO, c.AC_ANHO, c.AC_MES)
                End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CAB", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_ID_LETRA)
                c.AC_ID = idcab

                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ld

                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Guardar_Contabilizar_Caja_Cobranzas_cambio_Estado(ByRef c As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB, _
                                                                          ld As List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET))
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CAB", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_ID_LETRA)
                c.AC_ID = idcab

                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ld

                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Function


    End Class

    Public Class RECEIVABLE_LIST_LINE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub
        Public Function get_validar_personal_pendiente_a_rendir(num_personal As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCHICA_SP_S_RECEIVABLE_LINE_CAJA_CHICA_DET_VALIDA_RENDICION", num_personal).Tables(0)
        End Function
        Public Sub Conformidad_CajaChica(ByVal _id As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_CERRAR_RECEIVABLE_CAJA_CHICA_CONFORMIDAD", _id)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Actualizacion_CajaChica_Rendicion(ls_det As List(Of ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA))
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_U_RECEIVABLE_LINE_CAJA_CHICA_RENDICION", .ID, .ITEM, .USUARIO_DOC_RENDICION, .TERMINAL_DOC_RENDICION, .STATUS, .TYPE_DOC_RENDICION, .SERIE_DOC_RENDICION, .NUMERO_DOC_RENDICION, .FECHA_DOC_RENDICION, .OBS_DOC_RENDICION, .COD_PROV_RENDICION)
                    End With
                Next

                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function VerificandoBancodeCuenta(ByVal _cuenta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CUENTA_BANCO", _cuenta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function
        Public Function VerificandoBancodeCuentaPago(ByVal _cuenta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CUENTA_BANCO_PAGO", _cuenta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function EliminarDetallesPlanillas(ByVal CodPlanilla As String, ByVal itemDoc As String, ByVal Tipodoc As String, ByVal numdoc As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_PLANILLA_DETALLES", CodPlanilla, itemDoc, Tipodoc, numdoc)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function MostrandoDescripcion(ByVal Consulta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Sub Insert(ls_det As List(Of ClsEntidades.RECEIVABLE_LIST_LINE), ByVal MonedaCobranza As String, ByVal FECHA_PLANILLA As Date)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                If ls_det.Count = 0 Then Exit Sub
                Dim query As String = "SELECT ISNULL(MAX(CONVERT(INT,ITEM)),0) FROM RECEIVABLE_LIST_LINE WHERE ID = '" & ls_det(0).ID & "' "

                Dim LastItem As Integer = SqlHelper.ExecuteScalar(tr, CommandType.Text, query)
                'Grabamos los detalles
                '++++++++
                Dim _TipoCambio_Ref As String = String.Empty
                Dim _Consulta As String = String.Empty
                Dim sSQLHistLet As String = String.Empty
                Dim sSQLLetra As String = String.Empty
                Dim dtTipoCamb As DataTable, dtletras As DataTable, dt_detalle As DataTable
                dtTipoCamb = New DataTable
                dtletras = New DataTable

                For Each d As ClsEntidades.RECEIVABLE_LIST_LINE In ls_det
                    With d
                        LastItem += 1
                        If .TYPE_DOC <> "NC" Then
                            .AMOUNT = .AMOUNT
                        Else
                            .AMOUNT = (Math.Abs(.AMOUNT)) * -1
                        End If
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_RECEIVABLE_LIST_LINE", .ID, Format(LastItem, "000"), .TYPE_DOC, .NUMBER_DOC, .TYPE_OPERATION, .REC_ID, .DATE_PLA, .AMOUNT, _
                                                   MonedaCobranza, .SELL_RATE, .CREATE_DATE, .USER_ID, .COMMENT, .SALES_ID, .BANK_ID, .BANK_DESCRIPTION, .DOC_REF, _
                                                  .NUM_REF, .IS_CASH_BANK, .AMOUNT_PER, .BANK_BUSSINESS_ID, .ACCOUNT_BANK_CHECK, .PAY_AUTO, .ANNEX_ID_AUX, .DOCUMET_ID, _
                                                  .NUMBER_SERIE, .NUMBER_DOCUMENT, .MEDIOS_PAGO)
                        If .TYPE_DOC <> "NC" Then
                            If .CURRENCY_ID = "ME" Then
                                If MonedaCobranza = "ME" Then
                                    .AMOUNT = .AMOUNT
                                Else
                                    .AMOUNT = .AMOUNT / .SELL_RATE
                                End If
                            ElseIf .CURRENCY_ID = "MN" Then
                                If MonedaCobranza = "MN" Then
                                    .AMOUNT = .AMOUNT
                                Else
                                    .AMOUNT = .AMOUNT * .SELL_RATE
                                End If
                            End If
                        Else
                            If .CURRENCY_ID = "ME" Then
                                If MonedaCobranza = "ME" Then
                                    .AMOUNT = (Math.Abs(.AMOUNT)) * -1
                                Else
                                    .AMOUNT = (Math.Abs(.AMOUNT / .SELL_RATE) * -1)
                                End If
                            ElseIf .CURRENCY_ID = "MN" Then
                                If MonedaCobranza = "MN" Then
                                    .AMOUNT = (Math.Abs(.AMOUNT) * -1)
                                Else
                                    .AMOUNT = (Math.Abs(.AMOUNT * .SELL_RATE) * -1)
                                End If
                            End If
                        End If
                        'For Each d As ClsEntidades.RECEIVABLE_LIST_LINE In ls_det
                        '    With d
                        sSQLHistLet = ""
                        dt_detalle = New DataTable("Letras_Cobranzas")
                        'validamos cancelacion de las letras
                        If .TYPE_DOC = "LT" Then
                            '_Consulta = "SELECT AMOUNT_BALANCE FROM CUSTOMER_BALANCE WHERE DOCUMENT_ID = 'LT' AND NUMBER_DOC = '" & .NUMBER_DOC & "'"
                            dt_detalle = SqlHelper.ExecuteDataset(tr, "CXC_SP_CUSTOMER_BALANCE_LT", .NUMBER_DOC).Tables(0) 'MostrandoDescripcion(_Consulta)
                            If dt_detalle.Rows.Count > 0 Then
                                If Math.Round(CDbl(dt_detalle.Rows(0).Item("AMOUNT_BALANCE").ToString), 3) = Math.Round(.AMOUNT, 3) Then
                                    dt_detalle.Clear()
                                    dt_detalle = Nothing
                                    dt_detalle = New DataTable("Letras_Cobranzas")
                                    '_Consulta = "SELECT * FROM LETTER WHERE LETTER_ID= '" & .NUMBER_DOC & "'"
                                    dt_detalle = SqlHelper.ExecuteDataset(tr, "CXC_SP_LETTER_COBRANZA", .NUMBER_DOC).Tables(0) 'MostrandoDescripcion(_Consulta)
                                    If dt_detalle.Rows.Count > 0 Then
                                        Select Case Strings.Left(dt_detalle.Rows(0).Item("STATUS_ACT").ToString, 2)
                                            Case "CB", "CBPR", "CBRN"
                                                sSQLHistLet = "CBPA"
                                            Case "CR", "CRPR", "CRRN"
                                                sSQLHistLet = "CRPA"
                                            Case "DS", "DSPR", "DSRN"
                                                sSQLHistLet = "DSPA"
                                            Case "GR", "GRPR", "GRRN"
                                                sSQLHistLet = "GRPA"
                                            Case "EB"
                                                sSQLHistLet = "EBPA"
                                        End Select
                                    End If
                                    If sSQLHistLet <> "" Then SqlHelper.ExecuteNonQuery(tr, "CXC_SP_I_U_LETTER", .NUMBER_DOC, sSQLHistLet)
                                Else
                                    sSQLHistLet = ""
                                End If
                            End If
                            dt_detalle.Clear()
                            dt_detalle = Nothing
                        End If
                        'fin de validamos cancelacion de las letras
                        '    End With
                        'Next
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_U_CUSTOMER_BALANCE", .ANNEX_ID_AUX, .DOCUMET_ID, .NUMBER_DOC, .AMOUNT)
                    End With
                Next
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Insert_CajaChica_Det(ls_det As List(Of ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA))
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                If ls_det.Count = 0 Then Exit Sub
                Dim query As String = "SELECT ISNULL(MAX(CONVERT(INT,ITEM)),0) FROM dbo.RECEIVABLE_LINE_CAJA_CHICA WHERE ID = '" & ls_det(0).ID & "' "

                Dim LastItem As Integer = SqlHelper.ExecuteScalar(tr, CommandType.Text, query)
                'Grabamos los detalles
                '++++++++
                Dim dtTipoCamb As DataTable
                dtTipoCamb = New DataTable

                For Each d As ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA In ls_det
                    With d
                        LastItem += 1
                        SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_I_RECEIVABLE_LINE_CAJA_CHICA", .ID, Format(LastItem, "000"), .TYPE_DOC, .NUMBER_DOC, .TYPE_OPERATION, .REC_ID, .DATE_PLA, .AMOUNT, _
                                                   .CURRENCY_ID, .SELL_RATE, .CREATE_DATE, .USER_ID, .COMMENT, .SALES_ID, .BANK_ID, .BANK_DESCRIPTION, .DOC_REF, _
                                                  .NUM_REF, .IS_CASH_BANK, .AMOUNT_PER, .BANK_BUSSINESS_ID, .ACCOUNT_BANK_CHECK, .PAY_AUTO, .ANNEX_ID_AUX, .DOCUMET_ID, _
                                                  .NUMBER_SERIE, .NUMBER_DOCUMENT, .MEDIOS_PAGO, .OPT_AN, .ID_PERSONAL, .ID_MOVIMIENTO, .MONTO_INGRESO, .MONTO_EGRESO, .STATUS)
                    End With
                Next

                SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_U_RECEIVABLE_LINE_CAJA_CHICA_SALDOS", ls_det(0).ID)

                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Eliminar_CajaChica_Det(ByVal _item As String, ByVal _id As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_D_RECEIVABLE_LINE_CAJA_CHICA_DET", _item, _id)
                SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_U_RECEIVABLE_LINE_CAJA_CHICA_SALDOS", _id)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Cerrar_CajaChica(ByVal _id As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_CERRAR_RECEIVABLE_CAJA_CHICA", _id)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub


        Public Sub Aperturar_CajaChica(ByVal _id As String)
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_APERTURAR_RECEIVABLE_CAJA_CHICA", _id)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Actualizacion_CajaChica_Det(ls_det As List(Of ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA))
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.RECEIVABLE_LINE_CAJA_CHICA In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_U_RECEIVABLE_LINE_CAJA_CHICA", .ID, .ITEM, .TYPE_DOC, .NUMBER_DOC, .TYPE_OPERATION, .REC_ID, .DATE_PLA, .AMOUNT, _
                                                   .CURRENCY_ID, .SELL_RATE, .CREATE_DATE, .USER_ID, .COMMENT, .SALES_ID, .BANK_ID, .BANK_DESCRIPTION, .DOC_REF, _
                                                  .NUM_REF, .IS_CASH_BANK, .AMOUNT_PER, .BANK_BUSSINESS_ID, .ACCOUNT_BANK_CHECK, .PAY_AUTO, .ANNEX_ID_AUX, .DOCUMET_ID, _
                                                  .NUMBER_SERIE, .NUMBER_DOCUMENT, .MEDIOS_PAGO, .OPT_AN, .ID_PERSONAL, .ID_MOVIMIENTO, .MONTO_INGRESO, .MONTO_EGRESO)
                    End With
                Next

                SqlHelper.ExecuteNonQuery(tr, "CCHICA_SP_U_RECEIVABLE_LINE_CAJA_CHICA_SALDOS", ls_det(0).ID)

                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub InsertNC(ls_det As List(Of ClsEntidades.RECEIVABLE_LIST_LINE), ByVal Tipodoc As String, ByVal SerieDoc As String, _
                             ByVal NumeroDoc As String, ByVal monto As Double, ByVal MonedaCobranza As String, ByVal FECHA_PLANILLA As Date)

            Dim query As String = "SELECT ISNULL(MAX(ITEM),0) FROM RECEIVABLE_LIST_LINE WHERE ID = '" & ls_det(0).ID & "' "
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim LastItem As Integer = SqlHelper.ExecuteScalar(tr, CommandType.Text, query)
            'Grabamos los detalles
            Try
                Dim _TipoCambio_Ref As String = String.Empty
                Dim _Consulta As String = String.Empty
                Dim dtTipoCamb As DataTable
                dtTipoCamb = New DataTable
                For Each d As ClsEntidades.RECEIVABLE_LIST_LINE In ls_det
                    With d
                        LastItem += 1
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_RECEIVABLE_LIST_LINE", .ID, LastItem, .TYPE_DOC, .NUMBER_DOC, .TYPE_OPERATION, .REC_ID, .DATE_PLA, .AMOUNT, MonedaCobranza, .SELL_RATE, .CREATE_DATE, .USER_ID, .COMMENT, .SALES_ID, .BANK_ID, .BANK_DESCRIPTION, .DOC_REF, .NUM_REF, .IS_CASH_BANK, .AMOUNT_PER, .BANK_BUSSINESS_ID, .ACCOUNT_BANK_CHECK, .PAY_AUTO, .ANNEX_ID_AUX, .DOCUMET_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .MEDIOS_PAGO)
                        If .CURRENCY_ID = "ME" Then
                            If MonedaCobranza = "ME" Then
                                .AMOUNT = .AMOUNT
                            Else
                                .AMOUNT = .AMOUNT / .SELL_RATE
                            End If
                        ElseIf .CURRENCY_ID = "MN" Then
                            If MonedaCobranza = "MN" Then
                                .AMOUNT = .AMOUNT
                            Else
                                .AMOUNT = .AMOUNT * .SELL_RATE
                            End If
                        End If
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_U_CUSTOMER_BALANCE", .ANNEX_ID_AUX, .DOCUMET_ID, .NUMBER_SERIE + .NUMBER_DOCUMENT, Math.Abs(CDbl(.AMOUNT)))
                        Dim dtDetalle As DataTable
                        dtDetalle = New DataTable
                        dtDetalle = SqlHelper.ExecuteDataset(tr, "CX_SP_S_VERIFICACION_COD_NC", .ANNEX_ID_AUX, SerieDoc + NumeroDoc).Tables(0)
                        Dim Moneda As String = String.Empty
                        Moneda = dtDetalle.Rows(0).Item("CURRENCY_ID").ToString
                        If Moneda = "ME" Then
                            If MonedaCobranza = "ME" Then
                                .AMOUNT = (Math.Abs(CDbl(monto))) * -1
                            Else
                                .AMOUNT = (Math.Abs(CDbl(monto)) / .SELL_RATE) * -1
                            End If
                        ElseIf Moneda = "MN" Then
                            If MonedaCobranza = "MN" Then
                                .AMOUNT = (Math.Abs(CDbl(monto))) * -1
                            Else
                                .AMOUNT = (Math.Abs(CDbl(monto)) * .SELL_RATE) * -1
                            End If
                        End If
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_U_CUSTOMER_BALANCE", .ANNEX_ID_AUX, Tipodoc, SerieDoc & NumeroDoc, (Math.Abs(CDbl(.AMOUNT))) * -1)
                    End With
                Next
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function get_planilla_Det_xID(num_planilla As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_RECEIVABLE_DET", num_planilla).Tables(0)
        End Function

        Public Function get_planilla_Det_Caja_Chica(num_planilla As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CCHICA_SP_S_RECEIVABLE_LINE_CAJA_CHICA_DET", num_planilla).Tables(0)
        End Function

        Public Function get_planilla_Caja_Chica() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CCHICA_SP_S_RECEIVABLE_LINE_CAJA_CHICA_DET_DET").Tables(0)
        End Function

        Public Function get_Mov_por_planilla_Caja_Chica() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CCHICA_SP_S_MOV_RLCC").Tables(0)
        End Function

        Public Function get_planilla_Det_xItem(num_planilla As String, item As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_RECEIVABLE_DET_XITEM", num_planilla, item).Tables(0)
        End Function

        Public Function VerificandoNumeracionDocumentosNC(ByVal Cliente As String, ByVal NumDoc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_COD_NC", Cliente, NumDoc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function ActualizacionDocumentosEliminados(ByVal CodCliente As String, ByVal Tipodoc As String, ByVal numdoc As String, ByVal Monto As Double) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_CUSTOMER_BALANCE_ELIMINADOS", CodCliente, Tipodoc, numdoc, Monto)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


    End Class


    Public Class RECEIVABLE_LIST_PAY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function EliminarPlanilla_Pagos_Proveedor(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_D_PLANILLA_DATOS_PAY", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function VerificarCuentaContableCliente(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C_PAY", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function




        Public Function DatosAsientoCabecera(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_CABECERA_ASIENTO", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function DatosAsientoDetalle(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_DETALLE_ASIENTO", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function ManualClienteCodigo(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CLIENTES_CODIGO_MANUAL", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function ManualClienteRuc(ByVal Ruc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CLIENTES_RUC_MANUAL", Ruc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function ManualClienteRuc_Pago_Proveedor(ByVal Ruc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_CLIENTES_RUC_MANUAL_PAY", Ruc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function ManualComprobantes(ByVal Voucher As String, ByVal Fecha As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_COMPROBANTE_MANUAL", Voucher, Fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function ManualTipoDocumento(ByVal Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_TIPO_DOC_M", Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Sub Insert_Pago_Proveedor(entidad As ClsEntidades.RECEIVABLE_LIST, bol_nuevo As Boolean, ByRef numero As String)

            'obtenemos el id de la planilla ,
            If bol_nuevo Then
                entidad.ID = SqlHelper.ExecuteScalar(cn, "CX_SP_S_RECEIVABLE_ID_PAY")
            End If
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_I_RECEIVABLE_LIST_PAY", .ID, .DATE_PLA, .AMOUNT, .AMOUNT_US, .AMOUNT_CH_DIF, .AMOUNT_CH_DIF_US, .VOUCHER_ID, .STATUS, .CREATE_DATE, .USER_ID, .SALES_ID, .VOUCHER_ID_US, .SELL_RATE)
            End With
            numero = entidad.ID
        End Sub

        Public Function get_planilla_x_fecha_Pago_Proveedor(fecha1 As String, fecha2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_RECEIVABLE_XDATE_PAY", fecha1, fecha2).Tables(0)
        End Function

        Public Function get_Ult_num_voucher(subd_ As String, ayo_ As Integer, mes_ As String) As String
            Dim Correlativo As String = String.Empty
            Try
                Correlativo = SqlHelper.ExecuteScalar(cn, "CO_SP_S_CORRELATIVO", subd_, ayo_, mes_)
                Correlativo = mes_ & Correlativo
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Correlativo
        End Function




        Public Function DetallesLetras(ByVal ID_PLANILLA As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_LETRAS_DET_PAY", ID_PLANILLA).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Function DetallesCuenta_Docs(ByVal n_doc As String, ByVal s_doc As String, ByVal t_doc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_CUENTA_DOCS", t_doc, s_doc, n_doc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function Contabilizar_Caja_Letra_Pago(ByVal Cod_planilla As String, ByVal DT_DATOS_ASIENTO As DataTable,
                                                     ByVal _Numeracion As String) As Boolean
            Dim estado As Boolean = True
            Try
                Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
                Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

                With cab
                    .AC_ID = 0
                    .AC_IDSUBDIARIO = "10"
                    .AC_NUM_VOUCHER = _Numeracion
                    .AC_ANHO = Date.Now.Year
                    .AC_MES = Date.Now.Month
                    .AC_FEC_VOUCHER = Date.Now()
                    .AC_IDMONEDA = 1
                    .AC_DEBE = DT_DATOS_ASIENTO.Compute("sum(AD_DEBE)", "")
                    .AC_HABER = DT_DATOS_ASIENTO.Compute("sum(AD_HABER)", "")
                    .AC_ESTADO = 2
                    .AC_GLOSA_VOU = "ACEPTACION DE LETRAS PARA EL PAGO"
                    .AC_ES_INTERFACE = 1
                    .AC_IDPLANILLA = ""
                    .AC_ID_LETRA = ""
                    .AC_ID_LETRA_PAGO = Cod_planilla
                End With
                '________________________________________ D E T A L L E S _____________________________________

                Dim monto As Double = 0
                Dim mon As Integer = 1
                Dim tc As Double = 0
                Dim cta12_Clientes As String = "1231"
                Dim Is_orig As String = String.Empty

                'Recorremos de la planilla

                If DT_DATOS_ASIENTO.Rows.Count() <> 0 Then
                    For j As Integer = 0 To DT_DATOS_ASIENTO.Rows.Count - 1
                        '//_________ C U E N T A  12   D E  C L I E N T E S _____________)_________________
                        ' //buscamos la cuenta contable
                        detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = j + 1
                        detalle.AD_CUENTA = DT_DATOS_ASIENTO.Rows(j)("AD_CUENTA").ToString()
                        detalle.AD_TANEXO = DT_DATOS_ASIENTO.Rows(j)("AD_TANEXO").ToString()
                        detalle.AD_IDANEXO = DT_DATOS_ASIENTO.Rows(j)("AD_IDANEXO").ToString()
                        detalle.AD_TDOC = DT_DATOS_ASIENTO.Rows(j)("AD_TDOC").ToString()
                        detalle.AD_SDOC = DT_DATOS_ASIENTO.Rows(j)("AD_SDOC").ToString()
                        detalle.AD_NDOC = DT_DATOS_ASIENTO.Rows(j)("AD_NDOC").ToString()
                        detalle.AD_FDOC = DT_DATOS_ASIENTO.Rows(j)("AD_FDOC").ToString()
                        detalle.AD_VDOC = DT_DATOS_ASIENTO.Rows(j)("AD_VDOC").ToString()
                        detalle.AD_DEBE = Math.Abs(Math.Round(DT_DATOS_ASIENTO.Rows(j)("AD_DEBE"), 3))
                        detalle.AD_HABER = Math.Abs(Math.Round(DT_DATOS_ASIENTO.Rows(j)("AD_HABER"), 3))
                        detalle.AD_TCAM = DT_DATOS_ASIENTO.Rows(j)("AD_TCAM").ToString()
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(DT_DATOS_ASIENTO.Rows(j)("AD_MONTO_ORI"), 3)
                        detalle.AD_PORCE_DESTINO = 0
                        detalle.AD_ES_CONCI = 0
                        detalle.AD_ANHO_CONI = 0
                        detalle.AD_MES_CONCI = 0
                        detalle.AD_ES_INAFECTO = 0
                        detalle.AD_IDMONEDA = DT_DATOS_ASIENTO.Rows(j)("AD_IDMONEDA").ToString()
                        detalle.AD_TDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_TDOC_REF").ToString()
                        detalle.AD_SDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_SDOC_REF").ToString()
                        detalle.AD_NDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_NDOC_REF").ToString()
                        detalle.AD_FDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_FDOC_REF").ToString()
                        detalle.AD_VDOC_REF = DT_DATOS_ASIENTO.Rows(j)("AD_VDOC_REF").ToString()
                        detalle.AD_GLOSA = ""
                        ls_det.Add(detalle)
                    Next
                    Guardar_Contabilizar_Caja_Cobranzas_Pago(cab, ls_det, False)
                Else
                    MsgBox("La planilla no posee registros para llevar a Contabilidad.", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                estado = False
            End Try
            Return estado
        End Function

        Public Function Contabilizar_Caja_Pagos_Proveedores(ByVal ID_PLANILLA As String, ByVal Fecha As Date, ByVal NUMERACION As String) As Boolean
            Dim _ESTADO As Boolean = True
            Try
                If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_PLANILLA_PAY", "04", ID_PLANILLA) = 0 Then
                    Dim total_movi As Double = 0
                    Dim dic_cta10 As New Dictionary(Of String, Double)
                    Dim dic_cta10_ori As New Dictionary(Of String, Double)

                    Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
                    Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                    Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "04"
                        .AC_NUM_VOUCHER = get_Ult_num_voucher("04", Fecha.Year, Format(Fecha.Month, "00"))
                        .AC_ANHO = Fecha.Year
                        .AC_MES = Format(Fecha.Month, "00")
                        .AC_FEC_VOUCHER = Date.Now()
                        .AC_IDMONEDA = 1
                        .AC_DEBE = 0
                        .AC_HABER = 0
                        .AC_ESTADO = 1
                        .AC_GLOSA_VOU = "PLANILLA DE PAGO : " & ID_PLANILLA & ""
                        .AC_ES_INTERFACE = 1
                        .AC_IDPLANILLA = ID_PLANILLA
                        .AC_ID_LETRA = ""
                        .AC_ID_PAGO = ID_PLANILLA
                    End With
                    '________________________________________ D E T A L L E S _____________________________________

                    Dim monto As Double = 0
                    Dim mon As Integer = 1
                    ' Dim tc As Double = 0
                    Dim cta12_Clientes As String = "121201"

                    '+++++
                    Dim FechaIngr As Date
                    Dim _Consulta As String
                    Dim dtTipoCamb As New DataTable
                    Dim dtTipoAnex As New DataTable
                    Dim _TipoCambio_Ref As Double = 0.0
                    FechaIngr = Fecha
                    If FechaIngr.ToString("dddd") = "martes" Then
                        FechaIngr = FechaIngr.AddDays(-3)
                    ElseIf FechaIngr.ToString("ddddd") = "lunes" Then
                        FechaIngr = FechaIngr.AddDays(-2)
                    Else
                        FechaIngr = FechaIngr.AddDays(-1)
                    End If
                    _Consulta = "SELECT isnull(SELL_RATE, 0) [SELL_RATE] FROM CURRENCY_EXCHANGE WHERE CURRENCY_DATE='" & FechaIngr & "'"
                    dtTipoCamb = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                    If dtTipoCamb.Rows.Count() <> 0 Then
                        _TipoCambio_Ref = dtTipoCamb.Rows(0).Item("SELL_RATE")
                    Else
                        _TipoCambio_Ref = 0
                    End If
                    '+++++
                    
                    'Recorremos de la planilla
                    Dim dt_detalles As DataTable
                    dt_detalles = New DataTable
                    dt_detalles = SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA_PAY_DET_PAY", ID_PLANILLA).Tables(0)
                    If dt_detalles.Rows.Count() <> 0 Then
                        For j As Integer = 0 To dt_detalles.Rows.Count - 1
                            ' //_________ C U E N T A  10   D E  C A J A ______________________________
                            Dim _CodigoProveedor As String = String.Empty
                            Dim _CuentaCliente As String = String.Empty
                            Dim Dtverificar As New DataTable
                            _CodigoProveedor = dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString()
                            monto = Math.Round(Double.Parse(dt_detalles.Rows(j)("AMOUNT").ToString()), 2)
                            detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                            mon = IIf(dt_detalles.Rows(j)("CURRENCY_ID").ToString() = "MN", 1, 2)
                            cta12_Clientes = _CuentaCliente
                            ' tc = Double.Parse(dt_detalles.Rows(j)("SELL_RATE").ToString())
                            If dic_cta10.ContainsKey(dt_detalles.Rows(j)("ACCOUNT").ToString()) Then
                                dic_cta10(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(IIf(mon = 1, monto, monto * _TipoCambio_Ref), 2)
                                dic_cta10_ori(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(monto, 2)
                            Else
                                dic_cta10.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(IIf(mon = 1, monto, monto * _TipoCambio_Ref), 2))
                                dic_cta10_ori.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(monto, 2))
                            End If
                            detalle.AD_IDCAB = 0
                            detalle.AD_SECUENCIA = ls_det.Count + 1
                            detalle.AD_CUENTA = dt_detalles.Rows(j)("ACCOUNT").ToString()

                            '++++
                            _Consulta = String.Empty
                            _Consulta = "SELECT ISNULL(PC_IDTIPO_ANEXO,0) [PC_IDTIPO_ANEXO]  FROM CO_TB_PLANCTAS WHERE PC_NUM_CTA ='" & dt_detalles.Rows(j)("ACCOUNT").ToString() & "'"
                            dtTipoAnex = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                            If dtTipoAnex.Rows.Count() <> 0 Then
                                detalle.AD_TANEXO = dtTipoAnex.Rows(0).Item("PC_IDTIPO_ANEXO")
                            Else
                                detalle.AD_TANEXO = 0
                            End If
                            '++++
                            detalle.AD_IDANEXO = ""
                            detalle.AD_TDOC = dt_detalles.Rows(j)("DOC_REF").ToString()
                            detalle.AD_SDOC = ""
                            detalle.AD_NDOC = dt_detalles.Rows(j)("NUM_REF").ToString()
                            detalle.AD_FDOC = "" 'dt_detalles.Rows(j)("DATE").ToString()
                            detalle.AD_VDOC = ""
                            detalle.AD_DEBE = 0
                            detalle.AD_HABER = Math.Round(IIf(mon = 1, monto, monto * _TipoCambio_Ref), 2)
                            detalle.AD_TCAM = _TipoCambio_Ref 'Val(dt_detalles.Rows(j)("SELL_RATE").ToString) '
                            detalle.AD_SEC_ORI_DES = 0
                            detalle.AD_IDCC = ""
                            detalle.AD_ES_DESTINO = 0
                            detalle.AD_IDMEDIOPAGO = ""
                            detalle.AD_MONTO_ORI = IIf(mon = 1, monto, monto) 'detalle.AD_HABER)
                            detalle.AD_PORCE_DESTINO = 0
                            detalle.AD_ES_CONCI = 0
                            detalle.AD_ANHO_CONI = 0
                            detalle.AD_MES_CONCI = 0
                            detalle.AD_ES_INAFECTO = 0
                            detalle.AD_IDMONEDA = mon
                            detalle.AD_TDOC_REF = ""
                            detalle.AD_SDOC_REF = ""
                            detalle.AD_NDOC_REF = ""
                            detalle.AD_FDOC_REF = ""
                            detalle.AD_VDOC_REF = ""
                            detalle.AD_GLOSA = ""
                            ls_det.Add(detalle)
                            total_movi += detalle.AD_DEBE + detalle.AD_HABER

                            '//_________ C U E N T A  42   D E  P R O V E E D O R E S _____________)_________________
                            Dim ruc As String = dt_detalles.Rows(j)("VAT_REGISTRATION").ToString()
                            Dim tdoc As String = dt_detalles.Rows(j)("DOCUMET_ID").ToString()
                            Dim sdoc As String = dt_detalles.Rows(j)("NUMBER_SERIE").ToString()
                            Dim ndoc As String = dt_detalles.Rows(j)("NUMBER_DOCUMENT").ToString()
                            Dim subd As String = "02" '//ventas
                            Dim tanexo As Integer = 2 '//proveedores

                            If dt_detalles.Rows(j)("TYPE_DOC").ToString().Equals("HO") Then
                                subd = "02"
                                tanexo = 1
                            End If
                            ' //buscamos la cuenta contable
                            Dim drrr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CO_SP_S_CTA_PROVISION", subd, ruc, tdoc, sdoc, ndoc)
                            If drrr.HasRows Then
                                drrr.Read()
                                cta12_Clientes = drrr("RESULTADO").ToString()
                            End If
                            drrr.Close()
                            If cta12_Clientes.Equals(String.Empty) Then cta12_Clientes = _CuentaCliente
                            detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
                            detalle.AD_IDCAB = 0
                            detalle.AD_SECUENCIA = ls_det.Count + 1
                            detalle.AD_CUENTA = cta12_Clientes
                            detalle.AD_TANEXO = tanexo
                            detalle.AD_IDANEXO = ruc
                            detalle.AD_TDOC = tdoc
                            detalle.AD_SDOC = sdoc.PadLeft(5, Char.Parse("0"))
                            detalle.AD_NDOC = ndoc.PadLeft(15, Char.Parse("0"))

                            'otengo la cuenta de la letra
                            If tdoc = "ANP" Or tdoc = "AR" Or tdoc = "MO" Then
                                dtTipoCamb = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C_AN", tdoc, dt_detalles.Rows(j)("CURRENCY_ID").ToString()).Tables(0)
                                If dtTipoCamb.Rows.Count <> 0 Then
                                    detalle.AD_CUENTA = dtTipoCamb.Rows(0).Item("ACCOUNT").ToString
                                Else
                                    MsgBox("Debe configurar la cuenta para el documento " + tdoc + " que desea contabilizar.", MsgBoxStyle.Critical, "Sistemas")
                                    _ESTADO = False
                                    Exit Function
                                End If
                                dtTipoCamb.Clear()
                                dtTipoCamb = Nothing
                            ElseIf tdoc = "LT" Then
                                detalle.AD_SDOC = "000"
                                detalle.AD_NDOC = dt_detalles.Rows(j)("NUMBER_DOC").ToString()
                                _Consulta = "SELECT B.ACCOUNT FROM dbo.LETTER_PAY A INNER JOIN dbo.STATUS_LETTER_PAY B ON A.STATUS_LAST=B.STATUS_ID INNER JOIN DBO.CUSTOMER_BALANCE_PAY C ON A.LETTER_ID=C.NUMBER_DOC AND C.DOCUMENT_ID='LT' AND B.CURRENCY_ID=C.CURRENCY_ID WHERE LETTER_ID='" & detalle.AD_NDOC & "'"
                                dtTipoCamb = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                                If dtTipoCamb.Rows.Count > 0 Then
                                    detalle.AD_CUENTA = dtTipoCamb.Rows(0).Item("ACCOUNT").ToString
                                Else
                                    MsgBox("Debe configurar la cuenta del estado de la letra que desea contabilizar.", MsgBoxStyle.Critical, "Sistemas")
                                    _ESTADO = False
                                    Exit Function
                                End If
                                dtTipoCamb.Clear()
                                dtTipoCamb = Nothing
                            Else
                                _Consulta = "SELECT TOP 1 AD_CUENTA,B.PC_DES_CTA AS AD_DES_CUENTA FROM dbo.CO_TB_ASIENTO_DET A INNER JOIN dbo.CO_TB_PLANCTAS B ON A.AD_CUENTA=B.PC_NUM_CTA WHERE AD_NDOC='" & detalle.AD_NDOC & "' AND AD_SDOC='" & detalle.AD_SDOC & "' AND AD_TDOC='" & detalle.AD_TDOC & "' AND AD_CUENTA LIKE '42%' AND A.AD_IDANEXO='" & detalle.AD_IDANEXO & "' ORDER BY AD_HABER DESC"
                                dtTipoCamb = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                                If dtTipoCamb.Rows.Count() <> 0 Then
                                    detalle.AD_CUENTA = dtTipoCamb.Rows(0).Item("AD_CUENTA").ToString
                                Else
                                    MsgBox("Debe configurar la cuenta para el documento " + tdoc + " que desea contabilizar.", MsgBoxStyle.Critical, "Sistemas")
                                    _ESTADO = False
                                    Exit Function
                                End If
                                dtTipoCamb.Clear()
                                dtTipoCamb = Nothing
                            End If

                            'fin de la otengo la cuenta de la letra

                            _Consulta = "SELECT DOC_DATE FROM dbo.CUSTOMER_BALANCE_PAY WHERE CUSTOMER_ID='" & dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString & "' AND DOCUMENT_ID='" & dt_detalles.Rows(j)("TYPE_DOC").ToString & "' AND	NUMBER_DOC='" & dt_detalles.Rows(j)("NUMBER_DOC").ToString & "'"
                            dtTipoCamb = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                            If dtTipoCamb.Rows.Count() <> 0 Then
                                detalle.AD_FDOC = dtTipoCamb.Rows(0).Item("DOC_DATE")
                            Else
                                detalle.AD_FDOC = ""
                            End If
                            detalle.AD_VDOC = ""

                            'detalle.AD_DEBE = 0
                            'detalle.AD_HABER = Math.Round(IIf(mon = 1, monto, monto * _TipoCambio_Ref), 2)
                            _Consulta = "SELECT * FROM dbo.CUSTOMER_BALANCE_PAY WHERE CUSTOMER_ID='" & dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString & "' AND DOCUMENT_ID='" & dt_detalles.Rows(j)("TYPE_DOC").ToString & "' AND	NUMBER_DOC='" & dt_detalles.Rows(j)("NUMBER_DOC").ToString & "'"
                            dtTipoCamb = SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
                            If dtTipoCamb.Rows.Count() = 0 Then
                                MsgBox("El documento no se encuentra en la cartera del Proveedor.", MsgBoxStyle.Information)
                                _ESTADO = False
                            End If


                            If tdoc = "NC" Then
                                If dt_detalles.Rows(j)("CURRENCY_ID").ToString = dtTipoCamb.Rows(0).Item("CURRENCY_ID") Then
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" Then
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = Math.Abs(monto)
                                        detalle.AD_MONTO_ORI = monto
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto * dtTipoCamb.Rows(0).Item("SELL_RATE"))) '_TipoCambio_Ref))
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = Math.Abs(monto)
                                    End If
                                Else
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "ME" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto / IIf(_TipoCambio_Ref = 0, 1, _TipoCambio_Ref))) * CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString)
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = Math.Abs(monto)
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "MN" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto)) * IIf(CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString) = 0, 1, CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString))
                                        detalle.AD_DEBE = 0
                                        detalle.AD_HABER = Math.Abs(monto)
                                    End If
                                End If
                            Else
                                If dt_detalles.Rows(j)("CURRENCY_ID").ToString = dtTipoCamb.Rows(0).Item("CURRENCY_ID") Then
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" Then
                                        detalle.AD_DEBE = monto
                                        detalle.AD_HABER = 0
                                        detalle.AD_MONTO_ORI = monto
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto * dtTipoCamb.Rows(0).Item("SELL_RATE")))
                                        detalle.AD_DEBE = monto
                                        detalle.AD_HABER = 0
                                    End If
                                Else
                                    If dt_detalles.Rows(j)("CURRENCY_ID").ToString = "MN" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "ME" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto / IIf(_TipoCambio_Ref = 0, 1, _TipoCambio_Ref))) * CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString)
                                        detalle.AD_DEBE = monto
                                        detalle.AD_HABER = 0
                                    ElseIf dt_detalles.Rows(j)("CURRENCY_ID").ToString = "ME" And dtTipoCamb.Rows(0).Item("CURRENCY_ID") = "MN" Then
                                        detalle.AD_MONTO_ORI = monto
                                        monto = ((monto)) * IIf(CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString) = 0, 1, CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString))
                                        detalle.AD_DEBE = monto
                                        detalle.AD_HABER = 0
                                    End If
                                End If
                            End If

                            detalle.AD_TCAM = CDbl(dtTipoCamb.Rows(0).Item("SELL_RATE").ToString)
                            detalle.AD_SEC_ORI_DES = 0
                            detalle.AD_IDCC = ""
                            detalle.AD_ES_DESTINO = 0
                            detalle.AD_IDMEDIOPAGO = ""
                            'detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, monto, monto), 2) 'detalle.AD_DEBE), 2)
                            detalle.AD_PORCE_DESTINO = 0
                            detalle.AD_ES_CONCI = 0
                            detalle.AD_ANHO_CONI = 0
                            detalle.AD_MES_CONCI = 0
                            detalle.AD_ES_INAFECTO = 0
                            detalle.AD_IDMONEDA = mon
                            detalle.AD_TDOC_REF = ""
                            detalle.AD_SDOC_REF = ""
                            detalle.AD_NDOC_REF = ""
                            detalle.AD_FDOC_REF = ""
                            detalle.AD_VDOC_REF = ""
                            detalle.AD_GLOSA = ""
                            ls_det.Add(detalle)
                        Next 'IF del detalle de planilla
                        '//ACTUALIZAMOS LOS TOTALES
                        cab.AC_DEBE = total_movi
                        cab.AC_HABER = total_movi
                        '//Grabamos el voucher por ID planilla
                        Guardar_Contabilizar_Pagos_Pagos_Proveedores(cab, ls_det, False)
                    Else
                        MsgBox("La planilla no posee registros para llevar a Contabilidad.", MsgBoxStyle.Information)
                        _ESTADO = False
                    End If
                Else
                    MsgBox("El documento ya fue enviado a  Contabilidad.", MsgBoxStyle.Information)
                    _ESTADO = False
                End If 'de validacio =0
            Catch ex As Exception
                _ESTADO = False
                MsgBox(ex.Message)
            End Try
            Return _ESTADO
        End Function

        Public Function Guardar_Contabilizar_Pagos_Pagos_Proveedores(ByRef c As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB, ld As List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET), edicion_ As Boolean)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                If edicion_ Then
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_D_ASIENTO_CAB", c.AC_ID, c.AC_IDSUBDIARIO, c.AC_ANHO, c.AC_MES)
                End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CAB_PAY", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_ID_LETRA, c.AC_ID_PAGO)
                c.AC_ID = idcab

                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ld

                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Function


        'Public Function Contabilizar_Caja_Cobranzas(ByVal ID_PLANILLA As String, ByVal Fecha As Date) As Boolean
        '    Dim _ESTADO As Boolean = True
        '    Try
        '        If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_PLANILLA", "03", ID_PLANILLA) = 0 Then
        '            Dim total_movi As Double = 0
        '            Dim dic_cta10 As New Dictionary(Of String, Double)
        '            Dim dic_cta10_ori As New Dictionary(Of String, Double)

        '            Dim cab As New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB
        '            Dim detalle As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
        '            Dim ls_det As New List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET)

        '            With cab
        '                .AC_ID = 0
        '                .AC_IDSUBDIARIO = "03"
        '                .AC_NUM_VOUCHER = get_Ult_num_voucher("03", Fecha.Year, Format(Fecha.Month, "00"))
        '                .AC_ANHO = Fecha.Year
        '                .AC_MES = Format(Fecha.Month, "00")
        '                .AC_FEC_VOUCHER = Date.Now()
        '                .AC_IDMONEDA = 1
        '                .AC_DEBE = 0
        '                .AC_HABER = 0
        '                .AC_ESTADO = 1
        '                .AC_GLOSA_VOU = "PLANILLA DE COBRANZA : " & ID_PLANILLA & ""
        '                .AC_ES_INTERFACE = 1
        '                .AC_IDPLANILLA = ID_PLANILLA
        '                .AC_ID_LETRA = ""
        '            End With
        '            '________________________________________ D E T A L L E S _____________________________________

        '            Dim monto As Double = 0
        '            Dim mon As Integer = 1
        '            Dim tc As Double = 0
        '            Dim cta12_Clientes As String = "121201"

        '            'Recorremos de la planilla
        '            Dim dt_detalles As DataTable
        '            dt_detalles = New DataTable
        '            dt_detalles = SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA_ING_DET", ID_PLANILLA).Tables(0)
        '            If dt_detalles.Rows.Count() <> 0 Then
        '                For j As Integer = 0 To dt_detalles.Rows.Count - 1
        '                    ' //_________ C U E N T A  10   D E  C A J A ______________________________
        '                    Dim _CodigoCliente As String = String.Empty
        '                    Dim _CuentaCliente As String = String.Empty
        '                    Dim Dtverificar As New DataTable
        '                    _CodigoCliente = dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString()
        '                    monto = Math.Round(Double.Parse(dt_detalles.Rows(j)("AMOUNT").ToString()), 2)
        '                    detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
        '                    mon = IIf(dt_detalles.Rows(j)("CURRENCY_ID").ToString() = "MN", 1, 2)
        '                    Dtverificar = SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CLIENTE_C_C", _CodigoCliente).Tables(0)
        '                    If Dtverificar.Rows.Count <> 0 Then
        '                        _CuentaCliente = String.Empty
        '                        If mon = 1 Then
        '                            If String.IsNullOrEmpty(Dtverificar.Rows(0).Item("ACCOUNT_LOCAL").ToString) Then
        '                                MsgBox("No se configuro la Cuenta Contable en Moneda Nacional." & vbCrLf & "Codigo Cliente : " & _CodigoCliente, MsgBoxStyle.Critical)
        '                                _ESTADO = False
        '                                Exit Try
        '                            Else
        '                                _CuentaCliente = Dtverificar.Rows(0).Item("ACCOUNT_LOCAL").ToString
        '                            End If
        '                        ElseIf mon = 2 Then
        '                            If String.IsNullOrEmpty(Dtverificar.Rows(0).Item("ACCOUNT_EXTERNAL").ToString) Then
        '                                MsgBox("No se configuro la Cuenta Contable en Moneda Extranjera." & vbCrLf & "Codigo Cliente : " & _CodigoCliente, MsgBoxStyle.Critical)
        '                                _ESTADO = False
        '                                Exit Try
        '                            Else
        '                                _CuentaCliente = Dtverificar.Rows(0).Item("ACCOUNT_EXTERNAL").ToString
        '                            End If
        '                        End If
        '                    Else
        '                        MsgBox("No se configuro ninguna Cuenta Contable al Cliente.." & vbCrLf & "Codigo Cliente : " & _CodigoCliente, MsgBoxStyle.Critical)
        '                        _ESTADO = False
        '                        Exit Try
        '                    End If
        '                    cta12_Clientes = _CuentaCliente
        '                    tc = Double.Parse(dt_detalles.Rows(j)("SELL_RATE").ToString())
        '                    If dic_cta10.ContainsKey(dt_detalles.Rows(j)("ACCOUNT").ToString()) Then
        '                        dic_cta10(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(IIf(mon = 1, monto, monto * tc), 2)
        '                        dic_cta10_ori(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(monto, 2)
        '                    Else
        '                        dic_cta10.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(IIf(mon = 1, monto, monto * tc), 2))
        '                        dic_cta10_ori.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(monto, 2))
        '                    End If
        '                    detalle.AD_IDCAB = 0
        '                    detalle.AD_SECUENCIA = ls_det.Count + 1
        '                    detalle.AD_CUENTA = dt_detalles.Rows(j)("ACCOUNT").ToString()
        '                    detalle.AD_TANEXO = 0
        '                    detalle.AD_IDANEXO = ""
        '                    detalle.AD_TDOC = dt_detalles.Rows(j)("DOC_REF").ToString()
        '                    detalle.AD_SDOC = ""
        '                    detalle.AD_NDOC = dt_detalles.Rows(j)("NUM_REF").ToString()
        '                    detalle.AD_FDOC = ""
        '                    detalle.AD_VDOC = ""
        '                    detalle.AD_DEBE = Math.Round(IIf(mon = 1, monto, monto * tc), 2)
        '                    detalle.AD_HABER = 0
        '                    detalle.AD_TCAM = tc
        '                    detalle.AD_SEC_ORI_DES = 0
        '                    detalle.AD_IDCC = ""
        '                    detalle.AD_ES_DESTINO = 0
        '                    detalle.AD_IDMEDIOPAGO = ""
        '                    detalle.AD_MONTO_ORI = IIf(mon = 1, monto, detalle.AD_HABER)
        '                    detalle.AD_PORCE_DESTINO = 0
        '                    detalle.AD_ES_CONCI = 0
        '                    detalle.AD_ANHO_CONI = 0
        '                    detalle.AD_MES_CONCI = 0
        '                    detalle.AD_ES_INAFECTO = 0
        '                    detalle.AD_IDMONEDA = mon
        '                    detalle.AD_TDOC_REF = ""
        '                    detalle.AD_SDOC_REF = ""
        '                    detalle.AD_NDOC_REF = ""
        '                    detalle.AD_FDOC_REF = ""
        '                    detalle.AD_VDOC_REF = ""
        '                    detalle.AD_GLOSA = ""
        '                    ls_det.Add(detalle)
        '                    total_movi += detalle.AD_DEBE + detalle.AD_HABER

        '                    '//_________ C U E N T A  12   D E  C L I E N T E S _____________)_________________
        '                    Dim ruc As String = dt_detalles.Rows(j)("VAT_REGISTRATION").ToString()
        '                    Dim tdoc As String = dt_detalles.Rows(j)("DOCUMET_ID").ToString()
        '                    Dim sdoc As String = dt_detalles.Rows(j)("NUMBER_SERIE").ToString()
        '                    Dim ndoc As String = dt_detalles.Rows(j)("NUMBER_DOCUMENT").ToString()
        '                    Dim subd As String = "02" '//ventas
        '                    Dim tanexo As Integer = 1 '//clientes

        '                    If dt_detalles.Rows(j)("TYPE_DOC").ToString().Equals("HO") Then
        '                        subd = "02"
        '                        tanexo = 1
        '                    End If
        '                    ' //buscamos la cuenta contable
        '                    Dim drrr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CO_SP_S_CTA_PROVISION", subd, ruc, tdoc, sdoc, ndoc)
        '                    If drrr.HasRows Then
        '                        drrr.Read()
        '                        cta12_Clientes = drrr("RESULTADO").ToString()
        '                    End If
        '                    drrr.Close()
        '                    If cta12_Clientes.Equals(String.Empty) Then cta12_Clientes = _CuentaCliente
        '                    detalle = New LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET
        '                    detalle.AD_IDCAB = 0
        '                    detalle.AD_SECUENCIA = ls_det.Count + 1
        '                    detalle.AD_CUENTA = cta12_Clientes
        '                    detalle.AD_TANEXO = tanexo
        '                    detalle.AD_IDANEXO = ruc
        '                    detalle.AD_TDOC = tdoc
        '                    detalle.AD_SDOC = sdoc.PadLeft(5, Char.Parse("0"))
        '                    detalle.AD_NDOC = ndoc.PadLeft(15, Char.Parse("0"))
        '                    detalle.AD_FDOC = ""
        '                    detalle.AD_VDOC = ""
        '                    detalle.AD_DEBE = 0
        '                    detalle.AD_HABER = Math.Round(IIf(mon = 1, monto, monto * tc), 2)
        '                    detalle.AD_TCAM = tc
        '                    detalle.AD_SEC_ORI_DES = 0
        '                    detalle.AD_IDCC = ""
        '                    detalle.AD_ES_DESTINO = 0
        '                    detalle.AD_IDMEDIOPAGO = ""
        '                    detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, monto, detalle.AD_DEBE), 2)
        '                    detalle.AD_PORCE_DESTINO = 0
        '                    detalle.AD_ES_CONCI = 0
        '                    detalle.AD_ANHO_CONI = 0
        '                    detalle.AD_MES_CONCI = 0
        '                    detalle.AD_ES_INAFECTO = 0
        '                    detalle.AD_IDMONEDA = mon
        '                    detalle.AD_TDOC_REF = ""
        '                    detalle.AD_SDOC_REF = ""
        '                    detalle.AD_NDOC_REF = ""
        '                    detalle.AD_FDOC_REF = ""
        '                    detalle.AD_VDOC_REF = ""
        '                    detalle.AD_GLOSA = ""
        '                    ls_det.Add(detalle)
        '                Next 'IF del detalle de planilla
        '                '//ACTUALIZAMOS LOS TOTALES
        '                cab.AC_DEBE = total_movi
        '                cab.AC_HABER = total_movi
        '                '//Grabamos el voucher por ID planilla
        '                Guardar_Contabilizar_Caja_Cobranzas_Pago(cab, ls_det, False)
        '            Else
        '                MsgBox("La planilla no posee registros para llevar a Contabilidad.", MsgBoxStyle.Information)
        '                _ESTADO = False
        '            End If
        '        Else
        '            MsgBox("El documento ya fue enviado a  Contabilidad.", MsgBoxStyle.Information)
        '            _ESTADO = False
        '        End If 'de validacio =0
        '    Catch ex As Exception
        '        _ESTADO = False
        '        MsgBox(ex.Message)
        '    End Try
        '    Return _ESTADO
        'End Function


        Public Function Guardar_Contabilizar_Caja_Cobranzas_Pago(ByRef c As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_CAB, ld As List(Of LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET), edicion_ As Boolean)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                If edicion_ Then
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_D_ASIENTO_CAB", c.AC_ID, c.AC_IDSUBDIARIO, c.AC_ANHO, c.AC_MES)
                End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CAB_PAY_LETRA", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_ID_LETRA, c.AC_ID_LETRA_PAGO)
                c.AC_ID = idcab

                For Each d As LibContabilidad.ClsEntidades.CO_TB_ASIENTO_DET In ld

                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTO_DET", idcab, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA)
                Next
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Function



    End Class

    Public Class RECEIVABLE_LIST_LINE_PAY
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function VerificandoBancodeCuenta(ByVal _cuenta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_CUENTA_BANCO", _cuenta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function EliminarDetallesPlanillas_Pago_Proveedor(ByVal CodPlanilla As String, ByVal itemDoc As String, ByVal Tipodoc As String, ByVal numdoc As String, ByVal codcliente As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_PLANILLA_DETALLES_PAY", CodPlanilla, itemDoc, Tipodoc, numdoc, codcliente)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Sub Insert_Pago_Proveedor(ls_det As List(Of ClsEntidades.RECEIVABLE_LIST_LINE_PAY), ByVal MonedaCobranza As String, ByVal FECHA_PLANILLA As Date)

            If ls_det.Count = 0 Then Exit Sub

            Dim query As String = "SELECT ISNULL(MAX(CONVERT(INT,ITEM)),0) FROM RECEIVABLE_LIST_LINE_PAY WHERE ID = '" & ls_det(0).ID & "' "
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim LastItem As Integer = SqlHelper.ExecuteScalar(tr, CommandType.Text, query)
            'Grabamos los detalles

            '++++++++
            Dim _Consulta As String = String.Empty
            Dim sSQLHistLet As String = String.Empty
            Dim sSQLLetra As String = String.Empty
            Dim dtTipoCamb As DataTable, dtletras As DataTable, dt_detalle As DataTable
            dtTipoCamb = New DataTable

            For Each d As ClsEntidades.RECEIVABLE_LIST_LINE_PAY In ls_det
                With d
                    LastItem += 1
                    If .TYPE_DOC <> "NC" Then
                        .AMOUNT = .AMOUNT
                    Else
                        .AMOUNT = (Math.Abs(.AMOUNT)) * -1
                    End If
                    '++
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_RECEIVABLE_LIST_LINE_PAY", .ID, LastItem, .TYPE_DOC, .NUMBER_DOC, .TYPE_OPERATION, .REC_ID, .DATE_PLA, _
                                              .AMOUNT, MonedaCobranza, .SELL_RATE, .CREATE_DATE, .USER_ID, .COMMENT, .SALES_ID, .BANK_ID, .BANK_DESCRIPTION, .DOC_REF, _
                                              .NUM_REF, .IS_CASH_BANK, .AMOUNT_PER, .BANK_BUSSINESS_ID, .ACCOUNT_BANK_CHECK, .PAY_AUTO, .ANNEX_ID_AUX, .DOCUMET_ID, _
                                              .NUMBER_SERIE, .NUMBER_DOCUMENT, .MEDIOS_PAGO, .DATE_REF)
                    If .TYPE_DOC <> "NC" Then
                        If .CURRENCY_ID = "ME" Then
                            If MonedaCobranza = "ME" Then
                                .AMOUNT = .AMOUNT
                            Else
                                .AMOUNT = .AMOUNT / .SELL_RATE
                            End If
                        ElseIf .CURRENCY_ID = "MN" Then
                            If MonedaCobranza = "MN" Then
                                .AMOUNT = .AMOUNT
                            Else
                                .AMOUNT = .AMOUNT * .SELL_RATE
                            End If
                        End If
                    Else
                        If .CURRENCY_ID = "ME" Then
                            If MonedaCobranza = "ME" Then
                                .AMOUNT = (Math.Abs(.AMOUNT)) * -1
                            Else
                                .AMOUNT = (Math.Abs(.AMOUNT / .SELL_RATE) * -1)
                            End If
                        ElseIf .CURRENCY_ID = "MN" Then
                            If MonedaCobranza = "MN" Then
                                .AMOUNT = (Math.Abs(.AMOUNT) * -1)
                            Else
                                .AMOUNT = (Math.Abs(.AMOUNT * .SELL_RATE) * -1)
                            End If
                        End If
                    End If

                    sSQLHistLet = ""
                    dt_detalle = New DataTable("Letras_Pagos")
                    'validamos cancelacion de las letras
                    If .TYPE_DOC = "LT" Then
                        '_Consulta = "SELECT AMOUNT_BALANCE FROM CUSTOMER_BALANCE WHERE DOCUMENT_ID = 'LT' AND NUMBER_DOC = '" & .NUMBER_DOC & "'"
                        dt_detalle = SqlHelper.ExecuteDataset(tr, "CXC_SP_CUSTOMER_BALANCE_PAY_LT", .NUMBER_DOC).Tables(0) 'MostrandoDescripcion(_Consulta)
                        If dt_detalle.Rows.Count > 0 Then
                            If Math.Round(CDbl(dt_detalle.Rows(0).Item("AMOUNT_BALANCE").ToString), 3) = Math.Round(.AMOUNT, 3) Then
                                dt_detalle.Clear()
                                dt_detalle = Nothing
                                dt_detalle = New DataTable("Letras_Pagos")
                                '_Consulta = "SELECT * FROM LETTER WHERE LETTER_ID= '" & .NUMBER_DOC & "'"
                                dt_detalle = SqlHelper.ExecuteDataset(tr, "CXC_SP_LETTER_PAGOS", .NUMBER_DOC).Tables(0) 'MostrandoDescripcion(_Consulta)
                                If dt_detalle.Rows.Count > 0 Then
                                    Select Case Strings.Left(dt_detalle.Rows(0).Item("STATUS_ACT").ToString, 2)
                                        Case "CB", "CBPR", "CBRN"
                                            sSQLHistLet = "CBPA"
                                        Case "CR", "CRPR", "CRRN"
                                            sSQLHistLet = "CRPA"
                                        Case "DS", "DSPR", "DSRN"
                                            sSQLHistLet = "DSPA"
                                        Case "GR", "GRPR", "GRRN"
                                            sSQLHistLet = "GRPA"
                                        Case "EB"
                                            sSQLHistLet = "EBPA"
                                    End Select
                                End If
                                If sSQLHistLet <> "" Then SqlHelper.ExecuteNonQuery(tr, "CXC_SP_I_U_LETTER_PAY", .NUMBER_DOC, sSQLHistLet)
                            Else
                                sSQLHistLet = ""
                            End If
                        End If
                        dt_detalle.Clear()
                        dt_detalle = Nothing
                    End If
                    'fin de validamos cancelacion de las letras

                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_U_CUSTOMER_BALANCE_PAY ", .ANNEX_ID_AUX, .DOCUMET_ID, .NUMBER_DOC, .AMOUNT)
                End With
            Next
            tr.Commit()
        End Sub


        Public Sub InsertNC_Pago_Proveedor(ls_det As List(Of ClsEntidades.RECEIVABLE_LIST_LINE_PAY), ByVal Tipodoc As String, ByVal SerieDoc As String, _
                             ByVal NumeroDoc As String, ByVal monto As Double, ByVal MonedaCobranza As String, ByVal FECHA_PLANILLA As Date)

            Dim query As String = "SELECT ISNULL(MAX(ITEM),0) FROM RECEIVABLE_LIST_LINE_PAY WHERE ID = '" & ls_det(0).ID & "' "
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim LastItem As Integer = SqlHelper.ExecuteScalar(tr, CommandType.Text, query)
            'Grabamos los detalles
            Dim _TipoCambio_Ref As String = String.Empty
            Dim _Consulta As String = String.Empty
            Dim dtTipoCamb As DataTable
            dtTipoCamb = New DataTable
            Try
                For Each d As ClsEntidades.RECEIVABLE_LIST_LINE_PAY In ls_det
                    With d
                        LastItem += 1
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_RECEIVABLE_LIST_LINE_PAY", .ID, LastItem, .TYPE_DOC, .NUMBER_DOC, .TYPE_OPERATION, .REC_ID, .DATE_PLA, .AMOUNT, _
                                                    MonedaCobranza, .SELL_RATE, .CREATE_DATE, .USER_ID, .COMMENT, .SALES_ID, .BANK_ID, .BANK_DESCRIPTION, .DOC_REF,
                                                  .NUM_REF, .IS_CASH_BANK, .AMOUNT_PER, .BANK_BUSSINESS_ID, .ACCOUNT_BANK_CHECK, .PAY_AUTO, .ANNEX_ID_AUX,
                                                  .DOCUMET_ID, .NUMBER_SERIE, .NUMBER_DOCUMENT, .MEDIOS_PAGO)
                        If .CURRENCY_ID = "ME" Then
                            If MonedaCobranza = "ME" Then
                                .AMOUNT = .AMOUNT
                            Else
                                .AMOUNT = .AMOUNT / .SELL_RATE
                            End If
                        ElseIf .CURRENCY_ID = "MN" Then
                            If MonedaCobranza = "MN" Then
                                .AMOUNT = .AMOUNT
                            Else
                                .AMOUNT = .AMOUNT * .SELL_RATE
                            End If
                        End If
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_U_CUSTOMER_BALANCE_PAY", .ANNEX_ID_AUX, .DOCUMET_ID, .NUMBER_SERIE + .NUMBER_DOCUMENT, Math.Abs(CDbl(.AMOUNT)))
                        Dim dtDetalle As DataTable
                        dtDetalle = New DataTable
                        dtDetalle = SqlHelper.ExecuteDataset(tr, "CX_SP_S_VERIFICACION_COD_NC_PAY", .ANNEX_ID_AUX, SerieDoc + NumeroDoc).Tables(0)
                        Dim Moneda As String = String.Empty
                        Moneda = dtDetalle.Rows(0).Item("CURRENCY_ID").ToString
                        If Moneda = "ME" Then
                            If MonedaCobranza = "ME" Then
                                .AMOUNT = (Math.Abs(CDbl(monto))) * -1
                            Else
                                .AMOUNT = (Math.Abs(CDbl(monto)) / .SELL_RATE) * -1
                            End If
                        ElseIf Moneda = "MN" Then
                            If MonedaCobranza = "MN" Then
                                .AMOUNT = (Math.Abs(CDbl(monto))) * -1
                            Else
                                .AMOUNT = (Math.Abs(CDbl(monto)) * .SELL_RATE) * -1
                            End If
                        End If
                        SqlHelper.ExecuteNonQuery(tr, "CX_SP_U_CUSTOMER_BALANCE_PAY", .ANNEX_ID_AUX, Tipodoc, SerieDoc & NumeroDoc, (Math.Abs(CDbl(.AMOUNT))) * -1)
                    End With
                Next
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function get_planilla_Det_xID_Pago_Proveedor(num_planilla As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_RECEIVABLE_DET_PAY", num_planilla).Tables(0)
        End Function

        Public Function get_planilla_Det_xItem(num_planilla As String, item As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_RECEIVABLE_DET_XITEM", num_planilla, item).Tables(0)
        End Function

        Public Function VerificandoNumeracionDocumentosNC_Pago_Proveedor(ByVal Cliente As String, ByVal NumDoc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_VERIFICAR_COD_NC_PAY", Cliente, NumDoc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function ActualizacionDocumentosEliminados_Pago_Proveedor(ByVal CodCliente As String, ByVal Tipodoc As String, ByVal numdoc As String, ByVal Monto As Double) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_CUSTOMER_BALANCE_ELIMINADOS_PAY", CodCliente, Tipodoc, numdoc, Monto)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


    End Class



End Class
