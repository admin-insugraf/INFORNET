Imports LibConexion
Imports LibComunVar
Imports System.Data
Imports System.Data.SqlClient
Imports LibCobranzas
Imports System.Windows.Forms

Public Class ClsReporteGenerales
    Dim dtTable As DataTable
    Dim LibData As LibConexion.ClsData

    Dim cn As SqlConnection
    Dim dataBL As New LibConexion.ClsData

    Dim Adodc1 As DataTable
    Dim Adodc2 As DataTable
    Dim Adodc3 As DataTable
    Dim Adodc4 As DataTable
    Dim Adodc5 As DataTable

    Dim ntra, nConReg, nTotRec As Integer
    Public Const VGFConta = False

    Public Sub New()
        cn = dataBL.ConexionBD
    End Sub
    '-----Lotes
    Public Function Get_ImprimirReporte_Lotes_todos(ByVal IDE As String, ByVal Listaalmacen As List(Of String), ByVal fechaINI As String,
                   ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                   ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_DE_LOTES_LUSA_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), "", "", "0", "1", _
                              mesAnt, anoAnt, mesActual, anoAct, LOTE)

            For i As Integer = 0 To Listaalmacen.Count() - 1
                SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_DE_LOTES_LUSA", IDE, Listaalmacen(i), CInt(fechaINI), CInt(fechaFIN), "", "", "0", "1", _
                                     mesAnt, anoAnt, mesActual, anoAct, LOTE)
            Next

            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_DE_LOTES_LUSA_FINAL", IDE, "", CInt(fechaINI), CInt(fechaFIN), "", "", "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct, LOTE).Tables(0)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Get_ImprimirReporte_Stock_Mensual_Almacen(ByVal FAMILIA_ID As String, ByVal idLinea As String, ByVal mes As String, ByVal anio As String, ByVal fecha As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_STK_MENSUAL_ARTICULO_ALMACEN", FAMILIA_ID, idLinea, mes, anio, fecha).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Imprimir_Producto_Vencer(ByVal Almacen As String, ByVal prod_inicial As String, ByVal prod_final As String, ByVal fecha As String, _
                                                 ByVal familia As String, ByVal linea As String) As DataTable
        Try

            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_PROD_A_VENCER", Almacen, prod_inicial, prod_final, fecha, familia, linea).Tables(0)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Nombre_Empresa() As DataTable
        Try

            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_COMPANY").Tables(0)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Crear_Lista_Productos()
        Try
            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "AUDITORIA_SP_CREA_TABLA_PROD_ELEGIDOS")
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Inserta_Lista_Productos(ByVal _codigo As String, ByVal _descripcion As String)
        Try
            SqlHelper.ExecuteNonQuery(cn, "AUDITORIA_SP_INSERTA_TABLA_PROD_ELEGIDOS", _codigo, _descripcion)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Imprimir_Producto_Cuarentena_MP(ByVal familia As String, ByVal prod_inicial As String, ByVal prod_final As String) As DataTable
        Try
            Dim Dt_almacenes_Default_mp As New DataTable
            Dt_almacenes_Default_mp = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_ALMACEN_MP").Tables(0)
            If Dt_almacenes_Default_mp.Rows.Count() <> 0 Then
                Dim row As DataRow = Dt_almacenes_Default_mp.NewRow()
                row.Item("WAREHOUSE_DEFAULT") = "18" 'CUARENTENA MP
                Dt_almacenes_Default_mp.Rows.InsertAt(row, 0)
                For i As Integer = 0 To Dt_almacenes_Default_mp.Rows.Count() - 1
                    If Dt_almacenes_Default_mp.Rows(i).Item(0) = "26" Then
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_I", Dt_almacenes_Default_mp.Rows(i).Item(0).ToString)
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_II", Dt_almacenes_Default_mp.Rows(i).Item(0).ToString)
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_III", Dt_almacenes_Default_mp.Rows(i).Item(0).ToString)
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL_IV", Dt_almacenes_Default_mp.Rows(i).Item(0).ToString)
                    Else
                        SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", Dt_almacenes_Default_mp.Rows(i).Item(0).ToString)
                    End If
                Next
            End If
            Return SqlHelper.ExecuteDataset(cn, "RPT_ALM_REPORTE_PROD_CUARENTENA", familia, prod_inicial, prod_final).Tables(0)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Imprimir_Ingresos_Cuarentena(ByVal Fecha_ini As String, ByVal fecha_fin As String, ByVal familia As String, ByVal prod_inicial As String, ByVal prod_final As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_ALM_INGRESOS_CUARENTENA_PT", Fecha_ini, fecha_fin, familia, prod_inicial, prod_final).Tables(0)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function Imprimir_Producto_Cuarentena_PT(ByVal familia As String, ByVal prod_inicial As String, ByVal prod_final As String) As DataTable
        Try
            Dim Dt_almacenes_Default As New DataTable
            Dt_almacenes_Default = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "ALM_SP_S_ALMACEN_PT").Tables(0)
            If Dt_almacenes_Default.Rows.Count() <> 0 Then
                Dim row As DataRow = Dt_almacenes_Default.NewRow()
                row.Item("WAREHOUSE_DEFAULT") = "04" 'CUARENTENA PT
                Dt_almacenes_Default.Rows.InsertAt(row, 0)
                For i As Integer = 0 To Dt_almacenes_Default.Rows.Count() - 1
                    SqlHelper.ExecuteNonQuery(cn, "ACT_QTY_LOTE_2010_AL", Dt_almacenes_Default.Rows(i).Item(0).ToString)
                Next
            End If
            Return SqlHelper.ExecuteDataset(cn, "RPT_ALM_REPORTE_PROD_CUARENTENA_PT", familia, prod_inicial, prod_final).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Imprimir_Producto_Mayor_Venta(ByVal Fecha_ini As String, ByVal fecha_fin As String, ByVal familia As String, ByVal prod_inicial As String, ByVal prod_final As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "RPT_ALM_REPORTE_PROD_MAYOR_VENTA", Fecha_ini, fecha_fin, familia, prod_inicial, prod_final).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function




    Public Function Get_ImprimirReporte_Lotes(ByVal IDE As String, ByVal alma As String, ByVal fechaINI As String,
                       ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                       ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_DE_LOTES_LUSA_UNO", IDE, "", fechaINI, fechaFIN, "", "", "0", "1", _
                                mesAnt, anoAnt, mesActual, anoAct, LOTE)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_DE_LOTES_LUSA", IDE, alma, fechaINI, fechaFIN, "", "", "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct, LOTE)
            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_DE_LOTES_LUSA_FINAL", IDE, "", fechaINI, fechaFIN, "", "", "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct, LOTE).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



    ''SOLO UN ALMACEN CON UN LOTE ELEGIDO
    Public Function Get_ImprimirReporte_Articulos(ByVal IDE As String, ByVal alma As String, ByVal fechaINI As String,
                    ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                    ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            'SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
            '                    mesAnt, anoAnt, mesActual, anoAct)
            'SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX", IDE, alma, CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
            '                          mesAnt, anoAnt, mesActual, anoAct)
            'Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_FINAL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
            '                          mesAnt, anoAnt, mesActual, anoAct).Tables(0)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_CON_LOTES_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                  mesAnt, anoAnt, mesActual, anoAct, LOTE)

            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_CON_LOTES", IDE, alma, CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                     mesAnt, anoAnt, mesActual, anoAct, LOTE)
            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_CON_LOTES_FINAL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct, LOTE).Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    ''SIN LOTE CON UN ALMACEN
    Public Function Get_ImprimirReporte_Articulos_SIN_LOTE(ByVal IDE As String, ByVal alma As String, ByVal fechaINI As String,
                 ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                 ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX", IDE, alma, CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)
            Dim CSQL2 As String

            CSQL2 = "UPDATE A SET A.CAALMA=B.ID FROM [tempdb].dbo." & IDE & "KARDEXSQL A INNER JOIN dbo.WAREHOUSE B ON A.CAALMA=B.NAME"
            'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)

            CSQL2 = " UPDATE C SET C.NUM_ANALISIS=D.NUMBER_ANALIS from [tempdb].dbo." & IDE & "KARDEXSQL AS C  INNER JOIN  "
            CSQL2 = CSQL2 & " WAREHOUSE_TRANS_LINE AS D ON C.CODIGO=D.PART_ID   AND C.DELOTE=D.NUMBER_LOT and C.CAALMA=D.WAREHOUSE_ID AND C.CATD=D.DOCUMENT_ID AND C.CANUMDOC=D.NUMBER_DOCUMENT "
            'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)

            CSQL2 = " UPDATE C SET C.OPT_ENTREGA=E.IS_LOTE_A_FABRICAR from [tempdb].dbo." & IDE & "KARDEXSQL AS C INNER JOIN WAREHOUSE_TRANS AS E ON   "
            CSQL2 = CSQL2 & " C.CATD = E.DOCUMENT_ID AND C.CANUMDOC=E.NUMBER_DOCUMENT AND C.CATIPMOV=E.TYPE_TRANS AND C.CACODMOV=E.TRANS_ID AND C.CAALMA = E.WAREHOUSE_ID   "
            'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)

            CSQL2 = "UPDATE C SET C.NUM_ANALISIS=D.NUMBER_ANALIS,C.OPT_ENTREGA=E.IS_LOTE_A_FABRICAR from [tempdb].dbo." & IDE & "KARDEXSQL AS C "
            CSQL2 = CSQL2 & " INNER JOIN WAREHOUSE_TRANS AS E ON  C.CATD = E.DOCUMENT_ID AND C.CANUMDOC=E.NUMBER_DOCUMENT AND C.CATIPMOV=E.TYPE_TRANS AND C.CACODMOV=E.TRANS_ID AND C.CAALMA = E.WAREHOUSE_ID "
            CSQL2 = CSQL2 & " INNER JOIN WAREHOUSE_TRANS_LINE AS D ON E.WAREHOUSE_ID=D.WAREHOUSE_ID AND E.DOCUMENT_ID  = D.DOCUMENT_ID AND E.NUMBER_DOCUMENT =D.NUMBER_DOCUMENT AND C.CODIGO=D.PART_ID and C.CAALMA=D.WAREHOUSE_ID "
            'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)

            CSQL2 = "UPDATE  A SET A.CAALMA=B.ID +' '+B.NAME   FROM [tempdb].dbo." & IDE & "KARDEXSQL A INNER JOIN dbo.WAREHOUSE B ON A.CAALMA=B.ID"
            'SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)


            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_FINAL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct).Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_ImprimirReporte_Articulos_Balance_Alcohol(ByVal IDE As String, ByVal alma As String, ByVal fechaINI As String,
                 ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                 ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_UNO_BALANCE_ALCOHOL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX", IDE, alma, CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)

            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_FINAL_BALANCE_ALCOHOL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct).Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function



    Public Function Get_ImprimirReporte_Articulos_lotes(ByVal IDE As String, ByVal alma As String, ByVal fechaINI As String,
                   ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                   ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_CON_LOTES_UNO", IDE, alma, CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                mesAnt, anoAnt, mesActual, anoAct, LOTE)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_CON_LOTES", IDE, alma, CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct, LOTE)
            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_CON_LOTES_FINAL", IDE, alma, CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct, LOTE).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function


    'TODOS LOS ALMACENES CON UN LOTE
    Public Function Get_ImprimirReporte_Articulos_todos(ByVal IDE As String, ByVal ListaArticulos As List(Of String), ByVal fechaINI As String,
                ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
                ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_CON_LOTES_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                              mesAnt, anoAnt, mesActual, anoAct, LOTE)

            For i As Integer = 0 To ListaArticulos.Count() - 1
                SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_CON_LOTES", IDE, ListaArticulos(i), CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                     mesAnt, anoAnt, mesActual, anoAct, LOTE)
            Next
            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_CON_LOTES_FINAL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct, LOTE).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_ImprimirReporte_Stock_Mensual(ByVal FAMILIA_ID As String, ByVal idLinea As String, ByVal mes As String, ByVal anio As String, ByVal fecha As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_STK_MENSUAL_ARTICULO", FAMILIA_ID, idLinea, mes, anio, fecha).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_Rpt_Auditoria_Stock(ByVal _fecha_ini As String, ByVal _fecha_fin As String, ByVal _familia As String, ByVal _tipo_articulo As String, ByVal _opcion As String, ByVal _idalmacen As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "AUDITORIA_SP_S_STOCK_X_ALMACEN", _fecha_ini, _fecha_fin, _familia, _tipo_articulo, _idalmacen)
            Return SqlHelper.ExecuteDataset(cn, "AUDITORIA_SP_S_STOCK_X_ALMACEN_LISTA", _opcion).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Function


    Public Function Get_ImprimirReporte_Stock_Lotes_Mensual(ByVal idalmacen As String, ByVal fechaINI As String, ByVal fechaFIN As String, ByVal ArtIni As String, ByVal ArtFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_STK_MENSUAL_LOTE_ARTICULO", idalmacen, fechaINI, fechaFIN, ArtIni, ArtFin).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_ImprimirReporte_Stock_General(ByVal idalmacen As String, ByVal ArtIni As String, ByVal ArtFin As String) As DataTable
        Try
            Return SqlHelper.ExecuteDataset(cn, "ALM_SP_S_STK_ARTICULO_GENERAL", idalmacen, ArtIni, ArtFin).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    '' SIN LOTE TODOS LOS ALMACENES
    Public Function Get_ImprimirReporte_Articulos_lotes_todos(ByVal IDE As String, ByVal ListaArticulos As List(Of String), ByVal fechaINI As String,
             ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
             ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                              mesAnt, anoAnt, mesActual, anoAct)

            For i As Integer = 0 To ListaArticulos.Count() - 1
                SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX", IDE, ListaArticulos(i), CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                     mesAnt, anoAnt, mesActual, anoAct)
            Next

            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_DOS", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_TRES", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_CUATRO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)

            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_FINAL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_ImprimirReporte_Articulos_lotes_todos_Balances_Alcohol(ByVal IDE As String, ByVal ListaArticulos As List(Of String), ByVal fechaINI As String,
             ByVal fechaFIN As String, ByVal ART1 As String, ByVal ART2 As String, ByVal TODOSMOV As String, ByVal TODOS As String,
             ByVal mesAnt As String, ByVal anoAnt As String, ByVal mesActual As String, ByVal anoAct As String, ByVal LOTE As String) As DataTable
        Try
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                              mesAnt, anoAnt, mesActual, anoAct)

            For i As Integer = 0 To ListaArticulos.Count() - 1
                SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX", IDE, ListaArticulos(i), CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                     mesAnt, anoAnt, mesActual, anoAct)
            Next

            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_UNO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_DOS", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_TRES", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_FINAL_CUATRO", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct)

            Return SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_FINAL", IDE, "", CInt(fechaINI), CInt(fechaFIN), ART1, ART2, "0", "1", _
                                      mesAnt, anoAnt, mesActual, anoAct).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function
    Public Function Get_ImprimirReporte_kardex_lote(ByVal TYPE_PART As String, ByVal FAMILY As String, ByVal WHO_ID As String, ByVal LOTE As String)
        Try
            Dim query As String = String.Empty
            SqlHelper.ExecuteNonQuery(cn, "ALM_SP_S_WAREHOUSE_KADEX_LOTE", TYPE_PART, FAMILY, LOTE)

            If WHO_ID = String.Empty Then
                query = "SELECT * FROM T_Reportes_Stock_Almacenes"
            Else
                query = "SELECT * FROM T_Reportes_Stock_Almacenes WHERE WAREHOUSE_ID  in (" & WHO_ID & ")"
            End If
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Function

    '''' REPORTE DE RECALCULO DE STOCK

    Public Function UltimoCierre() As String
        Dim dtmonth As DataTable
        dtmonth = New DataTable
        dtmonth = SqlHelper.ExecuteDataset(cn, "RPT_R_STOCK_CIERRE_MES").Tables(0)

        If dtmonth.Rows.Count() <> 0 Then
            UltimoCierre = dtmonth.Rows(0).Item("Tot").ToString
        Else
            UltimoCierre = ""
        End If
    End Function

    Public Function Get_ImprimirReporte_Recalculo_Stock(ByVal IDE As String, ByVal Almacen As String, fechaINI As String, _
                                              ByVal fechaFIN As String, ByVal todos As String, ByVal progreso As ProgressBar) As DataTable
        Try
            Dim dtmes As DataTable
            dtmes = New DataTable
            Dim cMesActu = String.Empty
            Dim cMesCirr As String = String.Empty
            Dim mes_actual As String = String.Empty
            Dim ano_actual As String = String.Empty
            Dim cAnoMes As String = String.Empty

            Dim mes_Ant As String = String.Empty
            Dim ano_Ant As String = String.Empty
            Dim mesPost As String = String.Empty
            Dim anoPost As String = String.Empty
            'creando tabla Temporal
            SqlHelper.ExecuteNonQuery(cn, CommandType.StoredProcedure, "RPT_R_STOCK_CREAR_MES")
            'Insertando datos tabla
            Dim i As Integer = 0
            Dim Fechainicial As String = String.Empty
            Do While CDate(fechaINI) <= CDate(fechaFIN)
                Fechainicial = (DateDiff("d", fechaINI, "01/01/1900") * -1)
                SqlHelper.ExecuteNonQuery(cn, "RPT_R_STOCK_MES", Fechainicial)
                fechaINI = DateAdd("M", 1, fechaINI)
                i = i + 1
            Loop
            'Recorriendo datos de los meses
            dtmes = SqlHelper.ExecuteDataset(cn, "RPT_R_STOCK_GET_MES").Tables(0)
            For j As Integer = 0 To dtmes.Rows.Count() - 1
                mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                ano_actual = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                cMesCirr = UltimoCierre()
                cAnoMes = ano_actual & mes_actual
                If cMesCirr <> "" Then
                    If cAnoMes <= cMesCirr Then
                        MsgBox("Hay meses cerrados en el rango de fechas", vbInformation, "Aviso")
                        Exit Try
                    End If
                End If
            Next
            progreso.Minimum = 0
            progreso.Maximum = 100
            For j As Integer = 0 To dtmes.Rows.Count() - 1
                progreso.Value = j
                mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                If Month(dtmes.Rows(j).Item("FECHAS")) = 1 Then
                    mes_Ant = "12"
                    mes_actual = "01"
                    ano_Ant = Format(Year(dtmes.Rows(j).Item("FECHAS")) - 1, "0000")
                    ano_actual = Year(dtmes.Rows(j).Item("FECHAS"))
                    mesPost = "02"
                    anoPost = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                Else
                    mes_Ant = Format(Month(dtmes.Rows(j).Item("FECHAS")) - 1, "00")
                    mes_actual = Format(Month(dtmes.Rows(j).Item("FECHAS")), "00")
                    ano_Ant = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    ano_actual = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    mesPost = Format(Month(DateAdd("M", 1, dtmes.Rows(j).Item("FECHAS"))), "00")
                    If mes_actual = "12" Then
                        anoPost = Year(DateAdd("YYYY", 1, dtmes.Rows(j).Item("FECHAS")))
                    Else
                        anoPost = Format(Year(dtmes.Rows(j).Item("FECHAS")), "0000")
                    End If
                End If
                SqlHelper.ExecuteNonQuery(cn, "INV_RECALCULO_STOCK", IDE, Almacen, mes_Ant, ano_Ant, mes_actual, ano_actual, "", "", 0)
                progreso.PerformStep()
            Next

            SqlHelper.ExecuteNonQuery(cn, "INV_RECALCULO_STOCK_ARTICULOS", Almacen, mesPost, anoPost)

            dtmes = SqlHelper.ExecuteDataset(cn, "ALM_SP_U_COSTO_ULTIMO").Tables(0)
            For j As Integer = 0 To dtmes.Rows.Count() - 1
                SqlHelper.ExecuteNonQuery(cn, CommandType.Text, "UPDATE dbo.PART_QTY SET LAST_PRICE=" & CDbl(dtmes.Rows(j).Item("AMOUNT").ToString) & " WHERE PART_ID='" & dtmes.Rows(j).Item("PART_ID").ToString & "'")
            Next

            progreso.Value = 100
        Catch ex As Exception
            Throw
            ex.Message.ToString()
        End Try
    End Function

    ''INVENTARIO VALORIZADO MENSUAL

    Function AnioMesAnterior(ByVal arAnioMes As String) As String
        Dim cadena As String = String.Empty
        Dim LMes, LAnio As String
        Try
            If Val(Mid(arAnioMes, 5, 2)) = 1 Then
                LAnio = Val(Left(arAnioMes, 4)) - 1
                LMes = 12
            Else
                LAnio = Val(Left(arAnioMes, 4))
                LMes = Val(Mid(arAnioMes, 5, 2)) - 1
            End If
            cadena = LAnio & LMes.PadLeft(2, "0")
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
        Return cadena
    End Function


    Private Sub LoadIngresoSalida(ByVal IDE As String, ByVal arCod As String, fechaini As String, ByVal moneda As String)
        Dim tcamb As Double
        Dim cCod As String
        Dim cAnoMes As String
        Dim CSQL2 As String = String.Empty
        Dim nSaldo As Double, nCosPro As Double
        Dim nPrecio As Double, nCantid As Double
        Dim flagError As Boolean
        Dim VALMOV, VALANTE As Double
        Dim saldoVal As Double
        Dim Fecha As String = String.Empty
        flagError = False

        cAnoMes = Format(Year(CDate(fechaini)), "0000") & Format(CDate(fechaini).Month, "00")
        cCod = ""
        Dim result() As DataRow = Adodc1.Select("PART_ID='" & arCod & "'")
        nSaldo = 0 : nCosPro = 0

        If result.Count() <> 0 Then
            nConReg = nConReg + 1
        Else
            nConReg = nConReg + 1
            Dim row() As DataRow = Adodc2.Select("PART_ID = '" & arCod & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "'")
            If row.Count() <> 0 Then
                For Each item As DataRow In Adodc2.Select("PART_ID = '" & arCod & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "'")
                    nSaldo = Math.Round(IIf(item("QTY_INITIAL").ToString = "", 0, item("QTY_INITIAL")) + (IIf(item("QTY_ENTER").ToString = "", 0, item("QTY_ENTER"))) - (IIf(item("QTY_OUT").ToString = "", 0, item("QTY_OUT"))), 6)
                    If moneda = "ME" Then
                        nCosPro = Math.Round(item("AMOUNT_US"), 6)
                    ElseIf moneda = "MN" Then
                        nCosPro = Math.Round(IIf(item("AMOUNT").ToString = "", 0, item("AMOUNT")), 6)
                    End If
                    saldoVal = Math.Round(nCosPro * nSaldo, 6)
                    Fecha = String.Empty
                    Fecha = (DateDiff("d", DateAdd("d", -1, "01/" & Right(cAnoMes, 2) & "/" & Left(cAnoMes, 4)), "01/01/1900") * -1)

                    CSQL2 = "INSERT INTO [tempdb].dbo." & IDE & "INVENTORY (ITEM,PART_ID,DOCUMENT_DATE,TIME,IS_IN_OUT,TRANS_ID,TYPE_DOC,WAREHOUSE_ID,NUMBER_DOC,QTY_INITIAL,UNIT_PRICE,INIT_VALUE,AVERAGE_COST)"
                    CSQL2 = CSQL2 & " values (0,'" & arCod & "'," & Fecha & ",'','I','','','',''," & nSaldo & "," & nCosPro & "," & saldoVal & "," & nCosPro & ")"
                    'Guardando data
                    SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)
                Next
            Else
                nSaldo = 0 : nCosPro = 0
            End If
        End If

        For Each item As DataRow In Adodc1.Select("PART_ID='" & arCod & "'")


            If IIf(item("CURRENCY_EXCHANGE").ToString = "", 0, item("CURRENCY_EXCHANGE")) <> 0 Then
                tcamb = IIf(item("CURRENCY_EXCHANGE").ToString = "", 0, item("CURRENCY_EXCHANGE"))
            Else
                'If VGFConta = True Then 'conta
                '    tcamb = Val(DllFunc.Devolver_Dato1(cconexconf, Adodc1("DATE_DOCUMENT"), "CURRENCY_EXCHANGE ", "CURRENCY_DATE", True, "SELL_RATE", "ME", "CURRENCY_ID"))
                'Else 'bdcomun
                '    tcamb = Val(DllFunc.Devolver_Dato1(cconexconf, Adodc1("DATE_DOCUMENT"), "CURRENCY_EXCHANGE ", "CURRENCY_DATE", True, "SELL_RATE", "ME", "CURRENCY_ID"))
                'End If
            End If

            If cCod <> item("PART_ID").ToString Then

                nPrecio = 0 : nCantid = 0 : nSaldo = 0 : nCosPro = 0

                Dim rows() As DataRow = Adodc2.Select("PART_ID='" & item("PART_ID").ToString & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "'")
                If rows.Count() <> 0 Then
                    For Each items As DataRow In Adodc2.Select("PART_ID = '" & item("PART_ID").ToString & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "'")
                        'nSaldo = Math.Round(IIf(items("QTY_INITIAL") = "", 0, items("QTY_INITIAL")) + (items("QTY_ENTER")) - items("QTY_OUT"), 6)
                        nSaldo = Math.Round(IIf(items("QTY_INITIAL").ToString = "", 0, items("QTY_INITIAL")) + (IIf(items("QTY_ENTER").ToString = "", 0, items("QTY_ENTER"))) - (IIf(items("QTY_OUT").ToString = "", 0, items("QTY_OUT"))), 6)
                        If moneda = "ME" Then
                            nCosPro = Math.Round(items("AMOUNT_US"), 6)
                        ElseIf moneda = "MN" Then
                            nCosPro = Math.Round(items("AMOUNT"), 6)
                        End If
                        saldoVal = Math.Round(nCosPro * nSaldo, 6)
                        Fecha = String.Empty
                        Fecha = (DateDiff("d", DateAdd("d", -1, "01/" & Right(cAnoMes, 2) & "/" & Left(cAnoMes, 4)), "01/01/1900") * -1)

                        CSQL2 = "INSERT INTO [tempdb].dbo." & IDE & "INVENTORY (ITEM,PART_ID,DOCUMENT_DATE,TIME,IS_IN_OUT,TRANS_ID,TYPE_DOC,WAREHOUSE_ID,NUMBER_DOC,QTY_INITIAL,UNIT_PRICE,INIT_VALUE,AVERAGE_COST)"
                        CSQL2 = CSQL2 & " values (0,'" & arCod & "'," & Fecha & ",'','I','','','',''," & nSaldo & "," & nCosPro & "," & saldoVal & "," & nCosPro & ")"
                        ''Guardando data
                        SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)
                    Next
                Else
                    nSaldo = 0 : nCosPro = 0
                End If
                VALANTE = Math.Round(saldoVal, 6)
            End If
            nCantid = IIf(item("QTY").ToString = "", 0, item("QTY"))
            '----
            If moneda = "ME" Then
                If Math.Round(tcamb, 3) > 0 Then
                    If item("CURRENCY_EXCHANGE").ToString = "ME" Then
                        nPrecio = Math.Round(item("AVERAGE_COST"), 6)
                    Else
                        nPrecio = Math.Round(item("AVERAGE_COST") / tcamb, 6)
                    End If
                Else
                    nPrecio = 0
                End If

            ElseIf moneda = "MN" Then

                If item("CURRENCY_EXCHANGE").ToString = "ME" Then
                    nPrecio = Math.Round(item("AVERAGE_COST").ToString * tcamb, 6)
                Else
                    nPrecio = Math.Round(IIf(item("AVERAGE_COST").ToString = "", 0, item("AVERAGE_COST")), 6)
                End If
            End If

            If item("TYPE_TRANS").ToString = "I" Then
                nSaldo = Format(nSaldo + nCantid, "0.000000")

                If item("TRANS_ID1").ToString = "AJ" And nCantid = 0 Then
                    VALMOV = Math.Round(1 * IIf(item("STATUS_VALUE").ToString = True, nPrecio, nCosPro), 6)
                Else
                    VALMOV = Math.Round(nCantid * IIf(item("STATUS_VALUE").ToString = True, nPrecio, nCosPro), 6)
                End If
            Else
                nSaldo = Format(nSaldo - nCantid, "0.000000")
                If item("TRANS_ID1").ToString = "AJ" And nCantid = 0 Then
                    VALMOV = Math.Round(1 * IIf(item("DOCUMENT_ID").ToString = "NS" And item("TRANS_ID1").ToString = "AJ", nPrecio, nCosPro), 6) 'marco nPrecio,nCosPro
                Else
                    VALMOV = Math.Round(nCantid * IIf(item("STATUS_VALUE").ToString = True, nPrecio, nCosPro), 6)
                End If
            End If

            If item("TYPE_TRANS").ToString = "I" And item("DOCUMENT_ID").ToString <> "NC" And item("STATUS_VALUE") = True Then
                If nSaldo <> 0 Then
                    nCosPro = Math.Round((Math.Round(VALMOV + VALANTE, 6)) / nSaldo, 6)
                End If
            ElseIf item("TYPE_TRANS").ToString = "S" And item("DOCUMENT_ID").ToString = "NS" Then  'And Adodc1("CACODMOV") = "AJ"
                If nSaldo <> 0 Then
                    nCosPro = Math.Round((Math.Round(VALANTE - VALMOV, 6)) / nSaldo, 6)
                End If
            End If
            '-------
            If item("TYPE_TRANS").ToString = "I" Then

                Fecha = String.Empty
                Fecha = (DateDiff("d", CDate(item("DATE_DOCUMENT")), "01/01/1900") * -1)


                CSQL2 = "Insert Into [tempdb].dbo." & IDE & "INVENTORY(ITEM,PART_ID,DOCUMENT_DATE,TIME,IS_IN_OUT,TRANS_ID,TYPE_DOC,WAREHOUSE_ID,NUMBER_DOC,QTY_INITIAL,QTY_IN,QTY_OUT,QTY_BALANCE,UNIT_PRICE,INIT_VALUE,IN_VALUE,OUT_VALUE,END_VALUE,AVERAGE_COST)  "
                CSQL2 = CSQL2 & " Values ('" & item("ITEM").ToString & "','" & item("PART_ID").ToString & "'," & Fecha & ",'" & item("HOUR").ToString & "','" & item("TYPE_TRANS").ToString & "','" & item("TRANS_ID1").ToString & "',"
                CSQL2 = CSQL2 & "'" & item("DOCUMENT_ID").ToString & "','" & item("WAREHOUSE_ID").ToString & "','" & item("NUMBER_DOCUMENT").ToString & "',0," & item("QTY").ToString & ",0"
                CSQL2 = CSQL2 & "," & nSaldo & "," & IIf(item("STATUS_VALUE") = False Or item("DOCUMENT_ID").ToString = "NC", nCosPro, nPrecio) & ",0," & VALMOV & ",0"
                CSQL2 = CSQL2 & "," & VALANTE + VALMOV & "," & nCosPro & ")"

            ElseIf item("TYPE_TRANS").ToString = "S" Then

                Fecha = String.Empty
                Fecha = (DateDiff("d", CDate(item("DATE_DOCUMENT")), "01/01/1900") * -1)

                CSQL2 = "Insert Into [tempdb].dbo." & IDE & "INVENTORY(ITEM,PART_ID,DOCUMENT_DATE,TIME,IS_IN_OUT,TRANS_ID,TYPE_DOC,WAREHOUSE_ID,NUMBER_DOC,QTY_INITIAL,QTY_IN,QTY_OUT,QTY_BALANCE,UNIT_PRICE,INIT_VALUE,IN_VALUE,OUT_VALUE,END_VALUE,AVERAGE_COST)  "
                CSQL2 = CSQL2 & " Values ('" & item("ITEM").ToString & "','" & item("PART_ID").ToString & "'," & Fecha & ",'" & item("HOUR").ToString & "','" & item("TYPE_TRANS").ToString & "','" & item("TRANS_ID1").ToString & "',"
                CSQL2 = CSQL2 & "'" & item("DOCUMENT_ID").ToString & "','" & item("WAREHOUSE_ID").ToString & "','" & item("NUMBER_DOCUMENT").ToString & "',0,0,"
                CSQL2 = CSQL2 & IIf(item("TYPE_TRANS").ToString = "S", item("QTY").ToString, 0) & "," & nSaldo & "," & IIf(item("DOCUMENT_ID").ToString = "NS" And item("STATUS_VALUE").ToString = True, nPrecio, nCosPro)
                If item("TRANS_ID").ToString = "AJ" And nCantid = 0 Then
                    CSQL2 = CSQL2 & ",0,0," & IIf(item("DOCUMENT_ID").ToString = "NS" And item("STATUS_VALUE") = True, nPrecio * 1, nCosPro * IIf(nCantid = 0, 1, nCantid))
                Else
                    CSQL2 = CSQL2 & ",0,0," & IIf(item("DOCUMENT_ID").ToString = "NS" And item("STATUS_VALUE") = True, nPrecio * nCantid, nCosPro * IIf(nCantid = 0, 1, nCantid))
                End If
                CSQL2 = CSQL2 & "," & VALANTE - VALMOV & "," & nCosPro & ")"
            End If
            VALANTE = Math.Round(IIf(item("TYPE_TRANS").ToString = "I", VALANTE + VALMOV, VALANTE - VALMOV), 6)
            ntra = 1
            ''Guardando data
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)
            cCod = Trim(item("PART_ID").ToString)
        Next
        Exit Sub
    End Sub

    Public Function Get_ImprimirReporte_Inventario_Valorizado(ByVal IDE As String, fechaINI As String, _
                                              ByVal articuloIni As String, ByVal articuloFin As String, ByVal TipoPart As String, ByVal moneda As String, _
                                              ByVal progreso As ProgressBar) As DataTable
        Try
            Dim dtMaeart As DataTable
            dtMaeart = New DataTable


            Dim cMesActu = String.Empty
            Dim cMesCirr As String = String.Empty
            Dim mes_actual As String = String.Empty
            Dim ano_actual As String = String.Empty
            Dim cAnoMes As String = String.Empty
            Dim EstiloReporte As String = String.Empty

            'creando tabla Temporal
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_INVENTARIO_VAL_MENSUAL", IDE & "INVENTORY", "0", "", "", "", "", "", "", "")

            cAnoMes = Format(CDate(fechaINI).Year, "0000") & Format(CDate(fechaINI).Month, "00")
            Dim YEAR_ACTUAL As Integer, YEAR_ANTERIOR As Integer
            YEAR_ACTUAL = Format(CDate(fechaINI).Year, "0000")
            YEAR_ANTERIOR = YEAR_ACTUAL - 1

            Adodc1 = New DataTable
            Adodc1 = SqlHelper.ExecuteDataset(cn, "INV_RPT_INVENTARIO_VAL_MENSUAL", "", "1", Format(CDate(fechaINI).Month, "00") _
                                       , Format(CDate(fechaINI).Year, "0000"), articuloIni, articuloFin, TipoPart, "", "").Tables(0)

            Adodc4 = New DataTable
            Adodc4 = SqlHelper.ExecuteDataset(cn, "INV_RPT_INVENTARIO_VAL_MENSUAL", "", "1", Format(CDate(fechaINI).Month, "00") _
                                 , Format(CDate(fechaINI).Year, "0000"), articuloIni, articuloFin, TipoPart, "", "").Tables(0)


            Adodc2 = New DataTable
            Adodc2 = SqlHelper.ExecuteDataset(cn, "INV_RPT_INVENTARIO_VAL_MENSUAL", "", "2", "", "", _
                                      articuloIni, articuloFin, "", AnioMesAnterior(cAnoMes), cAnoMes).Tables(0)

            Adodc3 = New DataTable
            Adodc3 = SqlHelper.ExecuteDataset(cn, "INV_RPT_INVENTARIO_VAL_MENSUAL", "", "3", "", "", _
                                      articuloIni, articuloFin, "", AnioMesAnterior(cAnoMes), cAnoMes).Tables(0)


            'Recorriendo los datos
            dtMaeart = SqlHelper.ExecuteDataset(cn, "INV_RPT_INVENTARIO_VAL_MENSUAL", "", "4", "", "", articuloIni, articuloFin, TipoPart, "", "").Tables(0)
            progreso.Minimum = 0
            progreso.Maximum = dtMaeart.Rows.Count()
            If dtMaeart.Rows.Count() <> 0 Then
                For j As Integer = 0 To dtMaeart.Rows.Count() - 1
                    progreso.Value = j
                    'MsgBox(j)
                    LoadIngresoSalida(IDE, dtMaeart.Rows(j).Item("PART_ID").ToString, fechaINI, moneda)
                    progreso.PerformStep()
                Next
            Else
                MsgBox("No existe información a procesar en el mes seleccionado", vbInformation, "Aviso")
                Exit Try
            End If
            Adodc5 = New DataTable
            Adodc5 = SqlHelper.ExecuteDataset(cn, "INV_RPT_INVENTARIO_VAL_MENSUAL", IDE & "INVENTORY", "5", "", "", "", "", "", "", "").Tables(0)
            progreso.Value = dtMaeart.Rows.Count()
            Return Adodc5
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_DatosPart(ByVal CadenaConsulta As String)
        Try
            Dim query As String = String.Empty
            query = CadenaConsulta
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function

    ''INVENTARIOS DE DOCUMENTOS
    ''DOCUMENTOS DE ALMACEN

    Public Function Get_ImprimirReporte_Documentos_Almacen(ByVal fechaINI As String, ByVal fechaFIN As String, ByVal Almacen As String, ByVal TipoMov As String, _
                                ByVal Mov_inicial As String, ByVal Mov_final As String) As DataTable
        Try
            Dim f_Ini, f_Fin As String
            f_Ini = String.Empty
            f_Fin = String.Empty
            'Fecha  en formato Numerico
            f_Ini = (DateDiff("d", CDate(fechaINI), "01/01/1900") * -1)
            f_Fin = (DateDiff("d", CDate(fechaFIN), "01/01/1900") * -1)

            If TipoMov = String.Empty Then
                Return SqlHelper.ExecuteDataset(cn, "RPT_INV_DOCUMENTOS_ALMACEN", CInt(f_Ini), CInt(f_Fin), Almacen, "", "", "", "0").Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(cn, "RPT_INV_DOCUMENTOS_ALMACEN", CInt(f_Ini), CInt(f_Fin), Almacen, TipoMov, Mov_inicial, Mov_final, "1").Tables(0)
            End If
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Get_DatosMovimientos(ByVal CadenaConsulta As String)
        Try
            Dim query As String = String.Empty
            query = CadenaConsulta
            Return SqlHelper.ExecuteDataset(cn, CommandType.Text, query).Tables(0)
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function

    ''INVENTARIOS DE DOCUMENTOS
    ''RESUMEN DE TRANSACCIONES POR ARTICULO

    Private Sub LoadIngresoSalidaKardexArticulo(ByVal IDE As String, ByVal arCod As String, fechaini As String, ByVal moneda As String, _
                                                ByVal Almacen As String)
        Dim tcamb As Double
        Dim cCod As String
        Dim cAnoMes As String
        Dim CSQL2 As String = String.Empty
        Dim nSaldo As Double, nCosPro As Double
        Dim nSaldo2 As Double
        Dim nCantid2 As Double
        Dim nPrecio As Double, nCantid As Double
        Dim flagError As Boolean
        Dim VALMOV, VALANTE As Double
        Dim saldoVal As Double
        Dim Fecha As String = String.Empty
        flagError = False
        Dim X As Integer = 0

        cAnoMes = Format(Year(CDate(fechaini)), "0000") & Format(CDate(fechaini).Month, "00")
        cCod = ""
        Dim result() As DataRow = Adodc1.Select("PART_ID='" & arCod & "'")
        Dim Consul() As DataRow = Adodc4.Select("PART_ID='" & arCod & "'")
        nSaldo = 0 : nCosPro = 0
        nSaldo2 = 0

        If result.Count() <> 0 Then
            nConReg = nConReg + 1
        Else
            nConReg = nConReg + 1
            '----2
            Dim item2() As DataRow = Adodc2.Select("PART_ID = '" & arCod & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "'")
            '----3
            Dim item3() As DataRow = Adodc3.Select("PART_ID = '" & arCod & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "' AND WAREHOUSE_ID='" & Almacen & "'")

            If item2.Count() <> 0 Then
                nSaldo = Math.Round(IIf(String.IsNullOrEmpty(item2(0)("QTY_INITIAL").ToString), 0, item2(0)("QTY_INITIAL")) + (IIf(item2(0)("QTY_ENTER").ToString = "", 0, item2(0)("QTY_ENTER"))) - (IIf(item2(0)("QTY_OUT").ToString = "", 0, item2(0)("QTY_OUT"))), 6)
                '-----Recorriendo el datatable 3
                If item3.Count() <> 0 Then
                    nSaldo2 = Math.Round(IIf(item3(0)("QTY_INITIAL").ToString = "", 0, item3(0)("QTY_INITIAL")) + (IIf(item3(0)("QTY_ENTER").ToString = "", 0, item3(0)("QTY_ENTER"))) - (IIf(item3(0)("QTY_OUT").ToString = "", 0, item3(0)("QTY_OUT"))), 6)

                    If item3(0)("WAREHOUSE_ID").ToString = Almacen Then
                        If moneda = "ME" Then
                            nCosPro = Math.Round(item3(0)("AMOUNT_US"), 6)
                        ElseIf moneda = "MN" Then
                            nCosPro = Math.Round(IIf(item3(0)("AMOUNT").ToString = "", 0, item3(0)("AMOUNT")), 6)
                        End If
                    Else
                        If moneda = "ME" Then
                            nCosPro = Math.Round(IIf(item2(0)("AMOUNT_US").ToString = "", 0, item2(0)("AMOUNT_US")), 6)
                        ElseIf moneda = "MN" Then
                            nCosPro = Math.Round(IIf(item2(0)("AMOUNT").ToString = "", 0, item2(0)("AMOUNT")), 6)
                        End If
                    End If
                Else
                    If moneda = "ME" Then
                        nCosPro = Math.Round(IIf(item2(0)("AMOUNT_US").ToString = "", 0, item2(0)("AMOUNT_US")), 6)
                    ElseIf moneda = "MN" Then
                        nCosPro = Math.Round(IIf(item2(0)("AMOUNT").ToString = "", 0, item2(0)("AMOUNT")), 6)
                    End If
                End If
            Else
                nSaldo = 0 : nCosPro = 0
                nSaldo2 = 0
            End If
        End If
        X = 0
        ''Recorriendo el Primer Datatable 
        For Each item As DataRow In Adodc1.Select("PART_ID='" & arCod & "'")
            If IIf(item("CURRENCY_EXCHANGE").ToString = "", 0, item("CURRENCY_EXCHANGE")) <> 0 Then
                tcamb = IIf(item("CURRENCY_EXCHANGE").ToString = "", 0, item("CURRENCY_EXCHANGE"))
            Else
                'If VGFConta = True Then 'conta
                '    tcamb = Val(DllFunc.Devolver_Dato1(cconexconf, Adodc1("DATE_DOCUMENT"), "CURRENCY_EXCHANGE ", "CURRENCY_DATE", True, "SELL_RATE", "ME", "CURRENCY_ID"))
                'Else 'bdcomun
                '    tcamb = Val(DllFunc.Devolver_Dato1(cconexconf, Adodc1("DATE_DOCUMENT"), "CURRENCY_EXCHANGE ", "CURRENCY_DATE", True, "SELL_RATE", "ME", "CURRENCY_ID"))
                'End If
            End If

            If cCod <> item("PART_ID").ToString Then
                nPrecio = 0 : nCantid = 0 : nSaldo = 0 : nCosPro = 0
                nSaldo2 = 0
                Dim item2() As DataRow = Adodc2.Select("PART_ID='" & item("PART_ID").ToString & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "'")
                Dim item3() As DataRow = Adodc3.Select("PART_ID = '" & arCod & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "' AND WAREHOUSE_ID='" & Almacen & "'")

                '--    '-----Recorriendo el datatable 2
                If item2.Count() <> 0 Then
                    nSaldo = Math.Round(IIf(item2(0)("QTY_INITIAL").ToString = "", 0, item2(0)("QTY_INITIAL")) + (IIf(item2(0)("QTY_ENTER").ToString = "", 0, item2(0)("QTY_ENTER"))) - (IIf(item2(0)("QTY_OUT").ToString = "", 0, item2(0)("QTY_OUT"))), 6)

                    '-----Recorriendo el datatable 3
                    If item3.Count() <> 0 Then
                        nSaldo2 = Math.Round(IIf(item3(0)("QTY_INITIAL").ToString = "", 0, item3(0)("QTY_INITIAL")) + (IIf(item3(0)("QTY_ENTER").ToString = "", 0, item3(0)("QTY_ENTER"))) - (IIf(item3(0)("QTY_OUT").ToString = "", 0, item3(0)("QTY_OUT"))), 6)

                        If item3(0)("WAREHOUSE_ID").ToString = Almacen Then
                            If moneda = "ME" Then
                                nCosPro = Math.Round(IIf(String.IsNullOrEmpty(item3(0)("AMOUNT_US").ToString), 0, item3(0)("AMOUNT_US")), 6)
                            ElseIf moneda = "MN" Then
                                nCosPro = Math.Round(IIf(String.IsNullOrEmpty(item3(0)("AMOUNT").ToString), 0, item3(0)("AMOUNT")), 6)
                            End If
                        Else
                            If moneda = "ME" Then
                                nCosPro = Math.Round(IIf(String.IsNullOrEmpty(item2(0)("AMOUNT_US").ToString), 0, item2(0)("AMOUNT_US")), 6)
                            ElseIf moneda = "MN" Then
                                nCosPro = Math.Round(IIf(String.IsNullOrEmpty(item2(0)("AMOUNT").ToString), 0, item2(0)("AMOUNT")), 6)
                            End If
                        End If
                    Else
                        If moneda = "ME" Then
                            nCosPro = Math.Round(IIf(String.IsNullOrEmpty(item2(0)("AMOUNT_US").ToString), 0, item2(0)("AMOUNT_US")), 6)
                        ElseIf moneda = "MN" Then
                            nCosPro = Math.Round(IIf(String.IsNullOrEmpty(item2(0)("AMOUNT").ToString), 0, item2(0)("AMOUNT")), 6)
                        End If
                    End If

                    'If Not Adodc3.EOF Then nSaldo2 = IIf(IsNull(Adodc3!QTY_INITIAL), 0, Adodc3!QTY_INITIAL) + (DllFunc.ESNULO(Adodc3!QTY_ENTER, 0) - DllFunc.ESNULO(Adodc3!QTY_OUT, 0))

                    'If Adodc3.EOF Then
                    '    nCosPro = IIf(Combo3.ListIndex <> 0, Adodc2("AMOUNT_US"), Adodc2("AMOUNT"))
                    'ElseIf Adodc3("WAREHOUSE_ID") = Almacen Then
                    '    nCosPro = IIf(Combo3.ListIndex <> 0, Adodc3("AMOUNT_US"), Adodc3("AMOUNT"))
                    'Else
                    '    nCosPro = IIf(Combo3.ListIndex <> 0, Adodc2("AMOUNT_US"), Adodc2("AMOUNT"))
                    'End If
                    'End If
                    'For Each item2 As DataRow In Adodc2.Select("PART_ID = '" & arCod & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "'")
                    '    nSaldo = Math.Round(IIf(item2("QTY_INITIAL").ToString = "", 0, item2("QTY_INITIAL")) + (IIf(item2("QTY_ENTER").ToString = "", 0, item2("QTY_ENTER"))) - (IIf(item2("QTY_OUT").ToString = "", 0, item2("QTY_OUT"))), 6)
                    '    '-----Recorriendo el datatable 3 
                    '    If row.Count() <> 0 Then


                    '        'For Each item3 As DataRow In Adodc3.Select("PART_ID = '" & arCod & "' AND YEAR_MONTH='" & AnioMesAnterior(cAnoMes) & "' AND WAREHOUSE_ID='" & Almacen & "'")
                    '        '    nSaldo2 = Math.Round(IIf(item3("QTY_INITIAL").ToString = "", 0, item3("QTY_INITIAL")) + (IIf(item3("QTY_ENTER").ToString = "", 0, item3("QTY_ENTER"))) - (IIf(item3("QTY_OUT").ToString = "", 0, item3("QTY_OUT"))), 6)
                    '        '    If item3("WAREHOUSE_ID").ToString = Almacen Then
                    '        '        If moneda = "ME" Then
                    '        '            nCosPro = Math.Round(item3("AMOUNT_US"), 6)
                    '        '        ElseIf moneda = "MN" Then
                    '        '            nCosPro = Math.Round(item3("AMOUNT"), 6)
                    '        '        End If
                    '        '    Else
                    '        '        If moneda = "ME" Then
                    '        '            nCosPro = Math.Round(item2("AMOUNT_US"), 6)
                    '        '        ElseIf moneda = "MN" Then
                    '        '            nCosPro = Math.Round(item2("AMOUNT"), 6)
                    '        '        End If
                    '        '    End If
                    '        'Next
                    '    Else
                    '        If moneda = "ME" Then
                    '            nCosPro = Math.Round(item2("AMOUNT_US"), 6)
                    '        ElseIf moneda = "MN" Then
                    '            nCosPro = Math.Round(item2("AMOUNT"), 6)
                    '        End If
                    '    End If
                    'Next
                Else
                    nSaldo = 0 : nCosPro = 0
                    nSaldo2 = 0
                End If
                VALANTE = Math.Round(nCosPro * nSaldo, 6)

            End If

            nCantid = item("QTY").ToString

            ''Recorriendo el Cuarto Datatable 
            Dim item4() As DataRow = Adodc4.Select("PART_ID='" & arCod & "'")
            If item4.Count() <> 0 Then
                If X <= item4.Count() Then
                    If Almacen = item("WAREHOUSE_ID").ToString Then nCantid2 = IIf(String.IsNullOrEmpty(item4(X)("QTY").ToString), 0, item4(X)("QTY"))
                End If
            End If
            '----
            If moneda = "ME" Then
                If Math.Round(tcamb, 3) > 0 Then
                    If item("CURRENCY_EXCHANGE").ToString = "ME" Then
                        nPrecio = Math.Round(item("AVERAGE_COST"), 6)
                    Else
                        nPrecio = Math.Round(item("AVERAGE_COST") / tcamb, 6)
                    End If
                Else
                    nPrecio = item("AVERAGE_COST")
                End If
            ElseIf moneda = "MN" Then
                If item("CURRENCY_EXCHANGE").ToString = "ME" Then
                    nPrecio = Math.Round(IIf(item("AVERAGE_COST").ToString = "", 0, item("AVERAGE_COST")) * IIf(tcamb = 0, 1, tcamb), 6)
                Else
                    nPrecio = Math.Round(IIf(item("AVERAGE_COST").ToString = "", 0, item("AVERAGE_COST")), 6)
                End If
            End If
            '----
            If item("TYPE_TRANS").ToString = "I" Then
                nSaldo = Format(nSaldo + nCantid, "0.000000")
                If Almacen = item("WAREHOUSE_ID").ToString Then nSaldo2 = Math.Round(nSaldo2 + nCantid2, 10)
                VALMOV = Math.Round(nCantid * nPrecio, 6)
            Else
                nSaldo = Format(nSaldo - nCantid, "0.000000")
                If Almacen = item("WAREHOUSE_ID").ToString Then nSaldo2 = Math.Round(nSaldo2 - nCantid2, 10)
                VALMOV = Math.Round(nCantid * IIf(item("DOCUMENT_ID").ToString = "NS" And item("TRANS_ID1").ToString = "AJ", nPrecio, nCosPro), 6)
            End If
            '----------------
            If item("TYPE_TRANS").ToString = "I" And item("DOCUMENT_ID").ToString <> "NC" And item("STATUS_VALUE") = True Then
                If nSaldo <> 0 Then
                    nCosPro = Math.Round((Math.Round(VALMOV + VALANTE, 6)) / nSaldo, 6)
                End If
            ElseIf item("TYPE_TRANS").ToString = "S" And item("DOCUMENT_ID").ToString = "NS" And item("TRANS_ID1").ToString = "AJ" Then
                If nSaldo <> 0 Then
                    nCosPro = Math.Round((Math.Round(VALANTE - VALMOV, 6)) / nSaldo, 6)
                End If
            End If
            '-------
            VALANTE = Math.Round(nCosPro * nSaldo, 6)
            '-----
            Fecha = String.Empty
            Fecha = (DateDiff("d", CDate(item("DATE_DOCUMENT")), "01/01/1900") * -1) + 2
            CSQL2 = "Insert Into [tempdb].dbo.JDIAZKARDEX "
            CSQL2 = CSQL2 & "(PART_ID,DOCUMENT_DATE,HOUR,TRANS_ID,TYPE_TRANS,NUMBER_DOC,QTY,UNIT_PRICE,AVERAGE_COST,STOCK_BALANCE,IS_SER_LOT,IN_OUT,WAREHOUSE_ID,ITEM)  "
            CSQL2 = CSQL2 & " Values ('"
            CSQL2 = CSQL2 & item("PART_ID").ToString & "'," & Fecha & ",'"
            CSQL2 = CSQL2 & item("HOUR").ToString & "','" & item("TRANS_ID1").ToString & "',"
            CSQL2 = CSQL2 & "'" & item("DOCUMENT_ID").ToString & "','" & item("NUMBER_DOCUMENT").ToString & "', "
            CSQL2 = CSQL2 & IIf(String.IsNullOrEmpty(item("QTY").ToString), 0, item("QTY")) & ","

            CSQL2 = CSQL2 & IIf(item("TYPE_TRANS").ToString = "I", IIf(item("STATUS_VALUE") = True And item("DOCUMENT_ID") <> "NC", nPrecio, nCosPro), IIf(item("DOCUMENT_ID").ToString = "NS" And item("TRANS_ID").ToString = "AJ", nPrecio, nCosPro))
            CSQL2 = CSQL2 & "," & nCosPro & ","
            CSQL2 = CSQL2 & nSaldo2
            CSQL2 = CSQL2 & ",'" & IIf(item("NUMBER_SERIE").ToString = String.Empty, item("NUMBER_LOT").ToString, item("NUMBER_SERIE").ToString)
            CSQL2 = CSQL2 & "','" & item("TYPE_TRANS").ToString & "',"

            CSQL2 = CSQL2 & "'" & item("WAREHOUSE_ID").ToString
            CSQL2 = CSQL2 & "'," & item("ITEM").ToString
            CSQL2 = CSQL2 & ")"
            ''Guardando data
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, CSQL2)
            cCod = Trim(item("PART_ID").ToString)
            X += 1
        Next
        Exit Sub
    End Sub



    Public Function Get_ImprimirReporte_Transacciones_Articulo(ByVal IDE As String, ByVal fechaINI As String, ByVal Almacen As String, ByVal TipoMov As String, ByVal Moneda As String, _
                                  ByVal Mov_inicial As String, ByVal Mov_final As String, ByVal articuloIni As String, ByVal articuloFin As String, _
                                  ByVal progreso As ProgressBar) As DataTable

        Try
            Dim dtMaeart As DataTable
            dtMaeart = New DataTable

            Dim cMesActu = String.Empty
            Dim cMesCirr As String = String.Empty
            Dim mes_actual As String = String.Empty
            Dim ano_actual As String = String.Empty
            Dim cAnoMes As String = String.Empty
            Dim CadenaConsulta As String = String.Empty

            'creando tabla Temporal
            SqlHelper.ExecuteNonQuery(cn, "INV_RPT_KARDEX_VAL_MOVIMIENTO", IDE & "KARDEX", "0", "", "", "", "", "", "", "")

            cAnoMes = Format(CDate(fechaINI).Year, "0000") & Format(CDate(fechaINI).Month, "00")

            Dim YEAR_ACTUAL As Integer, YEAR_ANTERIOR As Integer
            YEAR_ACTUAL = Format(CDate(fechaINI).Year, "0000")
            YEAR_ANTERIOR = YEAR_ACTUAL - 1

            Adodc1 = New DataTable
            Adodc1 = SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_VAL_MOVIMIENTO", "", "2", "", "", Format(CDate(fechaINI).Year, "0000") _
                                       , Format(CDate(fechaINI).Month, "00"), articuloIni, articuloFin, "").Tables(0)

            Adodc4 = New DataTable
            Adodc4 = SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_VAL_MOVIMIENTO", "", "2", "", "", Format(CDate(fechaINI).Year, "0000") _
                                       , Format(CDate(fechaINI).Month, "00"), articuloIni, articuloFin, "").Tables(0)


            Adodc2 = New DataTable
            Adodc2 = SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_VAL_MOVIMIENTO", "", "3", "", "", "", "", "", "", AnioMesAnterior(cAnoMes)).Tables(0)

            Adodc3 = New DataTable
            Adodc3 = SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_VAL_MOVIMIENTO", "", "4", "", "", "", "", "", "", AnioMesAnterior(cAnoMes)).Tables(0)

            'Recorriendo los datos
            dtMaeart = SqlHelper.ExecuteDataset(cn, "INV_RPT_KARDEX_VAL_MOVIMIENTO", "", "5", "", Almacen, "", "", articuloIni, articuloFin, "").Tables(0)
            progreso.Minimum = 0
            progreso.Maximum = dtMaeart.Rows.Count()
            If dtMaeart.Rows.Count() <> 0 Then
                For j As Integer = 0 To dtMaeart.Rows.Count() - 1
                    progreso.Value = j
                    LoadIngresoSalidaKardexArticulo(IDE, dtMaeart.Rows(j).Item("PART_ID").ToString, fechaINI, Moneda, Almacen)
                    progreso.PerformStep()
                Next
            Else
                MsgBox("No existe información a procesar en el mes seleccionado", vbInformation, "Aviso")
                Exit Try
            End If
            ''Datos Generales mostrando reporte ..
            Adodc5 = New DataTable
            Adodc5 = SqlHelper.ExecuteDataset(cn, "RPT_INV_DOC_WH_TRANS_ART", TipoMov, Almacen, Mov_inicial, Mov_final).Tables(0)
            progreso.Value = dtMaeart.Rows.Count()
            Return Adodc5
        Catch ex As Exception
            Throw
            MsgBox(ex.Message)
        End Try
    End Function
End Class
