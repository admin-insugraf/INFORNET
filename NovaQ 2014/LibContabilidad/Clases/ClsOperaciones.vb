Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibComunVar

Public Class ClsOperaciones

    Public Class ReportesCO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function Voucher01(idcab_ As Integer, periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_VOUCHER01", idcab_, periodo_).Tables(0)
        End Function

        Public Function Libro_Diario(ayo_ As Integer, mes_ As Integer, pc_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_DIARIO", ayo_, mes_, pc_).Tables(0)
        End Function

        Public Function Libro_Mayor(ayo_ As Integer, mes_ As Integer, pc_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_MAYOR", ayo_, mes_, pc_).Tables(0)
        End Function

        Public Function Libro_Bancos(ayo_ As Integer, mes_ As Integer, pc_ As String, moneda_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BANCOS", ayo_, mes_, pc_, moneda_).Tables(0)
        End Function

        Public Function Libro_Caja(ayo_ As Integer, mes_ As Integer, pc_ As String, moneda_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA", ayo_, mes_, pc_, moneda_).Tables(0)
        End Function

        Public Function Balance_Comprobacion(ayo_ As Integer, mes_ As Integer, con_cta_tit_ As Integer, acumulado_ As Integer, dig_cta_tit_ As Integer, solo_cta_tit_ As Integer, moneda_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BAL_COMPRO", ayo_, mes_, dig_cta_tit_, acumulado_, con_cta_tit_, solo_cta_tit_, moneda_).Tables(0)
        End Function

        Public Function Balance_Comprobacion_Detalle(ayo_ As Integer, mes_ As Integer, con_cta_tit_ As Integer, acumulado_ As Integer, dig_cta_tit_ As Integer, solo_cta_tit_ As Integer, moneda_ As Integer) As DataTable
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_S_BAL_COMPRO", ayo_, mes_, dig_cta_tit_, acumulado_, con_cta_tit_, solo_cta_tit_, moneda_)
            Dim query As String = "ALTER TABLE DBO.CO_TB_BAL_COMPRO ADD INV_ACTIVO FLOAT"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
            query = "ALTER TABLE DBO.CO_TB_BAL_COMPRO ADD INV_PASIVO FLOAT"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
            query = "ALTER TABLE DBO.CO_TB_BAL_COMPRO ADD NATU_PERDIDA FLOAT"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
            query = "ALTER TABLE DBO.CO_TB_BAL_COMPRO ADD NATU_GANANCIA FLOAT"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
            query = "ALTER TABLE DBO.CO_TB_BAL_COMPRO ADD FUNC_PERDIDA FLOAT"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
            query = "ALTER TABLE DBO.CO_TB_BAL_COMPRO ADD FUNC_GANANCIA FLOAT"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CO_SP_S_BAL_COMPRO_II").Tables(0)
        End Function

        Public Function Balance_Comprobacion_Detalle_Cuenta(ayo_ As Integer, mes_ As Integer, moneda_ As Integer, acumulado_ As Integer, cuenta_contable_ As String, opcion_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BAL_COMPRO_DETALLE", ayo_, mes_, moneda_, acumulado_, cuenta_contable_, opcion_).Tables(0)
        End Function

        Public Sub Balance_Comprobacion_Actualizar_Cuenta(id_asiento As Integer, item_asiento As Integer)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_DETALLE_ASIENTO", id_asiento, item_asiento)
        End Sub

        Public Function Analisis_Cta01(f1 As Date, f2 As Date, cta1_ As String, cta2_ As String, a1_ As String, a2_ As String, pendiente_ As Integer, ayo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_ANALISIS1", f1, f2, cta1_, cta2_, a1_, a2_, pendiente_, ayo_, Environment.MachineName).Tables(0)
        End Function

        Public Function Get_Cuentas(cta1_ As String, cta2_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_CUENTAS", cta1_, cta2_).Tables(0)
        End Function

        Public Function Daot(ayo_ As Integer, tipo_ As Integer, tope_ As Double) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_DAOT_DET", ayo_, tipo_, tope_).Tables(0)
        End Function

        Public Function Daot_Ventas(ayo_ As Integer, tipo_ As Integer, tope_ As Double) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_DAOT_DET_VENTAS", ayo_, tope_).Tables(0)
        End Function

        Public Function BG_getClases() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_CLASES_BG").Tables(0)
        End Function

        Public Function BG_getCuentas10s_sobreGiro(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_CTAS_10_SOBREGIRO", periodo_).Tables(0)
        End Function

        Public Sub BG_Limpiar_Tabla_Balance_Gral()
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "DELETE FROM CO_TB_REP_BG10")
        End Sub

        Public Function BG_getGrupos_x_Clase(idclase_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_GRUPOS_BG", idclase_).Tables(0)
        End Function

        Public Function BG_getCuentas_x_Grupo(idgrupo_ As Integer, ayo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_GRUPOBG_CUENTAS", idgrupo_, ayo_).Tables(0)
        End Function

        Public Sub BG_setImportes_Balance_Gral(clase_ As Integer, grupo_ As Integer, cuenta_ As String, ayo_ As Integer, mes_ As Integer, es_mensual_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_S_BG_1", clase_, grupo_, cuenta_, ayo_, mes_, es_mensual_)
        End Sub

        Public Sub BG_set_Actualiza_Importe_CajaBancos_Cero()
            Dim query As String = "update  CO_TB_REP_BG10 set rb_importe = 0 where rb_nucuenta = 10 "
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
        End Sub

        Public Sub BG_setActualizar_Cta10_SobreGiro(cuenta_ As String, periodo_ As Integer, mes_ As Integer, acumulado_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_BAL_GRAL_1", cuenta_, periodo_, mes_, acumulado_)
        End Sub

        Public Sub BG_set_Actualizar_Resultado_Ejercicio(ayo_ As Integer, mes_ As Integer, cuenta_resultado_ As String)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_S_RESUL_BAL_COMPRO_CTA89", ayo_, mes_, "1000", "999999", cuenta_resultado_)
        End Sub

        Public Sub BG_setActualizar_Importe_PasivoPatrimonio()
            Dim query As String = "update CO_TB_REP_BG10 set rb_importe2 = (select sum(rb_importe) from CO_TB_REP_BG10 where rb_idmod in (3,4,5))"
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, query)
        End Sub

        Public Function BG_getBalance_Gral_1() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "select * from CO_TB_REP_BG10").Tables(0)
        End Function

        Public Function get_BI_cta10(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA10", periodo_).Tables(0)
        End Function

        Public Function get_BI_cta12(periodo_ As Integer, opcion_ As Integer) As DataTable
            'Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA12", periodo_).Tables(0)
            If opcion_ = 1 Then 'resumido
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA12", periodo_).Tables(0)
            ElseIf opcion_ = 2 Then 'detallado
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA12_DETALLE", periodo_).Tables(0)
            End If
        End Function

        Public Function get_BI_cta14(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA14", periodo_).Tables(0)
        End Function

        Public Function get_BI_cta16(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA16", periodo_).Tables(0)
        End Function

        Public Function get_BI_cta19(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA19", periodo_).Tables(0)
        End Function

        Public Function get_BI_cta34(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA34", periodo_).Tables(0)
        End Function

        Public Function get_BI_cta41(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA41", periodo_).Tables(0)
        End Function

        Public Function get_BI_cta42(periodo_ As Integer, opcion_ As Integer) As DataTable
            If opcion_ = 1 Then 'resumido
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA42", periodo_).Tables(0)
            ElseIf opcion_ = 2 Then 'detallado
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA42_DETALLE", periodo_).Tables(0)
            End If
        End Function

        Public Function get_BI_cta46(periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_BI_CTA46", periodo_).Tables(0)
        End Function

        Public Function get_BI_ctaX(_nom_sp As String, periodo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, _nom_sp, periodo_).Tables(0)
        End Function

        Public Function get_Reporte_EGP(ayo_ As Integer, mes_ As Integer, formato_ As Integer) As DataTable
            Dim dt_tmp As DataTable = Nothing
            Select Case formato_
                Case 1
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP", ayo_, mes_, 0).Tables(0)
                Case 2
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP", ayo_, mes_, 0).Tables(0)
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_COMPA", ayo_ - 1, mes_, 0).Tables(0)
                Case 3
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP", ayo_, mes_, 1).Tables(0)
                Case 4
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP", ayo_, mes_, 1).Tables(0)
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_COMPA", ayo_ - 1, mes_, 1).Tables(0)
            End Select
            Return dt_tmp
        End Function
        
        Public Function get_Reporte_EGP_Naturaleza(ayo_ As Integer, mes_ As Integer, formato_ As Integer) As DataTable
            Dim dt_tmp As DataTable = Nothing
            Select Case formato_
                Case 1 'ACUMULADO
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_NATURALEZA", ayo_, mes_, 0).Tables(0)
                Case 2 'ACUMULADO COMPARATIVO
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_NATURALEZA", ayo_, mes_, 0).Tables(0)
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_COM_NATURALEZA", ayo_ - 1, mes_, 0).Tables(0)
                Case 3 'MENSUAL
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_NATURALEZA", ayo_, mes_, 1).Tables(0)
                Case 4 'MENSUAL COMPARATIVO
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_NATURALEZA", ayo_, mes_, 1).Tables(0)
                    dt_tmp = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_REP_EGP_COM_NATURALEZA", ayo_ - 1, mes_, 1).Tables(0)
            End Select
            Return dt_tmp
        End Function


    End Class

    Public Class Asiento_Contable
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

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


        Public Function Validar_Cierre_Apertura_Modulos(ByVal Mes As Integer, ByVal año As Integer, ByVal opcion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_VALIDAR_CIERRE_APERTURA_MODULOS", Mes, año, opcion).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function
        Public Function Conceptos_EGP_Naturaleza_Cuentas(ByVal _Codigo As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CO_TB_CTA_CONCEPTO_EGP_NATURALEZA", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modificar_Cuentas_EGP_Naturaleza(ByVal _codigo As Integer, lista As List(Of ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                ''
                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_CO_TB_CTA_CONCEPTO_EGP_NATURALEZA", _codigo)
                ''
                For Each d As ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_CO_TB_CTA_CONCEPTO_EGP_NATURALEZA", .CO_CONCEPTO, .CO_CUENTA)
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

        Public Function Conceptos_EGP_Naturaleza() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CO_TB_CONCEPTO_EGP_NATURALEZA").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Conceptos_Balance_general_Cuentas(ByVal _Codigo As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CO_TB_CTA_CONCEPTO_BALANCE_GENERAL", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Conceptos_EGP_Funcion_Cuentas(ByVal _Codigo As Integer) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CO_TB_CTA_CONCEPTO_EGP", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Modificar_Cuentas_EGP_Funcion(ByVal _codigo As Integer, lista As List(Of ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                ''
                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_CO_TB_CTA_CONCEPTO_EGP", _codigo)
                ''
                For Each d As ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_CO_TB_CTA_CONCEPTO_EGP", .CO_CONCEPTO, .CO_CUENTA)
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

        Public Function Modificar_Cuentas_Balance_General(ByVal _codigo As Integer, lista As List(Of ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE)) As Boolean
            Dim estados As Boolean = True
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try

                ''
                SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_D_CO_TB_CTA_CONCEPTO_BALANCE_GENERAL", _codigo)
                ''
                For Each d As ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE In lista
                    With d
                        SqlHelper.ExecuteNonQuery(tr, "COMPRA_SP_I_CO_TB_CTA_CONCEPTO_BALANCE_GENERAL", .CO_CONCEPTO, .CO_CUENTA)
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

        Public Function Conceptos_EGP_Funcion() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CO_TB_CONCEPTO_EGP").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Conceptos_Balance_general() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CO_TB_CONCEPTO_BALANCE_GENERAL").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function CopyDataTableBulk_Importar_Asientos(ByVal dTable As DataTable, ByVal STRNomTablaDestino As String) As Boolean
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

        Public Function Mostrar_Asientos_Importados() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_IMP_ASIENTOS_AUTO").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Guardar_Asiento_Cierre(ByVal nombre_store As String, ByVal anio As Integer, ByVal id_asiento As Integer) As Boolean
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(trVar, nombre_store, anio, id_asiento)

                trVar.Commit()
                trVar.Dispose()
                Return True
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Guardar_Importacion_Asientos() As Boolean
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(trVar, "CONTA_SP_I_IMP_ASIENTOS_AUTO")

                trVar.Commit()
                trVar.Dispose()
                Return True
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Montos_Documentos_Referencia_Compras(ByVal Tipodoc As String, ByVal Serie As String, ByVal Numero As String, ByVal Customer As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_DOC_REF_MONTOS_COMPRAS", Tipodoc, Serie, Numero, Customer).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificar_Tipo_doc_Ref(ByVal Tipodoc As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_TIPO_DOC", Tipodoc).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificacion_Existencia_Doc_Ref_Compras(ByVal Tipodoc As String, ByVal Serie As String, ByVal Numero As String, ByVal Customer As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_VERIFICACION_NOTA_CREDITO_DEBITO_COMPRAS", Tipodoc, Serie, Numero, Customer).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Sub get_PLE_Mayor(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)
            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_MAYOR_V2", ayo_, mes_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00060100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_NUM_VOUCHER") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("COD_PLAN") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_CUENTA") & "|||"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_TIPO_MONEDA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_DOC_EMISOR") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO_EMISOR") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_COMPROBANTE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SERIE_COMPROBANTE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO_COMPROBANTE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_FEC_VOUCHER") & "||"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_DOC") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_GLOSA_VOU").ToString.Replace("%", "porc").Replace("$", "dol").Replace("/", "") & "||"
                If dt_data.Rows(i)("AD_DEBE") = 0 Then
                    Strdatos = Strdatos & "0.00|"
                Else
                    Strdatos = Strdatos & dt_data.Rows(i)("AD_DEBE") & "|"
                End If
                If dt_data.Rows(i)("AD_HABER") = 0 Then
                    Strdatos = Strdatos & "0.00||"
                Else
                    Strdatos = Strdatos & dt_data.Rows(i)("AD_HABER") & "||"
                End If
                Strdatos = Strdatos & dt_data.Rows(i)("ESTADO_OPERACION") & "|"

                sw.WriteLine(Strdatos)
            Next
            sw.Close()

            dt_data = Nothing
        End Sub

        Public Sub get_PLE_Diario(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_DIARIO_V2", ayo_, mes_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00050100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)


            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_NUM_VOUCHER") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_CUENTA") & "|||"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_TIPO_MONEDA") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_DOC_EMISOR") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO_EMISOR") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_COMPROBANTE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SERIE_COMPROBANTE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO_COMPROBANTE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_FEC_VOUCHER") & "||"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_DOC") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AC_GLOSA_VOU").ToString.Replace("%", "porc").Replace("$", "dol").Replace("/", "") & "||"
                If dt_data.Rows(i)("AD_DEBE") = 0 Then
                    Strdatos = Strdatos & "0.00|"
                Else
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("AD_DEBE")), "####0.00") & "|"
                End If

                If dt_data.Rows(i)("AD_HABER") = 0 Then
                    Strdatos = Strdatos & "0.00||"
                Else
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("AD_HABER")), "####0.00") & "||"
                End If
                Strdatos = Strdatos & dt_data.Rows(i)("ESTADO_OPERACION") & "|"

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing
        End Sub

        Public Sub get_PLE_PlanCuentas(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal dia_ As Integer, ByVal Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLANCTAS_PLE", ayo_, mes_, dia_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00050300001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CUENTA") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DES_CUENTA"), 100) & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPOPLAN") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("DESPLAN") & "|||"
                Strdatos = Strdatos & dt_data.Rows(i)("ESTADO") & "|"
                sw.WriteLine(Strdatos)
            Next


            sw.Close()

            dt_data = Nothing
        End Sub

        Public Sub get_PLE_RegVentas(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_REGVEN_V2", ayo_, mes_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00140100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = dt_data.Rows(i)("PERIODO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("COU") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CORRELATIVO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_EMI") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_VEN") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SER_DOC") & "|"

                Select Case dt_data.Rows(i)("TIP_DOC")
                    Case "05" 'boleto de avion
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"

                    Case "01", "02", "03", "04", "06", "07", "08", "23", "25", "34", "35"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 7) & "|"

                    Case "00", "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "26", "27", "28", "29", "30", "31", "32", "37", "42", "43", "44", "45", "87", "88", "91", "96", "97", "98"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                    Case "11"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 15) & "|"

                    Case "36"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 8) & "|"

                    Case "56"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 4) & "|"

                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 6) & "|"

                End Select


                Strdatos = Strdatos & dt_data.Rows(i)("OPT1").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TDI_CLIENTE").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NDI_CLIENTE").ToString & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE").ToString, 60) & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("VALOR_EXPOR")), "####0.00") & "|"

                'Strdatos = Strdatos & dt_data.Rows(i)("BASE_G") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("DESC_BI") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("DESC_BI")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("IGV") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("DESCT_IGV") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("DESCT_IGV")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("OPE_EXONERADA") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OPE_EXONERADA")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("OPE_INAFECTA") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OPE_INAFECTA")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("BASE_IVAP") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_IVAP")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("IVAP") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IVAP")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_MONEDA") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("TIP_CAM") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("TIP_CAM")), "####0.000") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SER_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUM_DOC_REF").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CONTRATO").ToString & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ERROR1") & "|"

                Strdatos = Strdatos & dt_data.Rows(i)("FOB") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ESTADO") & "|"

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing

        End Sub
        Public Sub get_PLE_RegVentas_Sire(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_REGVEN_V2_SIRE", ayo_, mes_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00140400021112.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)



            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True, System.Text.Encoding.GetEncoding(1252))

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = LibComunVar.ClsVarComun.RucEmpresa & "|" '1
                Strdatos = Strdatos & dt_data.Rows(i)("RAZON_SOCIAL") & "|" '2
                Strdatos = Strdatos & dt_data.Rows(i)("PERIODO") & "||" '3 Y 4
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_EMI") & "|" '5
                Strdatos = Strdatos & dt_data.Rows(i)("FEC_VEN") & "|" '6
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC") & "|" '7
                Strdatos = Strdatos & dt_data.Rows(i)("SER_DOC") & "|" '8

                Select Case dt_data.Rows(i)("TIP_DOC")
                    Case "05" 'boleto de avion
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"

                    Case "01", "02", "03", "04", "06", "07", "08", "23", "25", "34", "35"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 7) & "|"

                    Case "00", "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "26", "27", "28", "29", "30", "31", "32", "37", "42", "43", "44", "45", "87", "88", "91", "96", "97", "98"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                    Case "11"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 15) & "|"

                    Case "36"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 8) & "|"

                    Case "56"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 4) & "|"

                    Case "50"
                        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 6) & "|" '9

                End Select


                Strdatos = Strdatos & dt_data.Rows(i)("OPT1").ToString & "|" '10
                Strdatos = Strdatos & dt_data.Rows(i)("TDI_CLIENTE").ToString & "|" '11
                Strdatos = Strdatos & dt_data.Rows(i)("NDI_CLIENTE").ToString & "|" '12
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE").ToString, 60) & "|" '13
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("VALOR_EXPOR")), "####0.00") & "|" '14

                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|" '15
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("DESC_BI")), "####0.00") & "|" '16
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV")), "####0.00") & "|" '17
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("DESCT_IGV")), "####0.00") & "|" '18
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OPE_EXONERADA")), "####0.00") & "|" '19
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OPE_INAFECTA")), "####0.00") & "|" '20
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|" '21
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_IVAP")), "####0.00") & "|" '22
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IVAP")), "####0.00") & "|" '23
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|" '24
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|" '25
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|" '26
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_MONEDA") & "|" '27
                If dt_data.Rows(i)("TIPO_MONEDA") = "PEN" Then
                    Strdatos = Strdatos & "|"
                ElseIf dt_data.Rows(i)("TIPO_MONEDA") = "USD" Then
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("TIP_CAM")), "####0.000") & "|" '28
                End If

                Strdatos = Strdatos & dt_data.Rows(i)("FEC_REF").ToString & "|" '29
                Strdatos = Strdatos & dt_data.Rows(i)("TIP_DOC_REF").ToString & "|" '30
                Strdatos = Strdatos & dt_data.Rows(i)("SER_REF").ToString & "|" '31
                Strdatos = Strdatos & dt_data.Rows(i)("NUM_DOC_REF").ToString & "|" '32
                Strdatos = Strdatos & dt_data.Rows(i)("CONTRATO").ToString & "|" '33
                Strdatos = Strdatos & dt_data.Rows(i)("ERROR1") & "|" '34

                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing

        End Sub

        Public Sub get_PLE_RegCompras(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String, _fecha_inicio As String, _fecha_fin As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim fecha_ini As String
            Dim fecha_fin As String

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If
            SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_S_REGISTRO_COMPRAS_TXT", mes_, ayo_)

            fecha_ini = _fecha_inicio
            fecha_fin = _fecha_fin
            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_REGCOM_V2", ayo_, mes_, fecha_ini, fecha_fin).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080100001111.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = Left(dt_data.Rows(i)("PERIODO"), 8) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("COU"), 40) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("CORRELATIVO"), 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_EMI"), 10) & "|"

                'If dt_data.Rows(i)("TIP_DOC").ToString = "14" Then
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_VEN"), 10) & "|"
                'Else
                '    Strdatos = Strdatos & "|"
                'End If

                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC"), 2) & "|"

                'If dt_data.Rows(i)("TIP_DOC") = "05" Then
                '    Strdatos = Strdatos & "1|"
                'Else
                Strdatos = Strdatos & dt_data.Rows(i)("SER_DOC") & "|"
                'If Left(dt_data.Rows(i)("TIP_DOC"), 2) = "50" Then
                '    Strdatos = Strdatos & Right(dt_data.Rows(i)("SER_DOC"), 3) & "|"
                'Else
                '    Strdatos = Strdatos & Right(dt_data.Rows(i)("SER_DOC"), 4) & "|"
                'End If
                'End If
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA"), 4) & "|"
                'Select Case dt_data.Rows(i)("TIP_DOC")
                '    Case "05" 'boleto de avion
                Strdatos = Strdatos & dt_data.Rows(i)("NUM_DOC") & "|"
                '    Case "01", "02", "03", "04", "06", "07", "08", "23", "25", "34", "35"
                '        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                '    Case "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "26", "27", "28", "29", "30", "31", "32", "37", "42", "43", "44", "45", "87", "88", "91", "96", "97", "98"
                '        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                '    Case "11"
                '        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                '    Case "36"
                '        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                '    Case "56"
                '        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                '    Case "50"
                '        Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 20) & "|"

                'End Select

                Strdatos = Strdatos & Left(dt_data.Rows(i)("OPT1"), 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TDI_PROVEEDOR"), 1) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NDI_CLIENTE"), 15) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE"), 100) & "|"

                If dt_data.Rows(i)("TIP_DOC") <> "07" Then
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_G")), "####0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("BASE_MIXTA") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_MIXTA")), "####0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("IGV_MIXTA") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_MIXTA")), "##,##0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("BASE_NOG") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_NOG")), "####0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("IGV_NOG") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_NOG")), "####0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("VALOR_NOGRABADAS") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")), "####0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|"
                    'Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|"
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|"
                Else
                    If Double.Parse(dt_data.Rows(i)("BASE_G")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IGV_G")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IGV_G")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IGV_G")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("BASE_MIXTA")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("BASE_MIXTA")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("BASE_MIXTA")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IGV_MIXTA")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IGV_MIXTA")), "##,##0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IGV_MIXTA")), "##,##0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("BASE_NOG")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("BASE_NOG")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("BASE_NOG")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IGV_NOG")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IGV_NOG")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IGV_NOG")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("ISC")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IMP_TOT")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|"
                    End If

                End If

                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|"

                ''Strdatos = Strdatos & dt_data.Rows(i)("IGV_G") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_G")), "####0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("BASE_MIXTA") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_MIXTA")), "####0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("IGV_MIXTA") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_MIXTA")), "##,##0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("BASE_NOG") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_NOG")), "####0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("IGV_NOG") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_NOG")), "####0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("VALOR_NOGRABADAS") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")), "####0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("ISC") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("OTROS_TRIBUTOS") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|"
                ''Strdatos = Strdatos & dt_data.Rows(i)("IMP_TOT") & "|"
                'Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CODIGO_MONEDA") & "|"
                'Strdatos = Strdatos & dt_data.Rows(i)("TIP_CAM") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("TIP_CAM")), "####0.000") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_REF").ToString, 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC_REF").ToString, 2) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("SER_REF").ToString, 4) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA2"), 4) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC_REF").ToString, 6) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_DETRA").ToString, 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_DETRA").ToString, 20) & "|"

                Strdatos = Strdatos & dt_data.Rows(i)("MARCA_RET") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CLASIFICACION") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("IDENTIFICACION") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ERROR1") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ERROR2") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ERROR3") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ERROR4") & "|"

                Strdatos = Strdatos & Left(dt_data.Rows(i)("ESTADO"), 1) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("ESTADO2"), 1) & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing

        End Sub

        Public Sub get_PLE_RegCompras_SIRE(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String, _fecha_inicio As String, _fecha_fin As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim fecha_ini As String
            Dim fecha_fin As String

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If
            SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_S_REGISTRO_COMPRAS_TXT", mes_, ayo_)

            fecha_ini = _fecha_inicio
            fecha_fin = _fecha_fin
            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_REGCOM_V2_SIRE", ayo_, mes_, fecha_ini, fecha_fin).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080400021112.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = LibComunVar.ClsVarComun.RucEmpresa & "|" '1
                Strdatos = Strdatos & dt_data.Rows(i)("RAZON_SOCIAL") & "|" '2
                Strdatos = Strdatos & dt_data.Rows(i)("PERIODO") & "||" '3 y 4
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_EMI"), 10) & "|" '5
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_VEN"), 10) & "|" '6
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC"), 2) & "|" '7
                Strdatos = Strdatos & dt_data.Rows(i)("SER_DOC") & "|" '8
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA"), 4) & "|" '9
                Strdatos = Strdatos & dt_data.Rows(i)("NUM_DOC") & "|" '10
                Strdatos = Strdatos & Left(dt_data.Rows(i)("OPT1"), 20) & "|" '11
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TDI_PROVEEDOR"), 1) & "|" '12
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NDI_CLIENTE"), 15) & "|" '13
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NOM_CLIENTE"), 100) & "|" '14

                If dt_data.Rows(i)("TIP_DOC") <> "07" Then
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|" '15
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_G")), "####0.00") & "|" '16
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_MIXTA")), "####0.00") & "|" '17
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_MIXTA")), "##,##0.00") & "|" '18
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("BASE_NOG")), "####0.00") & "|" '19
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IGV_NOG")), "####0.00") & "|" '20
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")), "####0.00") & "|" '21
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|" '22
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|" '23
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|" '24
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|" '25
                Else
                    If Double.Parse(dt_data.Rows(i)("BASE_G")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("BASE_G")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IGV_G")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IGV_G")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IGV_G")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("BASE_MIXTA")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("BASE_MIXTA")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("BASE_MIXTA")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IGV_MIXTA")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IGV_MIXTA")), "##,##0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IGV_MIXTA")), "##,##0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("BASE_NOG")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("BASE_NOG")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("BASE_NOG")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IGV_NOG")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IGV_NOG")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IGV_NOG")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("VALOR_NOGRABADAS")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("ISC")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("ISC")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IMPUESTO_BOLSAS")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("OTROS_TRIBUTOS")), "####0.00") & "|"
                    End If
                    If Double.Parse(dt_data.Rows(i)("IMP_TOT")) = 0 Then
                        Strdatos = Strdatos & "" & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|"
                    Else
                        Strdatos = Strdatos & "-" & Format(Double.Parse(dt_data.Rows(i)("IMP_TOT")), "####0.00") & "|"
                    End If

                End If

                Strdatos = Strdatos & dt_data.Rows(i)("CODIGO_MONEDA") & "|" '26
                If dt_data.Rows(i)("CODIGO_MONEDA") = "PEN" Then
                    Strdatos = Strdatos & "|"
                ElseIf dt_data.Rows(i)("CODIGO_MONEDA") = "USD" Then
                    Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("TIP_CAM")), "####0.000") & "|" '27
                End If

                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_REF").ToString, 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC_REF").ToString, 2) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("SER_REF").ToString, 4) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("DUA2"), 4) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC_REF").ToString, 8) & "||||||||||"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("NUM_DETRA").ToString, 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_DETRA").ToString, 10) & "||"
                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing

        End Sub

        Public Sub get_PLE_Comp_Retencion(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If


            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_COM_RETENCION", ayo_, mes_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\0621" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "R.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = dt_data.Rows(i)("VAT_REGISTRATION") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SERIE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_CR") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO_CR")), "####0.00") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TD_PAGO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SERIE_PAGO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO_PAGO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_PAGO") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO_PAGO")), "####0.00") & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing

        End Sub

        Public Sub get_PLE_Comp_Percepcion(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If


            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_COM_PERCEPCION", ayo_, mes_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\0621" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "P.txt"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = dt_data.Rows(i)("VAT_REGISTRATION") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SERIE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_CR") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO_CR")), "####0.00") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TD_PAGO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SERIE_PAGO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO_PAGO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_PAGO") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO_PAGO")), "####0.00") & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing

        End Sub
        Public Sub get_PLE_Prestador_Servicios_4ta(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If


            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_PRESTADOR_SERVICIOS_4TA", ayo_, mes_).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            StrNomArchivo = Str_vRutaPdt_ & "\0601" & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & ruc & ".4ta"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = dt_data.Rows(i)("TIPO_DOC") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AD_IDANEXO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_COMPROBANTE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SERIE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO")), "####0.00") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_EMISION") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("FECHA_PAGO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("INDICADOR_RETENCION") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("INDICADOR_RET_REGIMEN_PENSIONARIO") & "||"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing

        End Sub

        Public Sub get_PLE_DAOT(ayo_ As Integer, opcion As Integer, Str_vRutaPdt_ As String, tope_ As Double)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If

            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_DAOT_DET_TXT", ayo_, opcion, tope_).Tables(0)

            Dim StrNomArchivo As String = ""
            Dim Strdatos As String

            If dt_data.Rows.Count <> 0 Then
                If opcion = 1 Then 'COMPRAS
                    StrNomArchivo = Str_vRutaPdt_ & "\Costos.txt"
                ElseIf opcion = 2 Then 'VENTAS
                    StrNomArchivo = Str_vRutaPdt_ & "\Ingresos.txt"
                End If
            Else
                Exit Sub
            End If


            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1
                Strdatos = CStr(i + 1) & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("A") & "|"
                Strdatos = Strdatos & ruc & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ANIO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TYPE_COMPANY") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TIPO_DOC_DECLARADO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("NUMERO_DOC_DECLARADO") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO_TOTAL")), "####0") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AP_PATERNO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("AP_MATERNO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("PRIMER_NOMBRE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("SEGUNDO_NOMBRE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("RAZON_SOCIAL") & "|"
                sw.WriteLine(Strdatos)
            Next

            sw.Close()

            dt_data = Nothing

        End Sub

        Public Sub get_PLE_RegCompras_No_Domiciliados(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim fecha_ini As String
            Dim fecha_fin As String

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If
            SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_S_REGISTRO_COMPRAS_TXT_NO_DOMICILIADOS", mes_, ayo_)

            fecha_ini = "01/01/2015"
            fecha_fin = "01/01/2016"
            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_REGCOM_NO_DOMICILIADOS", ayo_, mes_, fecha_ini, fecha_fin).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            If dt_data.Rows.Count = 0 Then
                StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080200001011.txt"
            ElseIf dt_data.Rows.Count > 0 Then
                StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080200001111.txt"
            End If


            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = Left(dt_data.Rows(i)("PERIODO"), 8) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("COU"), 40) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("CORRELATIVO"), 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_EMI"), 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC"), 2) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("SER_DOC"), 20) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("VALOR")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OTROS_CONCEPTOS")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMP_TOTAL")), "####0.00") & "|"

                Strdatos = Strdatos & Left(dt_data.Rows(i)("DOC_DUA"), 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("SERIE_DUA"), 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("ANIO_DUA"), 20) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUMERO_DUA"), 6) & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO_RET_IGV")), "##,##0.00") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIPO_MONEDA"), 20) & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("TIPO_CAMBIO")), "####0.000") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("PAIS"), 20) & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("PROVEEDOR") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CODIGO_NO_DOMICILIADO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CODIGO_PROVEEDOR") & "|"

                Strdatos = Strdatos & dt_data.Rows(i)("UNO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("DOS") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TRES") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CUATRO") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("CINCO")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("SEIS")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("SIETE")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OCHO")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("NUEVE")), "####0.00") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("DIEZ") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("ONCE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("DOCE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("TRECE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CATORCE") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("QUINCE") & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing

        End Sub

        Public Sub get_PLE_RegCompras_No_Domiciliados_SIRE(ayo_ As Integer, mes_ As Integer, Str_vRutaPdt_ As String)

            Dim fq As New ClsOperaciones.freeQuery
            Dim dt_info_emp As DataTable = fq.get_Info_Empresa()
            Dim fecha_ini As String
            Dim fecha_fin As String

            Dim ruc As String = String.Empty
            Dim razon As String = String.Empty
            If dt_info_emp.Rows.Count > 0 Then
                ruc = dt_info_emp.Rows(0)("VAT_REGISTRATION").ToString()
                razon = dt_info_emp.Rows(0)("REPORT_SCREEN").ToString()
            End If
            SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_S_REGISTRO_COMPRAS_TXT_NO_DOMICILIADOS", mes_, ayo_)

            fecha_ini = "01/01/2015"
            fecha_fin = "01/01/2016"
            Dim dt_data As DataTable = SqlHelper.ExecuteDataset(cn, "SG_CO_SP_S_PLE_REGCOM_NO_DOMICILIADOS_SIRE", ayo_, mes_, fecha_ini, fecha_fin).Tables(0)
            Dim StrNomArchivo As String
            Dim Strdatos As String

            If dt_data.Rows.Count = 0 Then
                StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080500001012.txt"
            ElseIf dt_data.Rows.Count > 0 Then
                StrNomArchivo = Str_vRutaPdt_ & "\LE" & ruc & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & "00080500001112.txt"
            End If


            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt_, vbDirectory) = "" Then MkDir(Str_vRutaPdt_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            For i As Integer = 0 To dt_data.Rows.Count - 1

                Strdatos = Left(dt_data.Rows(i)("PERIODO"), 8) & "||"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("FEC_EMI"), 10) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIP_DOC"), 2) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("SER_DOC"), 20) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUM_DOC"), 11) & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("VALOR")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("OTROS_CONCEPTOS")), "####0.00") & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("IMP_TOTAL")), "####0.00") & "|"

                Strdatos = Strdatos & Left(dt_data.Rows(i)("DOC_DUA"), 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("SERIE_DUA"), 20) & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("ANIO_DUA"), 20) & "|"
                Strdatos = Strdatos & Right(dt_data.Rows(i)("NUMERO_DUA"), 6) & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("MONTO_RET_IGV")), "##,##0.00") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("TIPO_MONEDA"), 20) & "|"
                Strdatos = Strdatos & Format(Double.Parse(dt_data.Rows(i)("TIPO_CAMBIO")), "####0.000") & "|"
                Strdatos = Strdatos & Left(dt_data.Rows(i)("PAIS"), 20) & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("PROVEEDOR") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CODIGO_NO_DOMICILIADO") & "|"
                Strdatos = Strdatos & dt_data.Rows(i)("CODIGO_PROVEEDOR") & "|"

                Strdatos = Strdatos & "|||||||||00||00|||||||||||||"
                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            dt_data = Nothing

        End Sub
        

        Public Function GrabarDetalleAsientoCompra(ByVal _id_compra As String, ByVal _id_cab As Integer, ByVal _num_voucher As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_ASIENTOS_DETALLES_COMPRAS", _id_compra, _id_cab, _num_voucher)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function ConsultandoDocEliminacion(ByVal _codigo As Integer) As Boolean
            Dim estado As Boolean = True
            Try
                Dim Dt_documento As New DataTable
                Dim Dt_documento_detalle As DataTable
                Dim consulta As String = ""
                consulta = "SELECT CUSTOMER_ID , DOCUMENT_ID , NUMBER_DOC  FROM CUSTOMER_BALANCE_PAY WHERE NUM_REF_ASIENTO ='" & _codigo & "'"
                Dt_documento = SqlHelper.ExecuteDataset(cn, CommandType.Text, consulta).Tables(0)
                If Dt_documento.Rows().Count() <> 0 Then
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VALIDAR_CANJE_LETRAS_P", row("DOCUMENT_ID").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("DOCUMENT_ID").ToString & "-" & row("NUMBER_DOC").ToString & " se canjeo por una letra, no se puede eliminar el Voucher.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                    'Consultanto Pagos
                    Dt_documento_detalle = New DataTable
                    For Each row As DataRow In Dt_documento.Rows
                        'Consultanto letras
                        Dt_documento_detalle = SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VALIDAR_PAGO_P", row("DOCUMENT_ID").ToString, row("NUMBER_DOC").ToString, row("CUSTOMER_ID").ToString).Tables(0)
                        If Dt_documento_detalle.Rows().Count() <> 0 Then
                            MsgBox("La " & row("DOCUMENT_ID").ToString & "-" & row("NUMBER_DOC").ToString & " se realizo el pago, no se puede eliminar el Voucher.!", MsgBoxStyle.Critical)
                            estado = False
                            Exit Try
                        End If
                    Next
                End If
            Catch ex As Exception
                estado = False
                MsgBox(ex.Message)
            End Try
            Return estado
        End Function

 
        Public Function Verificacion_Compras_Varios(ByVal _codigo As Integer, ByVal voucher As String, ByVal fecha As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICA_PAGOS", _codigo, voucher, fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificacion_Compras_Varios_pagos(ByVal _codigo As Integer, ByVal voucher As String, ByVal fecha As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICA_PAGOS_CONTAB", _codigo, voucher, fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificacion_Aceptacion_Letras_Cob(ByVal _codigo As Integer, ByVal voucher As String, ByVal fecha As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICA_ACEP_LETRAS_CONTAB", _codigo, voucher, fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificacion_Aceptacion_Letras_Pagos(ByVal _codigo As Integer, ByVal voucher As String, ByVal fecha As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICA_ACEP_LETRAS_PAGOS_CONTAB", _codigo, voucher, fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificacion_Compras_Varios_Ventas(ByVal _codigo As Integer, ByVal voucher As String, ByVal fecha As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICA_VENTAS_CONTAB", _codigo, voucher, fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificacion_Compras_Varios_Canje_Letras(ByVal _codigo As Integer, ByVal voucher As String, ByVal fecha As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICA_CANJE_LETRAS_CONTAB", _codigo, voucher, fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function Verificacion_Ventas_Canje_Letras(ByVal _codigo As Integer, ByVal voucher As String, ByVal fecha As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICA_CANJE_LETRAS_COB_CONTAB", _codigo, voucher, fecha).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function Verificar_Ruc_Proveedor(ByVal _RUC As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICAR_RUC_PROVEEDOR", _RUC).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Verificar_codigo_Empleado(ByVal _RUC As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_VERIFICAR_COD_EMPLEADO", _RUC).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ReaperturandoAsiento_Varios(ByVal AC_ID As String, ByVal NUM_VOUCHER As String, ByVal FECHA As Date) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_S_ACTUALIZAR_ESTADO_REAPERTURAR", AC_ID, NUM_VOUCHER, FECHA)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function ReaperturandoAsiento(ByVal AC_ID As String, ByVal NUM_VOUCHER As String, ByVal FECHA As Date) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_U_CUSTOMER_BALANCE_PAY_ESTADO", AC_ID, NUM_VOUCHER, FECHA.ToString("dd/MM/yyyy"))
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Finalizar_Compra_Detalles(ByVal CODIGO As String, ByVal SUB_DIARIO As String, ByVal NUM_VOUCHER As String, ByVal FECHA As Date) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_COMPRA_FINALIZAR_DETALLES", CODIGO, SUB_DIARIO, NUM_VOUCHER, FECHA).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Get_Registro_Compras(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_PURCHASE_FACT_SUPPLIER_PAY", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Get_Habilitado_CBP(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_ND_SAVE_CBP", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Guardar_Finalizar_Compras(ByVal Lista_Detalles As List(Of ClsEntidades.CUSTOMER_BALANCE_PAY))
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                Dim _contador As Integer = 0
                For Each detalles As ClsEntidades.CUSTOMER_BALANCE_PAY In Lista_Detalles
                    With detalles
                        If _contador = 0 Then SqlHelper.ExecuteNonQuery(trVar, "CONTA_SP_D_CUSTOMER_BALANCE_PAY", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, .DOCUMENT_REF, .NUMBER_REF)

                        SqlHelper.ExecuteNonQuery(trVar, "CONTA_SP_I_CUSTOMER_BALANCE_PAY", .CUSTOMER_ID, .DOCUMENT_ID, .NUMBER_DOC, IIf(.DOC_DATE = "", DBNull.Value, .DOC_DATE), IIf(.CADUCATE_DATE = "", DBNull.Value, .CADUCATE_DATE) _
                                                  , .DOCUMENT_REF, .NUMBER_REF, .SALES_ID, .AMOUNT, .AMOUNT_BALANCE, .CURRENCY_ID, .SELL_RATE, .IS_DR_CR, .STATUS, .CREATE_DATE, .LAST_MODIFIED, _
                                                  .USER_ID, .ACCOUNT, .AMOUNT_COMM, .TYPE_REC, .REFERENCE_DATE, .IS_CHECK_DIF, .AMOUNT_BALANCE_INI, .TERMS, .PLACE_SALES, .BANK_ID, _
                                                  .BANK_DESCRIPTION, .AMOUNT_PER, .PERCENT_PER, .ACCOUNT_PER, .SERIE_AUX, .NUM_DOC_AUX, .AMOUNT_DETRAC, .PERCENT_DETRAC, .SALDO, .NUM_REF_ASIENTO, .VOUCHER_REF_ASIENTO, .FECHA_REF_ASIENTO)
                        _contador += 1
                    End With
                Next
                trVar.Commit()
                trVar.Dispose()
                Return True
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try


        End Function

        Public Function Guardar_Finalizar_Compras_Varios(ByVal AC_ID As String, ByVal AC_IDSUBDIARIO As String, ByVal NUM_VOUCHER As String,
                                                         ByVal DEBE As Double, ByVal HABER As Double)
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_S_ACTUALIZAR_ESTADO", AC_ID, AC_IDSUBDIARIO, NUM_VOUCHER, DEBE, HABER)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        'Contabilidad
        Public Function ValidarCodigo(ByVal SUB_DIARIO As String, ByVal CODIGO As String, ByVal ANIO As String, ByVal MES As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_VALIDAR_C", SUB_DIARIO, CODIGO, ANIO, MES).Tables(0)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ValidarCodigo_Canje_Letras_Cobros(ByVal SUB_DIARIO As String, ByVal CODIGO As String, ByVal ANIO As String, ByVal MES As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_VALIDAR_C", SUB_DIARIO, CODIGO, ANIO, MES).Tables(0)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ValidarCodigo_Canje_Letras_Pagos(ByVal SUB_DIARIO As String, ByVal CODIGO As String, ByVal ANIO As String, ByVal MES As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_VALIDAR_C", SUB_DIARIO, CODIGO, ANIO, MES).Tables(0)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ValidarCodigo_Cobranzas(ByVal SUB_DIARIO As String, ByVal CODIGO As String, ByVal ANIO As String, ByVal MES As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_VALIDAR_C", SUB_DIARIO, CODIGO, ANIO, MES).Tables(0)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ValidarCuentaContable_EstadoLetraPago(ByVal _codigo As String, ByVal _moneda As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_STATUS_LETTER_PAY", _codigo, _moneda).Tables(0)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Validar_Existe_CuentaContable(ByVal _codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_EXISTE_CUENTA", _codigo).Tables(0)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End Function
        Public Function ValidarCuentaContable_EstadoLetra(ByVal _codigo As String, ByVal _moneda As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "COMPRAS_SP_S_STATUS_LETTER", _codigo, _moneda).Tables(0)
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End Function

        Public Function UpdateComprasVarios(ByVal AC_ID As String, ByVal AC_IDSUBDIARIO As String, ByVal NUM_VOUCHER As String, ByVal AC_DEBE As Double, ByVal AC_HABER As Double) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_COMPRAS_VARIOS_ACTUALIZAR", AC_ID, AC_IDSUBDIARIO, NUM_VOUCHER, AC_DEBE, AC_HABER)
                Return True
            Catch ex As Exception
                Return False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function UpdateCompras(ByVal AC_ID As String, ByVal AC_IDSUBDIARIO As String, ByVal NUM_VOUCHER As String, ByVal AC_DEBE As Double, ByVal AC_HABER As Double) As Boolean
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_COMPRAS_ACTUALIZAR", AC_ID, AC_IDSUBDIARIO, NUM_VOUCHER, AC_DEBE, AC_HABER)
                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_COMPRAS_DESTINOS_ACTUALIZAR", AC_ID, AC_IDSUBDIARIO, NUM_VOUCHER)
                trVar.Commit()
                trVar.Dispose()
                Return True
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Secuencia(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CX_SP_S_ASIENTO_CONTABLE_ITEM", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Eliminar_Asiento_Compras_Varios(ByVal _Codigo As Integer, ByVal _Secuencia As Integer) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CX_SP_D_ASIENTO_CONTABLE", _Codigo, _Secuencia)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Get_ManualTercero(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CUENTA_C_TERCERO_M", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function





        Public Function Get_ManualDestino(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_TIPO_DESTINO_MANUAL", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function Get_ManualTipoDocumento(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CUENTA_C_TIPODOC_M", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function Get_ManualCuentaContable(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CUENTA_CONTABLE_M", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function Get_ManualBanco(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_BANCOS_M", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function Get_ManualCuentaContableII(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CUENTA_CONTABLE_M_II", _Codigo).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ManualCentroCosto(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CENTER_COST_MANUAL", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function Get_ManualTercero(ByVal _Codigo As String, ByVal _Tipo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_ANNEXED_CODIGO_M", _Codigo, _Tipo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function





        'centro de Costo

        Public Function EliminarCentroCosto(ByVal Entidad As ClsEntidades.CENTER_COST) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_D_CENTER_COST", Entidad.COST_CENTER_ID)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function CentrosCostos() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CENTER_COST").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function EdicionCentrosCostos(ByVal CODIGO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CENTER_COST_EDICION", CODIGO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function


        Public Function GuardarCentroCosto(ByVal Entidad As ClsEntidades.CENTER_COST) As Boolean
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_I_CENTRO_COSTO", .COST_CENTER_ID, .COST_CENTER_DESCRIPTION, .CREATE_DATE, .IS_STATUS, .USER_ID, .LAST_MODIFY_DATE, .COMPUTER_ID, .USER_MODIFIED, .NODE_ID, .NODE_KEY, .LEVEL_CCOST, .TYPE_MOV, .DESTINO_DEBE, .DESTINO_HABER)
                End With

                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function ModificarCentroCosto(ByVal Entidad As ClsEntidades.CENTER_COST) As Boolean
            Try
                With Entidad
                    SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_U_CENTRO_COSTO", .COST_CENTER_ID, .COST_CENTER_DESCRIPTION, .CREATE_DATE, .IS_STATUS, .USER_ID, .LAST_MODIFY_DATE, .COMPUTER_ID, .USER_MODIFIED, .NODE_ID, .NODE_KEY, .LEVEL_CCOST, .TYPE_MOV, .DESTINO_DEBE, .DESTINO_HABER)
                End With

                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function EliminarConceptoCompraDetalles(ByVal Entidad As ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_D_ONCEPTOS_DETALLE", Entidad.CO_CONCEPTO, Entidad.CO_ITEM)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function EliminarConceptoCompra(ByVal Entidad As ClsEntidades.CO_COMPRAS_CONCEPTOS_CABECERA) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_D_ONCEPTOS_CABECERA", Entidad.CO_CONCEPTO)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function GuardarConceptoCompra(ByVal Entidad As ClsEntidades.CO_COMPRAS_CONCEPTOS_CABECERA) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_I_ONCEPTOS_CABECERA", Entidad.CO_CONCEPTO, Entidad.CO_DESCRIPCION, Entidad.CREATE_DATE, Entidad.CREATE_USER)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function GuardarConceptoCompraDetalle(ByVal lista As List(Of ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE)) As Boolean
            Try
                For i As Integer = 0 To lista.Count() - 1
                    SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_I_ONCEPTOS_DETALLE", lista(i).CO_CONCEPTO, lista(i).CO_ITEM, lista(i).CO_CUENTA, lista(i).CO_DESCRIPCION)
                Next
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function ModificarConceptoCompraDetalle(ByVal Entidad As ClsEntidades.CO_COMPRAS_CONCEPTOS_DETALLE) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_U_ONCEPTOS_DETALLE", Entidad.CO_CONCEPTO, Entidad.CO_ITEM, Entidad.CO_CUENTA, Entidad.CO_DESCRIPCION)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function ModificarConceptoCompra(ByVal Entidad As ClsEntidades.CO_COMPRAS_CONCEPTOS_CABECERA) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CONTA_SP_U_ONCEPTOS_CABECERA", Entidad.CO_CONCEPTO, Entidad.CO_DESCRIPCION, Entidad.CREATE_DATE, Entidad.CREATE_USER)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function ConceptosComprasDetalles(ByVal _Codigo As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_CO_CONCEPTOS_DETALLE", _Codigo).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function



        Public Function ConceptosCompras() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_COMPRAS_CONCEPTOS_CABECERA").Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function



        Public Function DetalleCuentaContable(ByVal NumCuenta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_DETALLE_CUENTA_CONTABLE", NumCuenta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Function Detalle_Cen_Cos(ByVal NumCuenta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CONTA_SP_S_DETALLE_CENCOS", NumCuenta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function



        Public Function MuestraDescripcion(ByVal Consulta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Muestra_Opcion_TC(ByVal Consulta As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, CommandType.Text, Consulta).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function get_Lista_Asientos(sub_ As String, ayo_ As Integer, mes_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_GET_ASIENTOS", sub_, ayo_, mes_).Tables(0)
        End Function

        Public Function get_Lista_Retenciones_Importacion() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_GET_LISTA_RETENCIONES_IMPORTACION").Tables(0)
        End Function

        Public Function get_Lista_Asientos_Edit(id_ As Integer, sub_ As String, ayo_ As Integer, mes_ As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_GET_ASIENTOS_EDIT", id_, sub_, ayo_, mes_)
        End Function

        Public Function get_Lista_Asientos_Detalles_Edit(id_ As Integer, ayo_ As Integer, mes_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_GET_ASIENTOS_DETALLES_EDIT_I", id_, ayo_, mes_).Tables(0)
        End Function

        Public Function Delete(id_ As Integer, sub_ As String, ayo_ As Integer, mes_ As Integer) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_D_ASIENTO_CAB", id_, sub_, ayo_, mes_)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Anular(id_ As Integer, sub_ As String, ayo_ As Integer, mes_ As Integer) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_A_ASIENTO_CAB", id_, sub_, ayo_, mes_)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Existe_Num_Voucher(numero_ As String, subd_ As String, ayo_ As Integer, mes_ As Integer) As Boolean
            Dim rpta As Boolean = False
            Dim dato As Integer = SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXISTE_NUM_VOU", numero_, subd_, ayo_, mes_)
            If dato > 0 Then rpta = Not rpta
            Return rpta
        End Function

        Public Function get_Doc_Pendientes(ByVal cuenta_ As String, ByVal anexo_ As String, ByVal ayo_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_DOC_PENDIENTE", cuenta_, anexo_, ayo_).Tables(0)
        End Function

        Public Sub Contabilizar_Ventas(ayo_ As Integer, mes_ As Integer, fec_vou_ As String)

            Dim cta40igv As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_IGV FROM CO_TB_PARAMETROS").ToString()
            Dim cta40isc As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_ISC FROM CO_TB_PARAMETROS").ToString()

            If cta40igv = "" Then
                Throw New SyntaxErrorException("No esta configurado la cuenta del IGV")
            End If

            If cta40isc = "" Then
                Throw New SyntaxErrorException("No esta configurado la cuenta del ISC")
            End If

            Dim dt_cab As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_COMPROBA_VENTAS", ayo_, mes_).Tables(0)

            For i As Integer = 0 To dt_cab.Rows.Count - 1
                Dim ruc As String = dt_cab.Rows(i)("VAT_REGISTRATION").ToString()
                Dim td As String = dt_cab.Rows(i)("DOCUMENT_ID").ToString()
                Dim sd As String = dt_cab.Rows(i)("NUMBER_SERIE").ToString()
                Dim nd As String = dt_cab.Rows(i)("NUMBER_DOCUMENT").ToString()
                Dim fd As String = dt_cab.Rows(i)("DOCUMENT_DATE").ToString()
                Dim vd As String = dt_cab.Rows(i)("CADUCATE_DATE").ToString()
                Dim cta12_Sol As String = dt_cab.Rows(i)("CTA12_SOLES").ToString()
                Dim cta12_Dol As String = dt_cab.Rows(i)("CTA12_DOLAR").ToString()
                Dim mon As Integer = dt_cab.Rows(i)("CURRENCY_ID")
                Dim igv As Double = dt_cab.Rows(i)("AMOUNT_TAX")
                Dim total As Double = dt_cab.Rows(i)("AMOUNT")
                Dim anulado As Boolean = IIf(dt_cab.Rows(i)("STATUS") = "A", True, False)
                'Dim tc As Double = dt_cab.Rows(i)("SELL_RATE")
                Dim tc As Double = ClsVarComun.TCVenta
                Dim monto_isc As Double = dt_cab.Rows(i)("ISC")


                'el proce 'CO_SP_S_EXIS_COMPROBA_VENTAS' funciona para ventas y compras
                If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_COMPROBA_VENTAS", td, sd, nd, ruc) = 0 Then
                    Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
                    Dim detalle As ClsEntidades.CO_TB_ASIENTO_DET
                    Dim ls_det As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)

                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "02"
                        .AC_NUM_VOUCHER = get_Ult_num_voucher("02", ayo_, mes_)
                        .AC_ANHO = ayo_
                        .AC_MES = mes_
                        .AC_FEC_VOUCHER = fec_vou_
                        .AC_IDMONEDA = mon
                        .AC_DEBE = IIf(anulado, 0, total)
                        .AC_HABER = IIf(anulado, 0, total)
                        .AC_ESTADO = IIf(anulado, 0, 1)
                        .AC_GLOSA_VOU = dt_cab.Rows(i)("CUSTOMER_NAME").ToString
                        .AC_ES_INTERFACE = 1
                    End With

                    '//Detalle , cuenta 70, for por cada articulo del detalle y su cuenta 70 de la misma tabla de articulos.

                    Dim monto70 As Double = 0
                    Dim monto70_Ori As Double = 0
                    Dim total70 As Double = 0
                    Dim cant As Double = 0
                    Dim precio As Double = 0

                    Dim drrr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CO_SP_S_DETALLE_COMPRO", td, sd, nd)

                    If drrr.HasRows Then

                        While drrr.Read()
                            cant = Double.Parse(drrr("QTY").ToString())
                            precio = Double.Parse(drrr("PRICE_ORI").ToString())

                            'monto70 = Math.Round(IIf(mon = 1, cant * precio, (cant * precio) * tc), 2)
                            monto70 = Math.Round(IIf(mon = 1, cant * precio, (cant * precio)), 2)
                            monto70_Ori = Math.Round(cant * precio, 2)
                            total70 = total70 + monto70
                            detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                            detalle.AD_IDCAB = 0
                            detalle.AD_SECUENCIA = ls_det.Count + 1
                            detalle.AD_CUENTA = drrr("ACCOUNT_INTERNAL_ID")
                            detalle.AD_TANEXO = 0
                            detalle.AD_IDANEXO = ""
                            detalle.AD_TDOC = ""
                            detalle.AD_SDOC = ""
                            detalle.AD_NDOC = ""
                            detalle.AD_FDOC = ""
                            detalle.AD_VDOC = ""

                            If td = "NC" Then
                                detalle.AD_DEBE = Math.Abs(IIf(anulado, 0, monto70))
                                detalle.AD_HABER = 0
                            Else
                                detalle.AD_DEBE = 0
                                detalle.AD_HABER = Math.Abs(IIf(anulado, 0, monto70))
                            End If


                            detalle.AD_TCAM = tc
                            detalle.AD_SEC_ORI_DES = 0
                            detalle.AD_IDCC = ""
                            detalle.AD_ES_DESTINO = 0
                            detalle.AD_IDMEDIOPAGO = ""
                            detalle.AD_MONTO_ORI = IIf(anulado, 0, IIf(mon = 1, detalle.AD_HABER, monto70_Ori))
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
                            detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                            ls_det.Add(detalle)

                        End While
                    End If 'has row

                    drrr.Close()

                    Dim diferencia As Double = 0


                    If Not anulado Then

                        If (total70 + igv) <> total Then
                            diferencia = Math.Abs((total70 + igv) - total)
                            diferencia = Math.Round(diferencia, 2)
                        End If

                        If diferencia <> 0 Then

                            If total > (total70 + igv) Then
                                monto70 = monto70 + diferencia
                            Else
                                monto70 = monto70 - diferencia
                            End If

                            If td = "NC" Then
                                ls_det(ls_det.Count - 1).AD_DEBE = Math.Abs(IIf(anulado, 0, monto70))
                                ls_det(ls_det.Count - 1).AD_HABER = 0
                            Else
                                If td <> "CP" Then
                                    ls_det(ls_det.Count - 1).AD_DEBE = 0
                                    ls_det(ls_det.Count - 1).AD_HABER = Math.Abs(IIf(anulado, 0, monto70))
                                End If

                            End If

                        End If
                    End If
                    '//cuenta del IGV

                    If igv > 0 Then

                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = cta40igv
                        detalle.AD_TANEXO = 0
                        detalle.AD_IDANEXO = ""
                        detalle.AD_TDOC = ""
                        detalle.AD_SDOC = ""
                        detalle.AD_NDOC = ""
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""

                        If td = "NC" Then
                            'detalle.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, igv, igv * tc), 2))
                            detalle.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, igv, igv), 2))
                            detalle.AD_HABER = 0
                        Else
                            detalle.AD_DEBE = 0
                            ' detalle.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, igv, igv * tc), 2))
                            detalle.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, igv, igv), 2))
                        End If

                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, detalle.AD_HABER, igv), 2)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)

                    End If

                    '//cuenta del ISC 40
                    If monto_isc > 0 Then

                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = cta40isc
                        detalle.AD_TANEXO = 0
                        detalle.AD_IDANEXO = ""
                        detalle.AD_TDOC = ""
                        detalle.AD_SDOC = ""
                        detalle.AD_NDOC = ""
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""

                        If td = "NC" Then
                            detalle.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, monto_isc, monto_isc * tc), 2))
                            detalle.AD_HABER = 0
                        Else
                            detalle.AD_DEBE = 0
                            detalle.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, monto_isc, monto_isc * tc), 2))
                        End If

                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, detalle.AD_HABER, igv), 2)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)

                    End If


                    ' //cuenta del cliente 12
                    detalle = New ClsEntidades.CO_TB_ASIENTO_DET

                    detalle.AD_IDCAB = 0
                    detalle.AD_SECUENCIA = ls_det.Count + 1
                    detalle.AD_CUENTA = IIf(mon = 1, cta12_Sol, cta12_Dol)
                    detalle.AD_TANEXO = 1
                    detalle.AD_IDANEXO = ruc
                    detalle.AD_TDOC = td
                    detalle.AD_SDOC = sd
                    detalle.AD_NDOC = nd.PadLeft(10, Char.Parse("0"))
                    detalle.AD_FDOC = fd
                    detalle.AD_VDOC = vd

                    If td = "NC" Then
                        detalle.AD_DEBE = 0
                        'detalle.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, total, total * tc), 2))
                        detalle.AD_HABER = Math.Abs(Math.Round(IIf(mon = 1, total, total), 2))
                    Else
                        'detalle.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, total, total * tc), 2))
                        detalle.AD_DEBE = Math.Abs(Math.Round(IIf(mon = 1, total, total), 2))
                        detalle.AD_HABER = 0
                    End If

                    detalle.AD_TCAM = tc
                    detalle.AD_SEC_ORI_DES = 0
                    detalle.AD_IDCC = ""
                    detalle.AD_ES_DESTINO = 0
                    detalle.AD_IDMEDIOPAGO = ""
                    detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, detalle.AD_DEBE, total), 2)
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
                    detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                    ls_det.Add(detalle)
                    Call Insert(cab, ls_det, False)
                End If
            Next
        End Sub

        Public Sub Contabilizar_Compras(ayo_ As Integer, mes_ As Integer, fec_vou_ As String)
            Dim cta40igv As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_IGV FROM CO_TB_PARAMETROS").ToString()
            If cta40igv = "" Then
                Throw New SyntaxErrorException("No esta configurado la cuenta del IGV en los parametros")
            End If

            Dim dt_cab As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_COMPROBA_COMPRAS", ayo_, mes_).Tables(0)

            For i As Integer = 0 To dt_cab.Rows.Count - 1
                Dim ruc As String = dt_cab.Rows(i)("VENDOR_ID").ToString()
                Dim td As String = dt_cab.Rows(i)("REFER_DOCUMENT_TYPE").ToString()
                Dim sd As String = dt_cab.Rows(i)("SERIE").ToString()
                Dim nd As String = dt_cab.Rows(i)("REFER_DOCUMENT_NUMBER").ToString()
                Dim fd As String = dt_cab.Rows(i)("DOCUMENT_DATE").ToString()
                Dim vd As String = dt_cab.Rows(i)("EXPIRATION_DATE").ToString()
                Dim cta42_Sol As String = dt_cab.Rows(i)("CTA42_SOLES").ToString()
                Dim cta42_Dol As String = dt_cab.Rows(i)("CTA42_DOLAR").ToString()
                Dim ID_cab As String = dt_cab.Rows(i)("ID").ToString()
                Dim periodo As Integer = DateTime.Parse(fd).Year

                Dim mon As Integer = dt_cab.Rows(i)("CURRENCY_TYPE")
                Dim subtot As Double = dt_cab.Rows(i)("AMOUNT")
                Dim igv As Double = dt_cab.Rows(i)("AMOUNT_TAX")
                Dim total As Double = dt_cab.Rows(i)("AMOUNT_SALES")
                Dim tc As Double = dt_cab.Rows(i)("SELL_RATE")

                'el proce 'CO_SP_S_EXIS_COMPROBA_VENTAS' funciona para ventas y compras
                If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_COMPROBA_VENTAS", td, sd, nd, ruc) = 0 Then
                    Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
                    Dim detalle As ClsEntidades.CO_TB_ASIENTO_DET
                    Dim ls_det As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)

                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "01"
                        .AC_NUM_VOUCHER = get_Ult_num_voucher("01", ayo_, mes_)
                        .AC_ANHO = ayo_
                        .AC_MES = mes_
                        .AC_FEC_VOUCHER = fec_vou_
                        .AC_IDMONEDA = mon
                        .AC_DEBE = total
                        .AC_HABER = total
                        .AC_ESTADO = 1
                        .AC_GLOSA_VOU = dt_cab.Rows(i)("NAME_FACT")
                        .AC_ES_INTERFACE = 1
                    End With

                    '//Detalle de la cuenta 60

                    Dim monto60 As Double = 0
                    Dim monto60_Ori As Double = 0

                    Dim drrr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CO_SP_S_DETALLE_COMPRAS", ID_cab, periodo)

                    If drrr.HasRows Then

                        While drrr.Read()
                            monto60 = Math.Round(IIf(mon = 1, drrr("AMOUNT_TOTAL"), drrr("AMOUNT_TOTAL") * tc))
                            monto60_Ori = Math.Round(drrr("AMOUNT_TOTAL"))

                            detalle = New ClsEntidades.CO_TB_ASIENTO_DET

                            detalle.AD_IDCAB = 0
                            detalle.AD_SECUENCIA = ls_det.Count + 1
                            detalle.AD_CUENTA = drrr("CUENTA60")
                            detalle.AD_TANEXO = 0
                            detalle.AD_IDANEXO = ""
                            detalle.AD_TDOC = ""
                            detalle.AD_SDOC = ""
                            detalle.AD_NDOC = ""
                            detalle.AD_FDOC = ""
                            detalle.AD_VDOC = ""
                            detalle.AD_DEBE = monto60
                            detalle.AD_HABER = 0
                            detalle.AD_TCAM = tc
                            detalle.AD_SEC_ORI_DES = 0
                            detalle.AD_IDCC = drrr("CCOST_ID")
                            detalle.AD_ES_DESTINO = 0
                            detalle.AD_IDMEDIOPAGO = ""
                            detalle.AD_MONTO_ORI = IIf(mon = 1, detalle.AD_DEBE, monto60_Ori)
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
                            detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                            ls_det.Add(detalle)

                            '//Buscamos si tiene cuentas destinos

                            If drrr("PC_DES_D").ToString() <> "" Or drrr("PC_DES_H").ToString() Then

                                Dim monto_destino As Double = detalle.AD_DEBE
                                Dim ori As Double = detalle.AD_MONTO_ORI
                                Dim sec_ori_des As Integer = detalle.AD_SECUENCIA


                                '//Destino Debe
                                detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                                detalle.AD_IDCAB = 0
                                detalle.AD_SECUENCIA = ls_det.Count + 1
                                detalle.AD_CUENTA = drrr("PC_DES_D").ToString()
                                detalle.AD_TANEXO = 0
                                detalle.AD_IDANEXO = ""
                                detalle.AD_TDOC = ""
                                detalle.AD_SDOC = ""
                                detalle.AD_NDOC = ""
                                detalle.AD_FDOC = ""
                                detalle.AD_VDOC = ""
                                detalle.AD_DEBE = monto_destino
                                detalle.AD_HABER = 0
                                detalle.AD_TCAM = tc
                                detalle.AD_SEC_ORI_DES = 0
                                detalle.AD_IDCC = ""
                                detalle.AD_ES_DESTINO = 1
                                detalle.AD_IDMEDIOPAGO = ""
                                detalle.AD_MONTO_ORI = ori
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
                                detalle.AD_GLOSA = "DESTINO"
                                ls_det.Add(detalle)

                                '//Destino Haber
                                detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                                detalle.AD_IDCAB = 0
                                detalle.AD_SECUENCIA = ls_det.Count + 1
                                detalle.AD_CUENTA = drrr("PC_DES_H").ToString()
                                detalle.AD_TANEXO = 0
                                detalle.AD_IDANEXO = ""
                                detalle.AD_TDOC = ""
                                detalle.AD_SDOC = ""
                                detalle.AD_NDOC = ""
                                detalle.AD_FDOC = ""
                                detalle.AD_VDOC = ""
                                detalle.AD_DEBE = 0
                                detalle.AD_HABER = monto_destino
                                detalle.AD_TCAM = tc
                                detalle.AD_SEC_ORI_DES = 0
                                detalle.AD_IDCC = ""
                                detalle.AD_ES_DESTINO = 1
                                detalle.AD_IDMEDIOPAGO = ""
                                detalle.AD_MONTO_ORI = ori
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
                                detalle.AD_GLOSA = "DESTINO"
                                ls_det.Add(detalle)

                            End If '//Si tiene Destinos

                        End While
                    End If 'has row

                    drrr.Close()


                    '//cuenta del IGV

                    If igv > 0 Then

                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = cta40igv
                        detalle.AD_TANEXO = 0
                        detalle.AD_IDANEXO = ""
                        detalle.AD_TDOC = ""
                        detalle.AD_SDOC = ""
                        detalle.AD_NDOC = ""
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""
                        detalle.AD_DEBE = Math.Round(IIf(mon = 1, igv, igv * tc), 2)
                        detalle.AD_HABER = 0
                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, detalle.AD_DEBE, igv), 2)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)

                    End If

                    ' //cuenta del PROVEEDOR 42
                    detalle = New ClsEntidades.CO_TB_ASIENTO_DET

                    detalle.AD_IDCAB = 0
                    detalle.AD_SECUENCIA = ls_det.Count + 1
                    detalle.AD_CUENTA = IIf(mon = 1, cta42_Sol, cta42_Dol)
                    detalle.AD_TANEXO = 2
                    detalle.AD_IDANEXO = ruc
                    detalle.AD_TDOC = td
                    detalle.AD_SDOC = sd
                    detalle.AD_NDOC = nd
                    detalle.AD_FDOC = fd
                    detalle.AD_VDOC = vd
                    detalle.AD_DEBE = 0
                    detalle.AD_HABER = Math.Round(IIf(mon = 1, total, total * tc), 2)
                    detalle.AD_TCAM = tc
                    detalle.AD_SEC_ORI_DES = 0
                    detalle.AD_IDCC = ""
                    detalle.AD_ES_DESTINO = 0
                    detalle.AD_IDMEDIOPAGO = ""
                    detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, detalle.AD_HABER, total), 2)
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
                    detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                    ls_det.Add(detalle)
                    Call Insert(cab, ls_det, False)
                End If
            Next

        End Sub

        Public Sub Contabilizar_Honorarios(ayo_ As Integer, mes_ As Integer, fec_vou_ As String)

            Dim cta40igv As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_RETEN_RH FROM CO_TB_PARAMETROS").ToString()
            Dim cta60BaseRH As String = SqlHelper.ExecuteScalar(cn, CommandType.Text, "SELECT CTA_BASE_HONO FROM CO_TB_PARAMETROS").ToString()

            If cta40igv = "" Then
                Throw New SyntaxErrorException("No esta configurado la cuenta de retencion RH en los parametros")
            End If
            If cta60BaseRH = "" Then
                Throw New SyntaxErrorException("No esta configurado la cuenta de Base  RH en los parametros")
            End If

            Dim dt_cab As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_RECI_HONO", ayo_, mes_).Tables(0)


            For i As Integer = 0 To dt_cab.Rows.Count - 1


                Dim ruc As String = dt_cab.Rows(i)("VENDOR_ID").ToString()
                Dim td As String = dt_cab.Rows(i)("REFER_DOCUMENT_TYPE").ToString()
                Dim sd As String = dt_cab.Rows(i)("SERIE").ToString()
                Dim nd As String = dt_cab.Rows(i)("REFER_DOCUMENT_NUMBER").ToString()
                Dim fd As String = dt_cab.Rows(i)("DOCUMENT_DATE").ToString()
                Dim vd As String = dt_cab.Rows(i)("EXPIRATION_DATE").ToString()
                Dim cta424_Sol As String = dt_cab.Rows(i)("CTA424_SOLES").ToString()
                Dim cta424_Dol As String = dt_cab.Rows(i)("CTA424_DOLAR").ToString()
                Dim ID_cab As String = dt_cab.Rows(i)("ID").ToString()
                Dim periodo As Integer = DateTime.Parse(fd).Year

                Dim mon As Integer = dt_cab.Rows(i)("CURRENCY_TYPE")
                Dim subtot As Double = dt_cab.Rows(i)("AMOUNT")
                Dim igv_Retencion4ta As Double = dt_cab.Rows(i)("AMOUNT_TAX")
                Dim total As Double = dt_cab.Rows(i)("AMOUNT_SALES")
                Dim tc As Double = dt_cab.Rows(i)("SELL_RATE")

                ' //el proce 'CO_SP_S_EXIS_COMPROBA_VENTAS' funciona para ventas y compras
                If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_COMPROBA_VENTAS", td, sd, nd, ruc) = 0 Then
                    Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
                    Dim detalle As ClsEntidades.CO_TB_ASIENTO_DET
                    Dim ls_det As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)

                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "05"
                        .AC_NUM_VOUCHER = get_Ult_num_voucher("05", ayo_, mes_)
                        .AC_ANHO = ayo_
                        .AC_MES = mes_
                        .AC_FEC_VOUCHER = fec_vou_
                        .AC_IDMONEDA = mon
                        .AC_DEBE = total
                        .AC_HABER = total
                        .AC_ESTADO = 1
                        .AC_GLOSA_VOU = dt_cab.Rows(i)("NAME_FACT")
                        .AC_ES_INTERFACE = 1
                    End With

                    '//Detalle de la cuenta 60

                    Dim monto60 As Double = 0
                    Dim monto60_Ori As Double = 0

                    Dim drrr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CO_SP_S_DETALLE_COMPRAS", ID_cab, periodo)

                    If drrr.HasRows Then

                        While drrr.Read()

                            monto60 = Math.Round(IIf(mon = 1, drrr("AMOUNT_TOTAL"), drrr("AMOUNT_TOTAL") * tc))
                            monto60_Ori = Math.Round(drrr("AMOUNT_TOTAL"))

                            detalle = New ClsEntidades.CO_TB_ASIENTO_DET

                            detalle.AD_IDCAB = 0
                            detalle.AD_SECUENCIA = ls_det.Count + 1
                            detalle.AD_CUENTA = cta60BaseRH
                            detalle.AD_TANEXO = 0
                            detalle.AD_IDANEXO = ""
                            detalle.AD_TDOC = ""
                            detalle.AD_SDOC = ""
                            detalle.AD_NDOC = ""
                            detalle.AD_FDOC = ""
                            detalle.AD_VDOC = ""
                            detalle.AD_DEBE = monto60
                            detalle.AD_HABER = 0
                            detalle.AD_TCAM = tc
                            detalle.AD_SEC_ORI_DES = 0
                            detalle.AD_IDCC = drrr("CCOST_ID")
                            detalle.AD_ES_DESTINO = 0
                            detalle.AD_IDMEDIOPAGO = ""
                            detalle.AD_MONTO_ORI = IIf(mon = 1, detalle.AD_DEBE, monto60_Ori)
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
                            detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                            ls_det.Add(detalle)

                            ' //Buscamos si tiene cuentas destinos


                            If drrr("PC_DES_D").ToString() <> "" Or drrr("PC_DES_H").ToString() Then

                                Dim monto_destino As Double = detalle.AD_DEBE
                                Dim ori As Double = detalle.AD_MONTO_ORI
                                Dim sec_ori_des As Integer = detalle.AD_SECUENCIA


                                '//Destino Debe
                                detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                                detalle.AD_IDCAB = 0
                                detalle.AD_SECUENCIA = ls_det.Count + 1
                                detalle.AD_CUENTA = drrr("PC_DES_D").ToString()
                                detalle.AD_TANEXO = 0
                                detalle.AD_IDANEXO = ""
                                detalle.AD_TDOC = ""
                                detalle.AD_SDOC = ""
                                detalle.AD_NDOC = ""
                                detalle.AD_FDOC = ""
                                detalle.AD_VDOC = ""
                                detalle.AD_DEBE = monto_destino
                                detalle.AD_HABER = 0
                                detalle.AD_TCAM = tc
                                detalle.AD_SEC_ORI_DES = 0
                                detalle.AD_IDCC = ""
                                detalle.AD_ES_DESTINO = 1
                                detalle.AD_IDMEDIOPAGO = ""
                                detalle.AD_MONTO_ORI = ori
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
                                detalle.AD_GLOSA = "DESTINO"
                                ls_det.Add(detalle)

                                '//Destino Haber
                                detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                                detalle.AD_IDCAB = 0
                                detalle.AD_SECUENCIA = ls_det.Count + 1
                                detalle.AD_CUENTA = drrr("PC_DES_H").ToString()
                                detalle.AD_TANEXO = 0
                                detalle.AD_IDANEXO = ""
                                detalle.AD_TDOC = ""
                                detalle.AD_SDOC = ""
                                detalle.AD_NDOC = ""
                                detalle.AD_FDOC = ""
                                detalle.AD_VDOC = ""
                                detalle.AD_DEBE = 0
                                detalle.AD_HABER = monto_destino
                                detalle.AD_TCAM = tc
                                detalle.AD_SEC_ORI_DES = 0
                                detalle.AD_IDCC = ""
                                detalle.AD_ES_DESTINO = 1
                                detalle.AD_IDMEDIOPAGO = ""
                                detalle.AD_MONTO_ORI = ori
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
                                detalle.AD_GLOSA = "DESTINO"
                                ls_det.Add(detalle)

                            End If '//Si tiene Destinos



                        End While

                    End If '//HasRows

                    drrr.Close()

                    '//cuenta de la retencion 4017201

                    If igv_Retencion4ta > 0 Then

                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = cta40igv
                        detalle.AD_TANEXO = 0
                        detalle.AD_IDANEXO = ""
                        detalle.AD_TDOC = ""
                        detalle.AD_SDOC = ""
                        detalle.AD_NDOC = ""
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""
                        detalle.AD_DEBE = 0
                        detalle.AD_HABER = Math.Round(IIf(mon = 1, igv_Retencion4ta, igv_Retencion4ta * tc), 2)
                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, detalle.AD_HABER, igv_Retencion4ta), 2)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)

                    End If

                    '//cuenta del Honorario 424
                    detalle = New ClsEntidades.CO_TB_ASIENTO_DET

                    detalle.AD_IDCAB = 0
                    detalle.AD_SECUENCIA = ls_det.Count + 1
                    detalle.AD_CUENTA = IIf(mon = 1, cta424_Sol, cta424_Dol)
                    detalle.AD_TANEXO = 2
                    detalle.AD_IDANEXO = ruc
                    detalle.AD_TDOC = td
                    detalle.AD_SDOC = sd
                    detalle.AD_NDOC = nd
                    detalle.AD_FDOC = fd
                    detalle.AD_VDOC = vd
                    detalle.AD_DEBE = 0
                    detalle.AD_HABER = Math.Round(IIf(mon = 1, total, total * tc), 2)
                    detalle.AD_TCAM = tc
                    detalle.AD_SEC_ORI_DES = 0
                    detalle.AD_IDCC = ""
                    detalle.AD_ES_DESTINO = 0
                    detalle.AD_IDMEDIOPAGO = ""
                    detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, detalle.AD_HABER, total), 2)
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
                    detalle.AD_GLOSA = cab.AC_GLOSA_VOU

                    ls_det.Add(detalle)

                    Call Insert(cab, ls_det, False)


                End If 'si existe

            Next

        End Sub

        Public Sub Contabilizar_Caja_Ingresos(fec_ini_ As String, fec_fin_ As String, fecha_voucher_ As Date)
            Dim fec_1 As Date = CDate(fec_ini_)
            Dim fec_2 As Date = CDate(fec_fin_)
            Dim dt_cab As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA_ING", fec_1, fec_2).Tables(0)
            For i As Integer = 0 To dt_cab.Rows.Count - 1
                Dim id_planilla As String = dt_cab.Rows(i)("ID").ToString()
                If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_PLANILLA", "03", id_planilla) = 0 Then
                    Dim total_movi As Double = 0
                    Dim dic_cta10 As New Dictionary(Of String, Double)
                    Dim dic_cta10_ori As New Dictionary(Of String, Double)

                    Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
                    Dim detalle As ClsEntidades.CO_TB_ASIENTO_DET
                    Dim ls_det As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)

                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "03"
                        .AC_NUM_VOUCHER = get_Ult_num_voucher("03", fecha_voucher_.Year, fecha_voucher_.Month)
                        .AC_ANHO = fecha_voucher_.Year
                        .AC_MES = fecha_voucher_.Month
                        .AC_FEC_VOUCHER = fecha_voucher_.ToShortDateString
                        .AC_IDMONEDA = 1
                        .AC_DEBE = 0
                        .AC_HABER = 0
                        .AC_ESTADO = 1
                        .AC_GLOSA_VOU = "PLANILLA DE COBRANZA : " & id_planilla & ", Fecha : " & dt_cab.Rows(i)("DATE").ToString().Substring(0, 10)
                        .AC_ES_INTERFACE = 1
                        .AC_IDPLANILLA = id_planilla
                    End With


                    '________________________________________ D E T A L L E S _____________________________________

                    Dim monto As Double = 0
                    Dim mon As Integer = 1
                    Dim tc As Double = 0
                    Dim cta12_Clientes As String = "121201"

                    'Recorremos de la planilla
                    Dim dt_detalles As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA_ING_DET", id_planilla).Tables(0)
                    For j As Integer = 0 To dt_detalles.Rows.Count - 1

                        ' //_________ C U E N T A  10   D E  C A J A ______________________________

                        monto = Math.Round(Double.Parse(dt_detalles.Rows(j)("AMOUNT").ToString()), 2)
                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        mon = IIf(dt_detalles.Rows(j)("CURRENCY_ID").ToString() = "MN", 1, 2)
                        tc = Double.Parse(dt_detalles.Rows(j)("SELL_RATE").ToString())

                        If dic_cta10.ContainsKey(dt_detalles.Rows(j)("ACCOUNT").ToString()) Then
                            dic_cta10(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(IIf(mon = 1, monto, monto * tc), 2)
                            dic_cta10_ori(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(monto, 2)
                        Else
                            dic_cta10.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(IIf(mon = 1, monto, monto * tc), 2))
                            dic_cta10_ori.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(monto, 2))
                        End If

                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = dt_detalles.Rows(j)("ACCOUNT").ToString()
                        detalle.AD_TANEXO = 0
                        detalle.AD_IDANEXO = ""
                        detalle.AD_TDOC = ""
                        detalle.AD_SDOC = ""
                        detalle.AD_NDOC = ""
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""
                        detalle.AD_DEBE = Math.Round(IIf(mon = 1, monto, monto * tc), 2)
                        detalle.AD_HABER = 0
                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = IIf(mon = 1, monto, detalle.AD_HABER)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)
                        total_movi += detalle.AD_DEBE + detalle.AD_HABER

                        '//_________ C U E N T A  12   D E  C L I E N T E S _____________)_________________
                        Dim ruc As String = dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString()
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
                        If cta12_Clientes.Equals(String.Empty) Then cta12_Clientes = "121201"
                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = cta12_Clientes
                        detalle.AD_TANEXO = tanexo
                        detalle.AD_IDANEXO = ruc
                        detalle.AD_TDOC = tdoc
                        detalle.AD_SDOC = sdoc
                        detalle.AD_NDOC = ndoc
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""
                        detalle.AD_DEBE = 0
                        detalle.AD_HABER = Math.Round(IIf(mon = 1, monto, monto * tc), 2)
                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, monto, detalle.AD_DEBE), 2)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)

                    Next 'IF del detalle de planilla


                    '//ACTUALIZAMOS LOS TOTALES
                    cab.AC_DEBE = total_movi
                    cab.AC_HABER = total_movi


                    '//Grabamos el voucher por ID planilla
                    Call Insert(cab, ls_det, False)
                End If 'de validacio =0
            Next
        End Sub

        Public Sub Contabilizar_Caja_Egresos(fec_ini_ As String, fec_fin_ As String, fecha_voucher_ As Date)
            Dim fec_1 As Date = CDate(fec_ini_)
            Dim fec_2 As Date = CDate(fec_fin_)
            Dim dt_cab As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA_EGRE", fec_1, fec_2).Tables(0)

            For i As Integer = 0 To dt_cab.Rows.Count - 1
                Dim id_planilla As String = dt_cab.Rows(i)("ID").ToString()
                If SqlHelper.ExecuteScalar(cn, "CO_SP_S_EXIS_PLANILLA", "04", id_planilla) = 0 Then
                    Dim total_movi As Double = 0
                    Dim dic_cta10 As New Dictionary(Of String, Double)
                    Dim dic_cta10_ori As New Dictionary(Of String, Double)

                    Dim cab As New ClsEntidades.CO_TB_ASIENTO_CAB
                    Dim detalle As ClsEntidades.CO_TB_ASIENTO_DET
                    Dim ls_det As New List(Of ClsEntidades.CO_TB_ASIENTO_DET)

                    With cab
                        .AC_ID = 0
                        .AC_IDSUBDIARIO = "04"
                        .AC_NUM_VOUCHER = get_Ult_num_voucher("04", fecha_voucher_.Year, fecha_voucher_.Month)
                        .AC_ANHO = fecha_voucher_.Year
                        .AC_MES = fecha_voucher_.Month
                        .AC_FEC_VOUCHER = fecha_voucher_.ToShortDateString
                        .AC_IDMONEDA = 1
                        .AC_DEBE = 0
                        .AC_HABER = 0
                        .AC_ESTADO = 1
                        .AC_GLOSA_VOU = "PLANILLA DE COBRANZA : " & id_planilla & ", Fecha : " & dt_cab.Rows(i)("DATE").ToString().Substring(0, 10)
                        .AC_ES_INTERFACE = 1
                        .AC_IDPLANILLA = id_planilla

                    End With


                    '________________________________________ D E T A L L E S _____________________________________

                    Dim monto As Double = 0
                    Dim mon As Integer = 1
                    Dim tc As Double = 0
                    Dim cta42 As String = "121201"

                    'Recorremos de la planilla
                    Dim dt_detalles As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_S_CAJA_ING_DET", id_planilla).Tables(0)
                    For j As Integer = 0 To dt_detalles.Rows.Count - 1

                        ' //_________ C U E N T A  10   D E  C A J A ______________________________

                        monto = Math.Round(Double.Parse(dt_detalles.Rows(j)("AMOUNT").ToString()), 2)
                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        mon = IIf(dt_detalles.Rows(j)("CURRENCY_ID").ToString() = "MN", 1, 2)
                        tc = Double.Parse(dt_detalles.Rows(j)("SELL_RATE").ToString())

                        If dic_cta10.ContainsKey(dt_detalles.Rows(j)("ACCOUNT").ToString()) Then
                            dic_cta10(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(IIf(mon = 1, monto, monto * tc), 2)
                            dic_cta10_ori(dt_detalles.Rows(j)("ACCOUNT").ToString()) += Math.Round(monto, 2)
                        Else
                            dic_cta10.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(IIf(mon = 1, monto, monto * tc), 2))
                            dic_cta10_ori.Add(dt_detalles.Rows(j)("ACCOUNT").ToString(), Math.Round(monto, 2))
                        End If

                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = dt_detalles.Rows(j)("ACCOUNT").ToString()
                        detalle.AD_TANEXO = 0
                        detalle.AD_IDANEXO = ""
                        detalle.AD_TDOC = ""
                        detalle.AD_SDOC = ""
                        detalle.AD_NDOC = ""
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""
                        detalle.AD_DEBE = 0
                        detalle.AD_HABER = Math.Round(IIf(mon = 1, monto, monto * tc), 2)
                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = IIf(mon = 1, monto, detalle.AD_HABER)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)
                        total_movi += detalle.AD_DEBE + detalle.AD_HABER

                        '_________ C U E N T A  42   D E  P R O V E E D O R ______________________________
                        Dim ruc As String = dt_detalles.Rows(j)("ANNEX_ID_AUX").ToString()
                        Dim tdoc As String = dt_detalles.Rows(j)("DOCUMET_ID").ToString()
                        Dim sdoc As String = dt_detalles.Rows(j)("NUMBER_SERIE").ToString()
                        Dim ndoc As String = dt_detalles.Rows(j)("NUMBER_DOCUMENT").ToString()
                        Dim subd As String = "01" '//ventas
                        Dim tanexo As Integer = 2 '//proveedor

                        If dt_detalles.Rows(j)("TYPE_DOC").ToString().Equals("HO") Then
                            subd = "04"
                            tanexo = 4
                        End If

                        ' //buscamos la cuenta contable
                        Dim drrr As SqlDataReader = SqlHelper.ExecuteReader(cn, "CO_SP_S_CTA_PROVISION", subd, ruc, tdoc, sdoc, ndoc)
                        If drrr.HasRows Then
                            drrr.Read()
                            cta42 = drrr("RESULTADO").ToString()
                        End If
                        drrr.Close()
                        If cta42.Equals(String.Empty) Then cta42 = "421201"
                        detalle = New ClsEntidades.CO_TB_ASIENTO_DET
                        detalle.AD_IDCAB = 0
                        detalle.AD_SECUENCIA = ls_det.Count + 1
                        detalle.AD_CUENTA = cta42
                        detalle.AD_TANEXO = tanexo
                        detalle.AD_IDANEXO = ruc
                        detalle.AD_TDOC = tdoc
                        detalle.AD_SDOC = sdoc
                        detalle.AD_NDOC = ndoc
                        detalle.AD_FDOC = ""
                        detalle.AD_VDOC = ""
                        detalle.AD_DEBE = Math.Round(IIf(mon = 1, monto, monto * tc), 2)
                        detalle.AD_HABER = 0
                        detalle.AD_TCAM = tc
                        detalle.AD_SEC_ORI_DES = 0
                        detalle.AD_IDCC = ""
                        detalle.AD_ES_DESTINO = 0
                        detalle.AD_IDMEDIOPAGO = ""
                        detalle.AD_MONTO_ORI = Math.Round(IIf(mon = 1, monto, detalle.AD_DEBE), 2)
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
                        detalle.AD_GLOSA = cab.AC_GLOSA_VOU
                        ls_det.Add(detalle)

                    Next 'IF del detalle de planilla


                    '//ACTUALIZAMOS LOS TOTALES
                    cab.AC_DEBE = total_movi
                    cab.AC_HABER = total_movi


                    '//Grabamos el voucher por ID planilla
                    Call Insert(cab, ls_det, False)


                End If 'de validacio =0


            Next

        End Sub

        Public Sub Insert(ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB, ld As List(Of ClsEntidades.CO_TB_ASIENTO_DET), edicion_ As Boolean)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                If edicion_ Then
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_D_ASIENTO_CAB", c.AC_ID, c.AC_IDSUBDIARIO, c.AC_ANHO, c.AC_MES)
                End If

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CAB", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA)
                c.AC_ID = idcab

                For Each d As ClsEntidades.CO_TB_ASIENTO_DET In ld

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
        End Sub


        Public Sub Actualizar_Asiento_Cabecera(ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_CABECERA_ASIENTO", c.AC_ID, c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER, c.AC_FEC_VOUCHER, c.AC_GLOSA_VOU, c.AC_IDMONEDA)
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub



        Public Sub Guardar_Asiento_Cabecera(ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CONTABLE_CAB", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_RUC, c.AC_TIPO_DOC, c.AC_SER_DOC, c.AC_NUM_DOC, c.AC_FEC_DOC, c.AC_FEC_DOC_VENCE, c.AC_POR_IGV,
                            c.AC_VAL_IGV, c.AC_TOTAL_DOC, c.AC_TIPO_CAMBIO, c.AC_GLOSA_TRANSACCION, c.AC_DESTINO, c.AC_POR_ISC, c.AC_ISC, c.AC_POR_DETRAC, c.AC_FEC_PLE,
                            c.AC_TIPO_DOC_REF, c.AC_SER_DOC_REF, c.AC_NUM_DOC_REF, c.AC_FEC_DOC_REF, c.AC_DETRAC, c.AC_DUA, c.AC_OP_INAFECTA, c.AC_OP_GRAVADA, c.AC_ID_REGCOMPRA, c.AC_RECEIVABLE_TYPE,
                            c.AC_TIPO_DOC_DETRAC, c.AC_SER_DOC_DETRAC, c.AC_NUM_DOC_DETRAC, c.AC_FEC_DOC_DETRAC)
                c.AC_ID = idcab
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function Guardar_Asiento_Cabecera_Compras_Marcados(ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB) As Boolean
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_ASIENTO_CONTABLE_CAB", c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_RUC, c.AC_TIPO_DOC, c.AC_SER_DOC, c.AC_NUM_DOC, c.AC_FEC_DOC, c.AC_FEC_DOC_VENCE, c.AC_POR_IGV,
                            c.AC_VAL_IGV, c.AC_TOTAL_DOC, c.AC_TIPO_CAMBIO, c.AC_GLOSA_TRANSACCION, c.AC_DESTINO, c.AC_POR_ISC, c.AC_ISC, c.AC_POR_DETRAC, c.AC_FEC_PLE,
                            c.AC_TIPO_DOC_REF, c.AC_SER_DOC_REF, c.AC_NUM_DOC_REF, c.AC_FEC_DOC_REF, c.AC_DETRAC, c.AC_DUA, c.AC_OP_INAFECTA, c.AC_OP_GRAVADA, c.AC_ID_REGCOMPRA,
                            c.AC_RECEIVABLE_TYPE,
                            c.AC_TIPO_DOC_DETRAC, c.AC_SER_DOC_DETRAC, c.AC_NUM_DOC_DETRAC, c.AC_FEC_DOC_DETRAC)
                c.AC_ID = idcab

                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTOS_DETALLES_COMPRAS", "CO" & c.AC_ID_REGCOMPRA, idcab, c.AC_NUM_VOUCHER)

                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_COMPRAS_DESTINOS_ACTUALIZAR", idcab, c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER)

                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_COMPRAS_ESTADO", idcab)

                trVar.Commit()
                trVar.Dispose()
                Return True
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Actualiza_Centro_Costo_Compras(ByVal id_compra As String, ByVal cod_cc As String) As Boolean
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                SqlHelper.ExecuteNonQuery(trVar, "COMPRA_SP_U_PURCHASE_CC", id_compra, cod_cc)

                trVar.Commit()
                trVar.Dispose()
                Return True
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Throw
                Return False
            End Try
        End Function

        Public Sub Guardar_Asiento_Retenciones(ByRef c As ClsEntidades.RETENCIONES_GENERAL)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "CO_SP_I_RETENCIONES_GENERALES", c.RUC, c.SERIE_COMP,
                            c.NUMERO_COMP, c.FECHA_COMP, c.IMPORTE_TOTAL_COMP, c.TIPO, c.SERIE, c.NUMERO, c.FECHA_DOC, c.TOTAL_DOC,
                            c.POR_TRES_DOC, c.MES, c.MES_INT, c.ANIO)
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Throw
            End Try


        End Sub
        Public Sub Eliminar_Retenciones()
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                SqlHelper.ExecuteNonQuery(trVar, "CX_SP_D_RETENCIONES_GENERALES")

                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

        Public Sub Generar_Asiento_Retenciones_Automatico(ByRef c As ClsEntidades.RETENCIONES_GENERAL)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                Dim idcab As Integer = SqlHelper.ExecuteScalar(trVar, "RETENCIONES_SP_CARGAR_DETALLES_AUTOMATICO", c.RUC, c.SERIE_COMP,
                            c.NUMERO_COMP, c.MES_INT, c.MES, c.ANIO)
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

        Public Sub Guardar_Datos_Detraccion(ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_DATOS_DETRACCION", c.AC_ID,
                            c.AC_TIPO_DOC_DETRAC, c.AC_SER_DOC_DETRAC, c.AC_NUM_DOC_DETRAC, c.AC_FEC_DOC_DETRAC)

                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
                Throw
            End Try
        End Sub

        Public Sub Modificar_Asiento_Cabecera(ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                SqlHelper.ExecuteNonQuery(trVar, "CO_SP_U_ASIENTO_CONTABLE_CAB", c.AC_ID, c.AC_IDSUBDIARIO, c.AC_NUM_VOUCHER,
                            c.AC_ANHO, c.AC_MES, c.AC_FEC_VOUCHER, c.AC_IDMONEDA, c.AC_DEBE, c.AC_HABER, c.AC_ESTADO, c.AC_GLOSA_VOU,
                            c.AC_ES_INTERFACE, c.AC_IDPLANILLA, c.AC_RUC, c.AC_TIPO_DOC, c.AC_SER_DOC, c.AC_NUM_DOC, c.AC_FEC_DOC, c.AC_FEC_DOC_VENCE, c.AC_POR_IGV,
                            c.AC_VAL_IGV, c.AC_TOTAL_DOC, c.AC_TIPO_CAMBIO, c.AC_GLOSA_TRANSACCION, c.AC_DESTINO, c.AC_POR_ISC, c.AC_ISC, c.AC_POR_DETRAC, c.AC_FEC_PLE,
                            c.AC_TIPO_DOC_REF, c.AC_SER_DOC_REF, c.AC_NUM_DOC_REF, c.AC_FEC_DOC_REF, c.AC_DETRAC, c.AC_DUA, c.AC_OP_INAFECTA, c.AC_OP_GRAVADA, c.AC_ID_REGCOMPRA,
                            c.AC_TIPO_DOC_DETRAC, c.AC_SER_DOC_DETRAC, c.AC_NUM_DOC_DETRAC, c.AC_FEC_DOC_DETRAC)
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                Throw
            End Try
        End Sub

     

        Public Sub Guardar_Asiento_Detalle(ByVal ld As List(Of ClsEntidades.CO_TB_ASIENTO_DET))
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                For Each d As ClsEntidades.CO_TB_ASIENTO_DET In ld
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTO_DET", d.AD_IDCAB, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
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
                Throw
            End Try
        End Sub

        Public Sub Guardar_Asiento_Detalle_(ByVal ld As List(Of ClsEntidades.CO_TB_ASIENTO_DET))
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                For Each d As ClsEntidades.CO_TB_ASIENTO_DET In ld
                    SqlHelper.ExecuteNonQuery(trVar, "CONTA_SP_I_ASIENTO_DET_I", d.AD_IDCAB, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA, d.AD_PERCEN_DETRACC, d.AD_CEN_COS)
                Next
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                Throw
            End Try
        End Sub

        Public Sub Guardar_Asiento_Detalle_Activo_Fijo(ByVal ld As List(Of ClsEntidades.CO_TB_ASIENTO_DET), ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try
                For Each d As ClsEntidades.CO_TB_ASIENTO_DET In ld
                    SqlHelper.ExecuteNonQuery(trVar, "CONTA_SP_I_ASIENTO_DET", d.AD_IDCAB, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA, d.AD_PERCEN_DETRACC)
                Next
                SqlHelper.ExecuteNonQuery(trVar, "CONTA_SP_ACT_ASIENTO_DESTINOS", c.AC_ID)
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                Throw
            End Try
        End Sub

        Public Sub Actualizar_Asiento_Detalle_(ByVal ld As List(Of ClsEntidades.CO_TB_ASIENTO_DET))
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.CO_TB_ASIENTO_DET In ld
                    'Borrando Datos
                    SqlHelper.ExecuteNonQuery(trVar, "CX_SP_D_ASIENTO_CONTABLE", d.AD_IDCAB, d.AD_SECUENCIA)
                    'Guardando
                    SqlHelper.ExecuteNonQuery(trVar, "CONTA_SP_I_ASIENTO_DET_I", d.AD_IDCAB, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
                                  d.AD_IDANEXO, d.AD_TDOC, d.AD_SDOC, d.AD_NDOC, IIf(d.AD_FDOC = "", DBNull.Value, d.AD_FDOC),
                                  IIf(d.AD_VDOC = "", DBNull.Value, d.AD_VDOC), d.AD_DEBE, d.AD_HABER,
                                  d.AD_TCAM, d.AD_SEC_ORI_DES, d.AD_IDCC, d.AD_ES_DESTINO, d.AD_IDMEDIOPAGO, d.AD_MONTO_ORI,
                                  d.AD_PORCE_DESTINO, d.AD_ES_CONCI, d.AD_ANHO_CONI, d.AD_MES_CONCI, d.AD_ES_INAFECTO, d.AD_IDMONEDA,
                                  d.AD_TDOC_REF, d.AD_SDOC_REF, d.AD_NDOC_REF,
                                  IIf(d.AD_FDOC_REF = "", DBNull.Value, d.AD_FDOC_REF),
                                  IIf(d.AD_VDOC_REF = "", DBNull.Value, d.AD_VDOC_REF), d.AD_GLOSA, d.AD_PERCEN_DETRACC, d.AD_CEN_COS)
                Next
                trVar.Commit()
                trVar.Dispose()
            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub


        Public Sub Actualizar_Asiento_Detalle(ByVal ld As List(Of ClsEntidades.CO_TB_ASIENTO_DET))
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                For Each d As ClsEntidades.CO_TB_ASIENTO_DET In ld
                    'Borrando Datos
                    SqlHelper.ExecuteNonQuery(trVar, "CX_SP_D_ASIENTO_CONTABLE", d.AD_IDCAB, d.AD_SECUENCIA)
                    'Guardando
                    SqlHelper.ExecuteNonQuery(trVar, "CO_SP_I_ASIENTO_DET", d.AD_IDCAB, d.AD_SECUENCIA, d.AD_CUENTA, d.AD_TANEXO,
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
                Throw
            End Try
        End Sub


        Public Sub Guardar_Modifica_Asiento_Contable(ByRef c As ClsEntidades.CO_TB_ASIENTO_CAB, ld As List(Of ClsEntidades.CO_TB_ASIENTO_DET), edicion_ As Boolean)
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
                            c.AC_TIPO_DOC_REF, c.AC_SER_DOC_REF, c.AC_NUM_DOC_REF, c.AC_FEC_DOC_REF, c.AC_DETRAC, c.AC_DUA, c.AC_OP_INAFECTA, c.AC_OP_GRAVADA)
                c.AC_ID = idcab

                For Each d As ClsEntidades.CO_TB_ASIENTO_DET In ld
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
                Throw
            End Try
        End Sub

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

    End Class

    Public Class CO_TB_TIPO_ANEXO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_TIPO_ANEXO").Tables(0)
        End Function

        Public Sub Insert(cod_ As Integer, des_ As String)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_TIPO_ANEXO", cod_, des_)
        End Sub

        Public Sub Update(cod_ As Integer, des_ As String)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_TIPO_ANEXO", cod_, des_)
        End Sub

    End Class

    Public Class CO_TB_PARAMETROS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function getParametros() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "select * from CO_TB_PARAMETROS").Tables(0)
        End Function

        Public Function Update(igv_ As String, dif_gan_ As String, dif_per_ As String, retenrh_ As String, baserh_ As String, isc_ As String, detracc_ As String, igv_cp As String, cta_cob_contado As String, cta_igv_ret As String, cta_42_soles As String, cta_42_dolares As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_PARAMETROS", igv_, dif_gan_, dif_per_, retenrh_, baserh_, isc_, detracc_, igv_cp, cta_igv_ret, cta_42_soles, cta_42_dolares) ', cta_cob_contado)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
    End Class

    Public Class CO_TB_SUBDIARIO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(SD_ID_ As String, SD_DESCRIPCION_ As String, SD_ABREVIATURA_ As String, SD_ES_APER_ As Integer, SD_ES_CIER_ As Integer, SD_ISTATUS_ As Integer, SD_IDOPERACION_ As Integer, SD_ES_DIFCAM_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_SUBDIARIO", SD_ID_, SD_DESCRIPCION_, SD_ABREVIATURA_, SD_ES_APER_, SD_ES_CIER_, SD_ISTATUS_, SD_IDOPERACION_, SD_ES_DIFCAM_)
        End Sub

        Public Sub Update(SD_ID_ As String, SD_DESCRIPCION_ As String, SD_ABREVIATURA_ As String, SD_ES_APER_ As Integer, SD_ES_CIER_ As Integer, SD_ISTATUS_ As Integer, SD_IDOPERACION_ As Integer, SD_ES_DIFCAM_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_SUBDIARIO", SD_ID_, SD_DESCRIPCION_, SD_ABREVIATURA_, SD_ES_APER_, SD_ES_CIER_, SD_ISTATUS_, SD_IDOPERACION_, SD_ES_DIFCAM_)
        End Sub

        Public Sub Delete(SD_ID_ As String)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_D_SUBDIARIO", SD_ID_)
        End Sub

        Public Function get_Subdiario_x_Id(SD_ID_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_SUBDIARIO_BYID", SD_ID_).Tables(0)
        End Function

        Public Function get_Subdiarios() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_SUBDIARIO").Tables(0)
        End Function

        Public Function get_Subdiario_x_Ope(operacion_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_SUBDIARIO_OPE", operacion_).Tables(0)
        End Function

    End Class

    Public Class CO_TB_OPERACION
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_OperacionesTodos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_OPERACION_TODOS").Tables(0)
        End Function

        Public Function get_Operaciones() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_OPERACION").Tables(0)
        End Function

        Public Function get_OperacionesVarios() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_OPERACION_VARIOS").Tables(0)
        End Function
    End Class

    Public Class CO_TB_TIPO_MOV
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_TIPO_MOV").Tables(0)
        End Function
    End Class

    Public Class CO_TB_MONEDA
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

        Public Function get_Monedas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_MONEDA_CMB").Tables(0)
        End Function

        Public Function get_Monedas_II() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_MONEDA_CMB_II").Tables(0)
        End Function

        Public Function get_TiposCambio() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CO_SP_S_MONEDA_CMB").Tables(0)
        End Function


    End Class

    Public Class CO_TB_MEDIOPAGO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Medios() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_MEDIOPAGO").Tables(0)
        End Function
    End Class

    Public Class CO_TB_PLANCTAS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(PC_NUM_CTA_ As String, PC_DES_CTA_ As String, PC_IDMONEDA_ As Integer, PC_IDTIPO_MOV_ As Integer, PC_IDTIPO_ANEXO_ As Integer, PC_PERIODO_ As Integer, PC_ES_CC_ As Integer, cta_d_d_ As String, cta_d_h_ As String, efectivo_ As Integer, cta_cor_ As Integer, mp_ As Integer, PC_TCAMBIO As Integer)
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_PLANCTAS", PC_NUM_CTA_, PC_DES_CTA_, PC_IDMONEDA_, PC_IDTIPO_MOV_, PC_IDTIPO_ANEXO_, PC_PERIODO_, PC_ES_CC_, cta_d_d_, cta_d_h_, efectivo_, cta_cor_, mp_, PC_TCAMBIO)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

        End Sub

        Public Sub Update(PC_NUM_CTA_ As String, PC_DES_CTA_ As String, PC_IDMONEDA_ As Integer, PC_IDTIPO_MOV_ As Integer, PC_IDTIPO_ANEXO_ As Integer, PC_PERIODO_ As Integer, PC_ES_CC_ As Integer, cta_d_d_ As String, cta_d_h_ As String, efectivo_ As Integer, cta_cor_ As Integer, mp_ As Integer, PC_TCAMBIO As Integer)
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_PLANCTAS", PC_NUM_CTA_, PC_DES_CTA_, PC_IDMONEDA_, PC_IDTIPO_MOV_, PC_IDTIPO_ANEXO_, PC_PERIODO_, PC_ES_CC_, cta_d_d_, cta_d_h_, efectivo_, cta_cor_, mp_, PC_TCAMBIO)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End Sub



        Public Sub Delete(PC_NUM_CTA_ As String, PC_PERIODO_ As Integer)
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_D_PLANCTAS", PC_NUM_CTA_)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

        End Sub

        Public Function get_Cuentas(PC_PERIODO_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_PLANCTAS", PC_PERIODO_).Tables(0)
        End Function

        Public Function get_Validar_Cuenta(_codigo As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_VALIDAR_PLANCTAS", _codigo).Tables(0)
        End Function

        Public Function get_Cuentas_Mov(PC_PERIODO_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_PLANCTAS_MOV", PC_PERIODO_).Tables(0)
        End Function

        Public Function get_Cuenta(PC_NUM_CTA_ As String, PC_PERIODO_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_PLANCTAS_BYID", PC_NUM_CTA_, PC_PERIODO_).Tables(0)
        End Function

    End Class

    Public Class CO_TB_TIPO_DOC_ANE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "select  TD_ID,TD_ID+' - '+TD_DESCRIPCION as 'TD_DESCRIPCION' from CO_TB_TIPO_DOC_ANE").Tables(0)
        End Function

        Public Function get_Direc_entrega(ByVal _CADENA As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, _CADENA).Tables(0)
        End Function


        Public Function get_Tipo_Via() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_VIA").Tables(0)
        End Function

        Public Function get_Tipo_Zona_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_ZONA").Tables(0)
        End Function

        Public Function get_Estado_Civil_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_CIVIL_STATUS").Tables(0)
        End Function

        Public Function get_Establecimiento_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_ESTABLISHMENT").Tables(0)
        End Function

        Public Function get_Cargo_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_CARGOS").Tables(0)
        End Function

        Public Function get_Area_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_AREA").Tables(0)
        End Function

        Public Function get_Fondo_Pensiones_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_AFP").Tables(0)
        End Function

        Public Function get_Comision_AFP_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_COMISION_AFP").Tables(0)
        End Function

        Public Function get_Banco_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PLA_SP_S_PL_BANK").Tables(0)
        End Function

        Public Function get_Moneda_RR_HH() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_WH_TIPOC").Tables(0)
        End Function

        Public Function get_Tipo_Planilla() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "PL_SP_S_PL_TIPO_PLANILLA").Tables(0)
        End Function

    End Class

    Public Class freeQuery
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Cta77Gan() As String
            Dim rpta As String = ""
            Dim drr As SqlDataReader

            drr = SqlHelper.ExecuteReader(cn, CommandType.Text, "SELECT CTA_DIF_GAN FROM CO_TB_PARAMETROS")

            If drr.HasRows Then
                drr.Read()
                rpta = drr("CTA_DIF_GAN").ToString
            End If

            drr.Close()

            Return rpta
        End Function

        Public Function get_Cta66Per() As String
            Dim rpta As String = ""
            Dim drr As SqlDataReader

            drr = SqlHelper.ExecuteReader(cn, CommandType.Text, "SELECT CTA_DIF_PER FROM CO_TB_PARAMETROS")

            If drr.HasRows Then
                drr.Read()
                rpta = drr("CTA_DIF_PER").ToString
            End If

            drr.Close()

            Return rpta
        End Function

        Public Function Insert_Annexed(id_ As String, tipo_ As String, ruc_ As String, des_ As String, refern_ As String, dir_ As String, telfo_ As String, repre_ As String, negocio_ As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_ANNEXED", id_, tipo_, ruc_, des_, refern_, dir_, telfo_, repre_, negocio_)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Return False
            End Try
        End Function

        Public Function Update_Annexed(id_ As String, tipo_ As String, ruc_ As String, des_ As String, refern_ As String, dir_ As String, telfo_ As String, repre_ As String, negocio_ As String) As Boolean
            Try
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_U_ANNEXED", id_, tipo_, ruc_, des_, refern_, dir_, telfo_, repre_, negocio_)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Return False
            End Try

        End Function

        Public Function get_Annexed(tipo_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT  * FROM ANNEXED WHERE TYPE = '" & tipo_ & "'").Tables(0)
        End Function

        Public Function get_Annexed_Ayuda(tipo_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT  VAT_REGISTRATION as 'RUC',NAME  as 'DESCRIPCION' FROM ANNEXED WHERE TYPE = '" & tipo_ & "'").Tables(0)
        End Function

        Public Function get_Info_Empresa() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "select * from dbo.COMPANY").Tables(0)
        End Function

        Public Sub Insert_Cod_Tmp(ls_entidades As List(Of ClsEntidades.CO_TB_CODIGOS_TMP))
            If ls_entidades.Count > 0 Then
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "delete from CO_TB_CODIGOS_TMP where pc = '" & ls_entidades(0).PC & "' ")
            End If

            For Each entidad As ClsEntidades.CO_TB_CODIGOS_TMP In ls_entidades
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_CODIGOS_TMP", entidad.CODIGO, entidad.PC)
            Next
        End Sub

        Public Sub Insert_Saldos_Cuentas(ls_entidades As List(Of String), ayo_ As Integer, mes_ As Integer, pc_ As String, moneda_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "DELETE FROM CO_TB_TMP_SALDO_CUENTA WHERE SC_PC = '" & pc_ & "' ")
            For Each cuenta As String In ls_entidades
                SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_SALDO_CUENTA1", ayo_, mes_, cuenta, pc_, moneda_)
            Next
        End Sub

        Public Sub Grabar_Ctas_Ant_Mes(ayo_ As Integer, mes_ As Integer, pc_ As String)
            SqlHelper.ExecuteNonQuery(cn, "CO_SP_I_CTA_ANT_MES", ayo_, mes_, pc_)
        End Sub

        Public Function Existe_Anexo(id_ As String, tipo_ As Integer) As Boolean
            Dim rpta As Boolean = False
            Dim query As String = String.Empty

            Select Case tipo_
                Case 1
                    query = "select count(*) from CUSTOMER where VAT_REGISTRATION = '" & id_ & "'"
                Case 2
                    query = "select count(*) from VENDOR where VAT_REGISTRATION = '" & id_ & "'"
                Case Else
                    query = "SELECT * FROM ANNEXED  WHERE TYPE = '" & tipo_ & "' AND VAT_REGISTRATION ='" & id_ & "'"
            End Select
            Dim r As Double
            If query.Length() <> 0 Then
                r = SqlHelper.ExecuteScalar(cn, CommandType.Text, query)
            Else
                r = 0
            End If
            If r > 0 Then rpta = True

            Return rpta

        End Function

        Public Function get_Clientes() As DataTable
            Dim query As String = "SELECT ID AS 'RUC',NAME AS 'DESCRIPCION' FROM CUSTOMER"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Descripcion_Cliente(ByVal ruc_ As String) As DataTable
            Dim query As String = "SELECT NAME  FROM CUSTOMER WHERE VAT_REGISTRATION = '" & ruc_ & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Proveedores() As DataTable
            Dim query As String = "SELECT ID AS 'RUC',NAME AS 'DESCRIPCION' FROM VENDOR"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Descripcion_Proveedor(ruc_ As String) As DataTable
            Dim query As String = "SELECT NAME  FROM VENDOR WHERE VAT_REGISTRATION = '" & ruc_ & "'"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_TipoCambio(fecha_ As String) As Double
            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(cn, "CO_SP_TIPO_CAMBIO", DateTime.Parse(fecha_).ToShortDateString()).Tables(0)
            Dim rpta As Double = 0
            If dt_tmp.Rows.Count > 0 Then
                rpta = dt_tmp(0)(0)
            End If
            Return rpta
        End Function

        Public Function get_Documentos() As DataTable
            Dim query As String = "SELECT TYPE_ID AS 'CODIGO',NAME AS 'DESCRIPCION' FROM DOCUMENT_TYPE"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Centro_Costo() As DataTable
            Dim query As String = "SELECT COST_CENTER_ID AS 'CODIGO',COST_CENTER_DESCRIPTION AS 'DESCRIPCION' FROM CENTER_COST"
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        End Function


    End Class


End Class
