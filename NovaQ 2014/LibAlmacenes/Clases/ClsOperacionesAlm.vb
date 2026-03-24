Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibComunVar
Imports LibContabilidad

Public Class ClsOperacionesAlm

    Public Class SOLICITANTE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function DocumentoPrincipal(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_S_SOLICITANTE", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Anular_Requisicion(ByVal CODIGO As String, ByVal TIPO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE REQUIREMENT SET STATUS='A' WHERE ID ='" & CODIGO & "'  AND TYPE = '" & TIPO & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function EliminacionSolicitante(ByVal _ID As String, ByVal _COD_AREA As String) As Boolean
            Dim ESTADO As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_SOLICITANTE", _ID, _COD_AREA)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                ESTADO = False
            End Try
            Return ESTADO
        End Function


        Public Function ActualizarSolicitante(ent_cab As ClsEntidadesAlm.SOLICITANTE) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_U_SOLICITANTE", .TYPE_ID, .ID, .DESCRIPTION, .CREATE_DATE, .COD_AREA)
                End With
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        Public Function GuardarSolicitante(ent_cab As ClsEntidadesAlm.SOLICITANTE) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_SOLICITANTE", .TYPE_ID, .ID, .DESCRIPTION, .CREATE_DATE, .COD_AREA)
                End With
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function
    End Class



    Public Class AREA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Function DocumentoPrincipal() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "COMPRA_SP_S_AREA_PRINCIPAL").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Anular_Requisicion(ByVal CODIGO As String, ByVal TIPO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE REQUIREMENT SET STATUS='A' WHERE ID ='" & CODIGO & "'  AND TYPE = '" & TIPO & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function EliminacionArea(ByVal _NUMBER_DOCUMENT As String) As Boolean
            Dim ESTADO As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_AREA", _NUMBER_DOCUMENT)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                ESTADO = False
            End Try
            Return ESTADO
        End Function


        Public Function ActualizarArea(ent_cab As ClsEntidadesAlm.AREA) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_U_AREA", .ID, .DESCRIPTION)
                End With
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        Public Function GuardarArea(ent_cab As ClsEntidadesAlm.AREA) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_AREA", .ID, .DESCRIPTION)
                End With
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function
    End Class




    Public Class REQUIREMENT
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Function DatosUsuario(ByVal Cod_usuario As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_DETALLE_USUARIO", Cod_usuario).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Datos_Guia_Devolucion_Consulta_Cabecera(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_EDICION_DETALLE_GUIA_DEVOLUCION_CABECERA", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Cierre_Manual_Guia_Devolucion(ByVal CODIGO As String, ByVal TIPO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE ALM_GUIA_DEVOLUCION SET PC_ES_MANUAL='" & Environment.MachineName & "', USER_ES_MANUAL='" & LibComunVar.ClsVarComun.USUARIO & "', FECHA_ES_MANUAL=GETDATE(), STATUS_ATENCION='04', STATUS='F', ES_MANUAL='SI' WHERE ID ='" & CODIGO & "'  AND TYPE = '" & TIPO & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Datos_Guia_Devolucion_Consulta(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_EDICION_DETALLE_GUIA_DEVOLUCION", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function get_Lista_Estados_Requisiciones() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_S_S_ESTADOS_REQUISICIONES").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Finalizar_Guia_Salida_Indirecta(ByVal CODIGO As String, ByVal TIPO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE GUIA_SALIDA_INDIRECTA SET PC_CONFORMIDAD='" & Environment.MachineName & "', USER_CONFORMIDAD='" & LibComunVar.ClsVarComun.USUARIO & "', FECHA_CONFORMIDAD=GETDATE(), STATUS='F' WHERE ID ='" & CODIGO & "'  AND TYPE = '" & TIPO & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Autorizar_Guia_Devolucion(ByVal CODIGO As String, ByVal TIPO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE ALM_GUIA_DEVOLUCION SET PC_AUTORIZACION='" & Environment.MachineName & "', USER_AUTORIZACION='" & LibComunVar.ClsVarComun.USUARIO & "', FECHA_AUTORIZACION=GETDATE(), STATUS='AU' WHERE ID ='" & CODIGO & "'  AND TYPE = '" & TIPO & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Anular_Guia_Devolucion(ByVal CODIGO As String, ByVal TIPO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE ALM_GUIA_DEVOLUCION SET PC_ANUL='" & Environment.MachineName & "', USER_ANUL='" & LibComunVar.ClsVarComun.USUARIO & "', FECHA_ANUL=GETDATE(), STATUS='A' WHERE ID ='" & CODIGO & "'  AND TYPE = '" & TIPO & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function get_DatosGenerales_Guia_Devolucion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal _Tipo As String,
                                                        ByVal _Area_id As String, ByVal _Estado_id As String, ByVal _Estado_atencion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_GUIA_DEVOLUCION_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _Tipo, _Area_id, _Estado_id, _Estado_atencion).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Actualizar_Guia_Devolucion(ent_cab As ClsEntidadesAlm.GUIA_DEVOLUCION, lista As List(Of ClsEntidadesAlm.GUIA_DEVOLUCION_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_U_GUIA_DEVOLUCION", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT,
                                              .PART_ID, .PART_DESCRIPTION, .LOTE, .VCTO_LOTE, .CANTIDAD, .AREA_ID, .STATUS,
                                              .CREATE_DATE, .UPDATE_DATE, .USER_ID)
                End With

                'detalle de doc
                Dim SQL As String = "DELETE  FROM ALM_GUIA_DEVOLUCION_LINE WHERE ID='" & ent_cab.ID & "' AND TYPE ='" & ent_cab.TYPE & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                For Each d As ClsEntidadesAlm.GUIA_DEVOLUCION_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_GUIA_DEVOLUCION_LINE", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .N_ANALISIS, .STATUS,
                                                  .DOCUMENT_DATE, .COD_PRIORIDAD, "")
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

        Public Function Guardar_Guia_Devolucion(ent_cab As ClsEntidadesAlm.GUIA_DEVOLUCION, lista As List(Of ClsEntidadesAlm.GUIA_DEVOLUCION_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_GUIA_DEVOLUCION", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT,
                                               .PART_ID, .PART_DESCRIPTION, .LOTE, .VCTO_LOTE, .CANTIDAD, .AREA_ID,
                                              .STATUS, .CREATE_DATE, .UPDATE_DATE, .USER_ID, .NUMERO_OP)
                End With
                'detalle de doc
                For Each d As ClsEntidadesAlm.GUIA_DEVOLUCION_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "ALM_SP_I_GUIA_DEVOLUCION_LINE", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .N_ANALISIS, .STATUS,
                                                  .DOCUMENT_DATE, .COD_PRIORIDAD)
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

        Public Function Get_cabecera_Requisiciones_materiales(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_CABECERA_REQ_MATERIALES", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function get_Area_Usuario(ByVal _codigo_usuario As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_AREA_USUARIO", _codigo_usuario).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Get_cabecera_Requisiciones_materiales_RM(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_CABECERA_REQ_MATERIALES_RM", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function Datos_Stock_Req_Materiales(ByVal _Articulo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_STOCK_PART_REQ_MATERIALES", _Articulo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosRequisicionDetalleModoEdicion_OC(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_DETALLE_II_OC", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosRequisicionDetalleModoEdicion(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_DETALLE_II", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosRequisicionDetalleModoEdicion_RM(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_DETALLE_RM", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosRequisicion_Imprenta_DetalleModoEdicion(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_DETALLE_II_LOTES", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function DatosRequisicion_Imprenta_Detalle_Lotes(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_DETALLE_LOTES", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosRequisicion_Imprenta_Detalle_ME(ByVal Tipodoc As String, ByVal numero As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_EDICION_DETALLE_ME", Tipodoc, numero).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Anular_Requisicion(ByVal CODIGO As String, ByVal TIPO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE REQUIREMENT SET STATUS='A' WHERE ID ='" & CODIGO & "'  AND TYPE = '" & TIPO & "'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function






        Public Function EliminacionRequisicion(ByVal _TIPOMOV As String, ByVal _NUMBER_DOCUMENT As String) As Boolean
            Dim ESTADO As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_REQUERIEMENT", _TIPOMOV, _NUMBER_DOCUMENT)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                ESTADO = False
            End Try
            Return ESTADO
        End Function


        Public Function ActualizarRequisiciones(ent_cab As ClsEntidadesAlm.REQUIREMENT, lista As List(Of ClsEntidadesAlm.REQUIREMENT_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_U_REQUEREMENT", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT, .AREA_ID, .STATUS, .CREATE_DATE, .UPDATE_DATE, .USER_ID, .PROJECT_ID)
                End With

                'detalle de doc
                Dim SQL As String = "DELETE  FROM REQUIREMENT_LINE WHERE ID='" & ent_cab.ID & "' AND TYPE ='" & ent_cab.TYPE & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .STATUS,
                                                          .DOCUMENT_DATE, .AMOUNT_BALANCE, .CCOST_ID, .COMMENT, .PROJECT_ID, .COD_PRIORIDAD, .ID_VENDOR)
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

        Public Function ActualizarRequisiciones_RM(ent_cab As ClsEntidadesAlm.REQUIREMENT, lista As List(Of ClsEntidadesAlm.REQUIREMENT_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_U_REQUEREMENT_RM", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT, .AREA_ID, .STATUS,
                                              .CREATE_DATE, .UPDATE_DATE, .USER_ID, .PROJECT_ID, .TIPO)
                End With

                'detalle de doc
                Dim SQL As String = "DELETE  FROM REQUIREMENT_LINE WHERE ID='" & ent_cab.ID & "' AND TYPE ='" & ent_cab.TYPE & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_RM", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .STATUS,
                                                          .DOCUMENT_DATE, .AMOUNT_BALANCE, .CCOST_ID, .COMMENT, .PROJECT_ID, .COD_PRIORIDAD, .ID_VENDOR, .NUMERO_OP)
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

        Public Function ActualizarRequisiciones_Imprenta(ent_cab As ClsEntidadesAlm.REQUIREMENT, lista As List(Of ClsEntidadesAlm.REQUIREMENT_LINE), lista_lotes As List(Of ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA), lista_me As List(Of ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA_ME)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_U_REQUEREMENT", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT, .AREA_ID, .STATUS, .CREATE_DATE, .UPDATE_DATE, .USER_ID, .PROJECT_ID)
                End With

                'detalle de doc
                Dim SQL As String = "DELETE  FROM REQUIREMENT_LINE WHERE ID='" & ent_cab.ID & "' AND TYPE ='" & ent_cab.TYPE & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .STATUS,
                                                          .DOCUMENT_DATE, .AMOUNT_BALANCE, .CCOST_ID, .COMMENT, .PROJECT_ID, .COD_PRIORIDAD, .ID_VENDOR)
                    End With
                Next

                'detalle de lotes
                SQL = "DELETE  FROM REQUIREMENT_LINE_LOTES WHERE ID='" & ent_cab.ID & "' AND TYPE ='" & ent_cab.TYPE & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA In lista_lotes
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II_LOTES", .ID, .TYPE, .ITEM_PRODUCTO, .ITEM, .LOTE, .VCTO, .PRODUCTO)
                    End With
                Next

                'detalle de Materiales de 
                SQL = "DELETE  FROM REQUIREMENT_LINE_ME WHERE ID='" & ent_cab.ID & "' AND TYPE ='" & ent_cab.TYPE & "'"
                SqlHelper.ExecuteNonQuery(tr, CommandType.Text, SQL)
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA_ME In lista_me
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II_ME", .ID, .TYPE, .ITEM_PRODUCTO, .ITEM, .PART_ID, .PART_DESCRIPTION, .PART_UNIT, .CANTIDAD, .PRODUCTO)
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

        Public Function GuardarRequerimientos(ent_cab As ClsEntidadesAlm.REQUIREMENT, lista As List(Of ClsEntidadesAlm.REQUIREMENT_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUEREMENT", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT, .AREA_ID, .STATUS, .CREATE_DATE, .UPDATE_DATE, .USER_ID, .PROJECT_ID)
                End With
                'detalle de doc
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .STATUS,
                                                  .DOCUMENT_DATE, .AMOUNT_BALANCE, .CCOST_ID, .COMMENT, .PROJECT_ID, .COD_PRIORIDAD, .ID_VENDOR)
                    End With
                Next
                'actualizamos la numeracion
                SqlHelper.ExecuteNonQuery(tr, "CONTA_SP_U_ACTUALIZA_CORRELATIVO", ent_cab.TYPE, CDbl(ent_cab.ID))
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        Public Function GuardarRequerimientos_RM(ent_cab As ClsEntidadesAlm.REQUIREMENT, lista As List(Of ClsEntidadesAlm.REQUIREMENT_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUEREMENT_RM", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT, .AREA_ID, .STATUS,
                                              .CREATE_DATE, .UPDATE_DATE, .USER_ID, .PROJECT_ID, .SEDE, .TIPO)
                End With
                'detalle de doc
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_RM", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .STATUS,
                                                  .DOCUMENT_DATE, .AMOUNT_BALANCE, .CCOST_ID, .COMMENT, .PROJECT_ID, .COD_PRIORIDAD, .ID_VENDOR, .NUMERO_OP)

                        'SqlHelper.ExecuteNonQuery(tr, "PED_SP_U_MANTENIMIENTO_OP_PRE_PRENSA_REQUERIMIENTOS", .NUMERO_OP)
                    End With
                Next
                'actualizamos la numeracion
                SqlHelper.ExecuteNonQuery(tr, "CONTA_SP_U_ACTUALIZA_CORRELATIVO_REQ_RM", ent_cab.TYPE, ent_cab.SEDE)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function

        Public Function GuardarRequerimientos_Imprenta(ent_cab As ClsEntidadesAlm.REQUIREMENT, lista As List(Of ClsEntidadesAlm.REQUIREMENT_LINE), lista_lotes As List(Of ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA), lista_me As List(Of ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA_ME)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'cabecera doc
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUEREMENT", .ID, .TYPE, .REQUIRED_USER, .REQUIRED_DATE, .COMMENT, .AREA_ID, .STATUS, .CREATE_DATE, .UPDATE_DATE, .USER_ID, .PROJECT_ID)
                End With
                'detalle de doc
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .STATUS,
                                                  .DOCUMENT_DATE, .AMOUNT_BALANCE, .CCOST_ID, .COMMENT, .PROJECT_ID, .COD_PRIORIDAD, .ID_VENDOR)
                    End With
                Next

                'detalle de lotes
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA In lista_lotes
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II_LOTES", .ID, .TYPE, .ITEM_PRODUCTO, .ITEM, .LOTE, .VCTO, .PRODUCTO)
                    End With
                Next

                'detalle de Materiales de Empaque
                For Each d As ClsEntidadesAlm.REQUIREMENT_LINE_IMPRENTA_ME In lista_me
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_REQUIEREMENT_LINE_II_ME", .ID, .TYPE, .ITEM_PRODUCTO, .ITEM, .PART_ID, .PART_DESCRIPTION, .PART_UNIT, .CANTIDAD, .PRODUCTO)
                    End With
                Next

                'actualizamos la numeracion
                SqlHelper.ExecuteNonQuery(tr, "CONTA_SP_U_ACTUALIZA_CORRELATIVO", ent_cab.TYPE, CDbl(ent_cab.ID))
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function
        Public Function Datos_Stock(ByVal _Articulo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_STOCK_PART", _Articulo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DatosGeneralesRequisiciones(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal _Tipo As String, ByVal _Area_id As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_REQUISICION_PRINCIPAL", _FECHA_INI, _FECHA_FIN, _OPCION, _Tipo, _Area_id).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DatosGeneralesRequisiciones_RM(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal _Tipo As String, ByVal _Area_id As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_REQUISICION_PRINCIPAL_RM", _FECHA_INI, _FECHA_FIN, _OPCION, _Tipo, _Area_id).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function get_Lista_Areas() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_AREA").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_Datos_Producto(ByVal _codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "REQUI_SP_S_PART", _codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function get_DetallesRequisicionesII(ByVal codigo As String, ByVal tipo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_DETALLE_REQUIREMENT", codigo, tipo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function get_DatosGeneralesRequisicionesII(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, ByVal _Tipo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_REQUISICION_PRINCIPAL_II", _FECHA_INI, _FECHA_FIN, _OPCION, _Tipo).Tables(0)
            Catch ex As Exception
                Throw
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


    Public Class PURCHASE_ORDER
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Mostrar_Detalles_Requisicion(ByVal STIPO As String, NUMERO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_REQUIREMENT", STIPO, NUMERO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Mostrar_Detalles_Requisicion_Imprenta(ByVal STIPO As String, NUMERO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_REQUIREMENT_IMPRENTA", STIPO, NUMERO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Mostrar_Documentos_Principal_Consulta(ByVal STIPO As String, ByVal FECHA_INI As String, FECHA_FIN As String, OPCION As String, user_id As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_LIST_PURCHASE_ORDER_III", "", STIPO, FECHA_INI, FECHA_FIN, OPCION, 2, user_id).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Cierre_Manual_Oden_Compra(ByVal CODIGO As String, ByVal TIPO_DOC As String, ByVal SERIE_DOC As String,
                                                  ByVal NUM_DOC As String, ByVal FECHA_DOC As String, ByVal OBSERVACIONES As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE PURCHASE_ORDER SET OBSERVACIONES_CIERRE_MANUAL='" & OBSERVACIONES & "', FECHA_REF_CIERRE_MANUAL='" & FECHA_DOC & "', NUM_REF_CIERRE_MANUAL='" & NUM_DOC & "', SERIE_REF_CIERRE_MANUAL='" & SERIE_DOC & "', TIPO_DOC_REF_CIERRE_MANUAL='" & TIPO_DOC & "', OPT_CIERRE_MANUAL='SI', PC_CIERRE_MANUAL='" & Environment.MachineName & "', USER_CIERRE_MANUAL='" & LibComunVar.ClsVarComun.USUARIO & "', FECHA_CIERRE_MANUAL=GETDATE(), STATUS_ID='04' WHERE ID='" & CODIGO & "' and type='OC' "
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Modo_Edicion_Detalle_Orden_Servicio_Imprenta(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_DETALLE_ORDEN_SERVICIO_IMPRENTA", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle_Orden_Servicio_Imprenta_Lotes(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_DETALLE_ORDEN_SERVICIO_IMPRENTA_LOTES", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle_Orden_Servicio(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_DETALLE_ORDEN_SERVICIO", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Modo_Edicion_Cabecera_Orden_Servicio(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_CABECERA_ORDEN_SERVICIO", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Cabecera_Orden_Servicio_Imprenta(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_CABECERA_ORDEN_SERVICIO_IMPRENTA", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Requisicion_Detalle_Orden_Servicio(ByVal CODIGO As String, ByVal ITEMS As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_REQUI_SERV_DET", CODIGO, ITEMS).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function Requisicion_Detalle_Orden_Servicio_Imprenta(ByVal CODIGO As String, ByVal ITEMS As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_REQUI_SERV_IMPRENTA_DET", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Requisicion_Detalle_Orden_Servicio_Imprenta_Lotes(ByVal CODIGO As String, ByVal ITEMS As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_REQUI_SERV_IMPRENTA_DET_LOTES", CODIGO, ITEMS).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Get_DatosIgvsSistema() As DataTable
            Try
                'creando tabla Temporal
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PED_SP_S_ORDER_PARAMETER").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function



        Public Function Eliminar_Oden_Compra(ByVal CODIGO As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "PUR_SP_D_ORDEN_COMPRA", CODIGO)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Cambiar_Estado_Oden_Compra(ByVal CONSULTA As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CONSULTA)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Anular_Oden_Compra(ByVal CODIGO As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='05' WHERE ID='" & CODIGO & "' and type='OC'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = "EXEC COMPRAS_SP_U_ESTADO_REQ_COT_ANUL_ORDER_PURCHASE 'OC','" & CODIGO & "'"
                'sql = "UPDATE REQUIREMENT SET STATUS='P' WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' and REQUI_ID<>'' and type='OC'  GROUP BY REQUI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE REQUIREMENT SET STATUS='P'  WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_QUOTE_LINE  WHERE ID IN (SELECT COTI_ID  FROM PURCHASE_ORDER_LINE  " _
                '       & "WHERE ID='" & CODIGO & "'  and COTI_ID<>'' and type='OC'  GROUP BY COTI_ID) AND REQUI_ID <>''  GROUP BY REQUI_ID )"

                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE PURCHASE_QUOTE  SET STATUS='AC' WHERE ID IN (SELECT COTI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' AND COTI_ID <>'' and type='OC'  GROUP BY COTI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE dbo.REQUIREMENT_LINE SET ORDEN_GENERADA='NO' where TYPE='RQ'  "
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE B SET B.ORDEN_GENERADA='SI' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RQ' AND a.PART_ID=B.PART_ID INNER JOIN dbo.PURCHASE_ORDER c ON a.ID=c.ID AND a.TYPE=c.TYPE AND c.STATUS_ID<>'05'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Anular_Oden_Servicio(ByVal CODIGO As String) As Boolean
            Try
                'Dim dt_anular As DataTable
                'dt_anular = New DataTable
                'Dim sql As String = ""
                'sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='05' WHERE ID='" & CODIGO & "' and type='OS'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE REQUIREMENT SET STATUS='P' WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' and REQUI_ID<>'' and type='OS'  GROUP BY REQUI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE PURCHASE_QUOTE  SET STATUS='AC' WHERE ID IN (SELECT COTI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' AND COTI_ID <>'' and type='OS'  GROUP BY COTI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE dbo.REQUIREMENT_LINE SET ORDEN_GENERADA='NO' where TYPE='RS'  "
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE B SET B.ORDEN_GENERADA='SI' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RS' AND a.PART_ID=B.PART_ID INNER JOIN dbo.PURCHASE_ORDER c ON a.ID=c.ID AND a.TYPE=c.TYPE AND c.STATUS_ID<>'05'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='05' WHERE ID='" & CODIGO & "' and type='OS'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = "EXEC COMPRAS_SP_U_ESTADO_REQ_COT_ANUL_ORDER_PURCHASE 'OS','" & CODIGO & "'"
                'sql = "UPDATE REQUIREMENT SET STATUS='P' WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' and REQUI_ID<>'' and type='OC'  GROUP BY REQUI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE REQUIREMENT SET STATUS='P'  WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_QUOTE_LINE  WHERE ID IN (SELECT COTI_ID  FROM PURCHASE_ORDER_LINE  " _
                '       & "WHERE ID='" & CODIGO & "'  and COTI_ID<>'' and type='OC'  GROUP BY COTI_ID) AND REQUI_ID <>''  GROUP BY REQUI_ID )"

                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE PURCHASE_QUOTE  SET STATUS='AC' WHERE ID IN (SELECT COTI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' AND COTI_ID <>'' and type='OC'  GROUP BY COTI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE dbo.REQUIREMENT_LINE SET ORDEN_GENERADA='NO' where TYPE='RQ'  "
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE B SET B.ORDEN_GENERADA='SI' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RQ' AND a.PART_ID=B.PART_ID INNER JOIN dbo.PURCHASE_ORDER c ON a.ID=c.ID AND a.TYPE=c.TYPE AND c.STATUS_ID<>'05'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Anular_Oden_ServicioImprenta(ByVal CODIGO As String) As Boolean
            Try
                'Dim dt_anular As DataTable
                'dt_anular = New DataTable
                'Dim sql As String = ""
                'sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='05' WHERE ID='" & CODIGO & "' and type='OS'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE REQUIREMENT SET STATUS='P' WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' and REQUI_ID<>'' and type='OS'  GROUP BY REQUI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE PURCHASE_QUOTE  SET STATUS='AC' WHERE ID IN (SELECT COTI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' AND COTI_ID <>'' and type='OS'  GROUP BY COTI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE dbo.REQUIREMENT_LINE SET ORDEN_GENERADA='NO' where TYPE='RS'  "
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE B SET B.ORDEN_GENERADA='SI' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RS' AND a.PART_ID=B.PART_ID INNER JOIN dbo.PURCHASE_ORDER c ON a.ID=c.ID AND a.TYPE=c.TYPE AND c.STATUS_ID<>'05'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = "UPDATE PURCHASE_ORDER SET STATUS_ID='05' WHERE ID='" & CODIGO & "' and type='OI'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = "EXEC PUR_SP_U_REFER_ORDEN_COMPRA_DET_IMPRENTA_OS_ANULACION '" & CODIGO & "','OI'"
                'sql = "UPDATE REQUIREMENT SET STATUS='P' WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' and REQUI_ID<>'' and type='OC'  GROUP BY REQUI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE REQUIREMENT SET STATUS='P'  WHERE ID IN (SELECT REQUI_ID FROM PURCHASE_QUOTE_LINE  WHERE ID IN (SELECT COTI_ID  FROM PURCHASE_ORDER_LINE  " _
                '       & "WHERE ID='" & CODIGO & "'  and COTI_ID<>'' and type='OC'  GROUP BY COTI_ID) AND REQUI_ID <>''  GROUP BY REQUI_ID )"

                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE PURCHASE_QUOTE  SET STATUS='AC' WHERE ID IN (SELECT COTI_ID FROM PURCHASE_ORDER_LINE  WHERE ID='" & CODIGO & "' AND COTI_ID <>'' and type='OC'  GROUP BY COTI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                'sql = ""
                'sql = "UPDATE dbo.REQUIREMENT_LINE SET ORDEN_GENERADA='NO' where TYPE='RQ'  "
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE B SET B.ORDEN_GENERADA='SI' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RQ' AND a.PART_ID=B.PART_ID INNER JOIN dbo.PURCHASE_ORDER c ON a.ID=c.ID AND a.TYPE=c.TYPE AND c.STATUS_ID<>'05'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
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

        Public Function Modo_Edicion_Detalle_II(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_EDICION_DETALLE_II", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Requisicion_Detalle(ByVal CODIGO As String, ByVal ITEMS As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_REQUI_DET", CODIGO, ITEMS).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function Cotizacion_Detalle(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_LISTA_QUOTE_DET", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Sub ActualizandoEstado(ByVal LISTA_ENT_DET As List(Of ClsEntidadesAlm.PURCHASE_ORDER_LINE))
            Try
                ''Actualizando el Estado --
                'REQUISICIONES
                Dim sql As String = ""
                sql = "UPDATE REQUIREMENT SET STATUS='O' WHERE ID IN  (SELECT REQUI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OC'  GROUP BY REQUI_ID) AND " _
                & " TYPE IN (SELECT REQUI_TYPE FROM dbo.PURCHASE_ORDER_LINE WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OC'  GROUP BY REQUI_TYPE)"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'COTIZACION Y REQUISICION
                sql = "UPDATE PURCHASE_QUOTE SET STATUS='O' WHERE ID IN  (SELECT COTI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND COTI_ID<>'' and type='OC'  GROUP BY COTI_ID)"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).REQUI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RQ'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).COTI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RQ'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE B SET B.ORDEN_GENERADA='SI',B.STATUS='O' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RQ' AND a.PART_ID=B.PART_ID  WHERE a.ID='" & LISTA_ENT_DET(0).ID & "' AND a.TYPE='OC' "
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub




        Public Sub ActualizandoEstadoOrdenServicio(ByVal LISTA_ENT_DET As List(Of ClsEntidadesAlm.PURCHASE_ORDER_LINE))
            Try
                ''Actualizando el Estado --
                'REQUISICIONES
                'Dim sql As String = ""
                'sql = "UPDATE REQUIREMENT SET STATUS='O' WHERE ID IN  (SELECT REQUI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                '& " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OS'  GROUP BY REQUI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                ''COTIZACION Y REQUISICION
                'sql = "UPDATE PURCHASE_QUOTE SET STATUS='O' WHERE ID IN  (SELECT COTI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                '& " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND COTI_ID<>'' and type='OS'  GROUP BY COTI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                '& " WHERE ID='" & LISTA_ENT_DET(0).REQUI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RS'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE B SET B.ORDEN_GENERADA='SI' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RS' AND a.PART_ID=B.PART_ID  WHERE a.ID='" & LISTA_ENT_DET(0).ID & "' AND a.TYPE='OS'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                ''Actualizando el Estado --
                'REQUISICIONES
                Dim sql As String = ""
                sql = "UPDATE REQUIREMENT SET STATUS='O' WHERE ID IN  (SELECT REQUI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OS'  GROUP BY REQUI_ID) AND " _
                & " TYPE IN (SELECT REQUI_TYPE FROM dbo.PURCHASE_ORDER_LINE WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OS'  GROUP BY REQUI_TYPE)"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'COTIZACION Y REQUISICION
                sql = "UPDATE PURCHASE_QUOTE SET STATUS='O' WHERE ID IN  (SELECT COTI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND COTI_ID<>'' and type='OS'  GROUP BY COTI_ID)"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).REQUI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RS'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).COTI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RS'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE B SET B.ORDEN_GENERADA='SI',B.STATUS='O' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RS' AND a.PART_ID=B.PART_ID  WHERE a.ID='" & LISTA_ENT_DET(0).ID & "' AND a.TYPE='OS' "
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Public Sub ActualizandoEstadoOrdenServicio_Imprenta(ByVal LISTA_ENT_DET As List(Of ClsEntidadesAlm.PURCHASE_ORDER_LINE))
            Try
                ''Actualizando el Estado --
                'REQUISICIONES
                'Dim sql As String = ""
                'sql = "UPDATE REQUIREMENT SET STATUS='O' WHERE ID IN  (SELECT REQUI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                '& " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OS'  GROUP BY REQUI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                ''COTIZACION Y REQUISICION
                'sql = "UPDATE PURCHASE_QUOTE SET STATUS='O' WHERE ID IN  (SELECT COTI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                '& " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND COTI_ID<>'' and type='OS'  GROUP BY COTI_ID)"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                '& " WHERE ID='" & LISTA_ENT_DET(0).REQUI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RS'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'sql = ""
                'sql = "UPDATE B SET B.ORDEN_GENERADA='SI' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RS' AND a.PART_ID=B.PART_ID  WHERE a.ID='" & LISTA_ENT_DET(0).ID & "' AND a.TYPE='OS'"
                'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)

                ''Actualizando el Estado --
                'REQUISICIONES
                Dim sql As String = ""
                sql = "UPDATE REQUIREMENT SET STATUS='O' WHERE ID IN  (SELECT REQUI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OI'  GROUP BY REQUI_ID) AND " _
                & " TYPE IN (SELECT REQUI_TYPE FROM dbo.PURCHASE_ORDER_LINE WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND REQUI_ID<>'' and type='OI'  GROUP BY REQUI_TYPE)"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                'COTIZACION Y REQUISICION
                sql = "UPDATE PURCHASE_QUOTE SET STATUS='O' WHERE ID IN  (SELECT COTI_ID FROM dbo.PURCHASE_ORDER_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).ID & "'  AND COTI_ID<>'' and type='OI'  GROUP BY COTI_ID)"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).REQUI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RI'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE dbo.REQUIREMENT SET STATUS='O' WHERE ID IN (SELECT REQUI_ID FROM dbo.PURCHASE_QUOTE_LINE " _
                & " WHERE ID='" & LISTA_ENT_DET(0).COTI_ID & "'  AND REQUI_ID<>''  GROUP BY REQUI_ID)AND TYPE='RI'"
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                sql = ""
                sql = "UPDATE B SET B.ORDEN_GENERADA='SI',B.STATUS='O' FROM dbo.PURCHASE_ORDER_LINE a INNER JOIN dbo.REQUIREMENT_LINE b ON a.REQUI_ID=b.ID AND b.TYPE='RI' AND a.PART_ID=B.PART_ID  WHERE a.ID='" & LISTA_ENT_DET(0).ID & "' AND a.TYPE='OI' "
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Public Function GuardarOrdenCompra(ByVal Ent_cab As ClsEntidadesAlm.PURCHASE_ORDER, lista As List(Of ClsEntidadesAlm.PURCHASE_ORDER_LINE),
                                           ByVal TipoAnexDocuem As String, ByVal Edicion As Boolean) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                ''Borrando la data
                SqlHelper.ExecuteNonQuery(tr, "PUR_SP_D_FORMULACION_DET_EDICION", Ent_cab.ID, Ent_cab.TYPE)
                '+++++++
                With Ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_CAB_IV", .ID, .TYPE, .DOCUMENT_DATE, .VENDOR_ID, .NUMBER_ESTIMATING, .CURRENCY_TYPE, .TERMS_NAME,
                                              .SELL_RATE, .PROMISE_DATE, .COMMENT, .AUTORIZED_ID, .BUYER_PURCHASE_ID, .TIME_DLV, .ADDR_DLV, .STATUS_ID, .AMOUNT, .DISCOUNT,
                                              .AMOUNT_TAX, .AMOUNT_SALES, .UPDATE_DATE, .UPDATE_HOUR, .USER_ID, .CURR_EXCHANGE_TYPE, .NAME_FACT, .VAT_REGISTRATION_FACT,
                                              .ADDR_FACT, .REFER_DOCUMENT_TYPE, .REFER_DOCUMENT_NUMBER, .PROJECT_ID, .FLAG_PROMISE_DATE, .AMOUNT_FLETE, .FLAG_FLETE_IGV,
                                              .ORDEN_PARA_IMPORTACION, .FECHA_INGRESO_IMPORTACION, .NUMERO_DOC_IMPORTACION, .PRIORIDAD, .TIPO_ENTREGA, .MODO_ENTREGA)
                End With
                For Each d As ClsEntidadesAlm.PURCHASE_ORDER_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_DET_I", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .UNIT_REFERENCE, .FACTOR_REFERENCE, .QTY,
                                                  .PRICE, .DISCOUNT_PER, .DISCOUNT, .AMOUNT_TAX, .PERCENT_TAX, .PRICE_NET, .AMOUNT_TOTAL, .AMOUNT_TOTAL_NET, .QTY_ENTER, .QTY_OUT,
                                                  .STATUS_ID, .COMMENT1, .TEXT_COMMENT, .IS_VAT, .PRICE_UNIT, .CCOST_ID, .PROJECT_ID, .AREA_ID, .COTI_ID, .REQUI_ID, .FLAG_FREE_IGV,
                                                  IIf(.TYPE = "OC", "RQ", "RS"), .QTY_ORIGINAL, .EQUIVALENCIA, .UNIT_PROVEEDOR, .CECOS)
                    End With
                Next
                'actualizamos la numeracion
                'If Edicion = False Then
                '    SqlHelper.ExecuteNonQuery(tr, "PUR_SP_U_CORRELATIVO", "OC", Ent_cab.ID)
                'End If
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function

        Public Function GuardarOrdenServicio(ByVal Ent_cab As ClsEntidadesAlm.PURCHASE_ORDER, lista As List(Of ClsEntidadesAlm.PURCHASE_ORDER_LINE),
                                          ByVal TipoAnexDocuem As String, ByVal Edicion As Boolean) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                ''Borrando la data
                SqlHelper.ExecuteNonQuery(tr, "PUR_SP_D_FORMULACION_DET_EDICION", Ent_cab.ID, Ent_cab.TYPE)
                ''''''
                With Ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_CAB", .ID, .TYPE, .DOCUMENT_DATE, .VENDOR_ID, .NUMBER_ESTIMATING, .CURRENCY_TYPE, .TERMS_NAME,
                                              .SELL_RATE, .PROMISE_DATE, .COMMENT, .AUTORIZED_ID, .BUYER_PURCHASE_ID, .TIME_DLV, .ADDR_DLV, .STATUS_ID, .AMOUNT, .DISCOUNT,
                                              .AMOUNT_TAX, .AMOUNT_SALES, .UPDATE_DATE, .UPDATE_HOUR, .USER_ID, .CURR_EXCHANGE_TYPE, .NAME_FACT, .VAT_REGISTRATION_FACT,
                                              .ADDR_FACT, .REFER_DOCUMENT_TYPE, .REFER_DOCUMENT_NUMBER, .PROJECT_ID, .FLAG_PROMISE_DATE, .AMOUNT_FLETE, .FLAG_FLETE_IGV)
                End With
                For Each d As ClsEntidadesAlm.PURCHASE_ORDER_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_DET_I", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .UNIT_REFERENCE, .FACTOR_REFERENCE, .QTY,
                                                  .PRICE, .DISCOUNT_PER, .DISCOUNT, .AMOUNT_TAX, .PERCENT_TAX, .PRICE_NET, .AMOUNT_TOTAL, .AMOUNT_TOTAL_NET, .QTY_ENTER, .QTY_OUT,
                                                  .STATUS_ID, .COMMENT1, .TEXT_COMMENT, .IS_VAT, .PRICE_UNIT, .CCOST_ID, .PROJECT_ID, .AREA_ID, .COTI_ID, .REQUI_ID, .FLAG_FREE_IGV,
                                                  IIf(.TYPE = "OC", "RQ", "RS"), .QTY_ORIGINAL, .EQUIVALENCIA, .UNIT_PROVEEDOR, .CECOS)
                    End With
                Next
                'actualizamos la numeracion
                'If Edicion = False Then
                '    SqlHelper.ExecuteNonQuery(tr, "PUR_SP_U_CORRELATIVO", "OS", Ent_cab.ID)
                'End If

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        Public Function GuardarOrdenServicio_Imprenta(ByVal Ent_cab As ClsEntidadesAlm.PURCHASE_ORDER, lista As List(Of ClsEntidadesAlm.PURCHASE_ORDER_LINE),
                                          ByVal TipoAnexDocuem As String, ByVal Edicion As Boolean, lista_lotes As List(Of ClsEntidadesAlm.PURCHASE_ORDER_LINE_LOTES)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                ''Borrando la data
                SqlHelper.ExecuteNonQuery(tr, "PUR_SP_D_FORMULACION_DET_EDICION", Ent_cab.ID, Ent_cab.TYPE)
                ''''''
                With Ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_CAB", .ID, .TYPE, .DOCUMENT_DATE, .VENDOR_ID, .NUMBER_ESTIMATING, .CURRENCY_TYPE, .TERMS_NAME,
                                              .SELL_RATE, .PROMISE_DATE, .COMMENT, .AUTORIZED_ID, .BUYER_PURCHASE_ID, .TIME_DLV, .ADDR_DLV, .STATUS_ID, .AMOUNT, .DISCOUNT,
                                              .AMOUNT_TAX, .AMOUNT_SALES, .UPDATE_DATE, .UPDATE_HOUR, .USER_ID, .CURR_EXCHANGE_TYPE, .NAME_FACT, .VAT_REGISTRATION_FACT,
                                              .ADDR_FACT, .REFER_DOCUMENT_TYPE, .REFER_DOCUMENT_NUMBER, .PROJECT_ID, .FLAG_PROMISE_DATE, .AMOUNT_FLETE, .FLAG_FLETE_IGV)
                End With
                For Each d As ClsEntidadesAlm.PURCHASE_ORDER_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_DET", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .UNIT_REFERENCE, .FACTOR_REFERENCE, .QTY,
                                                  .PRICE, .DISCOUNT_PER, .DISCOUNT, .AMOUNT_TAX, .PERCENT_TAX, .PRICE_NET, .AMOUNT_TOTAL, .AMOUNT_TOTAL_NET, .QTY_ENTER, .QTY_OUT,
                                                  .STATUS_ID, .COMMENT1, .TEXT_COMMENT, .IS_VAT, .PRICE_UNIT, .CCOST_ID, .PROJECT_ID, .AREA_ID, .COTI_ID, .REQUI_ID, .FLAG_FREE_IGV, IIf(.TYPE = "OI", "RI", ""))
                    End With
                Next

                For Each d As ClsEntidadesAlm.PURCHASE_ORDER_LINE_LOTES In lista_lotes
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "PUR_SP_I_ORDEN_COMPRA_DET_LOTES", .ID, .TYPE, .ITEM_PRODUCTO, .ITEM_ME, .ITEM, .PART_ID_ME, .COD_PRODUCTO, .REQUI_ID)
                    End With
                Next
                SqlHelper.ExecuteNonQuery(tr, "PUR_SP_U_REFER_ORDEN_COMPRA_DET_IMPRENTA", Ent_cab.ID, Ent_cab.TYPE)
                SqlHelper.ExecuteNonQuery(tr, "PUR_SP_U_REFER_ORDEN_COMPRA_DET_IMPRENTA_OS", Ent_cab.ID, Ent_cab.TYPE)
                'actualizamos la numeracion
                'If Edicion = False Then
                '    SqlHelper.ExecuteNonQuery(tr, "PUR_SP_U_CORRELATIVO", "OS", Ent_cab.ID)
                'End If

                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function

        Public Function DetalleInicialOrdenCompras(ByVal Formula_mp As String, ByVal Formula_ee As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_ORDEN_COMPRA_DETALLES", Formula_mp, Formula_ee).Tables(0)
        End Function

        Public Function Consultas_Generales(ByVal _Consulta As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
        End Function


        Public Function Mostrar_Documentos_Principal(ByVal STIPO As String, ByVal FECHA_INI As String, FECHA_FIN As String, OPCION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "PUR_LIST_PURCHASE_ORDER", "", STIPO, FECHA_INI, FECHA_FIN, OPCION, 2).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
    End Class

    Public Class PURCHASE_FACT_SUPPLIER
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Compras_Detalle_Caja_Chica(ByVal id_caja_chica As String, ByVal item_caja_chica As String, ByVal item As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_LISTA_DETALLE_CAJA_CHICA", id_caja_chica, item_caja_chica, item).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function Get_Tipo_Doc() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "COMPRA_SP_S_DOCUMENT_TYPE").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Function

        Public Function Get_ValidaRetencion(ByVal tipo_doc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_VALIDA_RETENCION", tipo_doc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function Get_Datos_Verifica_Retencion(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_DATOS_VERIFICA_COMP_RET", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Genera_Comp_Retencion(ByVal CODIGO As String, ByVal FECHA As String) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = ""
                sql = "EXEC COMPRAS_SP_U_GENERA_COMP_RETENCION '" & CODIGO & "','" & FECHA & "' "
                If sql <> "" Then SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Get_Validacion_Ingreso_Compras(ByVal _td As String, ByVal _serie As String, ByVal _numero As String, ByVal _proveedor As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_VALIDA_INGRESO_COMPRA", _td, _serie, _numero, _proveedor).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Function

        Public Function Get_Validacion_Modificacion_Compras(ByVal _td As String, ByVal _serie As String, ByVal _numero As String, ByVal _proveedor As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_VALIDA_MODIFICACION_COMPRA", _td, _serie, _numero, _proveedor).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Function


        Public Function Eliminar_Oden_Compra(ByVal CODIGO As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "PUR_SP_D_ORDEN_COMPRA", CODIGO)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Cambiar_Estado_Oden_Compra(ByVal CONSULTA As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CONSULTA)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function VerificarDocumentos(ByVal _NombreStore As String, ByVal _DOCUMENT_ID As String,
                                        ByVal _NUMBER_SERIE As String, ByVal _NUMBER_DOCUMENT As String) As Boolean
            Dim estado As Boolean = True
            Try
                Dim dtAnulacion As New DataTable
                dtAnulacion = SqlHelper.ExecuteDataset(cn, _NombreStore, _DOCUMENT_ID, _NUMBER_SERIE, _NUMBER_DOCUMENT).Tables(0)
                If dtAnulacion.Rows.Count() <> 0 Then
                    estado = False
                Else
                    estado = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                estado = False
            End Try
            Return estado
        End Function

        Public Function Anular_Oden_Compra(ByVal CODIGO As String) As Boolean
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = ""
                sql = "UPDATE PURCHASE_FACT_SUPPLIER SET STATUS_ID='02' WHERE ID='" & CODIGO & "'"
                If sql <> "" Then SqlHelper.ExecuteNonQuery(tr, CommandType.Text, sql)
                sql = ""
                sql = "EXEC COMPRAS_SP_U_ESTADO_ANUL_OC_PFS '" & CODIGO & "'"
                If sql <> "" Then SqlHelper.ExecuteNonQuery(tr, CommandType.Text, sql)
                sql = ""
                sql = "DELETE FROM dbo.CUSTOMER_BALANCE_PAY WHERE DOCUMENT_REF='FP' AND NUMBER_REF='" & CODIGO & "'"
                If sql <> "" Then SqlHelper.ExecuteNonQuery(tr, CommandType.Text, sql)

                SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ESTADO_CAJA_CHICA_PFS", CODIGO, "SI")

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Anular_Oden_Importacion(ByVal CODIGO As Integer) As Boolean
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim sql As String = ""
                sql = ""
                sql = "UPDATE PURCHASE_FACT_SUPPLIER_IMPORT SET STATUS_ID='02' WHERE ID=" & CODIGO
                If sql <> "" Then SqlHelper.ExecuteNonQuery(tr, CommandType.Text, sql)


                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Anular_Licitacion(ByVal CODIGO As Integer) As Boolean
            Try
                Dim dt_anular As DataTable
                dt_anular = New DataTable
                Dim sql As String = ""
                sql = ""
                sql = "UPDATE LICITACION SET ESTADO='ANULADO' WHERE ID=" & CODIGO & ""
                If sql <> "" Then SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Modo_Edicion_Cabecera(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_MODO_EDICION_CABECERA", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function get_Verifica_Ubigeo_Proveedor(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_VERIFICA_UBIGEO", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Cabecera_Importacion(ByVal CODIGO As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_MODO_EDICION_CABECERA_PURCHASE_FACT_SUPPLIER_IMPORT", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Licitacion(ByVal CODIGO As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LCITACION_DETALLE_PIVOT", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Licitacion_Reporte(ByVal CODIGO As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LICITACION_REPORTE_PIVOT", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_MODO_EDICION_DETALLE", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle_Importacion(ByVal CODIGO As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_MODO_EDICION_DETALLE_PURCHASE_FACT_SUPPLIER_LINE_IMPORT", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle_Importacion_Gastos_Varios(ByVal CODIGO As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_MODO_EDICION_DETALLE_PURCHASE_FACT_SUPPLIER_LINE_IMPORT_GASTOS_VARIOS", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Get_Datos_Importacion(ByVal CODIGO As String, ByVal TIPO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_DATOS_IMPORTACION", CODIGO, TIPO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modo_Edicion_Detalle_Doc_Ref_Compras(ByVal tipo_doc As String, ByVal serie_doc As String, ByVal numero_doc As String, ByVal vendor_id As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_MODO_EDICION_DETALLE_DOC_REF_COMPRAS", tipo_doc, serie_doc, numero_doc, vendor_id).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function Requisicion_Detalle(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_REQUI_DET", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Compras_Detalle(ByVal CODIGO As String, ByVal TIPO_CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRA_SP_S_LISTA_PURCHASE_FACT_SUPPLIER_LINE", CODIGO, TIPO_CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function GuardarCompra(ByVal Ent_cab As ClsEntidadesAlm.PURCHASE_FACT_SUPPLIER, lista As List(Of ClsEntidadesAlm.PURCHASE_FACT_SUPPLIER_LINE),
                                           ByVal TipoAnexDocuem As String, ByVal _opcion_nuevo As Boolean, ByVal DT_DETALLE_DOC_REF As DataTable, ByVal Ent_cab_Importacion As ClsEntidadesAlm.REFERENCES_DOCUMENT_IMPORTACION_COMPRAS) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                ''
                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_COMPRAS_DET_EDICION", Ent_cab.ID)
                ''
                With Ent_cab
                    Dim a As Integer
                    a = SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_COMPRA_CAB", .ID, .TYPE, .DOCUMENT_DATE, .VENDOR_ID, .NUMBER_ESTIMATING, .CURRENCY_TYPE, .TERMS_NAME,
                                              .SELL_RATE, .PROMISE_DATE, .COMMENT, .AUTORIZED_ID, .BUYER_PURCHASE_ID, .TIME_DLV, .ADDR_DLV, .STATUS_ID, .AMOUNT, .DISCOUNT,
                                              .AMOUNT_TAX, .AMOUNT_SALES, .UPDATE_DATE, .UPDATE_HOUR, .USER_ID, .CURR_EXCHANGE_TYPE, .NAME_FACT, .VAT_REGISTRATION_FACT,
                                              .ADDR_FACT, .REFER_DOCUMENT_TYPE, .REFER_DOCUMENT_NUMBER,
                                              .SERIE, .EXPIRATION_DATE, .BUDGET_ID, .ORDER_BUY_ID, .NOTE_IN_ID, .WAREHOUSE_ID, .TYPE_DESTINE, .REFER_DOCUMENT_DATE, .CREATE_DATE,
                                              .PERCENT_DETRAC, .COM_PER_ID, .COM_PER_TD, .COM_PER_SERIE, .COM_PER_NUMERO, .COM_PER_PERCENT, .COM_PER_DATE_EMISION,
                                              .COM_PER_DATE_VCTO, .TD_AN, .SERIE_AN, .NUMERO_AN, .FECHA_AN, .MONTO_AN, .CENTRO_DE_COSTOS, .NUM_ORDER_PAGO, .AMOUNT_INAFECTO,
                                              .IS_IMPORTATION, .DETRAC_DATE, .DETRAC_NUMBER, .ID_CAJA_CHICA, .ITEM_CAJA_CHICA, .ITEM)
                End With

                If Ent_cab.IS_IMPORTATION = "1" Then
                    With Ent_cab_Importacion
                        Dim a As Integer
                        a = SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_COMPRA_IMPORTACION", .ID, .TYPE, .TIPO_DOCUMENTO, .SERIE, .ANIO, .NUMERO_DOCUMENTO)
                    End With
                End If


                For Each d As ClsEntidadesAlm.PURCHASE_FACT_SUPPLIER_LINE In lista
                    With d
                        Dim a As Integer
                        a = SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_COMPRA_DET_I", .ID, .TYPE, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .UNIT_REFERENCE, .FACTOR_REFERENCE, .QTY,
                                                  .PRICE, .DISCOUNT_PER, .DISCOUNT, .AMOUNT_TAX, .PERCENT_TAX, .PRICE_NET, .AMOUNT_TOTAL, .AMOUNT_TOTAL_NET, .QTY_ENTER, .QTY_OUT,
                                                  .STATUS_ID, .COMMENT1, .TEXT_COMMENT, .IS_VAT, .PRICE_UNIT, .CCOST_ID, .FLAG_FREE_IGV, .CENCOS)
                    End With
                Next

                'ACTUALIZAMOS ESTADO DE LAS ORDENES DE COMPRA ADJUNTADAS AL REG. DE COMPRAS
                With Ent_cab
                    Dim a As Integer
                    a = SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ESTADO_OC_PFS", .ID)
                End With

                'ACTUALIZAMOS ESTADO DE LAS COMPRAS POR CAJA CHICA
                With Ent_cab
                    If .ID_CAJA_CHICA <> "" And .ITEM_CAJA_CHICA <> "" And .ITEM <> "" Then
                        Dim a As Integer
                        a = SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ESTADO_CAJA_CHICA_PFS", .ID, "SIR")
                    End If
                End With

                If _opcion_nuevo = True Then
                    SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_NUM_ORDEN_PAGO")
                End If

                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_DOC_REF_COMPRAS", Ent_cab.REFER_DOCUMENT_TYPE, Ent_cab.SERIE, Ent_cab.REFER_DOCUMENT_NUMBER, Ent_cab.VENDOR_ID)

                If DT_DETALLE_DOC_REF.Rows.Count > 0 Then
                    For Each item As DataRow In DT_DETALLE_DOC_REF.Rows
                        SqlHelper.ExecuteNonQuery(tr, "FACT_SP_I_DETALLE_DOC_REF_COMPRAS", Ent_cab.REFER_DOCUMENT_TYPE, Ent_cab.SERIE, Ent_cab.REFER_DOCUMENT_NUMBER, item("TIPO_DOC"), item("SERIE_DOC"), item("NUM_DOC"), IIf(String.IsNullOrEmpty(item("FECHA_DOC")), DBNull.Value, item("FECHA_DOC")), item("MONTO"), item("IGV"), Ent_cab.VENDOR_ID, item("MONEDA"))
                    Next
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

        Public Function Guardar_Importacion(ByVal Ent_cab As ClsEntidadesAlm.PURCHASE_FACT_SUPPLIER_IMPORT, lista As List(Of ClsEntidadesAlm.PURCHASE_FACT_SUPPLIER_LINE_IMPORT),
                                           ByVal _opcion_nuevo As Boolean,
                                           ByVal Ent_cab_Importacion As ClsEntidadesAlm.PURCHASE_FACT_SUPPLIER_LINE_IMPORT_GASTOS_VARIOS) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim a As Integer

                If _opcion_nuevo = True Then
                    With Ent_cab
                        a = SqlHelper.ExecuteScalar(tr, "COMPRA_SP_I_PURCHASE_FACT_SUPPLIER_IMPORT", .ID, .VENDOR_ID, .INVOICE, .FECHA_INVOICE, .NRO_DAM, .FECHA_DAM,
                                                      .CURRENCY_TYPE, .SELL_RATE, .COMMENT, .USER_ID, .STATUS_ID)
                    End With
                    Ent_cab.ID = a
                Else
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_COMPRAS_IMPORTACION", Ent_cab.ID)
                    With Ent_cab
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_U_PURCHASE_FACT_SUPPLIER_IMPORT", .ID, .VENDOR_ID, .INVOICE, .FECHA_INVOICE, .NRO_DAM, .FECHA_DAM,
                                                      .CURRENCY_TYPE, .SELL_RATE, .COMMENT, .USER_ID, .STATUS_ID)
                    End With
                End If


                With Ent_cab_Importacion
                    SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_PURCHASE_FACT_SUPPLIER_LINE_IMPORT_GASTOS_VARIOS", Ent_cab.ID, .COMISION_AGENCIA_ADUANAS2, .GASTOS_OPERATIVOS,
                                              .GASTOS_ADMINISTATIVOS, .HANDLING_DESTINO, .TRANSMISION_MANIFIESTO, .GASTOS_OPERACIONAL_DESTINO, .SEGURO3, .ALMACEN,
                                              .VISTOS_BUENOS, .DEVOLUCION_CONTENEDOR, .DESCONSOLIDACION, .REPARACION_CONTENEDOR, .RECTIFICACION_MANI,
                                              .FLETE_MARITIMO, .TRANSPORTE_TERRESTRE)
                End With

                For Each d As ClsEntidadesAlm.PURCHASE_FACT_SUPPLIER_LINE_IMPORT In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_PURCHASE_FACT_SUPPLIER_LINE_IMPORT", Ent_cab.ID, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .DAM,
                                                  .QTY, .PRICE, .PRICE_TOTAL, .AD_VALOREM2, .ISC, .IGV, .IPM, .DERECHOS_ESPECIFICOS, .DERECHOS_ANTIDUMPING, .SEGURO2,
                                                  .SOBRETASA_TRIBUTO, .SOBRETASA_SANCION, .PERCEPCION2, .VALOR_REF_FLETE_DAM, .FLETE_DAM, .SEGURO_DAM, .AD_VALOREM_DAM,
                                                  .IGV_DAM, .IPM_DAM, .PERCEPCION_DAM, .COMISION_AGENCIA_ADUANAS2, .GASTOS_OPERATIVOS, .GASTOS_ADMINISTRATIVOS,
                                                  .HANDLING_DESTINO, .TRANSMISION_MANIFIESTO, .GASTOS_OPERACIONAL_DESTINO, .SEGURO3, .ALMACEN, .VISTOS_BUENOS,
                                                  .DEVOLUCION_CONTENEDOR, .DESCONSOLIDACION, .REPARACION_CONTENEDOR, .RECTIFICACION_MANI, .FLETE_MARITIMO,
                                                  .TRANSPORTE_TERRESTRE, .TC, .TOTAL_COSTO_AGENCIA_ADUANAS, .COSTO_INVOICE2_TOTAL, .COSTO_ADVALOREM_TOTAL,
                                                  .COSTO_AGENCIA_ADUANA_TOTAL, .COSTO_TOTAL, .COSTO_UNITARIO, .COSTO_UNITARIO_SOLES)
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

        Public Function Guardar_Licitacion(ByVal Ent_cab As ClsEntidadesAlm.LICITACION, DT_INGRESO As DataTable, NUM_ENTREGAS As Integer, OPCION_IGV As Integer) As Boolean
            Dim estados As Boolean = True
            Dim a As Integer = 0
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                ''
                SqlHelper.ExecuteNonQuery(tr, "VENTAS_SP_D_LICITACIONES", Ent_cab.ID_CABECERA)
                ''
                With Ent_cab
                    a = SqlHelper.ExecuteScalar(tr, "VENTAS_SP_I_LICITACIONES", .NUMERO_LICITACION, .FECHA, .NUMERO_ENTREGAS, .OBS, .USUARIO, .TERMINAL)
                End With

                'For Each d As ClsEntidadesAlm.LICITACION_LINE In lista
                '    With d
                '        SqlHelper.ExecuteNonQuery(tr, "VENTAS_SP_I_LICITACIONES_LINE", a, .ITEM, .PART_ID, .CANTIDAD_TOTAL, .COD_CLIENTE, .CANTIDAD_CLIENTE, .PRECIO_CON_IGV, .PRECIO_SIN_IGV, .FLAG_IGV, .TEXTO_NRO_ENTREGA, .CANTIDAD_ENTREGA)
                '    End With
                'Next
                Dim CompraDetENT = New ClsEntidadesAlm.LICITACION_LINE
                For i As Integer = 0 To DT_INGRESO.Rows.Count() - 1

                    With CompraDetENT
                        .ITEM = CInt(DT_INGRESO.Rows(i).Item("ITEM").ToString)
                        .PART_ID = DT_INGRESO.Rows(i).Item("PART_ID").ToString
                        .DESCRIPTION = DT_INGRESO.Rows(i).Item("DESCRIPTION").ToString
                        .UNIT = DT_INGRESO.Rows(i).Item("UNIT").ToString
                        .PRESENTACION = DT_INGRESO.Rows(i).Item("PRESENTACION").ToString
                        .CANTIDAD_TOTAL = CDbl(DT_INGRESO.Rows(i).Item("CANTIDAD_TOTAL").ToString)
                        .COD_CLIENTE = DT_INGRESO.Rows(i).Item("COD_CLIENTE").ToString
                        .CLIENTE = DT_INGRESO.Rows(i).Item("CLIENTE").ToString
                        .RUC = DT_INGRESO.Rows(i).Item("RUC").ToString
                        .CANTIDAD_CLIENTE = CDbl(DT_INGRESO.Rows(i).Item("CANTIDAD_CLIENTE").ToString)
                        .PRECIO = CDbl(DT_INGRESO.Rows(i).Item("PRECIO").ToString)
                        .PRECIO_CON_IGV = CDbl(DT_INGRESO.Rows(i).Item("PRECIO_CON_IGV").ToString)
                        .PRECIO_SIN_IGV = CDbl(DT_INGRESO.Rows(i).Item("PRECIO_SIN_IGV").ToString)
                        .VALOR_VENTA = CDbl(DT_INGRESO.Rows(i).Item("VALOR_VENTA").ToString)
                        .IGV_ART = CDbl(DT_INGRESO.Rows(i).Item("IGV_ART").ToString)
                        .IMPORTE = CDbl(DT_INGRESO.Rows(i).Item("IMPORTE").ToString)
                        .FLAG_IGV = OPCION_IGV
                        For j As Integer = 1 To NUM_ENTREGAS
                            .TEXTO_NRO_ENTREGA = "ENTREGA" & CStr(j)
                            .CANTIDAD_ENTREGA = CDbl(DT_INGRESO.Rows(i).Item("ENTREGA" & CStr(j) & "").ToString)
                            SqlHelper.ExecuteNonQuery(tr, "VENTAS_SP_I_LICITACIONES_LINE", a, .ITEM, .PART_ID,
                            .DESCRIPTION, .UNIT, .PRESENTACION, .CANTIDAD_TOTAL, .COD_CLIENTE, .CLIENTE, .RUC,
                            .CANTIDAD_CLIENTE, .PRECIO, .PRECIO_CON_IGV, .PRECIO_SIN_IGV, .VALOR_VENTA, .IGV_ART, .IMPORTE,
                            .FLAG_IGV, .TEXTO_NRO_ENTREGA, .CANTIDAD_ENTREGA)
                        Next
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

        Public Function DetalleInicialOrdenCompras(ByVal Formula_mp As String, ByVal Formula_ee As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "PUR_SP_S_ORDEN_COMPRA_DETALLES", Formula_mp, Formula_ee).Tables(0)
        End Function

        Public Function Consultas_Generales(ByVal _Consulta As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _Consulta).Tables(0)
        End Function


        Public Function Mostrar_Documentos_Principal(ByVal FECHA_INI As Date, FECHA_FIN As Date, OPCION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_COMPRAS_PRINCIPAL", FECHA_INI, FECHA_FIN, OPCION, 0).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Mostrar_Documentos_Principal_Importacion(ByVal FECHA_INI As Date, FECHA_FIN As Date, OPCION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_IMPORTACION_PRINCIPAL", FECHA_INI, FECHA_FIN, OPCION).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Mostrar_Documentos_Principal_Licitacion(ByVal FECHA_INI As Date, FECHA_FIN As Date, OPCION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LICITACIONES_LISTA", FECHA_INI, FECHA_FIN, OPCION).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
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


        Public Function get_TiposCambio() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_TIPOC").Tables(0)
        End Function

        Public Function get_Prioridad_Pedido() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_PRIORIDAD_PEDIDO").Tables(0)
        End Function
        Public Function get_Tipo_Entrega_Pedido() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_TIPO_ENTREGA_PEDIDO").Tables(0)
        End Function

        Public Function get_Modo_Entrega_Pedido() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_MODO_ENTREGA_PEDIDO").Tables(0)
        End Function

        Public Function get_Porcentaje_IGV() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_IGV").Tables(0)
        End Function


        Public Function get_TiposCambio_fecha_dada(ByVal FECHA_DADA As String) As Double
            'Return SqlHelper.ExecuteScalar(cn, CommandType.StoredProcedure, "COMPRA_SP_S_CURRENCY_EXCHANGE", FECHA_DADA)
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'Obteniendo el correlativo
                Dim tc As Double = 0
                tc = SqlHelper.ExecuteScalar(tr, "COMPRA_SP_S_CURRENCY_EXCHANGE", FECHA_DADA)
                Return tc
            Catch ex As Exception
                MsgBox(ex.Message)
                Return 0
            End Try
        End Function
    End Class

    Public Class USUARIO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Lista_Proveedores() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "COMPRAS_SP_S_LISTA_PROVEEDOR").Tables(0)
        End Function

        Public Function EliminacionSolCotizacion(ByVal _numero_documento As String) As Boolean
            Dim ESTADO As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_D_PURCHASE_QUOTE", _numero_documento)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                ESTADO = False
                Throw
            End Try
            Return ESTADO
        End Function
        Public Function AnularSolCotizacion(ByVal _numero_documento As String) As Boolean
            Dim ESTADO As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_PURCHASE_QUOTE", _numero_documento)
                'SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ESTADO_REQUIREMENT_SOL_COTIZACION_ANULACION", _numero_documento)
                SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ESTADO_REQUIREMENT_ANUL_SOL_COTIZACION", _numero_documento)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                ESTADO = False
                MsgBox(ex.Message)
            End Try
            Return ESTADO
        End Function
        Public Function DatosGeneralesUsuario(ByVal _CodigoUsuario As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_DATOS_USUARIO", _CodigoUsuario).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosListaRequisiciones(ByVal _opcion_tipo_requisicion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_REQUISICIONES", _opcion_tipo_requisicion).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosListaRequisicion_especifica(ByVal _numero_requisicion As String, ByVal _tipo_requisicion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_LISTA_REQUISICION_ESPECIFICO", _numero_requisicion, _tipo_requisicion).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function DatosGeneralesSolicitudCotizacion_Cabecera(ByVal _CODIGO_SOL_COTIZACION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_SOL_COTIZACION_ESPECIFICO_CABECERA", _CODIGO_SOL_COTIZACION).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function DatosGeneralesSolicitudCotizacion_Detalle(ByVal _CODIGO_SOL_COTIZACION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_SOL_COTIZACION_ESPECIFICO_DETALLE", _CODIGO_SOL_COTIZACION).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function DatosGenerales_Act_Coti_SolicitudCotizacion_Detalle(ByVal _CODIGO_SOL_COTIZACION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_ACT_COTIZACION_ESPECIFICO_DETALLE", _CODIGO_SOL_COTIZACION).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function get_DatosGeneralesSolicitudCotizacion(ByVal _fecha_inicial As String, ByVal _fecha_final As String, ByVal _opcion_busqueda As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_SOLI_COTIZACION", _fecha_inicial, _fecha_final, _opcion_busqueda).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function get_Numeracion_Sol_Cotizacion() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_NUMERACION_SOLI_COTIZACION").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function get_Datos_Provedor(ByVal _cod_proveedor As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_DATOS_PROVEEDOR", _cod_proveedor).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function get_Datos_Forma_Pago(ByVal _cod_Forma_Pago As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_DATOS_TERMS_PAY", _cod_Forma_Pago).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function get_Datos_Articulo(ByVal _cod_articulo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_MUESTRA_ARTICULOS_SOL_COTI_DATOS", _cod_articulo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function get_Imprimir_Sol_cotizacion(ByVal _numero_cotizacion As String, ByVal _OPCION As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_RPT_PURCHASE_QUOTE", _numero_cotizacion, _OPCION).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function GuardandoPurchaseQuote(ent_cab As ClsEntidadesAlm.PURCHASE_QUOTE, lista As List(Of ClsEntidadesAlm.PURCHASE_QUOTE_LINE),
                                               ByVal data_Proveedores As DataTable, ByRef _CodigoSolicitudCotizacion As String) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                'Obteniendo el correlativo
                Dim Correlativo As Integer = 0
                Correlativo = SqlHelper.ExecuteScalar(tr, "COMPRA_SP_CORRELATIVO_COTIZACION")
                Correlativo = IIf(String.IsNullOrEmpty(Correlativo), 0, Correlativo)
                For Each Row As DataRow In data_Proveedores.Rows
                    Correlativo += 1
                    'cabecera doc
                    With ent_cab
                        .ID = String.Format("{0:0000000000}", CInt(Correlativo))
                        _CodigoSolicitudCotizacion = .ID
                        SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_I_PURCHASE_QUOTE", .ID, .DOCUMENT_DATE, Row("ID").ToString, .CURRENCY_ID, .COMMENT, .COMMENT_COT, IIf(.QUOTE_DATE = "", DBNull.Value, .QUOTE_DATE), .SCTIPCAM,
                                                  .SCVALIDEZ, .SCTIEMENT, .SCFORPAG, .SCNCOTIZ, .CREATE_DATE, IIf(.UPDATE_DATE = "", DBNull.Value, .UPDATE_DATE), .USER_ID, .PROJECT_ID, .STATUS)
                    End With
                    'detalle del documento
                    For Each d As ClsEntidadesAlm.PURCHASE_QUOTE_LINE In lista
                        With d
                            SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_I_PURCHASE_QUOTE_LINE", ent_cab.ID, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .PRICE, .AMOUNT_TAX, .AMOUNT,
                                                      .GUARANTEE, .QUALITY, .MARK, .COMMENT, .CURRENCY_ID, .DISCOUNT, IIf(.DLV_DATE = "", DBNull.Value, .DLV_DATE), .IS_VAT, .PROJECT_ID, .CC_ID, .AREA_ID, .REQUI_ID, .REQUI_TYPE)
                        End With
                    Next
                    'Guardando datos
                    data_Proveedores.BeginInit()
                    Row("NUMERACION") = ent_cab.ID
                    data_Proveedores.EndInit()
                    data_Proveedores.AcceptChanges()
                Next
                'detalle de doc

                ''ACTUALIZANDO CORRELATIVO
                SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_NUMERO_SOL_COTIZACION", CInt(Correlativo))
                ''         
                tr.Commit()
                tr.Dispose()
                For Each Row As DataRow In data_Proveedores.Rows
                    SqlHelper.ExecuteNonQuery(cn, "COMPRAS_SP_U_ESTADO_REQUIREMENT_SOL_COTIZACION", Row("NUMERACION"), "E")
                Next
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function

        Public Function Guardando_ActCotizacion(ent_cab As ClsEntidadesAlm.PURCHASE_QUOTE, lista As List(Of ClsEntidadesAlm.PURCHASE_QUOTE_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'cabecera doc
                With ent_cab

                    SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ACT_PURCHASE_QUOTE", .ID, .DOCUMENT_DATE, .VENDOR_ID, .CURRENCY_ID, .COMMENT, .COMMENT_COT, IIf(.QUOTE_DATE = "", DBNull.Value, .QUOTE_DATE), .SCTIPCAM,
                                              .SCVALIDEZ, .SCTIEMENT, .SCFORPAG, .SCNCOTIZ, .CREATE_DATE, IIf(.UPDATE_DATE = "", DBNull.Value, .UPDATE_DATE), .USER_ID, .PROJECT_ID, .STATUS)
                End With

                'detalle de doc
                For Each d As ClsEntidadesAlm.PURCHASE_QUOTE_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ACT_PURCHASE_QUOTE_LINE", .ID, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .PRICE, .AMOUNT_TAX, .AMOUNT,
                                                  .GUARANTEE, .QUALITY, .MARK, .COMMENT, .CURRENCY_ID, .DISCOUNT, IIf(.DLV_DATE = "", DBNull.Value, .DLV_DATE), .IS_VAT, .PROJECT_ID, .CC_ID, .AREA_ID, .REQUI_ID)
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
        Public Function ActualizandoPurchaseQuote(ent_cab As ClsEntidadesAlm.PURCHASE_QUOTE, lista As List(Of ClsEntidadesAlm.PURCHASE_QUOTE_LINE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                With ent_cab
                    SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_D_PURCHASE_QUOTE", .ID)
                End With
                'cabecera doc
                With ent_cab

                    SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_I_PURCHASE_QUOTE", .ID, .DOCUMENT_DATE, .VENDOR_ID, .CURRENCY_ID, .COMMENT, .COMMENT_COT, IIf(.QUOTE_DATE = "", DBNull.Value, .QUOTE_DATE), .SCTIPCAM,
                                              .SCVALIDEZ, .SCTIEMENT, .SCFORPAG, .SCNCOTIZ, .CREATE_DATE, IIf(.UPDATE_DATE = "", DBNull.Value, .UPDATE_DATE), .USER_ID, .PROJECT_ID, .STATUS)
                End With

                'detalle de doc
                For Each d As ClsEntidadesAlm.PURCHASE_QUOTE_LINE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_I_PURCHASE_QUOTE_LINE", .ID, .ITEM, .PART_ID, .PART_DESCRIPTION, .UNIT, .QTY, .PRICE, .AMOUNT_TAX, .AMOUNT,
                                                  .GUARANTEE, .QUALITY, .MARK, .COMMENT, .CURRENCY_ID, .DISCOUNT, IIf(.DLV_DATE = "", DBNull.Value, .DLV_DATE), .IS_VAT, .PROJECT_ID, .CC_ID, .AREA_ID, .REQUI_ID, .REQUI_TYPE)
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
        Public Function ActualizandoNumeracionPurchaseQuote(ByVal _numero As Integer) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                'actualizo la numeracion de la Solicitud de Cotizacion
                SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_NUMERO_SOL_COTIZACION", _numero)
                'With ent_cab
                '    SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ESTADO_REQUIREMENT_SOL_COTIZACION", .ID)
                'End With
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                estados = False
            End Try
            Return estados
        End Function
        Public Function ActualizandoEstadoRequirementPurchaseQuote(ByVal _numero As String, _opcion As String) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, "COMPRAS_SP_U_ESTADO_REQUIREMENT_SOL_COTIZACION", _numero, _opcion)
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
                estados = False
            End Try
            Return estados
        End Function
    End Class

End Class
