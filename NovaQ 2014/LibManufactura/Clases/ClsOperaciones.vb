Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion

Public Class ClsOperaciones

    Public Class ORDER_PRODUCTION
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Comprometer_Mercaderia(ByVal DTDATOS As DataTable, ByVal NRO_OF As String, ByVal WHO_ID As String) As Boolean
            Dim SQL As String
            Dim COD As String = String.Empty
            Dim CAN_ANTE As Double = 0
            Dim CAN As Double = 0
            Try
                If DTDATOS.Rows.Count > 0 Then
                    For Each row As DataRow In DTDATOS.Rows
                        CAN_ANTE = 0
                        CAN = 0
                        'If row(8) = "MP" Then
                        COD = row(1).ToString
                        CAN = CDbl(row(6))
                        SQL = String.Empty
                        SQL = "Select ISNULL(QTY_REFERENCE,0) [QTY_REFERENCE]  from dbo.PART_QTY WHERE  PART_ID='" & COD & "' AND WAREHOUSE_ID='" & WHO_ID & "'"
                        Dim dtComprometer As New DataTable
                        dtComprometer = SqlHelper.ExecuteDataset(cn, CommandType.Text, SQL).Tables(0)
                        If dtComprometer.Rows.Count() <> 0 Then
                            CAN_ANTE = CDbl(dtComprometer.Rows(0).Item("QTY_REFERENCE"))
                        End If
                        CAN = CAN + CAN_ANTE
                        SQL = String.Empty
                        SQL = "UPDATE  dbo.PART_QTY SET QTY_REFERENCE=" & CAN & " WHERE WAREHOUSE_ID='" & WHO_ID & "' AND PART_ID='" & COD & "'"
                        SqlHelper.ExecuteNonQuery(cn, CommandType.Text, SQL)
                        'End If
                    Next
                End If
                SQL = String.Empty
                SQL = "UPDATE  dbo.ORDER_PRODUCTION SET COMPROMETIDO='1' WHERE ID='" & NRO_OF & "' AND WHO_ID='" & WHO_ID & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, SQL)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Public Sub Insert_Lista_Equipos(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_I_LISTA_EQUIPOS", .TYPE_ID, .NAME, .CODIGO_EQUIPO)
            End With
        End Sub

        Public Sub Insert_Linea_Produccion(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_I_LINEA_PRODUCCION", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Sub Insert_Proceso_Produccion(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_I_PROCESO_PRODUCCION", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Sub Insert_Personal(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_I_PERSONAL_PRODUCCION", .TYPE_ID, .NAME, .CODIGO_EQUIPO)
            End With
        End Sub

        Public Sub Update_Lista_Equipos(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_U_LISTA_EQUIPOS", .TYPE_ID, .NAME, .CODIGO_EQUIPO)
            End With
        End Sub
        Public Sub Update_Linea_Produccion(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_U_LINEA_PRODUCCION", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Sub Update_Proceso_Produccion(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_U_PROCESO_PRODUCCION", .TYPE_ID, .NAME)
            End With
        End Sub

        Public Sub Update_Personal(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_U_PERSONAL_PRODUCCION", .TYPE_ID, .NAME, .CODIGO_EQUIPO)
            End With
        End Sub

        Public Sub Delete_Lista_Equipos(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_D_LISTA_EQUIPOS", .TYPE_ID)
            End With
        End Sub

        Public Sub Delete_Linea_Produccion(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_D_LINEA_PRODUCCION", .TYPE_ID)
            End With
        End Sub

        Public Sub Delete_Proceso_Produccion(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_D_PROCESO_PRODUCCION", .TYPE_ID)
            End With
        End Sub

        Public Sub Delete_Personal(entidad As ClsEntidades.PERSONAL)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "MANTENIMIENTO_SP_D_PERSONAL_PRODUCCION", .TYPE_ID)
            End With
        End Sub

        Public Function get_Lista_Equipos_Existe(ByVal _codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LISTA_EQUIPOS_EXISTE", _codigo).Tables(0)
        End Function

        Public Function get_Linea_Produccion_Existe(ByVal _codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LINEA_PRODUCCION_EXISTE", _codigo).Tables(0)
        End Function

        Public Function get_Proceso_Produccion_Existe(ByVal _codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_PROCESO_PRODUCCION_EXISTE", _codigo).Tables(0)
        End Function

        Public Function get_Personal_Existe(ByVal _codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_PERSONAL_PRODUCCION_EXISTE", _codigo).Tables(0)
        End Function

        Public Function get_Codigo_Lista_Equipo() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LISTA_EQUIPOS_OBTENER_CODIGO").Tables(0)
        End Function

        Public Function get_Codigo_Linea_Produccion() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LINEA_PRODUCCION_OBTENER_CODIGO").Tables(0)
        End Function

        Public Function get_Codigo_Proceso_Produccion() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_PROCESO_PRODUCCION_OBTENER_CODIGO").Tables(0)
        End Function

        Public Function get_Codigo_Personal() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_PERSONAL_PRODUCCION_OBTENER_CODIGO").Tables(0)
        End Function

        Public Function get_Lista_Equipos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LISTA_EQUIPOS").Tables(0)
        End Function

        Public Function get_Lista_Lineas_Produccion() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LISTA_LINEA_PRODUCCION").Tables(0)
        End Function

        Public Function get_Lista_Procesos_Produccion() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LISTA_PROCESOS_PRODUCCION").Tables(0)
        End Function

        Public Function get_Lista_Personal() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_LISTA_PERSONAL_PRODUCCION").Tables(0)
        End Function

        Public Function Eliminar_Proceso_Costeo(ByVal codigo As Integer) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CTR_SP_D_PROCESO_COSTEO", codigo)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Insert_Importar_Costos_MP_EE(ls_det As List(Of ClsEntidades.PART)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)

            Try

                For Each d As ClsEntidades.PART In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PART_SP_I_U_COSTOS_MP_EE ", .ID, .PESO, .UNIT_PRICE)
                    End With
                Next
                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Ejecutar_Eliminacion_Movimientos_Temporales(ByVal _nombre_sp As String) As Boolean
            Dim estado As Integer

            Try
                estado = SqlHelper.ExecuteNonQuery(cn, _nombre_sp)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

        End Function
        Public Function CopyDataTableBulk_Importar_Costos_MP_EE(ByVal dTable As DataTable, ByVal STRNomTablaDestino As String) As Boolean
            Try
                Dim mySqlBulk As SqlClient.SqlBulkCopy = New SqlClient.SqlBulkCopy(cn)
                mySqlBulk.DestinationTableName = STRNomTablaDestino
                mySqlBulk.WriteToServer(dTable)
                'cn.Close()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Public Function Mostrar_Documentos_Importados_Costos_MP_EE(ByVal _opcion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFAC_IMP_COSTOS_MP_EE", _opcion).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function get_Lista_Costos_MP_EE(ByVal _tipo_precio As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_PART_LISTA_COSTOS_MP_EE", _tipo_precio).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function


        Public Function Liquidacion_Manual_OF(ByVal codigo As String, ByVal almacen As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "MANUFACT_SP_U_ORDER_PRODUCTION", codigo, almacen)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Sub Actualizacion_Costos_MP_EE(ByVal HORA As String, ByVal USUARIO As String, ByVal DATOS As DataTable, ByVal progreso As ProgressBar, ByVal IndicadorMaquila As Integer)
            Dim trs As SqlTransaction
            trs = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim CODIGO_ART As String = String.Empty
                Dim COSTO As String = String.Empty
                Dim COSTO_ME As String = String.Empty

                progreso.Minimum = 0
                progreso.Maximum = DATOS.Rows.Count()
                If DATOS.Rows.Count() <> 0 Then
                    For i As Integer = 0 To DATOS.Rows.Count() - 1
                        CODIGO_ART = String.Empty
                        COSTO = String.Empty
                        COSTO_ME = String.Empty

                        CODIGO_ART = DATOS.Rows(i).Item("Codigo").ToString

                        If String.IsNullOrEmpty(DATOS.Rows(i).Item("Costo").ToString) Then
                            COSTO = 0.0
                        Else
                            COSTO = DATOS.Rows(i).Item("Costo").ToString
                        End If

                        If String.IsNullOrEmpty(DATOS.Rows(i).Item("CostoME").ToString) Then
                            COSTO_ME = 0.0
                        Else
                            COSTO_ME = DATOS.Rows(i).Item("CostoME").ToString
                        End If

                        progreso.Value = i

                        '-----Precio Articulo
                        SqlHelper.ExecuteNonQuery(trs, "PART_SP_I_U_COSTOS_MP_EE", CODIGO_ART, CDbl(COSTO), CDbl(COSTO_ME))

                        progreso.PerformStep()
                    Next
                End If
                progreso.Value = 0
                trs.Commit()
                trs.Dispose()
            Catch ex As Exception
                trs.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function Mostrar_OF_Adicionales(ByVal _numero_op As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANUFACT_SP_S_ADICIONALES", _numero_op).Tables(0)
        End Function

        Public Function Genera_Descarga(ByVal codigo As String, ByVal almacen As String, ByVal usuario As String, ByVal tc As Double) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PROD_SP_I_PRODUCCION_EGRESOS", codigo, almacen, usuario, tc).Tables(0)
        End Function

        Public Function Liberar_Mercaderia(ByVal DTDATOS As DataTable, ByVal NRO_OF As String, ByVal WHO_ID As String) As Boolean
            Dim SQL As String
            Dim COD As String = String.Empty
            Dim CAN_ANTE As Double = 0
            Dim CAN As Double = 0
            Try
                If DTDATOS.Rows.Count > 0 Then
                    For Each row As DataRow In DTDATOS.Rows
                        CAN_ANTE = 0
                        CAN = 0
                        'If row(8) = "MP" Then
                        COD = row(1).ToString
                        CAN = CDbl(row(6))
                        SQL = String.Empty
                        SQL = "select ISNULL(QTY_REFERENCE,0) [QTY_REFERENCE] from  dbo.PART_QTY WHERE  PART_ID='" & COD & "' AND WAREHOUSE_ID='" & WHO_ID & "'"
                        Dim dtComprometer As New DataTable
                        dtComprometer = SqlHelper.ExecuteDataset(cn, CommandType.Text, SQL).Tables(0)
                        If dtComprometer.Rows.Count() <> 0 Then
                            CAN_ANTE = CDbl(dtComprometer.Rows(0).Item("QTY_REFERENCE"))
                        End If
                        CAN = Math.Round(CAN_ANTE - CAN, 6)
                        SQL = String.Empty
                        SQL = "UPDATE  dbo.PART_QTY SET QTY_REFERENCE=" & CAN & " WHERE WAREHOUSE_ID='" & WHO_ID & "' AND PART_ID='" & COD & "'"
                        SqlHelper.ExecuteNonQuery(cn, CommandType.Text, SQL)
                        'End If
                    Next
                End If
                SQL = String.Empty
                SQL = "UPDATE  dbo.ORDER_PRODUCTION SET COMPROMETIDO='0' WHERE ID='" & NRO_OF & "' AND WHO_ID='" & WHO_ID & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, SQL)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Formulacion(ByVal codigo As String, ByVal almacen As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CTR_SP_D_ORDEN_PROD", codigo, almacen)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Modo_Edicion_Cabecera(ByVal Id As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_OP_EDICION_CABECERA", Id).Tables(0)
        End Function

        Public Function Modo_Edicion_Detalle(ByVal Id As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_OP_EDICION_DETALLE", Id).Tables(0)
        End Function

        Public Function Mostrar_Consulta(ByVal _Consulta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Ejecutar_Consulta(ByVal _Consulta As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, _Consulta)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Mostrar_Documentos_Principal_Materiales(ByVal id As String) As DataTable
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim dtResultado As DataTable
            Dim dtResPart As DataTable
            dtResultado = New DataTable("Materiales_Part")
            dtResPart = New DataTable()
            Try
                dtResultado = SqlHelper.ExecuteDataset(tr, "CTR_SP_S_ORDEN_PROD_MAT_ORDER_PROD", id).Tables(0)
                If dtResultado.Rows.Count() <> 0 Then
                    'dtResPart = SqlHelper.ExecuteDataset(tr, "CTR_SP_S_ORDEN_PROD_MATERIAL_PRINCIPAL", id, dtResultado.Rows(0).Item("PART_FORM").ToString, dtResultado.Rows(0).Item("PART_FORM_EE").ToString, _
                    '                          dtResultado.Rows(0).Item("WHO_ID").ToString, dtResultado.Rows(0).Item("QTY").ToString, dtResultado.Rows(0).Item("VOLUMEN_LLENADO").ToString, _
                    '                          dtResultado.Rows(0).Item("TEXTO_COMPOSICION").ToString, dtResultado.Rows(0).Item("LOTE").ToString, dtResultado.Rows(0).Item("COMPROMETIDO").ToString).Tables(0)

                    dtResPart = SqlHelper.ExecuteDataset(tr, "CTR_SP_S_ORDEN_PROD_MATERIAL_PRINCIPAL", id, dtResultado.Rows(0).Item("PART_FORM").ToString, dtResultado.Rows(0).Item("PART_FORM_EE").ToString, _
                           dtResultado.Rows(0).Item("WHO_ID").ToString, CDbl(dtResultado.Rows(0).Item("QTY").ToString)).Tables(0)
                    If dtResPart.Rows.Count() = 0 Then
                        dtResPart = New DataTable()
                        dtResPart = SqlHelper.ExecuteDataset(tr, "CTR_SP_S_ORDEN_PROD_MATERIAL_PRINCIPAL_SUB", dtResultado.Rows(0).Item("PART_FORM").ToString).Tables(0)
                    End If
                End If
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
            End Try
            Return dtResPart
        End Function


        Public Function Mostrar_Documentos_Principal(ByVal Tipodoc As String, ByVal opcion As String, ByVal FECHA_INI As String, ByVal FECHA_FIN As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_PLANIFICA_PRINCIPAL", Tipodoc, opcion, FECHA_INI, FECHA_FIN).Tables(0)
        End Function


        Public Function Mostrar_Documentos_Principal_Verifica_Stock(ByVal Tipodoc As String, ByVal opcion As Integer, ByVal fecha_ini As String, ByVal fecha_fin As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_PLANIFICA_PRINCIPAL_VERIFCA_STOCK", Tipodoc, opcion, fecha_ini, fecha_fin).Tables(0)
        End Function


        Public Function Mostrar_Documentos_Orden_Fabricacion(ByVal Tipodoc As String, ByVal opcion As String, ByVal FECHA_INI As String, ByVal FECHA_FIN As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_ORDEN_FABRICACION_PRINCIPAL", Tipodoc, opcion, FECHA_INI, FECHA_FIN).Tables(0)
        End Function


        Public Function Mostrar_Articulos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "lista_producto").Tables(0)
        End Function


        Public Function Mostrar_FormulaMp() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "lista_formula").Tables(0)
        End Function

        Public Function Mostrar_FormulaEe() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "lista_formulaee").Tables(0)
        End Function

        Public Function Mostrando_Detalles_Articulos(ByVal Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_OREDEN_PRODUC_ARTICULO", Codigo).Tables(0)
        End Function

        Public Function Mostrar_Almacenes(ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_ALMACENES", codigo).Tables(0)
        End Function

        Public Function GuardarOrdenProduccion(ByVal Ent_cab As ClsEntidades.ORDER_PRODUCTION, lista As List(Of ClsEntidades.ORDER_PRODUCTION_LINE), lista_cabecera As List(Of ClsEntidades.ORDER_PRODUCTION)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim dtResultado As DataTable
            Dim dtResPart As DataTable
            Try
                For Each e As ClsEntidades.ORDER_PRODUCTION In lista_cabecera
                    With e
                        SqlHelper.ExecuteNonQuery(tr, "CTR_SP_I_ORDEN_PROD_CAB", .ID, .WHO_ID, .DOCUMENT_DATE, .DATE_INIT, .DATE_OUT, .TURNO, _
                                                  .DOCUMENT_REF, .USER_ID, .STATUS, .COMMENT, .COMPROMETIDO, .MONEDA, .QTY_PRODUCID, .LIQUID, _
                                                  .VENCIMIENTO, .LOTE, .RS, .VOLUMEN_LLENADO, .TEXTO_COMPOSICION, .FECHA_REGISTRO)
                        SqlHelper.ExecuteNonQuery(tr, "CTR_SP_D_ORDEN_PROD_DET_EDICION", .ID, .WHO_ID)
                    End With
                Next

                For Each d As ClsEntidades.ORDER_PRODUCTION_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CTR_SP_I_ORDEN_PROD_DET", .ID, .WHO_ID, .PART_ID, .UNIT_PART, .QTY, .PART_FORM, .DESCRIPTION_PART, .DESCRIPTION_FORM, _
                                                  .PART_FORM_EE, .DESCRIPTION_FORM_EE, .COMMENT, "", 0)


                        dtResultado = New DataTable("Producccion_Detalles")
                        dtResultado = SqlHelper.ExecuteDataset(tr, "CTR_SP_S_OREDEN_PRODUC_CODIGO", .ID, .WHO_ID).Tables(0)

                        If dtResultado.Rows.Count() <> 0 Then
                            SqlHelper.ExecuteNonQuery(tr, "CTR_SP_I_ORDEN_PRODUC_DETALLE", dtResultado.Rows(0).Item("PART_FORM").ToString, _
                                                      dtResultado.Rows(0).Item("PART_FORM_EE").ToString, .ID)
                            ''lOTES
                            'dtResPart = New DataTable()
                            'dtResPart = SqlHelper.ExecuteDataset(tr, "CTR_SP_S_ORDEN_PROD_PART", dtResultado.Rows(0).Item("PART_FORM_EE").ToString).Tables(0)
                            'If dtResPart.Rows.Count() <> 0 Then
                            '    SqlHelper.ExecuteNonQuery(tr, "CTR_SP_I_U_FORMULACION_CAB", Ent_cab.LOTE, Ent_cab.WHO_ID, _
                            '                              dtResPart.Rows(0).Item("PART_ID").ToString, Ent_cab.VENCIMIENTO)
                            'End If
                        End If
                    End With
                Next


                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function

    End Class



    Public Class PURCHASE_ORDER
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Function Eliminar_Oden_Compra(ByVal CODIGO As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "PUR_SP_D_ORDEN_COMPRA", CODIGO)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Modo_Edicion_Cabecera(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_CABECERA", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_DETALLE", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function GuardarOrdenCompra(ByVal Ent_cab As ClsEntidades.PURCHASE_ORDER, lista As List(Of ClsEntidades.PURCHASE_ORDER_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "PUR_SP_D_FORMULACION_DET_EDICION", Ent_cab.ID, Ent_cab.TYPE)

                With Ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_CAB", .ID, .TYPE, .DOCUMENT_DATE, .VENDOR_ID, .NUMBER_ESTIMATING, .CURRENCY_TYPE, .TERMS_NAME, _
                                              .SELL_RATE, .PROMISE_DATE, .COMMENT, .AUTORIZED_ID, .BUYER_PURCHASE_ID, .TIME_DLV, .ADDR_DLV, .STATUS_ID, .AMOUNT, .DISCOUNT, _
                                              .AMOUNT_TAX, .AMOUNT_SALES, .UPDATE_DATE, .UPDATE_HOUR, .USER_ID, .CURR_EXCHANGE_TYPE, .NAME_FACT, .VAT_REGISTRATION_FACT, _
                                              .ADDR_FACT, .REFER_DOCUMENT_TYPE, .REFER_DOCUMENT_NUMBER, .PROJECT_ID, "0", 0, 0)
                End With

                For Each d As ClsEntidades.PURCHASE_ORDER_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_DET", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .UNIT_REFERENCE, .FACTOR_REFERENCE, .QTY, _
                                                  .PRICE, .DISCOUNT_PER, .DISCOUNT, .AMOUNT_TAX, .PERCENT_TAX, .PRICE_NET, .AMOUNT_TOTAL, .AMOUNT_TOTAL_NET, .QTY_ENTER, .QTY_OUT, _
                                                  .STATUS_ID, .COMMENT1, .TEXT_COMMENT, .IS_VAT, .PRICE_UNIT, .CCOST_ID, .PROJECT_ID, .AREA_ID, .COTI_ID, .REQUI_ID, 0, "")
                    End With
                Next
                'actualizamos la numeracion
                SqlHelper.ExecuteNonQuery(tr, "PUR_SP_U_CORRELATIVO", "OC", Ent_cab.ID)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        Public Function DetalleInicialOrdenCompras(ByVal Formula_mp As String, ByVal Formula_ee As String, ByVal Id_OP As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_ORDEN_COMPRA_DETALLES", Formula_mp, Formula_ee, Id_OP).Tables(0)
        End Function

        Public Function Consultas_Generales(ByVal _Consulta As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
        End Function


        Public Function Mostrar_Documentos_Principal(ByVal CODIGO As String, ByVal STIPO As String, ByVal FECHA_INI As Date, FECHA_FIN As Date, OPCION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_LIST_PURCHASE_ORDER", "", STIPO, FECHA_INI, FECHA_FIN, OPCION, 2).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
    End Class


    Public Class FORMULATION
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Modo_Edicion_Detalle_Formula_EE(ByVal Almacen As String, ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_EDICION_DETALLE_EE", Almacen, codigo).Tables(0)
        End Function

        Public Function get_Detalle_Archivos_Formulas(ByVal _id As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_BANDEJA_NO_CONFORMIDAD_FILES_LISTA", _id).Tables(0)
        End Function

        Public Function Modo_Edicion_Cabecera_Proceso_Costeo(ByVal codigo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFACT_SP_S_PROCESO_COSTEO", codigo).Tables(0)
        End Function
        Public Function Modo_Edicion_Detalle_Proceso_Costeo_MP(ByVal codigo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFACT_SP_S_PROCESO_COSTEO_MP", codigo).Tables(0)
        End Function
        Public Function Modo_Edicion_Detalle_Proceso_Costeo_PT(ByVal codigo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFACT_SP_S_PROCESO_COSTEO_PT", codigo).Tables(0)
        End Function
        Public Function Modo_Edicion_Detalle_Proceso_Costeo_PT_LINE(ByVal codigo As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFACT_SP_S_PROCESO_COSTEO_PT_LINE", codigo).Tables(0)
        End Function

        Public Function Modo_Edicion_Cabecera(ByVal codigo As String, ByVal Almacen As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_EDICION_CABECERA", codigo, Almacen).Tables(0)
        End Function

        Public Function Modo_Edicion_Detalle(ByVal Almacen As String, ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_EDICION_DETALLE", Almacen, codigo).Tables(0)
        End Function

        Public Function Modo_Edicion_Detalle_HC(ByVal Almacen As Integer, ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_EDICION_DETALLE_HC", Almacen, codigo).Tables(0)
        End Function

        Public Function Modo_Edicion_Detalle_Procesos(ByVal Almacen As String, ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_EDICION_DETALLE_PROCESOS", Almacen, codigo).Tables(0)
        End Function

        Public Function Modo_Edicion_Detalle_Procesos_HC(ByVal Almacen As Integer, ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_EDICION_DETALLE_PROCESOS_HC", Almacen, codigo).Tables(0)
        End Function


        Public Function Modo_Edicion_Detalle_Historial_Cambios(ByVal Almacen As String, ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_EDICION_DETALLE_FORMULATION_HISTORIAL_CAMBIOS", Almacen, codigo).Tables(0)
        End Function

        Public Function Modo_Edicion_Detalle_Proceso_Costeo_MP_REPROCESO(ByVal codigo As Integer, Optional ByVal _porcentaje As Integer = 100) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFACT_SP_S_PROCESO_COSTEO_MP_I", codigo, _porcentaje).Tables(0)
        End Function
        Public Function Modo_Edicion_Detalle_Proceso_Costeo_PT_REPROCESO(ByVal codigo As Integer, Optional ByVal _porcentaje As Integer = 100) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFACT_SP_S_PROCESO_COSTEO_PT_I", codigo, _porcentaje).Tables(0)
        End Function
        Public Function Modo_Edicion_Detalle_Proceso_Costeo_PT_LINE_REPROCESO(ByVal codigo As Integer, Optional ByVal _porcentaje As Integer = 100) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "LOS_MANUFACT_SP_S_PROCESO_COSTEO_PT_LINE_I", codigo).Tables(0)
        End Function

        Public Function Mostrar_Articulo_Manual(ByVal Almacen As String, ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_ARTICULO_MANUAL", Almacen, codigo).Tables(0)
        End Function


        Public Function Mostrar_Almacenes(ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_ALMACENES", codigo).Tables(0)
        End Function

        Public Function GuardarProceso_Costeo(ByVal ent_cab As ClsEntidades.PROCESO_COSTEO, lista_mp As List(Of ClsEntidades.PROCESO_COSTEO_MP), _
                                              lista_pt As List(Of ClsEntidades.PROCESO_COSTEO_PT), lista_pt_line As List(Of ClsEntidades.PROCESO_COSTEO_PT_LINE), _
                                              ByVal _estado_edicion As Boolean) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim _codigo As Integer = 0
                With ent_cab
                    If _estado_edicion Then
                        SqlHelper.ExecuteNonQuery(tr, "LOS_MANUFACT_SP_U_PROCESO_COSTEO_I", .ID, .USER_ID, .GLOSA, .LOTE)
                        SqlHelper.ExecuteNonQuery(tr, "LOS_MANUFACT_SP_D_PROCESO_COSTEO", .ID)
                        _codigo = .ID
                    Else
                        _codigo = SqlHelper.ExecuteScalar(tr, "LOS_MANUFACT_SP_I_PROCESO_COSTEO_I", .ID, .FECHA, .ID_FORMULA, .USER_ID, .GLOSA, .LOTE)
                    End If

                End With

                For Each d As ClsEntidades.PROCESO_COSTEO_MP In lista_mp
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "LOS_MANUFACT_SP_I_PROCESO_COSTEO_MP", _codigo, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .AVERAGE_COST)
                    End With
                Next

                For Each d As ClsEntidades.PROCESO_COSTEO_PT In lista_pt
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "LOS_MANUFACT_SP_I_PROCESO_COSTEO_PT", _codigo, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .CANTIDAD,
                                                  .COSTO_UNITARIO, .COSTOS_VARIOS, .SUB_TOTAL, .IGV, .COSTO_FINAL)
                    End With
                Next

                For Each d As ClsEntidades.PROCESO_COSTEO_PT_LINE In lista_pt_line
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "LOS_MANUFACT_SP_I_PROCESO_COSTEO_PT_LINE", _codigo, .ITEM_PT, .ITEM, .PART_ID, .PART_DESCRIPTION, .COSTO_UNITARIO)
                    End With
                Next

                If _estado_edicion Then
                    SqlHelper.ExecuteNonQuery(tr, "LOS_MANUFACT_SP_U_PROCESO_COSTEO_U_COSTO_PT_EDICION", _codigo)
                Else
                    SqlHelper.ExecuteNonQuery(tr, "LOS_MANUFACT_SP_U_PROCESO_COSTEO_U_COSTO_PT", _codigo)
                End If


                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function

        Public Function Mostrar_Almacenes_LiquidacionOF() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PROD_SP_S_ALMACENES").Tables(0)
        End Function

        Public Function Obtener_Stock(ByVal codigo As String, ByVal almacen As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PROD_SP_S_STOCK", codigo, almacen).Tables(0)
        End Function

        Public Function Obtener_Costo_Produccion(ByVal id_formula As String, ByVal id_of As String, ByVal moneda As String, ByVal cantidad_of As Double, ByVal cantidad_terminada As Double, ByVal tc As Double) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PROD_SP_S_COSTO_PRODUCCION", id_formula, id_of, moneda, cantidad_of, cantidad_terminada, tc).Tables(0)
        End Function
        Public Function Obtener_Costo_Produccion_EE(ByVal id_prod As String, ByVal moneda As String, ByVal almacen As String, ByVal tc As Double) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PROD_SP_S_COSTO_PRODUCCION_EE", id_prod, moneda, tc, almacen).Tables(0)
        End Function
        Public Function Mostrar_Documentos_Principal(ByVal Tipodoc As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_FORMULACION_DOCUMENTO_PRINCIPAL", Tipodoc).Tables(0)
        End Function




        Public Function UnidadesReferencia() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CTR_SP_S_UNIT").Tables(0)
        End Function

        Public Function UnidadesReferencia_Equivalencia(ByVal Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CTR_SP_S_UNIT_EQUIVALENCIA", Codigo).Tables(0)
        End Function

        Public Function Eliminar_Formulacion(ByVal Codigo As String, ByVal almacen As String) As Boolean
            Try
                Return SqlHelper.ExecuteNonQuery(cn, "CTR_SP_D_FORMULACION_DET", Codigo, almacen)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function GuardarFormulacionProduccion(ByVal ent_cab As ClsEntidades.FORMULATION, lista As List(Of ClsEntidades.FORMULATION_LINE), _
                                                     lista_procesos As List(Of ClsEntidades.FORMULATION_LINE_PROCESOS)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "CTR_SP_I_FORMULACION_CAB", .ID, .WHO_ID, .DESCRIPTION, .DOCUMENT_DATE, .USER_ID, .STATUS, .COMMENT, .MONEDA, .TYPE_DOC, .DESCARGA_TOTAL)
                End With
                'Borrando detalles
                SqlHelper.ExecuteNonQuery(tr, "CTR_SP_D_FORMULACION_DET_EDICION", ent_cab.ID, ent_cab.WHO_ID)

                For Each d As ClsEntidades.FORMULATION_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CTR_SP_I_FORMULACION_DET", .ID, .WHO_ID, .ITEM, .PART_ID, .QTY, .AVERAGE_COST, .STATUS, .TYPE, .DESCRIPTION, .SECUENCE, _
                                                  .UNIT, .EQUIVALENCIA, .POR_EXCESO, .DESCARGA_TOTAL, .QTY_TEORICA)
                    End With
                Next

                For Each d As ClsEntidades.FORMULATION_LINE_PROCESOS In lista_procesos
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "CTR_SP_I_FORMULACION_DET_PROCESOS", .ID, .ITEM, .MAQUINA, .PROCESO)
                    End With
                Next
                'actualizamos la numeracion
                SqlHelper.ExecuteNonQuery(tr, "MANUFAC_SP_U_NUMBER_DOCUMENT", "FO", "001")
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function

        Public Function GuardarLiquidacionProduccion(ByVal ent_cab As ClsEntidades.LIQUIDACION_OP, lista As List(Of ClsEntidades.LIQUIDACION_OP_LINE), ByVal tc As Double) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "PROD_SP_I_LIQUIDACION_OP", .ID, .FECHA, .USER_ID)
                End With

                For Each d As ClsEntidades.LIQUIDACION_OP_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PROD_SP_D_LIQUIDACION_OP_LINE", .ID, .PART_ID, .DESCRIPTION, .UNIT, .PART_ID_PRES, _
                                                  .DESCRIPTION_PRES, .UNIT_PRES, .QTY, .AVERAGE_COST_PROM, .AVERAGE_COST_ULT, .AVERAGE_COST_PRES_PROM, _
                                                  .AVERAGE_COST_PRES_ULT, .WHO_PRES, .AVERAGE_COST_TOTAL_PROM, .AVERAGE_COST_TOTAL_ULT, .WHO_INGRESO, _
                                                  .WHO_DES_INGRESO, .MONEDA, .TIPO_LIQUIDACION)
                    End With
                Next
                SqlHelper.ExecuteNonQuery(tr, "PROD_SP_U_ORDER_PRODUCTION", ent_cab.ID)
                SqlHelper.ExecuteNonQuery(tr, "PROD_SP_I_LIQUIDACION_INGRESOS", ent_cab.ID, ent_cab.USER_ID, tc)
                SqlHelper.ExecuteNonQuery(tr, "PROD_SP_I_LIQUIDACION_EGRESOS", ent_cab.ID, ent_cab.USER_ID, tc)
                SqlHelper.ExecuteNonQuery(tr, "PROD_SP_I_LIQUIDACION_EGRESOS_ADICIONALES", ent_cab.ID, ent_cab.USER_ID, tc)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function
    End Class


    Public Class ORDERS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function GET_DEVOLVER_DATOS_ENVIO_EMAIL(ByVal _CODIGO As String) As DataTable
            Try

                'Dim alma As String = String.Empty
                'alma = MostrandoAlmacenes()
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_DATOS_ENVIO_EMAIL", _CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function Despachar_Pedido(ByVal STRNumPedido As String, ByVal _responsable As String, ByVal _vehiculo As String, ByVal _usuario As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "PED_SP_S_DESPACHAR_PEDIDOS_I", STRNumPedido, _responsable, _vehiculo, _usuario)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Parte_Produccion_Historial_Personal_Preparacion_Especial(ByVal _equipo As String, ByVal fecha As String, ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MANTENIMIENTO_OP_HISTORIAL_PERSONAL_PREPARACION_ESPECIAL", _equipo, fecha, turno).Tables(0)
        End Function

        Public Function Guardar_Parte_Produccion_Historial_Personal_Preparacion_Especial_Equipo(ls_det As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                With ls_det
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_PARTE_PRODUCCION_HISTORIAL_PERSONAL_ACT_NO_PROGRAMADA", .USER_ID, .EQUIPO_COD, .DESCRIPCION, _
                                              .NUMERO_OP, .USER_ID_REGISTRO, .PC_ID_REGISTRO, .TURNO, .FECHA_TURNO, .NUMERO_OP_II, .MOTIVO_ACT_NO_PROGRAMADA)
                End With

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Parte_Produccion_Historial_Personal_No_Operatividad(ByVal _equipo As String, ByVal fecha As String, ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MANTENIMIENTO_OP_HISTORIAL_PERSONAL_NO_OPERATIVIDAD", _equipo, fecha, turno).Tables(0)
        End Function

        Public Function Guardar_Parte_Produccion_Historial_Personal_Sin_Trabajo_detalle(ls_det As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL, _
                                                                                ls_det_det As List(Of ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim idcab As Integer = SqlHelper.ExecuteScalar(tr, "PED_SP_I_PARTE_PRODUCCION_HISTORIAL_PERSONAL_SIN_TRABAJO_I", ls_det.USER_ID, ls_det.EQUIPO_COD, ls_det.DESCRIPCION, _
                                              ls_det.NUMERO_OP, ls_det.USER_ID_REGISTRO, ls_det.PC_ID_REGISTRO, ls_det.TURNO, ls_det.FECHA_TURNO, ls_det.MOTIVO_ACT_NO_PROGRAMADA)


                For Each d As ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO In ls_det_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_TRABAJOS_MANTENIMIENTO", idcab, .ITEM, .ID, .DESCRIPCION)
                    End With
                Next


                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Guardar_Parte_Produccion_Historial_Personal_Act_No_Programda(ls_det As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                With ls_det
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_PARTE_PRODUCCION_HISTORIAL_PERSONAL_ACT_NO_PROGRAMADA_I", .USER_ID, .EQUIPO_COD, .DESCRIPCION, _
                                              .NUMERO_OP, .USER_ID_REGISTRO, .PC_ID_REGISTRO, .TURNO, .FECHA_TURNO, .NUMERO_OP_II, .MOTIVO_ACT_NO_PROGRAMADA, _
                                              .PLIEGOS_BUENOS, .PLIEGOS_MALOS)
                End With

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Parte_Produccion_Historial_Personal_Act_No_Programadas(ByVal _equipo As String, ByVal fecha As String, ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MANTENIMIENTO_OP_HISTORIAL_PERSONAL_ACT_NO_PROGRAMADAS", _equipo, fecha, turno).Tables(0)
        End Function

        Public Function get_Lista_Detalles_OP(ByVal FECHA As String, ByVal MAQUINA As String, ByVal TURNO As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_LISTA_OPS", FECHA, MAQUINA, TURNO).Tables(0)
        End Function

        Public Function Guardar_Parte_Produccion_Historial_Personal_Sin_Trabajo(ls_det As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL, _
                                                                                ls_det_ayudantes As List(Of ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_PARTE_PRODUCCION_HISTORIAL_PERSONAL_SIN_TRABAJO_IIII", ls_det.USER_ID, ls_det.EQUIPO_COD, ls_det.DESCRIPCION, _
                '                              ls_det.NUMERO_OP, ls_det.USER_ID_REGISTRO, ls_det.PC_ID_REGISTRO, ls_det.TURNO, ls_det.FECHA_TURNO, _
                '                              ls_det.MOTIVO_ACT_NO_PROGRAMADA, ls_det.AYUDANTE, ls_det.SUPERVISOR, ls_det.HORAS_PROGRAMADAS_ISOGRAF, _
                '                              ls_det.PLIEGOS_PROGRAMADAS_ISOGRAF)

                For Each d As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL In ls_det_ayudantes
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_MANTENIMIENTO_OP_PARTE_PRODUCCION_DETALLE_AYUDANTES", .USER_ID, .EQUIPO_COD, .USER_ID_REGISTRO, .PC_ID_REGISTRO, .TURNO, _
                                                  .FECHA_TURNO, .HORAS_PROGRAMADAS_ISOGRAF, .AYUDANTE, .SUPERVISOR, .NUMERO_OP)
                    End With
                Next

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Parte_Produccion_Produccion_Programada_Verificar_Turno_Finalizado(ByVal codigo As String, ByVal fecha As String, ByVal opcion As String, _
                                                                                   ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_PRODUCCION_PROGRAMADA_VERIFICA_TURNO_FINALIZADO", codigo, fecha, opcion, turno).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Detalle_Ops(ByVal OPCION As String, ByVal anio As Integer, ByVal mes As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_OP_EJECUTADOS", OPCION, anio, mes).Tables(0)
        End Function

        Public Function get_Detalle_Parte_Diario(ByVal id_op As Integer, ByVal item_op As Integer, ByVal MAQUINA As String, ByVal FECHA As String, ByVal TURNO As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_DETALLE_PARTE_DIARIO_OPS", id_op, item_op, FECHA, MAQUINA, TURNO).Tables(0)
        End Function

        Public Function get_Detalle_Parte_Diario_Tiempo_No_Productivo(ByVal MAQUINA As String, ByVal FECHA As String, ByVal TURNO As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_DETALLE_PARTE_DIARIO_OPS_LISTA", FECHA, MAQUINA, TURNO).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Produccion_Programada2_Troquel(ByVal codigo As String, ByVal fecha As String, ByVal fecha_fin As String, ByVal turno As String,
                                                                            ByVal adjunta_op As String, ByVal maquina_2 As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_PRODUCCION_PROGRAMADA_IV_TROQUEL", codigo, fecha, fecha_fin, turno, adjunta_op).Tables(0)
        End Function

        Public Function Guardar_Tiempo_Operado_OPS(id_op As Integer, item_op As Integer, equipo As String, fecha As String, tiempo As String, _flag As Boolean, _
                                                   tiempo_operativo As String, turno As String, estado_op As String, Optional pliegos_buenos As String = "", _
                                                   Optional pliegos_malos As String = "") As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String
                If _flag = True Then
                    query = "DELETE FROM dbo.TIEMPOS_OPS"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                    query = "DELETE FROM dbo.TIEMPOS_OPS_PAUSADOS"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                    query = "DELETE FROM dbo.TIEMPOS_OPS_SIN_TRABAJO"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                    query = "DELETE FROM dbo.TIEMPOS_OPS_ACT_NO_PROGRAMADA"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                    query = "DELETE FROM dbo.TIEMPOS_OPS_PRODUCCION"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                    query = "DELETE FROM dbo.TIEMPOS_OPS_PREPARACION_ESPECIAL"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                    query = "INSERT INTO dbo.TIEMPOS_OPS_PRODUCCION(MAQUINA_COD, FECHA, CONCEPTO, TIEMPO,TURNO) "
                    query = query & " VALUES('" & equipo & "','" & fecha & "','TIEMPO PRODUCTIVO','" & tiempo_operativo & "','" & turno & "') "

                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                End If


                query = "INSERT INTO dbo.TIEMPOS_OPS(ID_CAB, ITEM, MAQUINA_COD, FECHA, TIEMPO,TURNO,ESTADO_OP,PLIEGOS_BUENOS,PLIEGOS_MALOS) "
                query = query & " VALUES(" & id_op & "," & item_op & ",'" & equipo & "','" & fecha & "','" & tiempo & "','" & turno & "','" & estado_op & "','" & pliegos_buenos & "','" & pliegos_malos & "') "

                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Mantenimiento_Produccion_Programada_Parte_Diario_Nuevo_Otro(ByVal codigo As String, ByVal fecha As String, ByVal fecha_fin As String, ByVal turno As String) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PRODUCCION_PROGRAMADA_PARTE_DIARIO_DETALLE_NUEVO_BI", codigo, fecha, turno)
        End Function

        Public Function Get_Consulta_Parte_Produccion(ByVal codigo As String, ByVal fecha As String, ByVal fecha_fin As String, ByVal op As String) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_CONSULTA", codigo, fecha, fecha_fin, op)
        End Function

        Public Function Guardar_Parte_Produccion_BI(ls_det As List(Of ClsEntidades.PARTE_PRODUCCION), ByVal _fecha As String, ByVal _turno As String,
                                                    ByVal _maquina As String) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim idcab As Integer
            Try

                SqlHelper.ExecuteNonQuery(tr, "PED_SP_D_PARTE_PRODUCCION", _fecha, _turno, _maquina)

                For Each d As ClsEntidades.PARTE_PRODUCCION In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_PARTE_PRODUCCION_II", _maquina, _turno, .FECHA, .MAQUINA, .HORARIO, .TURNO, .SUPERVISOR, .MAQUINISTA, .AYUDANTE,
                                                  .HORAS_FIJAS, .HORAS_EXTRAS, .HORAS_PROGRAMADAS, .HORAS_TRABAJADAS, .VELOCIDAD_TEORICA, .VELOCIDAD_REAL, .PRODUCTIVIDAD,
                                                  .RESULTADOS, .AREA_IMPRODUCTIVA, .OBSERVACIONES, .TIEMPO_INVERTIDO, .USER_ID, .PC_ID, .CODIGO, .OBS,
                                                  .HORAS_PRODUCTIVAS, .MANTENIMIENTO_PREVENTIVO, .PORCENTAJE, .REFRIGERIO, .PLIEGOS_PRODUCIDOS, .HORAS_PROGRAMADAS_ISOGRAF,
                                                  .PLIEGOS_PROGRAMADAS_ISOGRAF, .PLIEGOS_BUENOS, .PLIEGOS_MALOS)
                    End With
                Next

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Tiempo_Produccion_OPS(equipo As String, fecha As String, concepto As String, tiempo As String, _flag As Boolean, turno As String) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String

                If _flag = True Then
                    query = "DELETE FROM dbo.TIEMPOS_OPS_PRODUCCION"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                End If

                query = "INSERT INTO dbo.TIEMPOS_OPS_PRODUCCION(MAQUINA_COD, FECHA, CONCEPTO, TIEMPO,TURNO) "
                query = query & " VALUES('" & equipo & "','" & fecha & "','" & concepto & "','" & tiempo & "','" & turno & "') "

                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Tiempo_(equipo As String, fecha As String, concepto As String, tiempo As String, _flag As Boolean) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String

                query = "DELETE FROM dbo.TIEMPOS_OPS"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                query = "DELETE FROM dbo.TIEMPOS_OPS_PRODUCCION"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                query = "DELETE FROM dbo.TIEMPOS_OPS_PAUSADOS"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                query = "DELETE FROM dbo.TIEMPOS_OPS_SIN_TRABAJO"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                query = "DELETE FROM dbo.TIEMPOS_OPS_ACT_NO_PROGRAMADA"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                query = "DELETE FROM dbo.TIEMPOS_OPS_PREPARACION_ESPECIAL"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Mantenimiento_Produccion_Programada_Parte_Diario_Nuevo(ByVal codigo As String, ByVal fecha As String, ByVal fecha_fin As String, ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PRODUCCION_PROGRAMADA_PARTE_DIARIO_DETALLE_NUEVO", codigo, fecha, turno).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Historial_Personal(ByVal _equipo As String, ByVal fecha As String, ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MANTENIMIENTO_OP_HISTORIAL_PERSONAL", _equipo, fecha, turno).Tables(0)
        End Function

        Public Function get_Verificar_OP_operando(ByVal OPCION As String, ByVal fecha As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_OP_OPERANDO", OPCION, fecha).Tables(0)
        End Function

        Public Function Guardar_Parte_Produccion(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PED_SP_U_PARTE_PRODUCCION_III", .ID, .ITEM, .HORA_INICIO_PRODUCCION, .HORA_FINAL_PRODUCCION, _
                                                  .PLIEGOS_BUENOS_PRODUCCION, .PLIEGOS_MALOS_PRODUCCION, .OBS_PRODUCCION, .USER_ID, .USER_ID_DESPACHO, .TIEMPO_EJECUTADO, _
                                                  .TIPO_ORDEN)
                    End With
                Next

                'For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                '    With d
                '        SqlHelper.ExecuteNonQuery(tr, "PED_SP_U_PARTE_PRODUCCION_ACTUALIZA_ESTADO", .ID, .ITEM, .USER_ID_DESPACHO)
                '    End With
                'Next

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Parte_Produccion_Historial_Personal(ls_det As ClsEntidades.MANTENIMIENTO_OP_HISTORIAL_PERSONAL) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String
                query = "SELECT isnull(max(isnull(ITEM,0)),0) FROM dbo.MANTENIMIENTO_OP_HISTORIAL_PERSONAL WHERE EQUIPO_COD='" & ls_det.EQUIPO_COD & "' AND FECHA='" & ls_det.FECHA & "'"

                Dim LastItem As Integer = SqlHelper.ExecuteScalar(tr, CommandType.Text, query)

                With ls_det
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_PARTE_PRODUCCION_HISTORIAL_PERSONAL", .USER_ID, .EQUIPO_COD, .FECHA, LastItem + 1, .DESCRIPCION, _
                                              .NUMERO_OP, .NUMERO_OP_ID, .ITEM_OP_ID, .USER_ID_REGISTRO, .PC_ID_REGISTRO)
                End With

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Parte_Produccion_Detalle_Movimientos(ByVal OPCION As String, ByVal id As Integer, ByVal item As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_DETALLE_MOVIMIENTOS_II", OPCION, id, item).Tables(0)
        End Function

        Public Function get_Verificar_OP_operando_ii(ByVal OPCION As String, ByVal fecha As String, ByVal id_ As Integer, ByVal item_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_OP_OPERANDO_I", OPCION, fecha, id_, item_).Tables(0)
        End Function

        Public Function Guardar_Tiempo_Operado_x_OP_Analisis(MAQUINA_COD As String, MAQUINA As String, ID_CAB_OP As Integer, ITEM_OP As Integer, TIEMPO_ISOGRAF As Double, _
                                                             TIEMPO_INFORNET As Double, MES As String, AÑO As String, ESTADO_OP As String) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String

                query = "INSERT INTO dbo.MANTENIMIENTO_OP_GRAFICO_OPS(MAQUINA_COD, MAQUINA, ID_CAB_OP, ITEM_OP, TIEMPO_ISOGRAF, TIEMPO_INFORNET, MES, AÑO,ESTADO_OP) "
                query = query & " VALUES('" & MAQUINA_COD & "','" & MAQUINA & "'," & ID_CAB_OP & "," & ITEM_OP & "," & TIEMPO_ISOGRAF & "," & TIEMPO_INFORNET & ",'" & MES & "','" & AÑO & "','" & ESTADO_OP & "') "

                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, query)

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Parte_Produccion_Usuarios(ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PART_SP_S_USUARIO_IMAGEN", codigo).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Detalle(ByVal OPCION As String, ByVal id As Integer, ByVal item As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_DETALLE", OPCION, id, item).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Produccion_Programada_Verificar_Turno(ByVal codigo As String, ByVal fecha As String, ByVal opcion As String, _
                                                                                   ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_PRODUCCION_PROGRAMADA_VERIFICA_TURNO_INGRESO", codigo, fecha, opcion, turno).Tables(0)
        End Function

        Public Function Guardar_Parte_Produccion_Detalle(parte_produccion As ClsEntidades.MANTENIMIENTO_OP_PARTE_PRODUCCION, ByVal opcion As String) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With parte_produccion
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_PARTE_PRODUCCION_DETALLE_IV", .ID, .ITEM, .ITEM_DET, .CONCEPTO, .FECHA, .HORA, .OBSERVACIONES, _
                                              .USER_ID, .PC_ID, .TIEMPO_CIERRE, .SIGNO, opcion, .TURNO, .FECHA_TURNO, .MOTIVO_PAUSA, .PLIEGOS_BUENOS, .PLIEGOS_MALOS, .TIPO_ORDEN)

                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_U_PARTE_PRODUCCION_DETALLE_IV", .ID, .ITEM, opcion, .ESTADO, .AREA_PP, .TIPO_ORDEN)
                    'SqlHelper.ExecuteNonQuery(tr, "PED_SP_U_PARTE_PRODUCCION_ACTUALIZA_ESTADO", .ID, .ITEM, opcion)

                End With

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Modo_Edicion_Detalle2(ByVal codigo As String) As DataTable
            Try
                'creando tabla Temporal
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_EDICION_DETALLE_I", codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle_Pedidos_Prog_Despacho(ByVal codigo As String) As DataTable
            Try
                'creando tabla Temporal
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_EDICION_DETALLE_PROGRAMACION_DEPACHO", codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function get_Tipo_Maquina(ByVal codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_OBTENER_TIPO_MAQUINA", codigo).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Produccion_Programada(ByVal codigo As String, ByVal fecha As String, ByVal fecha_fin As String, ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_PRODUCCION_PROGRAMADA_III", codigo, fecha, fecha_fin, turno).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Produccion_Programada2(ByVal codigo As String, ByVal fecha As String, ByVal fecha_fin As String, ByVal turno As String, ByVal adjunta_op As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_RPT_PARTE_PRODUCCION_PRODUCCION_PROGRAMADA_IV", codigo, fecha, fecha_fin, turno, adjunta_op).Tables(0)
        End Function

        Public Function Guardar_Act_Fecha_Programacion_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String
                query = "SELECT ISNULL(MAX(ITEM),0) FROM dbo.MANTENIMIENTO_OP_PROGRAMACION WHERE FECHA_DESPACHO='" & ls_det(0).FECHA_DESPACHO & "' AND ESTADO_DESPACHO in ('SI','SIR') "

                Dim LastItem As Integer = SqlHelper.ExecuteScalar(cn, CommandType.Text, query)

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_PROGRAMACION_OP_DESPACHO_ACT_FECHA_4", .ID, .FECHA_ANT_DESPACHO, .ITEM_ANT_DESPACHO,
                                                  .FECHA_DESPACHO, .USER_ID_DESPACHO, .ITEM_DESPACHO + LastItem, .OBSERVACIONES_DESPACHO, .HORA_ENTREGA_ACORDADO,
                                                  .MOTIVO_REPROGRAMACION, .OBSERVACION_REPROGRAMACION, .REPROGRAMACION, .TIPO_ORDEN)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Act_Fecha_Programacion_Lista_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String
                query = "SELECT ISNULL(MAX(ORDEN),0) FROM dbo.LISTA_DESPACHO WHERE FECHA_DESPACHO='" & ls_det(0).FECHA_DESPACHO & "' "

                Dim LastItem As Integer = SqlHelper.ExecuteScalar(cn, CommandType.Text, query)

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_LISTA_DESPACHO_ACT_FECHA", .ID, .FECHA_ANT_DESPACHO, .ITEM_ANT_DESPACHO,
                                                  .FECHA_DESPACHO, .USER_ID_DESPACHO, .ITEM_DESPACHO + LastItem, .OBSERVACIONES_DESPACHO, .HORA_ENTREGA_ACORDADO,
                                                  .MOTIVO_REPROGRAMACION, .OBSERVACION_REPROGRAMACION, .REPROGRAMACION)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Act_Fecha_Programacion_Despacho_Oficial(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                Dim query As String
                query = "SELECT ISNULL(MAX(SECUENCIA),0) FROM dbo.ORDERS_APP_DESPACHO WHERE FECHA_PROGRAMACION='" & ls_det(0).FECHA_DESPACHO & "' "

                Dim LastItem As Integer = SqlHelper.ExecuteScalar(cn, CommandType.Text, query)

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_ORDERS_APP_DESPACHO_ACT_FECHA", .ID, .FECHA_ANT_DESPACHO, .ITEM_ANT_DESPACHO,
                                                  .FECHA_DESPACHO, .USER_ID_DESPACHO, .ITEM_DESPACHO + LastItem, .OBSERVACIONES_DESPACHO, .HORA_ENTREGA_ACORDADO)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Act_Trans_Vehiculo_Programacion_Despacho_Oficial(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP), ByVal trans_ As String,
                                                                                 ByVal vehiculo_ As String) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_ORDERS_APP_DESPACHO_ACT_TRANS_VEHICULO", .ID, .FECHA_ANT_DESPACHO, .ITEM_ANT_DESPACHO,
                                                  .FECHA_DESPACHO, .USER_ID_DESPACHO, .ITEM_DESPACHO, .OBSERVACIONES_DESPACHO, .HORA_ENTREGA_ACORDADO, trans_, vehiculo_)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Deshacer_Programacion_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_D_PROGRAMACION_OP_DESPACHO_DESHACER_I", .ID, .ITEM_DESPACHO, .FECHA_DESPACHO, .TIPO_ORDEN)

                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Deshacer_Programacion_Lista_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_D_LISTA_DESPACHO_DESHACER", .ID, .ITEM_DESPACHO, .FECHA_DESPACHO, .CANTIDAD)

                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Deshacer_Programacion_Despacho_Oficial(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_D_ORDERS_APP_DESPACHO_DESHACER", .ID, .ITEM_DESPACHO, .FECHA_DESPACHO)

                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Act_Correlativo_Programacion_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_PROGRAMACION_OP_DESPACHO_ACT_CORRELATIVO_III", .ID, .FECHA_ANT_DESPACHO, .ITEM_ANT_DESPACHO,
                                                  .USER_ID_DESPACHO, .ITEM_DESPACHO, .TIPO_ORDEN)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Act_Correlativo_Programacion_Lista_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_LISTA_DESPACHO_ACT_CORRELATIVO", .ID, .FECHA_ANT_DESPACHO, .ITEM_ANT_DESPACHO,
                                                  .USER_ID_DESPACHO, .ITEM_DESPACHO)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Act_Correlativo_Programacion_Despacho_Oficial(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_ORDERS_APP_DESPACHO_ACT_CORRELATIVO", .ID, .FECHA_ANT_DESPACHO, .ITEM_ANT_DESPACHO,
                                                  .USER_ID_DESPACHO, .ITEM_DESPACHO)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Mantenimiento_Despachos_Programados(ByVal _fecha_inicio As String, ByVal _fecha_fin As String, ByVal _linea_produccion As String,
                                                                ByVal _cod_equipo As String, ByVal _cod_familia As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_MANTENIMIENTO_OP_DESPACHOS_PROGRAMADOS_II", _fecha_inicio, _fecha_fin, _linea_produccion, _cod_equipo, _cod_familia).Tables(0)
        End Function

        Public Function get_Mantenimiento_Lista_Despachos_Programados(ByVal _fecha_inicio As String, ByVal _fecha_fin As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_LISTA_DESPACHO", _fecha_inicio, _fecha_fin).Tables(0)
        End Function

        Public Function get_Reporte_Comparativo_OP_vs_Dispensado(ByVal _codigo_interno As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_COMPARATIVO_DE_DISPENSACION_OPS", _codigo_interno).Tables(0)
        End Function

        Public Function get_Reporte_Comparativo_OP_vs_Dispensado_Consulta(ByVal _codigo_interno As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_COMPARATIVO_DE_DISPENSACION_OPS_I", _codigo_interno)
        End Function


        Public Function get_Lista_Programacion_Despachos(ByVal _fecha_inicio As String, ByVal _fecha_fin As String, ByVal _linea_produccion As String,
                                                         ByVal _cod_trans As String, ByVal _cod_vehiculo As String, ByVal _cod_estado As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_LISTA_PROGRAMACION_DESPACHOS", _fecha_inicio, _fecha_fin, _linea_produccion,
                                            _cod_trans, _cod_vehiculo, _cod_estado).Tables(0)
        End Function

        Public Function Obtener_Datos_Empresa() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_COMPANY").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Guardar_Programacion_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim query As String
                Dim LastItem As Integer

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        query = "SELECT ISNULL(MAX(ITEM),0) FROM dbo.MANTENIMIENTO_OP_PROGRAMACION WHERE FECHA_DESPACHO='" & d.FECHA_DESPACHO & "' AND ESTADO_DESPACHO in ('SI','SIR') "

                        LastItem = SqlHelper.ExecuteScalar(cn, CommandType.Text, query)

                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_OP_DESPACHO_II", .ID, .CANTIDAD_DESPACHO, .PUNTO_SALIDA_DESPACHO, .OBSERVACIONES_DESPACHO,
                                                  .FECHA_DESPACHO, .USER_ID_DESPACHO, .ESTADO_DESPACHO, .ITEM_DESPACHO + LastItem, Environment.MachineName,
                                                  .HORA_ENTREGA_ACORDADO, .COD_EQUIPO, .TIPO_ORDEN)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Programacion_Lista_Despacho(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim query As String
                Dim LastItem As Integer = 0

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        If LastItem = 0 Then
                            query = "SELECT ISNULL(MAX(ORDEN),0) FROM dbo.LISTA_DESPACHO WHERE FECHA_DESPACHO='" & d.FECHA_DESPACHO & "' "

                            LastItem = SqlHelper.ExecuteScalar(cn, CommandType.Text, query)
                        End If

                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_LISTA_DESPACHO", .ID, .ITEM, .PRODUCTO, LastItem + 1, .CANTIDAD, _
                                                  .FECHA_DESPACHO, LibComunVar.ClsVarComun.USUARIO)

                        LastItem = LastItem + 1
                    End With
                Next

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_U_REQUERIMIENTO_PRODUCCION_OP", .ID, .ITEM, .PRODUCTO, .CANTIDAD)
                    End With
                Next

                'tr.Commit()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Programacion_Recojo(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP), ByVal _cod_trans As String,
                                                              ByVal _cod_vehiculo As String, ByVal _fecha As String,
                                                              ByVal _cliente As String, ByVal _direccion As String, ByVal _obs As String,
                                                               ByVal _des_trans As String) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_RECOJO", .ID, _cod_trans, _cod_vehiculo, _fecha, LibComunVar.ClsVarComun.USUARIO, .ITEM_DESPACHO,
                                                  _cliente, _direccion, _obs, _des_trans)
                    End With
                Next

                'tr.Commit()
                'tr.Dispose()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Programacion_Despacho_OFicial(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP), ByVal _cod_trans As String,
                                                              ByVal _cod_vehiculo As String, ByVal _fecha As String, ByVal _des_trans As String,
                                                              ls_det_ORDER_LINE_APP_DESPACHO As List(Of ClsEntidades.ORDER_LINE_APP_DESPACHO)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                
                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_I", .ID, _cod_trans, _cod_vehiculo, _fecha, LibComunVar.ClsVarComun.USUARIO,
                                                  .ITEM_DESPACHO, _des_trans)
                    End With
                Next

                For Each d As ClsEntidades.ORDER_LINE_APP_DESPACHO In ls_det_ORDER_LINE_APP_DESPACHO
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_II", .ID_CAB, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .EMPRESA)
                    End With
                Next

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_III", .ID, .EMPRESA)
                    End With
                Next

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_IV", .ID, .EMPRESA)
                    End With
                Next

                'tr.Commit()
                'tr.Dispose()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Programacion_Despacho_OFicial_Fusionado(ls_det As List(Of ClsEntidades.MANTENIMIENTO_OP), ls_det_2 As List(Of ClsEntidades.MANTENIMIENTO_OP),
                                                                        ByVal _cod_trans As String,
                                                              ByVal _cod_vehiculo As String, ByVal _fecha As String, ByVal _des_trans As String,
                                                              ls_det_ORDER_LINE_APP_DESPACHO As List(Of ClsEntidades.ORDER_LINE_APP_DESPACHO)) As Boolean
            'Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_I", .ID, _cod_trans, _cod_vehiculo, _fecha, LibComunVar.ClsVarComun.USUARIO,
                                                  .ITEM_DESPACHO, _des_trans)
                    End With
                Next

                For Each d As ClsEntidades.ORDER_LINE_APP_DESPACHO In ls_det_ORDER_LINE_APP_DESPACHO
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_II", .ID_CAB, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .EMPRESA, .CODIGO_INTERNO)
                    End With
                Next

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_III", .ID, .EMPRESA)
                    End With
                Next

                For Each d As ClsEntidades.MANTENIMIENTO_OP In ls_det_2
                    With d
                        SqlHelper.ExecuteNonQuery(cn, "PED_SP_I_PROGRAMACION_DESPACHO_V", .ID, .EMPRESA)
                    End With
                Next

                'tr.Commit()
                'tr.Dispose()
                Return True
            Catch ex As Exception
                'tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Mantenimiento_Despachos(ByVal _linea_produccion As String, ByVal _familia_produccion As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_MANTENIMIENTO_OP_DESPACHOS_I", _linea_produccion, _familia_produccion).Tables(0)
        End Function

        Public Function get_Mantenimiento_Lista_Despachos(ByVal _linea_produccion As String, ByVal _familia_produccion As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_MANTENIMIENTO_OP_LISTA_DESPACHOS", _linea_produccion, _familia_produccion).Tables(0)
        End Function

        Public Function get_Programacion_Despachos(ByVal _linea_produccion As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_PROGRAMACION_DESPACHOS", _linea_produccion).Tables(0)
        End Function

        Public Function Get_ManualVendedor(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RECEIVABLE_VENDEDOR", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function get_CentroCostos_Ayuda() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CENTER_COST_AYU").Tables(0)
        End Function

        Public Function get_item_archivo_Quejas_Reclamos(ByVal _id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_QUEJAS_RECLAMOS_ARCHIVOS", _id).Tables(0)
        End Function

        Public Function get_item_archivo_Gestion_Muestra_Desarrollo(ByVal _id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_GESTION_MUESTRAS_DESARROLLO_ARCHIVOS", _id).Tables(0)
        End Function

        Public Function get_Queja_Reclamo_Detalle(ByVal _id_informe As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_QUEJAS_RECLAMOS_CONSULTA", _id_informe).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function get_Gestion_Muestra_Desarrollo(ByVal _id_informe As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_GESTION_MUESTRAS_DESARROLLO", _id_informe).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function Grabar_Archivo_Queja_Reclamo(ByVal id_cab As Integer, archivo As ClsEntidades.DATOS_ARCHIVO) As Boolean
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                With archivo
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_QUEJAS_RECLAMOS_ARCHIVOS_I", id_cab, .USER_ID, .IP_PC, .PC_ID, .NOMBRE_ARCHIVO,
                                              .ARCHIVO, .DES_ARCHIVO, .ITEM)
                End With

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Grabar_Archivo_Gestion_Muestra_Desarrollo(ByVal id_cab As Integer, archivo As ClsEntidades.DATOS_ARCHIVO) As Boolean
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                With archivo
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_GESTION_MUESTRAS_DESARROLLO_ARCHIVOS_I", id_cab, .USER_ID, .IP_PC, .PC_ID, .NOMBRE_ARCHIVO,
                                              .ARCHIVO, .DES_ARCHIVO, .ITEM)
                End With

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Detalle_Archivos_Quejas_Reclamos(ByVal _id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_QUEJAS_RECLAMOS_ARCHIVOS_I", _id).Tables(0)
        End Function

        Public Function get_Detalle_Archivos_Gestion_Muestra_Desarrollo(ByVal _id As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_GESTION_MUESTRAS_DESARROLLO_ARCHIVOS_i", _id).Tables(0)
        End Function

        Public Function get_DatosGeneralesPedido(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_ORDERS_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_datos_archivo_descargar_Queja_Reclamo(ByVal _id As Integer, ByVal _item As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_QUEJAS_RECLAMOS_ARCHIVOS_DESCARGA", _id, _item).Tables(0)
        End Function

        Public Function get_datos_archivo_descargar_Gestion_Muestra_Desarrollo(ByVal _id As Integer, ByVal _item As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_GESTION_MUESTRAS_DESARROLLO_ARCHIVOS_DESCARGA", _id, _item).Tables(0)
        End Function

        Public Function Eliminar_Archivo_Queja_Reclamo(ByVal id_cab As Integer, ByVal item As Integer) As Boolean
            Dim tr As SqlTransaction

            Try
                tr = cn.BeginTransaction(IsolationLevel.Serializable)
                SqlHelper.ExecuteNonQuery(tr, "PED_D_QUEJAS_RECLAMOS_ARCHIVOS", id_cab, item)
                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Archivo_Gestion_Muestra_Desarrollo(ByVal id_cab As Integer, ByVal item As Integer) As Boolean
            Dim tr As SqlTransaction

            Try
                tr = cn.BeginTransaction(IsolationLevel.Serializable)
                SqlHelper.ExecuteNonQuery(tr, "PED_D_GESTION_MUESTRAS_DESARROLLO_ARCHIVOS", id_cab, item)
                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_Quejas_Reclamos(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION_FECHAS As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_QUEJAS_RECLAMOS_PRINCIPAL", _OPCION_FECHAS, _FECHA_INI, _FECHA_FIN).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function get_Gestion_Muestra_Desarrollo(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION_FECHAS As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PED_SP_S_GESTION_MUESTRAS_DESARROLLO_PRINCIPAL_I", _OPCION_FECHAS, _FECHA_INI, _FECHA_FIN).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function


        Public Sub GuardarPedido(entidad As ClsEntidades.ORDER, ls_det As List(Of ClsEntidades.ORDER_LINE))
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_ORDERS", .ID, .ORDER_DATE, .CADUCATE_DATE, .SALES_ID, .PLACE_SALES, .CUSTOMER_ID, .CUSTOMER_NAME, _
                                              .CUSTOMER_ADDR, .VAT_REGISTRATION, .AMOUNT, .DISCOUNT_CUSTOMER, .DISCOUNT_SP, .TERMS, .SELL_RATE, .CURRENCY_ID, _
                                              .DOCUMENT_REF, .SERIE_REF, .NUMBER_REF, .CREATE_DATE, .STATUS, .USER_ID, .COMMENT, .NUMBER_GUIA, .NUMBER_REC, _
                             .ORDER_PURCHASE, .COMMENT1, .AMOUNT_VAT, .DISCOUNT, .DISCOUNT_AMOUNT, .REC_TYPE, .DISCOUNT_VAL, .STATUS_ORDER, .TRAMA_ID, .AMOUNT_ISC)
                End With
                For Each d As ClsEntidades.ORDER_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PED_SP_I_ORDERS_LINE", .ID, .ITEM, .PART_ID, .PART_DESCRIPTION, .QTY, .PRICE_SALES, .PRICE_ORI, .DISCOUNT, .AMOUNT_TAX, _
                            .DISCOUNT_CUST, .DISCOUNT_SP, .PERCENT_TAX, .PERCENT_DISCOUNT, .AMOUNT_US, .AMOUNT, .STATUS, .SERIE, .WAREHOUSE_ID, .TEXT_COMMENT, .QTY_REF, .LOT, _
                            .BALANCE, .IS_PART_TAX, .LIST_ID, .UNIT, .PERCENT_ISC, .AMOUNT_ISC)
                    End With
                Next
                tr.Commit()
                'Actualizando Correlativo PEDIDO
                SqlHelper.ExecuteNonQuery(cn, "FACT_SP_S_R_CORRELATIVO", "PD")
            Catch ex As Exception
                tr.Rollback()
            End Try
        End Sub

        Public Function Guardar_Queja_Reclamo(entidad As ClsEntidades.QUEJAS_RECLAMOS, ByVal _nuevo As Boolean, ByRef _numero_queja_reclamo As Integer) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim _id_cab As Integer
            Try
                With entidad
                    _id_cab = SqlHelper.ExecuteScalar(tr, "PED_SP_I_QUEJAS_RECLAMOS", .ID, .FECHA, .TIPO, .COD_CLIENTE, .CONTACTO, .CARGO, .CORREO_ELECTRONICO,
                                              .TELEFONO, .PRODUCTO, .FECHA_ACONTECIMIENTO, .REDACCION_HECHOS, .SOLICITA_CLIENTE, .ACCIONES_INMEDIATAS,
                                              .ACCIONES_CORRECTIVAS, .CONCLUSION, .STATUS, .USER_PC, .PC_ID, .NOMBRE_RESPONSABLE, .CARGO_RESPONSABLE)
                    _numero_queja_reclamo = _id_cab
                End With


                If _nuevo Then
                    SqlHelper.ExecuteScalar(tr, "PED_SP_I_QUEJAS_RECLAMOS_ARCHIVOS", _id_cab)
                End If

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                Return False
            End Try
        End Function

        Public Function Guardar_Gestion_Muestra_Desarrollo(entidad As ClsEntidades.GESTION_MUESTRAS_DESARROLLO, ByVal _nuevo As Boolean, ByRef _numero_queja_reclamo As Integer) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim _id_cab As Integer
            Try
                With entidad
                    _id_cab = SqlHelper.ExecuteScalar(tr, "PED_SP_I_GESTION_MUESTRAS_DESARROLLO_III", .ID, .FECHA, .COD_CLIENTE, .CONTACTO, .VENDEDOR, .FECHA_VISITA,
                                              .NOMBRE_MUESTRA, .CANTIDAD_MUESTRA, .CANTIDAD_PROYECTADA_VENTAS, .FECHA_ENVIO_MUESTRA, .ESTADO_MUESTRA, .ESTADO_COMERCIAL,
                                              .USER_PC, .PC_ID, .FECHA_RECEPCION_MUESTRA, .OBSERVACIONES, .USO, .FECHA_ENVIO, .CODIGO_QI, .CANTIDAD_M)
                    _numero_queja_reclamo = _id_cab
                End With


                If _nuevo Then
                    SqlHelper.ExecuteScalar(tr, "PED_SP_I_GESTION_MUESTRAS_DESARROLLO_ARCHIVOS", _id_cab)
                End If

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                Return False
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
        Public Function get_DetalleAlmacen_CONTROL(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String, ByVal ESTADO As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_CONTROL", alm_, doc_, num_, ESTADO).Tables(0)
        End Function

        Public Function Detalle_Almacen_Control_PT(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String, ByVal ESTADO As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_LINE_CONTROL_PT", alm_, doc_, num_, ESTADO).Tables(0)
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
        Private dtTable As DataTable

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Guardar_Produccion_OP(entidad As ClsEntidades.PRODUCCION_OP, ls As List(Of ClsEntidades.PRODUCCION_OP), ls_det As List(Of ClsEntidades.PRODUCCION_OP_LINE), _
                                              ls_det_procesos As List(Of ClsEntidades.PRODUCCION_OP_LINE_PROCESOS), ByVal _edicion As Boolean) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim idcab As Integer = 0
            Try
                With entidad
                    idcab = SqlHelper.ExecuteScalar(tr, "MANUFACTURA_SP_I_PRODUCCION_OP_NEW", .ID, .FECHA, .STATUS, .USER_ID)
                End With
                entidad.ID = idcab

                If _edicion Then
                    SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_D_PRODUCCION_OP_DETALLES", entidad.ID)
                End If

                For Each d As ClsEntidades.PRODUCCION_OP In ls
                    With d
                        SqlHelper.ExecuteScalar(tr, "MANUFACTURA_SP_I_PRODUCCION_OP_PRODUCTOS_I", idcab, .ITEM, .COD_CLIENTE, .FECHA_ENTREGA, .VENDEDOR, .DESTINATARIO, .URGENTE, _
                                                .OBSERVACIONES, .PART_ID, .CANTIDAD, .ID_REQUERIMIENTO, .ITEM_REQUERIMIENTO, .FACTOR)
                    End With
                Next

                For Each d As ClsEntidades.PRODUCCION_OP_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_I_PRODUCCION_OP_LINE_I", idcab, .ITEM, .CODIGO, .COSTO, .CANTIDAD, .TOTAL, .ITEM_PRODUCTO)
                    End With
                Next

                For Each d As ClsEntidades.PRODUCCION_OP_LINE_PROCESOS In ls_det_procesos
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_I_PRODUCCION_OP_LINE_PROCESOS_I", idcab, .ITEM, .PROCESO, .MAQUINA, .INICIO, .FIN, .ITEM_PRODUCTO)
                    End With
                Next

                If _edicion = False Then
                    SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_U_REQUERIMIENTO_PRODUCCION_OP", entidad.ID)
                End If

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Orden_Desarrollo(entidad As ClsEntidades.PRODUCCION_OP, ls As List(Of ClsEntidades.PRODUCCION_OP), ls_det As List(Of ClsEntidades.PRODUCCION_OP_LINE), _
                                              ls_det_procesos As List(Of ClsEntidades.PRODUCCION_OP_LINE_PROCESOS), ByVal _edicion As Boolean) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim idcab As Integer = 0
            Try
                With entidad
                    idcab = SqlHelper.ExecuteScalar(tr, "MANUFACTURA_SP_I_ORDEN_DESARROLLO_NEW", .ID, .FECHA, .STATUS, .USER_ID)
                End With
                entidad.ID = idcab

                If _edicion Then
                    SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_D_ORDEN_DESARROLLO_DETALLES", entidad.ID)
                End If

                For Each d As ClsEntidades.PRODUCCION_OP In ls
                    With d
                        SqlHelper.ExecuteScalar(tr, "MANUFACTURA_SP_I_ORDEN_DESARROLLO_PRODUCTOS_II", idcab, .ITEM, .COD_CLIENTE, .FECHA_ENTREGA, .VENDEDOR, .DESTINATARIO, .URGENTE, _
                                                .OBSERVACIONES, .PART_ID, .CANTIDAD, .ID_REQUERIMIENTO, .ITEM_REQUERIMIENTO, .FACTOR, .DESCRIPCION, .UNIDAD)
                    End With
                Next

                For Each d As ClsEntidades.PRODUCCION_OP_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_I_ORDEN_DESARROLLO_LINE_I", idcab, .ITEM, .CODIGO, .COSTO, .CANTIDAD, .TOTAL, .ITEM_PRODUCTO)
                    End With
                Next

                For Each d As ClsEntidades.PRODUCCION_OP_LINE_PROCESOS In ls_det_procesos
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_I_ORDEN_DESARROLLO_LINE_PROCESOS_I", idcab, .ITEM, .PROCESO, .MAQUINA, .INICIO, .FIN, .ITEM_PRODUCTO)
                    End With
                Next

                If _edicion = False Then
                    SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_U_GESTION_MUESTRAS_DESARROLLO", entidad.ID)
                End If

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Public Function Guardar__Requerimiento_Produccion_OP(entidad As ClsEntidades.REQUERIMIENTO_PRODUCCION_OP, ls_det As List(Of ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE), _
                                              ByVal _edicion As Boolean) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim idcab As Integer = 0
            Try
                With entidad
                    idcab = SqlHelper.ExecuteScalar(tr, "MANUFACTURA_SP_I_PRODUCCION_OP_III", .ID, .FECHA, .STATUS, .PART_ID, .CANTIDAD, 0, 0, 0, _
                                                    .USER_ID, "", "", "", "", "", "", .COD_CLIENTE, .OBSERVACIONES, .NUMERO_PEDIDO, .ITEM_PEDIDO, _
                                                    .DESTINATARIO, .URGENTE, .FECHA_ENTREGA, .VENDEDOR)
                End With
                entidad.ID = idcab

                If _edicion Then
                    SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_D_REQUERIMIENTO_PRODUCCION_OP_DETALLES", entidad.ID)
                End If

                For Each d As ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_I_REQUERIMIENTO_PRODUCCION_OP_LINE_I", idcab, .ITEM, .CODIGO, .COSTO, .CANTIDAD, .TOTAL,
                                                  .PLANEAMIENTO)
                    End With
                Next

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Actualizacion_Derivacion_Planeamiento(entidad As ClsEntidades.REQUERIMIENTO_PRODUCCION_OP,
                                                                      ls_det As List(Of ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE), _
                                              ByVal _edicion As Boolean) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim idcab As Integer = 0
            Try
                For Each d As ClsEntidades.REQUERIMIENTO_PRODUCCION_OP_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_U_REQUERIMIENTO_PRODUCCION_OP_LINE_I", .ID_CAB, .ITEM, .CODIGO, .COSTO, .CANTIDAD, .TOTAL,
                                                  .PLANEAMIENTO, LibComunVar.ClsVarComun.USUARIO)
                    End With
                Next

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Produccion_OP_Liquidacion(ls_det As List(Of ClsEntidades.PRODUCCION_OP_LIQUIDACION), ls_det_almacen_cabecera As List(Of ClsEntidades.WAREHOUSE_TRANS), _
                                            ls_det_almacen As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Dim idcab As Integer = 0
            Try

                For Each d As ClsEntidades.PRODUCCION_OP_LIQUIDACION In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_I_PRODUCCION_OP_LIQUIDACION", .ID_CAB, .ITEM, .TIPO, .COSTO, .CANTIDAD, .WAREHOUSE_REF, .DOCUMENT_REF, _
                                                  .NUMBER_DOCUMENT_REF, .FECHA_REF, .USER_ID, .ITEM_PRODUCTO)
                    End With
                Next
                '--parte de almacen ingreso de Fabricacion
                ''For Each d As ClsEntidades.WAREHOUSE_TRANS In ls_det_almacen_cabecera
                ''    With d
                ''        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                ''                                  .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                ''                                  .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                ''                                  .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .UPDATE_DATE, _
                ''                                  .NUM_ORDER_MANUFACT, "")

                ''    End With
                ''Next
                
                ''For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det_almacen
                ''    With d
                ''        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                ''                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                ''                                  .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN, _
                ''                                  .AVERAGE_COST, .CURRENCY_ID, .NUMBER_ANALIS)
                ''    End With
                ''Next
                'Actualizando Correlativo de Almacen
                ''For Each d As ClsEntidades.WAREHOUSE_TRANS In ls_det_almacen_cabecera
                ''    With d
                ''        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", .WAREHOUSE_ID, .TYPE_TRANS)
                ''    End With
                ''Next
                'actualizo el costo de todos los ingresos anteriores
                For Each d As ClsEntidades.PRODUCCION_OP_LIQUIDACION In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_U_PRODUCCION_OP_LIQUIDACION_COSTO", .ID_CAB, .COSTO, .ITEM_PRODUCTO)
                        Exit For
                    End With
                Next

                'Actualizando Almacen
                'SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", "01")

                ''For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det_almacen
                ''    With d
                ''        SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL_CON_ARTICULO", .WAREHOUSE_ID, .PART_ID)
                ''    End With
                ''Next

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Descarga_OP(entidad As ClsEntidades.PRODUCCION_OP, entidad_almacen As ClsEntidades.WAREHOUSE_TRANS, _
                                            ls_det_almacen As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)

            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_U_PRODUCCION_OP", .ID, entidad_almacen.WAREHOUSE_ID, entidad_almacen.DOCUMENT_ID, entidad_almacen.NUMBER_DOCUMENT)

                End With

                If ls_det_almacen.Count > 0 Then
                    '--parte de almacen LA SALIDA DE INSUMOS
                    With entidad_almacen
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                                  .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                                  .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                                  .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .UPDATE_DATE, _
                                                  .NUM_ORDER_MANUFACT, "")

                    End With

                    For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det_almacen
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                      .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                      .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN, _
                                                      .AVERAGE_COST, .CURRENCY_ID, .NUMBER_ANALIS)
                        End With
                    Next
                    'Actualizando Correlativo de Almacen
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad_almacen.WAREHOUSE_ID, entidad_almacen.TYPE_TRANS)
                    'Actualizando Almacen
                    SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", entidad_almacen.WAREHOUSE_ID)
                End If

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Descarga_Orden_Desarrollo(entidad As ClsEntidades.PRODUCCION_OP, entidad_almacen As ClsEntidades.WAREHOUSE_TRANS, _
                                            ls_det_almacen As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)

            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "MANUFACTURA_SP_U_ORDEN_DESARROLLO", .ID, entidad_almacen.WAREHOUSE_ID, entidad_almacen.DOCUMENT_ID, entidad_almacen.NUMBER_DOCUMENT)

                End With

                If ls_det_almacen.Count > 0 Then
                    '--parte de almacen LA SALIDA DE INSUMOS
                    With entidad_almacen
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                                  .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                                  .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                                  .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .UPDATE_DATE, _
                                                  .NUM_ORDER_MANUFACT, "")

                    End With

                    For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det_almacen
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                      .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                      .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN, _
                                                      .AVERAGE_COST, .CURRENCY_ID, .NUMBER_ANALIS)
                        End With
                    Next
                    'Actualizando Correlativo de Almacen
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad_almacen.WAREHOUSE_ID, entidad_almacen.TYPE_TRANS)
                    'Actualizando Almacen
                    SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", entidad_almacen.WAREHOUSE_ID)
                End If

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Produccion_OP(ByVal codigo_ As Integer) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "MANUFACTURA_SP_D_PRODUCCION_OP_I", codigo_)
                'SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", "01")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Orden_Desarrollo(ByVal codigo_ As Integer) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "MANUFACTURA_SP_D_ORDEN_DESARROLLO_I", codigo_)
                'SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", "01")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Eliminar_Requerimiento_Produccion_OP(ByVal codigo_ As Integer) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "MANUFACTURA_SP_D_REQUERIMIENTO_PRODUCCION_OP", codigo_)
                'SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", "01")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function FechaGuiaAnalasis(ByVal almacen As String, ByVal Tipo As String, ByVal numero As String) As DataTable
            Dim SQL As String = ""
            SQL = "SELECT DATE_DOCUMENT  FROM WAREHOUSE_TRANS  WHERE  DOCUMENT_ID ='" & Tipo & " '  AND NUMBER_DOCUMENT='" & numero & "' AND WAREHOUSE_ID ='" & almacen & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, SQL).Tables(0)
        End Function

        Public Function ObteniendoNumeroAnalisis(ByVal _anio As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_NUM_ANALISIS", _anio).Tables(0)
            Catch ex As Exception
                Throw
            End Try

        End Function


        Public Function Verificando_Guia_A(ByVal Tipo As String, ByVal Numero As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_VERIFICA_GUIA_A", Tipo, Numero).Tables(0)
        End Function

        Public Function Mostrando_Tipo_Articulo(ByVal Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_VERIFICAR_ARTICULO", Codigo).Tables(0)
        End Function

        Public Function Mostrando_Clase_Articulo(ByVal Codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_VERIFICAR_ARTICULO_PT", Codigo).Tables(0)
        End Function



        '***** TODAS LAS GUIAS 
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
                If TipoNumeracionGuia = "A" Then
                    'Actualizando Correlativo Guia Remision
                    SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "GUIA_SP_S_GUIA_REMISION_NUM_DOCUMENT_GS")
                End If
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
        Public Function get_CabeceraAlmacen_CONTROL(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_CONTROL", alm_, doc_, num_).Tables(0)
        End Function

        Public Function get_GuiaFtsinDescargoCabecera(ByVal DOCUMENT_ID As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_SIN_DESCARGO_CAB", DOCUMENT_ID, NUMBER_DOCUMENT).Tables(0)
        End Function


        Public Sub Guardar(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE))
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, .TYPE_TRANS, .TRANS_ID, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .DOC_ID_REF, .NUM_ID_REF, .UPDATE_DATE, .HOUR, .USER_ID, .CUSTOMER_ID, .CUSTOMER_NAME, .STATUS_GUIA, .PRINTER_STATUS, .PROJECT_ID)
                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .ITEM, .PART_ID, .QTY, .PART_DESCRIPTION, .NUMBER_LOT, .PROJECT_ID, .QT_BULTOS, .OPT_ENTREGA, .NUM_PROTOCOLOS, .NUMBER_ANALIS)
                    End With
                Next
                tr.Commit()
                'Actualizando Correlativo Guia Analisis
                SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "ALM_SP_U_WAREHOUSE_TRANS_NUM_DOCUMENT_GA")
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
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

        Public Sub EliminarDocumentosAlmacen(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String, ByVal User As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_D_WH_DOC_ELIMINADOS", alm_, doc_, num_, User)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", alm_)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        'Guia de Remision
        Public Function get_DocumentosGuiaRemision() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "GUIA_SP_S_GUIA_REMISION_DOCUMENTOS").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Function get_VerificacionCodigoGuiaRemision(ByVal WAREHOUSE_ID As String, ByVal NUMBER_DOCUMENT As String) As DataTable
            Try
                dataBL = New LibConexion.ClsData
                dtTable = New DataTable
                dtTable = dataBL.Run_SP_DataTable("GUIA_SP_S_GUIA_REMISION_VERIFICAR_COD", _
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

        Public Function get_DatosGeneralesIngresoOc(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                             ByVal _TYPE_TRANS As String, ByVal _DOCUMENT_ID As String, ByVal _ACCESOALMACEN As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_WAREHOUSE_TRANS_PRINCIPAL_OC", _FECHA_INI, _FECHA_FIN, _OPCION, _TYPE_TRANS, _DOCUMENT_ID, _ACCESOALMACEN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Sub EliminarGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "GUIA_SP_S_GUIA_REMISION_ELIMINAR_DOCUMENTOS", alm_, doc_, num_)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", alm_)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub AnularGuiaRemision(ByVal alm_ As String, ByVal doc_ As String, ByVal num_ As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_TRANS_ESTADO", alm_, doc_, num_)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", alm_)
            Catch ex As Exception
                Throw
            End Try
        End Sub
        Public Sub Actualiza_valoracion_lote(ByVal part_id_ As String, ByVal lot_id_ As String, ByVal valoracion_ As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "CTR_SP_U_LOT", part_id_, lot_id_, valoracion_)
            Catch ex As Exception
                Throw
            End Try
        End Sub
        Public Sub Actualiza_Estado_Devolucion(ByVal document_id_ As String, ByVal number_document_ As String, ByVal _estado As String)
            Try
                If document_id_ = "RD" Then
                    SqlHelper.ExecuteNonQuery(cn, "ALM_SP_U_WAREHOUSE_DEVOLUCION_ESTADO", document_id_, number_document_, _estado)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Actualiza_Estado_Liberacion(ByVal who_id_ As String, ByVal document_id_ As String, ByVal number_document_ As String, ByVal _Tipo As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "CTR_SP_U_WAREHOUSE", who_id_, document_id_, number_document_, _Tipo)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Actualiza_Numero_Analisis_Liberacion(ByVal who_id_ As String, ByVal document_id_ As String, ByVal number_document_ As String, ByVal _anio As String)
            Try
                SqlHelper.ExecuteNonQuery(cn, "CTR_SP_U_WAREHOUSE_NUM_ANALISIS", who_id_, document_id_, number_document_, _anio)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub GuardarInventarioAlmacen_Control_Calidad(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE))
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .UPDATE_DATE, .NUM_ORDER_MANUFACT, "")

                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_INSERT_CONTROL", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN, .COMMENT, .NUMBER_ANALIS)
                        'If .DOCUMENT_ID = "NS" Then
                        '    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_LOT_NUM_ANALISIS", .PART_ID, .NUMBER_LOT, .NUMBER_ANALIS)
                        'End If
                    End With
                Next
                'Actualizando Correlativo de Almacen
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad.WAREHOUSE_ID, entidad.TYPE_TRANS)
                'Actualizando 
                SqlHelper.ExecuteNonQuery(tr, "SP_U_PART_QTY_LOT", entidad.NUMBER_DOCUMENT, entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID)
                'Actualizando Almacen
                'SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL_POR_ARTICULO", entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT)
                tr.Commit()
            Catch ex As Exception
                MsgBox(ex.Message)
                tr.Rollback()
            End Try
        End Sub

        Public Function GuardarInventarioAlmacen_Control_Calidad_PT(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE)) As Boolean
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_INSERT", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, .DATE_DOCUMENT, _
                                              .TYPE_TRANS, .TRANS_ID, .DOC_ID_REF, .NUM_ID_REF, .HOUR, .USER_ID, .CUSTOMER_ID, .VAT_REGISTRATION, _
                                              .CUSTOMER_NAME, .SALES_TERM, .CURRENCY_TYPE, .CURRENCY_EXCHANGE, .STATUS_GUIA, .AMOUNT, _
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, .UPDATE_DATE, .NUM_ORDER_MANUFACT, "")

                End With
                For Each d As ClsEntidades.WAREHOUSE_TRANS_LINE In ls_det
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_WAREHOUSE_TRANS_LINE_INSERT_CONTROL", .WAREHOUSE_ID, .DOCUMENT_ID, .NUMBER_DOCUMENT, _
                                                  .ITEM, .PART_ID, .QTY, .QTY_DLV, .QTY_REF, .QTY_INVOICED, .AMOUNT_SALES, .PART_DESCRIPTION, .UNIT_PART, .NUMBER_LOT, _
                                                  .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN, .COMMENT, .NUMBER_ANALIS)
                    End With
                Next
                'Actualizando Correlativo de Almacen
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad.WAREHOUSE_ID, entidad.TYPE_TRANS)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL_POR_ARTICULO", entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID, entidad.NUMBER_DOCUMENT)
                'Actualizando 
                SqlHelper.ExecuteNonQuery(tr, "SP_U_PART_QTY_LOT", entidad.NUMBER_DOCUMENT, entidad.WAREHOUSE_ID, entidad.DOCUMENT_ID)

                tr.Commit()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                tr.Rollback()
                Return False
            End Try
        End Function

        Public Sub GuardarInventarioAlmacen(entidad As ClsEntidades.WAREHOUSE_TRANS, ls_det As List(Of ClsEntidades.WAREHOUSE_TRANS_LINE))
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
                                                  .WAREHOUSE_REF, .ACCOUNT, .STATUS_VALUE, .NUM_PROTOCOLOS, .OPT_ENTREGA, .QT_BULTOS, .PROCEDENCIA, .PAIS_ORIGEN)
                    End With
                Next
                'Actualizando Correlativo de Almacen
                SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_WAREHOUSE_CORRELATIVO", entidad.WAREHOUSE_ID, entidad.TYPE_TRANS)
                'Actualizando Almacen
                SqlHelper.ExecuteNonQuery(tr, "ACT_QTY_LOTE_2010_AL", entidad.WAREHOUSE_ID)
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
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
                                              .ADDR_DLV, .VENDOR_ID, .VENDOR_NAME, .COMMENT, .TYPE_GUIA, .WAREHOUSE_REF, .NUMBER_PURCHASE, 0)

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
                                          .IS_ACCOUNT, .VAR_COUNT, .WHO_ID, .IS_GUIA_ANALISIS, .WHO_ID_PART_TYPE)
            End With
        End Sub

        Public Sub Update(entidad As ClsEntidades.TRANSACTION_TYPE)
            With entidad
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_U_TRANSACTION_TYPE", .TYPE_ID, .MOV_ID, .NAME, .IS_VALUED, .IS_VENDOR, .IS_DOC_REF, .IS_AUTHORIZED, _
                                          .IS_CCOST, .IS_ORDER_PURCHASE, .IS_COMMENT, .IS_WHO, .IS_CUSTOMER, .IS_ORDER_MANUFACT, _
                                          .IS_ACCOUNT, .VAR_COUNT, .WHO_ID, .IS_GUIA_ANALISIS, .WHO_ID_PART_TYPE)
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

        Public Function get_Almacenes_Ayuda(ByVal ID_ALAMACEN As String) As DataTable
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

    Public Class CURRENCY_TYPE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Monedas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_CURRENCY_TYPE").Tables(0)
        End Function

        Public Function get_Motivos_Sin_Trabajo(ByVal maquina As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MOTIVOS_SIN_TRABAJO", maquina).Tables(0)
        End Function

        Public Function Get_Listado_Trabajos_Mantenimiento(ByVal _maquina As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_TRABAJOS_MANTENIMIENTO", _maquina).Tables(0)
        End Function

        Public Function get_Motivos_Act_No_Programada(ByVal maquina As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MOTIVOS_ACT_NO_PROGRAMADA", maquina).Tables(0)
        End Function

        Public Function get_Parte_Produccion_Historial_Personal_Act_No_Programadas(ByVal _equipo As String, ByVal fecha As String, ByVal turno As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MANTENIMIENTO_OP_HISTORIAL_PERSONAL_ACT_NO_PROGRAMADAS", _equipo, fecha, turno).Tables(0)
        End Function

        Public Function get_Preparacion_Especial_Equipo(ByVal maquina As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_MOTIVOS_PREPARACION_ESPECIAL", maquina).Tables(0)
        End Function

        Public Function get_TiposCambio() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_TIPOC").Tables(0)
        End Function

        Public Function get_Turno() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_TURNO").Tables(0)
        End Function

        Public Function get_Motivos_Pausa() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "MANTENIMIENTO_SP_S_MOTIVOS_PAUSA").Tables(0)
        End Function

        Public Function get_Motivos_Pausa_Falla_equipo() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "MANTENIMIENTO_SP_S_MOTIVOS_PAUSA_FALLA_EQUIPO").Tables(0)
        End Function

        Public Function get_Procesos_Inicio_Prepacion(ByVal maquina As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_PROCESOS_INICIO", maquina).Tables(0)
        End Function

        Public Function get_Procesos_Area(ByVal maquina As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_PROCESOS_AREA", maquina).Tables(0)
        End Function

        Public Function get_Procesos_Produccion(ByVal maquina As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "MANTENIMIENTO_SP_S_PROCESOS_PRODUCCION_I", maquina).Tables(0)
        End Function
    End Class



    Public Class LETTER_EXCHANGE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

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
                             ByVal Tabla As DataTable, ByVal TipoNumeracion As String) As Boolean
            Dim estado As Boolean = True
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With entidad
                    SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_LETTER_EXCHANGE", .ID, .DATE_EXCHANGE, .VOUCHER_ID, .CREATE_DATE, .USER_ID, .STATUS, .ACCEPT_DATE, _
                                              .SELL_RATE, .CURRENCY_ID, .CUSTOMER_ID)
                End With
                If ls_det.Count > 0 Then
                    For Each l As ClsEntidades.LETTER_EXCHANGE_LINE In ls_det
                        With l
                            SqlHelper.ExecuteNonQuery(tr, "CX_SP_I_LETTER_EXCHANGE_LINE", .ID, .ITEM, .TYPE_DOC, .NUMBER_DOC, .AMOUNT, .CADUCATE_DATE, .IS_ORIG, .OPCION)
                        End With
                    Next
                End If
                For Each row As DataRow In Tabla.Select("Sel=True")
                    SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_S_LETTER_EX_ACT_SAL", entidad.CUSTOMER_ID, row("TipoDoc").ToString, row("NumDoc").ToString, row("Saldo").ToString)
                Next
                'Actualizando correlativo
                SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "LT")
                If TipoNumeracion = "A" Then
                    'Actualizando correlativo
                    SqlHelper.ExecuteNonQuery(tr, "LETRA_SP_U_LETTER_EX_ACT_CORREL", "LL")
                End If
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
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_R_CLIENTE_M", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_DocumentosPendientes(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETTER_EX_DOC_PEND", _Codigo).Tables(0)
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

        Public Function Get_DocumentosLetras(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "LETRA_SP_S_LETRA_PRINCIPAL", _Codigo).Tables(0)
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
                                Cadena = String.Empty
                                Cadena = "UPDATE  CUSTOMER_BALANCE SET AMOUNT_BALANCE=(AMOUNT_BALANCE - " & dtDetalleDoc.Rows(i).Item("AMOUNT").ToString & ") WHERE CUSTOMER_ID='" & dtDetalleCab.Rows(0).Item("CUSTOMER_ID").ToString & "'" _
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
                                LetterEnt.STATUS_ACT = "CR"
                                LetterEnt.STATUS_LAST = "CR"
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
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "LETRA_SP_S_REP_CLIENTES_PEND").Tables(0)
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

        Public Function ActualizandoCarteraClientes(ByVal CUSTOMER_ID As String, ByVal DOCUMENT_ID As String, ByVal NUMBER_DOC As String, _
                                                    ByVal DOC_DATE As String, ByVal CADUCATE_DATE As String, ByVal SALES_ID As String, _
                                                    ByVal CURRENCY_ID As String, ByVal SELL_RATE As String, ByVal USER_ID As String, _
                                                    ByVal AMOUNT As String, ByVal SALDO As String) As Boolean
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
End Class
