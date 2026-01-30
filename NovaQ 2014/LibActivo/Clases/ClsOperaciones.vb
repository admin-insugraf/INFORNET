Imports System.Data
Imports System.Data.SqlClient
Imports LibConexion
Imports LibComunVar

Public Class ClsOperaciones

    Public Class AF_MA_FAMI_CTA_CC
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(e As ClsEntidades.AF_MA_FAMI_CTA_CC)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_FAMI_CTA_CC", e.FC_IDFAMILIA, e.FC_NUM_CUENTA, e.FC_PORCE)
            End With
        End Sub

        Public Sub Delete(e As ClsEntidades.AF_MA_FAMI_CTA_CC)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_FAMI_CTA_CC", e.FC_IDFAMILIA, e.FC_NUM_CUENTA)
            End With
        End Sub

        Public Function get_Cuentas(e As ClsEntidades.AF_MA_FAMI_CTA_CC) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_FAMI_CTA_CC", e.FC_IDFAMILIA).Tables(0)
        End Function

    End Class

    Public Class AF_PR_DATOS_MANTE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Datos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_DATOS_MANTE").Tables(0)
        End Function

    End Class

    Public Class AF_PR_ACTIVO_MEJORA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(e As ClsEntidades.AF_PR_ACTIVO_MEJORA)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_ACTIVO_MEJORA", e.AM_IDACTIVO, e.AM_SEC, e.AM_REF, e.AM_IDPROVE, e.AM_TDOC, e.AM_SDOC, e.AM_NDOC, IIf(e.AM_FDOC = String.Empty, DBNull.Value, e.AM_FDOC), e.AM_MDOC, e.AM_IDMONEDA, e.AM_TCAM, e.AM_IDTIPO_PAGO, e.AM_OBS, e.AM_TASA, e.AM_FEC_REG, e.AM_USUARIO, e.AM_TERMINAL)
            End With
        End Sub

        Public Sub Update(e As ClsEntidades.AF_PR_ACTIVO_MEJORA)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_ACTIVO_MEJORA", e.AM_IDACTIVO, e.AM_SEC, e.AM_REF, e.AM_IDPROVE, e.AM_TDOC, e.AM_SDOC, e.AM_NDOC, IIf(e.AM_FDOC = String.Empty, DBNull.Value, e.AM_FDOC), e.AM_MDOC, e.AM_IDMONEDA, e.AM_TCAM, e.AM_IDTIPO_PAGO, e.AM_OBS, e.AM_TASA, e.AM_FEC_REG, e.AM_USUARIO, e.AM_TERMINAL)
            End With
        End Sub

        Public Sub Delete(e As ClsEntidades.AF_PR_ACTIVO_MEJORA)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_ACTIVO_MEJORA", e.AM_IDACTIVO, e.AM_SEC)
            End With
        End Sub

        Public Function get_Mejoras_Lista_todos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_ACTIVO_MEJORA").Tables(0)
        End Function

        Public Function get_Mejoras_x_Cod(e As ClsEntidades.AF_PR_ACTIVO_MEJORA) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTI_MEJO_XID", e.AM_IDACTIVO, e.AM_SEC).Tables(0)
        End Function

        Public Function get_Data_cmbs() As DataSet
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_CMBS_REGMEJORAS")
        End Function

    End Class

    Public Class AF_MA_ACTIVO_FIC
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_fichas(idactivo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTIVO_FIC", idactivo_).Tables(0)
        End Function

    End Class

    Public Class AF_MA_ACTIVO_IMG
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(e As ClsEntidades.AF_MA_ACTIVO_IMG)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_ACTIVO_IMG", e.AI_IDACTIVO, e.AI_IMG, e.AI_NOM, e.AI_DES, e.AI_SEC, e.AI_FECREG)
        End Sub

        Public Sub Update(e As ClsEntidades.AF_MA_ACTIVO_IMG)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_ACTIVO_IMG", e.AI_IDACTIVO, e.AI_IMG, e.AI_NOM, e.AI_DES, e.AI_SEC, e.AI_FECREG)
        End Sub

        Public Sub Delete(e As ClsEntidades.AF_MA_ACTIVO_IMG)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_ACTIVO_IMG", e.AI_IDACTIVO, e.AI_SEC)
        End Sub

        Public Sub Delete_All(e As ClsEntidades.AF_MA_ACTIVO_IMG)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_ACTIVO_IMG_ALL", e.AI_IDACTIVO)
        End Sub

        Public Function get_Imgs(e As ClsEntidades.AF_MA_ACTIVO_IMG) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTIVO_IMG", e.AI_IDACTIVO).Tables(0)
        End Function

    End Class

    Public Class AF_LT_ESTADO_INV
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Estados() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_ESTADO_INV").Tables(0)
        End Function

    End Class

    Public Class AF_LT_TOMA_INV_C

        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Sub Insert(ByRef e As ClsEntidades.AF_LT_TOMA_INV_C, ls_activos As List(Of ClsEntidades.AF_LT_TOMA_INV_D))
            Dim idcab As Integer = 0

            idcab = SqlHelper.ExecuteScalar(cn, "AF_SP_I_TOMA_INV_C", e.TI_FECHA, e.TI_OBS, e.TI_ESTADO, e.TI_TERMINAL, e.TI_USUARIO, e.TI_FECREG, e.TI_FECHA_FIN, e.TI_IDRESPONSABLE)

            e.TI_ID = idcab

            For Each a As ClsEntidades.AF_LT_TOMA_INV_D In ls_activos
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_TOMA_INV_D", idcab, a.TD_IDACTIVO, a.TD_ESTADO_INV, a.TD_IDUBICACION, a.TD_IDAREA, a.TD_IDEST_FIS, a.TD_IDRESPO, a.TD_IDIMG, a.TD_COMENTARIOS)
            Next

        End Sub

        Public Sub Update(ByRef e As ClsEntidades.AF_LT_TOMA_INV_C, ls_activos As List(Of ClsEntidades.AF_LT_TOMA_INV_D))

            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_TOMA_INV_D", e.TI_ID)

            For Each a As ClsEntidades.AF_LT_TOMA_INV_D In ls_activos
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_TOMA_INV_D", a.TD_IDCAB, a.TD_IDACTIVO, a.TD_ESTADO_INV, a.TD_IDUBICACION, a.TD_IDAREA, a.TD_IDEST_FIS, a.TD_IDRESPO, a.TD_IDIMG, a.TD_COMENTARIOS)
            Next

        End Sub

        Public Sub Update_Estado(numInv_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_TOMA_INV_C", numInv_)
        End Sub

        Public Function get_Inv_x_Numero(numInv_ As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_INV_X_NUM", numInv_)
        End Function

        Public Function get_Data_Combos() As DataSet
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_INV_CMBS")
        End Function

        Public Function get_Lista_Invs() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TOMA_INV_C").Tables(0)
        End Function

    End Class

    Public Class ReportesAF
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_reporte_determeinacion_depreciacion(fec_corte_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_REP_01", fec_corte_).Tables(0)
        End Function

        Public Function get_Datos_Activo_01(idactivo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTIVO06", idactivo_).Tables(0)
        End Function


    End Class

    Public Class AF_MA_RESPO_EJE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(e As ClsEntidades.AF_MA_RESPO_EJE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_RESPO_EJE", e.RE_ID, e.RE_DESCRIPCION)
        End Sub

        Public Sub Update(e As ClsEntidades.AF_MA_RESPO_EJE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_RESPO_EJE", e.RE_ID, e.RE_DESCRIPCION)
        End Sub

        Public Sub Delete(e As ClsEntidades.AF_MA_RESPO_EJE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_RESPO_EJE", e.RE_ID)
        End Sub

        Public Function get_Responsables() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_RESPO_EJE").Tables(0)
        End Function


    End Class

    Public Class AF_PR_BAJA_ACTIVO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(e As ClsEntidades.AF_PR_BAJA_ACTIVO)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_BAJA_ACTIVO", e.BA_IDACTIVO, e.BA_FECHA, e.BA_IDMOTIVO, IIf(e.BA_TIPO_DOC = String.Empty, DBNull.Value, e.BA_TIPO_DOC), e.BA_SER_DOC, e.BA_NUM_DOC, e.BA_PRECIO_VENTA, e.BA_IDMONEDA, IIf(e.BA_FEC_VENTA = String.Empty, DBNull.Value, e.BA_FEC_VENTA), IIf(e.BA_IDCLIENTE = String.Empty, DBNull.Value, e.BA_IDCLIENTE), e.BA_OBS)
            End With
        End Sub

        Public Sub Update(e As ClsEntidades.AF_PR_BAJA_ACTIVO)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_BAJA_ACTIVO", e.BA_IDACTIVO, e.BA_FECHA, e.BA_IDMOTIVO, IIf(e.BA_TIPO_DOC = String.Empty, DBNull.Value, e.BA_TIPO_DOC), e.BA_SER_DOC, e.BA_NUM_DOC, e.BA_PRECIO_VENTA, e.BA_IDMONEDA, IIf(e.BA_FEC_VENTA = String.Empty, DBNull.Value, e.BA_FEC_VENTA), IIf(e.BA_IDCLIENTE = String.Empty, DBNull.Value, e.BA_IDCLIENTE), e.BA_OBS)
            End With
        End Sub

        Public Sub Delete(e As ClsEntidades.AF_PR_BAJA_ACTIVO)
            With e
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_BAJA_ACTIVO", e.BA_IDACTIVO)
            End With
        End Sub

        Public Function get_Bajas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_BAJA_ACTIVO").Tables(0)
        End Function

        Public Function get_Documentos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT TYPE_ID,NAME FROM DOCUMENT_TYPE ORDER BY 1").Tables(0)
        End Function

        Public Function get_Monedas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT ID,NAME FROM CURRENCY_TYPE").Tables(0)
        End Function

        Public Function get_Clientes() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, "SELECT ID,NAME FROM CUSTOMER ORDER BY NAME").Tables(0)
        End Function

    End Class

    Public Class AF_MA_MOTIVO_BAJA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub


        Public Function get_Motivos_cmb() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_MOTIVO_BAJA_CMB").Tables(0)
        End Function

    End Class

    Public Class AF_PR_MANTE_C
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_PR_MANTE_C, lista As List(Of ClsEntidades.AF_PR_MANTE_D), lis_datos As List(Of ClsEntidades.AF_PR_MANTE_D_DATOS))
            Dim tr As SqlTransaction = cn.BeginTransaction

            Try
                Dim folio As Integer = 0
                folio = SqlHelper.ExecuteScalar(tr, "AF_SP_I_MANTE_C", e.MA_FEC_INI, e.MA_FEC_FIN, e.MA_IDTIPO_MANTE, e.MA_OBS, e.MA_IDTIPO_EJECUTOR, e.MA_IDRESPO_EJECU, e.MA_IDTERCERO_EJECU, e.MA_ESTADO, e.MA_USUARIO, e.MA_TERMINAL, e.MA_FECREG)

                For Each h As ClsEntidades.AF_PR_MANTE_D In lista
                    SqlHelper.ExecuteNonQuery(tr, "AF_SP_I_MANTE_D", folio, h.MD_IDACTIVO, _
                                              IIf(h.MD_FEC_INI.Trim = "", DBNull.Value, h.MD_FEC_INI), _
                                              IIf(h.MD_FEC_FIN.Trim = "", DBNull.Value, h.MD_FEC_FIN.Trim), _
                                              h.MD_HOR_INI, h.MD_HOR_FIN, h.MD_IDRESPO_ACTIVO, h.MD_IDAREA, _
                                              h.MD_IDEJECUTOR, h.MD_OBS, IIf(h.MD_IMG_ANT Is Nothing, DBNull.Value, h.MD_IMG_ANT), _
                                              IIf(h.MD_IMG_DES Is Nothing, DBNull.Value, h.MD_IMG_DES))
                Next

                For Each a As ClsEntidades.AF_PR_MANTE_D_DATOS In lis_datos
                    SqlHelper.ExecuteNonQuery(tr, "AF_SP_I_MANTE_D_DATOS", folio, a.DD_IDACTIVO, a.DD_ID, a.DD_VALOR)
                Next

                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
            End Try
            tr.Dispose()
        End Sub

        Public Sub update(e As ClsEntidades.AF_PR_MANTE_C, lista As List(Of ClsEntidades.AF_PR_MANTE_D), lis_datos As List(Of ClsEntidades.AF_PR_MANTE_D_DATOS))
            Dim tr As SqlTransaction = cn.BeginTransaction

            Try

                SqlHelper.ExecuteNonQuery(tr, "AF_SP_D_MANTE_D", e.MA_ID)
                SqlHelper.ExecuteNonQuery(tr, "AF_SP_D_MANTE_D_DATOS", e.MA_ID)

                SqlHelper.ExecuteNonQuery(tr, "AF_SP_U_MANTE_C", e.MA_ID, e.MA_FEC_INI, e.MA_FEC_FIN, e.MA_IDTIPO_MANTE, e.MA_OBS, e.MA_IDTIPO_EJECUTOR, e.MA_IDRESPO_EJECU, e.MA_IDTERCERO_EJECU, e.MA_ESTADO, e.MA_USUARIO, e.MA_TERMINAL, e.MA_FECREG)

                For Each h As ClsEntidades.AF_PR_MANTE_D In lista
                    SqlHelper.ExecuteNonQuery(tr, "AF_SP_I_MANTE_D", h.MD_IDFOLIO, h.MD_IDACTIVO, h.MD_FEC_INI, h.MD_FEC_FIN, h.MD_HOR_INI, h.MD_HOR_FIN, h.MD_IDRESPO_ACTIVO, h.MD_IDAREA, h.MD_IDEJECUTOR, h.MD_OBS, IIf(h.MD_IMG_ANT Is Nothing, DBNull.Value, h.MD_IMG_ANT), IIf(h.MD_IMG_DES Is Nothing, DBNull.Value, h.MD_IMG_DES))

                Next

                For Each a As ClsEntidades.AF_PR_MANTE_D_DATOS In lis_datos
                    SqlHelper.ExecuteNonQuery(tr, "AF_SP_I_MANTE_D_DATOS", a.DD_IDFOLIO, a.DD_IDACTIVO, a.DD_ID, a.DD_VALOR)
                Next

                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
            End Try
            tr.Dispose()
        End Sub

        Public Sub delete(e As ClsEntidades.AF_PR_MANTE_C)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_MANTE_C", e.MA_ID)
        End Sub

        Public Function get_Mantenimientos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_MANTE_C").Tables(0)
        End Function

        Public Function get_data_combos() As DataSet
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_MANTE_C_02")
        End Function

        Public Function get_data_x_Folio(numFolio_ As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_MANTE_C_03", numFolio_)
        End Function

    End Class

    Public Class AF_MA_TIPO_MANTE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_TIPO_MANTE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_TIPO_MANTE", e.TM_ID, e.TM_DESCRIPCION, e.TM_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_TIPO_MANTE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_TIPO_MANTE", e.TM_ID, e.TM_DESCRIPCION, e.TM_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_TIPO_MANTE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_TIPO_MANTE", e.TM_ID, e.TM_DESCRIPCION, e.TM_ESTADO)
        End Sub

        Public Function get_tipos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TIPO_MANTE").Tables(0)
        End Function

        Public Function get_tipos_cmb() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TIPO_MANTE_02").Tables(0)
        End Function

    End Class

    Public Class AF_MA_TERCE_EJE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_TERCE_EJE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_TERCE_EJE", e.TE_ID, e.TE_DESCRIPCION, e.TE_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_TERCE_EJE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_TERCE_EJE", e.TE_ID, e.TE_DESCRIPCION, e.TE_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_TERCE_EJE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_TERCE_EJE", e.TE_ID)
        End Sub

        Public Function get_terceros() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TERCE_EJE").Tables(0)
        End Function

        Public Function get_terceros_cmb() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TERCE_EJE_02").Tables(0)
        End Function

    End Class

    Public Class AF_MA_RESPO_ACTI
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_RESPO_ACTI)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_RESPO_ACTI", e.RA_ID, e.RA_DESCRIPCION, e.RA_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_RESPO_ACTI)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_RESPO_ACTI", e.RA_ID, e.RA_DESCRIPCION, e.RA_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_RESPO_ACTI)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_RESPO_ACTI", e.RA_ID)
        End Sub

        Public Function get_responsables() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_RESPO_ACTI").Tables(0)
        End Function

        Public Function get_responsables_cmb() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_RESPO_ACTI_02").Tables(0)
        End Function


    End Class

    Public Class AF_PR_TRANSFE_C
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_PR_TRANSFE_C, d As List(Of ClsEntidades.AF_PR_TRANSFE_D), ByRef num_folio_ As Integer)
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                num_folio_ = SqlHelper.ExecuteScalar(trVar, "AF_SP_I_TRANSFE_C", e.TR_FECHA_TR, e.TR_IDAREA_ORI, e.TR_IDAREA_DES, e.TR_OBS, e.TR_USUARIO, e.TR_TERMINAL, e.TR_FECREG, e.TR_IDRESPO_ACTI)

                For Each o As ClsEntidades.AF_PR_TRANSFE_D In d
                    SqlHelper.ExecuteNonQuery(trVar, "AF_SP_I_TRANSFE_D", num_folio_, o.TD_IDACTIVO)
                Next

                trVar.Commit()
                trVar.Dispose()

            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Sub Update(e As ClsEntidades.AF_PR_TRANSFE_C, d As List(Of ClsEntidades.AF_PR_TRANSFE_D))
            Dim trVar As SqlTransaction
            trVar = cn.BeginTransaction(System.Data.IsolationLevel.Serializable)
            Try

                SqlHelper.ExecuteNonQuery(trVar, "AF_SP_U_TRANSFE_C", e.TR_IDFOLIO, e.TR_FECHA_TR, e.TR_IDAREA_ORI, e.TR_IDAREA_DES, e.TR_OBS, e.TR_USUARIO, e.TR_TERMINAL, e.TR_FECREG, e.TR_IDRESPO_ACTI)

                SqlHelper.ExecuteNonQuery(trVar, "AF_SP_D_TRANSFE_D", e.TR_IDFOLIO)

                For Each o As ClsEntidades.AF_PR_TRANSFE_D In d
                    SqlHelper.ExecuteNonQuery(trVar, "AF_SP_I_TRANSFE_D", e.TR_IDFOLIO, o.TD_IDACTIVO)
                Next

                trVar.Commit()
                trVar.Dispose()

            Catch ex As Exception
                trVar.Rollback()
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function get_Transferencias() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TRANSFE_C").Tables(0)
        End Function

        Public Function get_Transferencias_x_numFolio(numFolio_ As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_TRANSFE_C_01", numFolio_)
        End Function

        Public Function get_Rep_Transferencias() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TRANSFE_02").Tables(0)
        End Function

    End Class

    Public Class AF_MA_USO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_USO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_USO", e.US_ID, e.US_DESCRIPCION, e.US_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_USO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_USO", e.US_ID, e.US_DESCRIPCION, e.US_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_USO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_USO", e.US_ID)
        End Sub

        Public Function get_usos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_USO").Tables(0)
        End Function

    End Class

    Public Class AF_MA_UBICACION
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_UBICACION)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_UBICACION", e.UB_ID, e.UB_DESCRIPCION, e.UB_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_UBICACION)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_UBICACION", e.UB_ID, e.UB_DESCRIPCION, e.UB_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_UBICACION)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_UBICACION", e.UB_ID)
        End Sub

        Public Function get_ubicaciones() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_UBICACION").Tables(0)
        End Function

    End Class

    Public Class AF_MA_TIPOPAGO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_TIPOPAGO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_TIPOPAGO", e.TP_ID, e.TP_DESCRIPCION, e.TP_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_TIPOPAGO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_TIPOPAGO", e.TP_ID, e.TP_DESCRIPCION, e.TP_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_TIPOPAGO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_TIPOPAGO", e.TP_ID)
        End Sub

        Public Function get_tipopagos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_TIPOPAGO").Tables(0)
        End Function

    End Class

    Public Class AF_MA_MARCA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_MARCA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_MARCA", e.MA_ID, e.MA_DESCRIPCION, e.MA_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_MARCA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_MARCA", e.MA_ID, e.MA_DESCRIPCION, e.MA_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_MARCA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_MARCA", e.MA_ID)
        End Sub

        Public Function get_marcas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_MARCA").Tables(0)
        End Function

    End Class

    Public Class AF_MA_CLASE
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_CLASE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_CLASE", e.CL_ID, e.CL_DESCRIPCION, e.CL_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_CLASE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_CLASE", e.CL_ID, e.CL_DESCRIPCION, e.CL_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_CLASE)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_CLASE", e.CL_ID)
        End Sub

        Public Function get_clases() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_CLASE").Tables(0)
        End Function

    End Class

    Public Class AF_MA_CENCOS
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_CENCOS)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_CENCOS", e.CC_ID, e.CC_DESCRIPCION, e.CC_ID)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_CENCOS)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_CENCOS", e.CC_ID, e.CC_DESCRIPCION, e.CC_ID)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_CENCOS)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_CENCOS", e.CC_ID)
        End Sub

        Public Function get_centros() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_CENCOS").Tables(0)
        End Function

    End Class

    Public Class AF_MA_AREA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_AREA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_AREA", e.AR_ID, e.AR_DESCRIPCION, e.AR_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_AREA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_AREA", e.AR_ID, e.AR_DESCRIPCION, e.AR_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_AREA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_AREA", e.AR_ID)
        End Sub

        Public Function get_areas() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_AREA").Tables(0)
        End Function

        Public Function get_areas_cmb() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_AREA_CMB").Tables(0)
        End Function

    End Class

    Public Class AF_MA_NIVEL_OBSO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_NIVEL_OBSO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_NIVEL_OBSO", e.NO_ID, e.NO_DESCRIPCION, e.NO_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_NIVEL_OBSO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_NIVEL_OBSO", e.NO_ID, e.NO_DESCRIPCION, e.NO_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_NIVEL_OBSO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_NIVEL_OBSO", e.NO_ID)
        End Sub

        Public Function get_niveles() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_NIVEL_OBSO").Tables(0)
        End Function

    End Class

    Public Class AF_MA_ESTADO_FISICO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(e As ClsEntidades.AF_MA_ESTADO_FISICO)
            SqlHelper.ExecuteNonQuery(cn, "AF_MA_I_ESTADO_FISICO", e.EF_ID, e.EF_DESCRIPCION, e.EF_ESTADO)
        End Sub

        Public Sub update(e As ClsEntidades.AF_MA_ESTADO_FISICO)
            SqlHelper.ExecuteNonQuery(cn, "AF_MA_U_ESTADO_FISICO", e.EF_ID, e.EF_DESCRIPCION, e.EF_ESTADO)
        End Sub

        Public Sub delete(e As ClsEntidades.AF_MA_ESTADO_FISICO)
            SqlHelper.ExecuteNonQuery(cn, "AF_MA_D_ESTADO_FISICO", e.EF_ID)
        End Sub

        Public Function get_estados() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_MA_S_ESTADO_FISICO").Tables(0)
        End Function

    End Class

    Public Class AF_MA_SUBGRUPO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(entidad As ClsEntidades.AF_MA_SUBGRUPO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_SUBGRUPO", entidad.SG_ID, entidad.SG_DESCRIPCION, entidad.SG_IDGRUPO, entidad.SG_ESTADO)
        End Sub

        Public Sub Update(entidad As ClsEntidades.AF_MA_SUBGRUPO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_SUBGRUPO", entidad.SG_ID, entidad.SG_DESCRIPCION, entidad.SG_IDGRUPO, entidad.SG_ESTADO)
        End Sub

        Public Sub delete(entidad As ClsEntidades.AF_MA_SUBGRUPO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_SUBGRUPO", entidad.SG_ID)
        End Sub

        Public Function get_subgrupos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_SUBGRUPO").Tables(0)
        End Function

    End Class

    Public Class AF_MA_GRUPO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub insert(entidad As ClsEntidades.AF_MA_GRUPO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_GRUPO", entidad.GR_ID, entidad.GR_DESCRIPCION, entidad.GR_ESTADO)
        End Sub

        Public Sub Update(entidad As ClsEntidades.AF_MA_GRUPO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_GRUPO", entidad.GR_ID, entidad.GR_DESCRIPCION, entidad.GR_ESTADO)
        End Sub

        Public Sub delete(entidad As ClsEntidades.AF_MA_GRUPO)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_GRUPO", entidad.GR_ID)
        End Sub

        Public Function get_grupos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_GRUPO").Tables(0)
        End Function

        Public Function get_grupos_cmb() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_GRUPO_02").Tables(0)
        End Function

    End Class

    Public Class AF_MA_CATEGORIA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(e As ClsEntidades.AF_MA_CATEGORIA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_CATEGORIA", e.CA_ID, e.CA_DESCRIPCION, e.CA_TASA, e.CA_ESTADO)
        End Sub

        Public Sub Update(e As ClsEntidades.AF_MA_CATEGORIA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_CATEGORIA", e.CA_ID, e.CA_DESCRIPCION, e.CA_TASA, e.CA_ESTADO)
        End Sub

        Public Sub Delete(e As ClsEntidades.AF_MA_CATEGORIA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_CATEGORIA", e.CA_ID)
        End Sub

        Public Function get_Categoria_01() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_CATEGORIA").Tables(0)
        End Function

        Public Function get_Categoria_02() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_CATEGORIA_02").Tables(0)
        End Function

        Public Function get_Tasa_x_IdCat(idcat_ As Integer) As Double
            Return SqlHelper.ExecuteScalar(cn, "AF_SP_S_CATEGORIA_03", idcat_)
        End Function

    End Class

    Public Class AF_MA_FAMILIA
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Sub Insert(e As ClsEntidades.AF_MA_FAMILIA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_FAMILIA", e.FA_ID, e.FA_DESCRIPCION, e.FA_IDMETODO, e.FA_IDCATEGORIA, e.FA_CUENTA_DEPRE, e.FA_CUENTA_ACTIVO, e.FA_CUENTA_GASTO, _
                                      e.FA_ESTADO)
        End Sub

        Public Sub Update(e As ClsEntidades.AF_MA_FAMILIA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_FAMILIA", e.FA_ID, e.FA_DESCRIPCION, e.FA_IDMETODO, e.FA_IDCATEGORIA, e.FA_CUENTA_DEPRE, e.FA_CUENTA_ACTIVO, e.FA_CUENTA_GASTO, _
                                      e.FA_ESTADO)
        End Sub

        Public Sub Delete(e As ClsEntidades.AF_MA_FAMILIA)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_FAMILIA", e.FA_ID)
        End Sub

        Public Function get_familia_01() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_FAMILIA_01").Tables(0)
        End Function

        Public Function get_familia_02(Idfamilia_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_FAMILIA_01", Idfamilia_).Tables(0)
        End Function

        Public Function get_tasa_cat(familia_ As Integer) As Double
            Return SqlHelper.ExecuteScalar(cn, "AF_SP_S_FAMILIA_03", familia_)
        End Function

        Public Function get_num_items_xFamilia(familia_ As String) As Double
            Return SqlHelper.ExecuteScalar(cn, "AF_SP_S_FAMILIA_04", familia_)
        End Function

        Public Function get_ctas_contables(ayo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_FAMILIA_05", ayo_).Tables(0)
        End Function


    End Class

    Public Class AF_MA_ACTIVO
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function get_Subdiario_x_Ope(operacion_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "CO_SP_S_SUBDIARIO_OPE", operacion_).Tables(0)
        End Function

        Public Function Validar_Cierre_Apertura_Modulos(ByVal Mes As Integer, ByVal año As Integer, ByVal opcion As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "CLI_SP_S_VALIDAR_CIERRE_APERTURA_MODULOS", Mes, año, opcion).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Throw
            End Try
        End Function

        Public Sub Insert(ByVal obe As ClsEntidades.AF_MA_ACTIVO, lis_img As List(Of ClsEntidades.AF_MA_ACTIVO_IMG), lis_fic As List(Of ClsEntidades.AF_MA_ACTIVO_FIC))

            Dim idactivo As Integer = 0

            idactivo = SqlHelper.ExecuteScalar(cn, "AF_SP_I_ACTIVO" _
            , obe.AC_IDACTIVO_REF _
            , obe.AC_CODIGO_ALT _
            , obe.AC_ACTIVO_DES _
            , obe.AC_IDFAMILIA _
            , IIf(obe.AC_FECHA_COMPRA = String.Empty, DBNull.Value, obe.AC_FECHA_COMPRA) _
            , IIf(obe.AC_FECHA_INI_OPE = String.Empty, DBNull.Value, obe.AC_FECHA_INI_OPE) _
            , obe.AC_IDGRUPO _
            , obe.AC_IDSUB_GRUPO _
            , obe.AC_IDMARCA _
            , obe.AC_MODELO _
            , obe.AC_NUMSERIE _
            , obe.AC_NUMPLACA _
            , obe.AC_IDPROVE _
            , obe.AC_TDOC _
            , obe.AC_SDOC _
            , obe.AC_NDOC _
            , IIf(obe.AC_FDOC = String.Empty, DBNull.Value, obe.AC_FDOC) _
            , obe.AC_MDOC _
            , obe.AC_IDMONEDA _
            , obe.AC_TCAM _
            , obe.AC_IDTIPO_PAGO _
            , obe.AC_IDESTADO_FISICO _
            , obe.AC_IDCLASE _
            , obe.AC_IDUSO _
            , obe.AC_IDNIVEL_OBS _
            , obe.AC_CODIGO_BARRA _
            , obe.AC_IDUBICACION _
            , obe.AC_IDCENCOS _
            , obe.AC_IDAREA _
            , obe.AC_LEA_NUM_CONTRATO _
            , IIf(obe.AC_LEA_FECHA_CONTRA = String.Empty, DBNull.Value, obe.AC_LEA_FECHA_CONTRA) _
            , IIf(obe.AC_LEA_FECHA_ARRENDA = String.Empty, DBNull.Value, obe.AC_LEA_FECHA_ARRENDA) _
            , obe.AC_LEA_NUM_COUTAS _
            , obe.AC_LEA_MONTO_TOTAL _
            , obe.AC_ANHOS _
            , obe.AC_MESES _
            , obe.AC_OBSERVACIONES _
            , obe.AC_MESESGARANTIA _
            , IIf(obe.AC_FEC_VENCE_GARAN = String.Empty, DBNull.Value, obe.AC_FEC_VENCE_GARAN) _
            , obe.AC_NUM_CONTRATO _
            , obe.AC_PERIODICIDAD_DIAS _
            , IIf(obe.AC_FEC_VENCE_CON = String.Empty, DBNull.Value, obe.AC_FEC_VENCE_CON) _
            , obe.AC_DEPRE_INICIAL _
            , obe.AC_ES_TASA_PARTICULAR _
            , obe.AC_USUARIO _
            , obe.AC_TERMINAL _
            , obe.AC_FECREG _
            , obe.AC_ESTADO _
            , obe.AC_USUARIO_MOD _
            , obe.AC_TERMINAL_MOD _
            , obe.AC_FECREG_MOD _
            , obe.AC_VALOR_RESIDUAL _
            , obe.AC_NUM_COTIZA _
            , obe.AC_NUM_ORD_COMPRA _
            , obe.AC_AUTORIZA_ADQ _
            , obe.AC_IDORIGEN_REQ _
            , obe.AC_IDRESPON_ACTI _
        )

            For Each img As ClsEntidades.AF_MA_ACTIVO_IMG In lis_img
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_ACTIVO_IMG", idactivo, img.AI_IMG, img.AI_NOM, img.AI_DES, img.AI_SEC, img.AI_FECREG)
            Next

            For Each fic As ClsEntidades.AF_MA_ACTIVO_FIC In lis_fic
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_ACTIVO_FIC", idactivo, fic.AF_SEC, fic.AF_ARCHIVO, fic.AF_FICHA)
            Next

        End Sub

        Public Sub Update(ByVal obe As ClsEntidades.AF_MA_ACTIVO, lis_img As List(Of ClsEntidades.AF_MA_ACTIVO_IMG), lis_fic As List(Of ClsEntidades.AF_MA_ACTIVO_FIC))

            SqlHelper.ExecuteNonQuery(cn, "AF_SP_U_ACTIVO" _
          , obe.AC_IDACTIVO _
          , obe.AC_IDACTIVO_REF _
          , obe.AC_CODIGO_ALT _
          , obe.AC_ACTIVO_DES _
          , obe.AC_IDFAMILIA _
          , IIf(obe.AC_FECHA_COMPRA = String.Empty, DBNull.Value, obe.AC_FECHA_COMPRA) _
            , IIf(obe.AC_FECHA_INI_OPE = String.Empty, DBNull.Value, obe.AC_FECHA_INI_OPE) _
          , obe.AC_IDGRUPO _
          , obe.AC_IDSUB_GRUPO _
          , obe.AC_IDMARCA _
          , obe.AC_MODELO _
          , obe.AC_NUMSERIE _
          , obe.AC_NUMPLACA _
          , obe.AC_IDPROVE _
          , obe.AC_TDOC _
          , obe.AC_SDOC _
          , obe.AC_NDOC _
          , IIf(obe.AC_FDOC = String.Empty, DBNull.Value, obe.AC_FDOC) _
          , obe.AC_MDOC _
          , obe.AC_IDMONEDA _
          , obe.AC_TCAM _
          , obe.AC_IDTIPO_PAGO _
          , obe.AC_IDESTADO_FISICO _
          , obe.AC_IDCLASE _
          , obe.AC_IDUSO _
          , obe.AC_IDNIVEL_OBS _
          , obe.AC_CODIGO_BARRA _
          , obe.AC_IDUBICACION _
          , obe.AC_IDCENCOS _
          , obe.AC_IDAREA _
          , obe.AC_LEA_NUM_CONTRATO _
       , IIf(obe.AC_LEA_FECHA_CONTRA = String.Empty, DBNull.Value, obe.AC_LEA_FECHA_CONTRA) _
            , IIf(obe.AC_LEA_FECHA_ARRENDA = String.Empty, DBNull.Value, obe.AC_LEA_FECHA_ARRENDA) _
          , obe.AC_LEA_NUM_COUTAS _
          , obe.AC_LEA_MONTO_TOTAL _
          , obe.AC_ANHOS _
          , obe.AC_MESES _
          , obe.AC_OBSERVACIONES _
          , obe.AC_MESESGARANTIA _
           , IIf(obe.AC_FEC_VENCE_GARAN = String.Empty, DBNull.Value, obe.AC_FEC_VENCE_GARAN) _
          , obe.AC_NUM_CONTRATO _
          , obe.AC_PERIODICIDAD_DIAS _
          , IIf(obe.AC_FEC_VENCE_CON = String.Empty, DBNull.Value, obe.AC_FEC_VENCE_CON) _
          , obe.AC_DEPRE_INICIAL _
          , obe.AC_ES_TASA_PARTICULAR _
          , obe.AC_USUARIO _
          , obe.AC_TERMINAL _
          , obe.AC_FECREG _
          , obe.AC_ESTADO _
          , obe.AC_USUARIO_MOD _
          , obe.AC_TERMINAL_MOD _
          , obe.AC_FECREG_MOD _
          , obe.AC_VALOR_RESIDUAL _
          , obe.AC_NUM_COTIZA _
            , obe.AC_NUM_ORD_COMPRA _
            , obe.AC_AUTORIZA_ADQ _
            , obe.AC_IDORIGEN_REQ _
            , obe.AC_IDRESPON_ACTI _
      )


            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_ACTIVO_IMG", obe.AC_IDACTIVO)

            For Each img As ClsEntidades.AF_MA_ACTIVO_IMG In lis_img
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_ACTIVO_IMG", img.AI_IDACTIVO, img.AI_IMG, img.AI_NOM, img.AI_DES, img.AI_SEC, img.AI_FECREG)
            Next


            SqlHelper.ExecuteNonQuery(cn, "AF_SP_D_ACTIVO_FIC", obe.AC_IDACTIVO)

            For Each fic As ClsEntidades.AF_MA_ACTIVO_FIC In lis_fic
                SqlHelper.ExecuteNonQuery(cn, "AF_SP_I_ACTIVO_FIC", fic.AF_IDACTIVO, fic.AF_SEC, fic.AF_ARCHIVO, fic.AF_FICHA)
            Next

        End Sub

        Public Function get_Listado_01() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTIVO01").Tables(0)
        End Function

        Public Function get_Listado_02(idactivo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTIVO02", idactivo_).Tables(0)
        End Function

        Public Function get_Lista_Combos() As DataSet
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTIVO03")
        End Function

        Public Function get_Listado_04_calc_depre(fec_proc_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_S_ACTIVO04", fec_proc_).Tables(0)
        End Function


        Public Sub delete_periodo_depreciacion(anho_ As Integer, mes_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_O_DEL_DEPRE", anho_, mes_)
        End Sub

        Public Sub Calcular_Depreciacion(idactivo_ As Integer, anho_ As Integer, mes_ As Integer)
            SqlHelper.ExecuteNonQuery(cn, "AF_SP_O_CAL_DEPRECI", idactivo_)
        End Sub

        Public Function Procesar_Asiento_Contable(anho_ As Integer, mes_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_O_PROC_ASIENTO", anho_, mes_).Tables(0)
        End Function

        Public Function Procesar_Asiento_Contable_Planilla(codigo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_O_PROC_ASIENTO_PLANILLA", codigo_).Tables(0)
        End Function

        Public Function Procesar_Depreciacion_Anual(anho_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(cn, "AF_SP_O_PROC_DEPRE_ANUAL", anho_).Tables(0)
        End Function

        Public Function get_Lista_05_AyudaActivos() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_ACTIVO05").Tables(0)
        End Function

        Public Function get_Lista_07_inventario() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_ACTIVO07").Tables(0)
        End Function

        Public Function get_Listado_Activo_Reporte() As DataTable
            Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "AF_SP_S_ACTIVO08").Tables(0)
        End Function

    End Class


End Class
