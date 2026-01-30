Imports LibConexion
Imports LibComunVar
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class ClsReporteGenerales
    Dim dtTable As DataTable
    Dim LibData As LibConexion.ClsData

    Public Class ReportesGerenciales
        Dim cn As SqlConnection
        Dim dataBL As New LibConexion.ClsData

        Public Sub New()
            cn = dataBL.ConexionBD
        End Sub

        Public Function EjecutaReporteVentasMensualArticulo(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _PRODUCTO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RPT_VENTAS_MENSUAL", _FECHA_INI, _FECHA_FIN, _PRODUCTO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function EjecutaReporteVentasMensualVendedor(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _PRODUCTO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RPT_VENTAS_MENSUAL_X_VENDEDOR", _FECHA_INI, _FECHA_FIN, _PRODUCTO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function EjecutaReporteVentasMensualVendedor_Totales(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _PRODUCTO As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "FACT_SP_S_RPT_VENTAS_MENSUAL_X_VENDEDOR_TOTALES", _FECHA_INI, _FECHA_FIN, _PRODUCTO).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End Function

        Public Function Get_ImprimirReporte(ByVal _NombreProcedimiento As String, Optional ByVal fec_ini_ As String = "", Optional ByVal fec_fin_ As String = "", _
                                            Optional ByVal Filtro As String = "", Optional ByVal Activador_Grupo As Integer = 0, Optional ByVal _TipoReporte As Integer = 0, _
                                            Optional ByVal NumeroReporte As String = "") As DataTable

            Select Case NumeroReporte
                Case "Reporte1"
                    Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, fec_ini_, fec_fin_, Filtro, Activador_Grupo, _TipoReporte).Tables(0)
                Case "Reporte2"
                    Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, fec_ini_, fec_fin_, Filtro).Tables(0)
                Case "Reporte3"
                    SqlHelper.ExecuteNonQuery(cn, _NombreProcedimiento, fec_ini_, fec_fin_)
                    Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "SP_REP_VENTAS_DIA_MOSTRAR").Tables(0)
                Case "Reporte4"
                    SqlHelper.ExecuteNonQuery(cn, _NombreProcedimiento, fec_ini_, fec_fin_, Activador_Grupo)
                    Return SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "SP_REP_VENTAS_STOCK_VALORIZADO_MOSTRAR").Tables(0)
                Case "Reporte5"
                    If _TipoReporte = 2 Then _TipoReporte = 1
                    Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, fec_ini_, fec_fin_, Filtro, Activador_Grupo, _TipoReporte).Tables(0)
            End Select
        End Function

        Public Function Get_ImprimirReporteII(ByVal _NombreProcedimiento As String, ByVal _fec_ini_ As String, ByVal fec_fin_ As String, _
                                          ByVal _Filtro As String, ByVal _tipo_Reporte As Integer, ByVal _cod_producto As String, _
                                          ByVal _lote_producto As String, ByVal numero_documento As String, Optional ByVal opcion2 As String = "") As DataTable
            Select Case _tipo_Reporte
                Case 2
                    Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _Filtro, _fec_ini_, fec_fin_, numero_documento, _cod_producto, _lote_producto, _tipo_Reporte, opcion2).Tables(0)
                Case Else
                    Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _Filtro, _fec_ini_, fec_fin_, _cod_producto, numero_documento, _lote_producto, _tipo_Reporte, opcion2).Tables(0)
            End Select
        End Function

        Public Function Get_WAREHOUSE(ByVal _NombreProcedimiento As String, ByVal fec_ini_ As String, ByVal fec_fin_ As String, _
                                        ByVal _Filtro As String) As DataTable
            Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, fec_ini_, fec_fin_, _Filtro).Tables(0)
        End Function

        Public Function get_Saldos_x_Cliente(todos_ As Boolean, pc_ As String) As DataTable
            Dim dt_tmp As DataTable = Nothing
            If todos_ Then
                dt_tmp = SqlHelper.ExecuteDataset(cn, CommandType.StoredProcedure, "CX_SP_S_SALDO_ALL").Tables(0)
            Else
                dt_tmp = SqlHelper.ExecuteDataset(cn, "CX_SP_S_SALDO_X_CLI", pc_).Tables(0)
            End If
            Return dt_tmp
        End Function


        Public Function EjecutaReporteVentasMensualArticulo(ByVal IDE As String, ByVal fechaINI As DateTimePicker, ByVal fechaFIN As DateTimePicker, _
                                                                  ByVal PuntoV_ini As String, ByVal PuntoV_fin As String, _
                                                                  ByVal ART1 As String, ByVal ART2 As String, _
                                                                  ByVal TipoReporte As String) As DataTable
            Dim tr As SqlTransaction = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                Dim cAnno1 As String = String.Empty
                Dim cAnno2 As String = String.Empty
                Dim cMes1 As String = String.Empty
                Dim cMes2 As String = String.Empty
                Dim dtDatos As DataTable
                Dim Query As String = String.Empty
                Dim sCol As String = String.Empty
                Dim DATO1 As String = String.Empty
                Dim dato As String = String.Empty


                cAnno1 = fechaINI.Value.Year
                cAnno2 = fechaFIN.Value.Year
                cMes1 = fechaINI.Value.Month
                cMes2 = fechaFIN.Value.Month

                Query = "SELECT * FROM CLOSESALES_MONTH" & cAnno1
                dtDatos = New DataTable("CLOSESALES_MONTH")
                dtDatos = SqlHelper.ExecuteDataset(tr, CommandType.Text, Query).Tables(0)
                If dtDatos.Rows.Count() <> 0 Then
                    SqlHelper.ExecuteNonQuery(tr, "RPT_R_CREAR_TEMPORAL", IDE, "VENT_MEN_ART")
                    sCol = String.Empty
                    sCol = "PLACE_SALES,PART_ID,DESCRIPTION,UNIT_OF_MEASUREMENT"
                    For i As Integer = 1 To 12
                        sCol = sCol & ",CANTIDAD" & i & ",VALORME" & i & " AS VALME" & i & ",VALORMN" & i & " AS VALMN" & i
                    Next
                    Query = String.Empty
                    Query = "SELECT TOP 1 " & sCol & " INTO  [tempdb].dbo." & IDE & "VENT_MEN_ART FROM  CLOSESALES_MONTH" & cAnno1
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, Query)

                    Query = String.Empty
                    Query = "DELETE FROM [tempdb].dbo." & IDE & "VENT_MEN_ART"
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, Query)
                    DATO1 = ""
                    dato = ""
                    For i = fechaINI.Value.Month To fechaFIN.Value.Month
                        DATO1 = DATO1 & ",ISNULL(CANTIDAD" & i & ",0) , ISNULL(VALORME" & i & ",0) AS VALME" & i & " ,ISNULL(VALORMN" & i & ",0)" & " AS VALMN" & i
                        dato = dato & ",CANTIDAD" & i & ",VALME" & i & ",VALMN" & i & ""
                    Next i

                    Query = "INSERT INTO [tempdb].dbo." & IDE & "VENT_MEN_ART (PLACE_SALES,PART_ID,DESCRIPTION,UNIT_OF_MEASUREMENT" & dato & ")" _
                          & "SELECT PLACE_SALES,PART_ID,DESCRIPTION,UNIT_OF_MEASUREMENT" & DATO1 & "" _
                          & " FROM CLOSESALES_MONTH" & cAnno1 & " " _
                          & "WHERE PART_ID>='" & Trim(ART1) & "' AND PART_ID<='" & Trim(ART2) & "' " _
                          & "AND PLACE_SALES>='" & PuntoV_ini & "' AND PLACE_SALES<='" & PuntoV_fin & "' "
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, Query)
                    DATO1 = ""
                    dato = ""
                    For i = 1 To 12
                        DATO1 = DATO1 & "CANTIDAD" & i & "=(CASE WHEN CANTIDAD" & i & " IS NULL THEN 0 ELSE CANTIDAD" & i & " END) ,VALME" & i & "=(CASE WHEN VALME" & i & " IS NULL THEN 0 ELSE VALME" & i & " END),VALMN" & i & "=(CASE WHEN VALMN" & i & " IS NULL THEN 0 ELSE VALMN" & i & " END)" & ","
                    Next i
                    DATO1 = Mid(DATO1, 1, Len(DATO1) - 1)
                    Query = ""
                    Query = "UPDATE [tempdb].dbo." & IDE & "VENT_MEN_ART SET " & DATO1 & ""
                    SqlHelper.ExecuteNonQuery(tr, CommandType.Text, Query)
                    'Retornando Datos..
                    SqlHelper.ExecuteNonQuery(tr, "RPT_VENTAS_MENS_ART", IDE & "VENT_MEN_ART")
                    Return SqlHelper.ExecuteDataset(tr, CommandType.StoredProcedure, "RPT_VENTAS_MENS_ART_MOSTRAR").Tables(0)
                Else
                    MsgBox("No se ha Realizado el Proceso de Generación de Ventas Mensuales.", MsgBoxStyle.Information, "Advertencia")
                    tr.Rollback()
                    Exit Try
                End If
                tr.Commit()
                tr.Dispose()
            Catch ex As Exception
                tr.Rollback()
                Throw
            End Try
        End Function


        Public Function EjecutaReporteMovimientoResumidoArticulo(ByVal fechaINI As String, ByVal fechaFIN As String, ByVal almacen As String) As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "SP_ING_SAL_LOT", almacen, fechaINI, fechaFIN).Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function ExportarSQLExcel(ByVal dt_reg_concar As DataTable, ByVal Ruta As String, ByVal NombreArchivo As String)
            'Proceso de conección e instruccion SELECT * FROM

            Dim MiDataSet As New DataSet
            Dim Columnas, Filas As Integer


            Try
                '=============================Proceso de carga del dataset========================================
                If dt_reg_concar.Rows.Count <= 0 Then
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("Error en DataSet :" & ex.Message)
            End Try
            '===================================Fin del proceso===================================================

            '=======================Aquí comprueba si Excel está instalado en el PC===============================

            Dim Excel As Object = CreateObject("Excel.Application")
            If Excel Is Nothing Then
                MsgBox("Al parecer Excel no està instalado en su PC. El funcionamiento de este proceso exige tener MS Excel instalado en su PC.", MsgBoxStyle.Critical)
                Return Nothing
                Exit Function
            End If
            '======================================================================================================

            '=================================Aqui comienza el proceso de Exportación a Excel======================
            Try
                With Excel
                    .SheetsInNewWorkbook = 1
                    .Workbooks.Add()
                    .Worksheets(1).Select()

                    Dim i As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1
                        'For Columnas = 0 To MiDataSet.Tables(0).Columns.Count - 1
                        .cells(1, i).value = dt_reg_concar.Columns(Columnas).ColumnName 'MiDataSet.Tables(0).Columns(Columnas).ColumnName
                        .cells(1, i).EntireRow.Font.Bold = True
                        i += 1
                    Next
                    i = 2
                    Dim k As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1 'MiDataSet.Tables(0).Columns.Count - 1
                        i = 2

                        For Filas = 0 To dt_reg_concar.Rows.Count - 1 'MiDataSet.Tables(0).Rows.Count - 1

                            If k = 1 Or k = 2 Or k = 10 Or k = 11 Or k = 18 Or k = 21 Or k = 23 Or k = 24 Or k = 25 Or k = 26 Or k = 27 Or k = 30 Or k = 31 Then
                                ' .Cells(1, k).EntireColumn.NumberFormat = "@"
                                .Cells(i, k).EntireColumn.NumberFormat = "@"
                            Else
                                '.Cells(i, k).numberformat = "@"
                            End If
                            .Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            i += 1
                        Next
                        k += 1
                    Next
                    '===================Aquí es donde guarda el archivo en la ruta especificada=====================

                    .ActiveCell.Worksheet.SaveAs(Ruta & NombreArchivo & ".xls")
                End With
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
                Excel = Nothing
                '==================================================================================================

            Catch ex As Exception
                MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical, "Error de proceso")
                Return Nothing
                Exit Function
            End Try

            ' El archivo excel se crea y se abre para insertar los valores.
            Dim Proceso() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
            For Each Pro As Process In Proceso
                Pro.Kill()
                'Advertimos que el trabajo de exportacion se ha realizado exitosamente
                MsgBox("Los datos han sido exportados correctamente.", MsgBoxStyle.Information)
            Next
            Return Excel
        End Function

        Public Function ExportarSQLExcel_Rep_Cobranza_Diario(ByVal dt_reg_concar As DataTable, ByVal Ruta As String, ByVal NombreArchivo As String)
            'Proceso de conección e instruccion SELECT * FROM

            Dim MiDataSet As New DataSet
            Dim Columnas, Filas As Integer
            Dim valor_celda As String

            Try
                '=============================Proceso de carga del dataset========================================
                If dt_reg_concar.Rows.Count <= 0 Then
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("Error en DataSet :" & ex.Message)
            End Try
            '===================================Fin del proceso===================================================

            '=======================Aquí comprueba si Excel está instalado en el PC===============================

            Dim Excel As Object = CreateObject("Excel.Application")
            If Excel Is Nothing Then
                MsgBox("Al parecer Excel no està instalado en su PC. El funcionamiento de este proceso exige tener MS Excel instalado en su PC.", MsgBoxStyle.Critical)
                Return Nothing
                Exit Function
            End If
            '======================================================================================================

            '=================================Aqui comienza el proceso de Exportación a Excel======================
            Try
                With Excel
                    .SheetsInNewWorkbook = 1
                    .Workbooks.Add()
                    .Worksheets(1).Select()

                    Dim i As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1
                        'For Columnas = 0 To MiDataSet.Tables(0).Columns.Count - 1
                        .cells(1, i).value = dt_reg_concar.Columns(Columnas).ColumnName 'MiDataSet.Tables(0).Columns(Columnas).ColumnName
                        .cells(1, i).EntireRow.Font.Bold = True
                        i += 1
                    Next
                    i = 2
                    Dim k As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1 'MiDataSet.Tables(0).Columns.Count - 1
                        i = 2

                        For Filas = 0 To dt_reg_concar.Rows.Count - 1 'MiDataSet.Tables(0).Rows.Count - 1

                            If k = 4 Or k = 7 Or k = 13 Then
                                ' .Cells(1, k).EntireColumn.NumberFormat = "@"
                                .Cells(i, k).EntireColumn.NumberFormat = "@"
                            Else
                                '.Cells(i, k).numberformat = "@"
                            End If
                            If Columnas >= 14 Then
                                valor_celda = IIf(IsDBNull(dt_reg_concar.Rows(Filas).ItemArray(Columnas)), 0, dt_reg_concar.Rows(Filas).ItemArray(Columnas)) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                                If valor_celda = "" Or Val(valor_celda) = 0 Then
                                    .Cells(i, k).Value = 0
                                Else
                                    .Cells(i, k).Value = CDbl(valor_celda)
                                End If
                            Else
                                .Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            End If
                            '.Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            i += 1
                        Next
                        k += 1
                    Next
                    '===================Aquí es donde guarda el archivo en la ruta especificada=====================

                    .ActiveCell.Worksheet.SaveAs(Ruta & NombreArchivo & ".xls")
                End With
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
                Excel = Nothing
                '==================================================================================================

            Catch ex As Exception
                MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical, "Error de proceso")
                Return Nothing
                Exit Function
            End Try

            ' El archivo excel se crea y se abre para insertar los valores.
            Dim Proceso() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
            For Each Pro As Process In Proceso
                Pro.Kill()
                'Advertimos que el trabajo de exportacion se ha realizado exitosamente
                MsgBox("Los datos han sido exportados correctamente.", MsgBoxStyle.Information)
            Next
            Return Excel
        End Function

        Public Function ExportarSQLExcel_Rep_Reg_Ventas_Cobranza_Diario(ByVal dt_reg_concar As DataTable, ByVal Ruta As String, ByVal NombreArchivo As String)
            'Proceso de conección e instruccion SELECT * FROM

            Dim MiDataSet As New DataSet
            Dim Columnas, Filas As Integer
            Dim valor_celda As String

            Try
                '=============================Proceso de carga del dataset========================================
                If dt_reg_concar.Rows.Count <= 0 Then
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("Error en DataSet :" & ex.Message)
            End Try
            '===================================Fin del proceso===================================================

            '=======================Aquí comprueba si Excel está instalado en el PC===============================

            Dim Excel As Object = CreateObject("Excel.Application")
            If Excel Is Nothing Then
                MsgBox("Al parecer Excel no està instalado en su PC. El funcionamiento de este proceso exige tener MS Excel instalado en su PC.", MsgBoxStyle.Critical)
                Return Nothing
                Exit Function
            End If
            '======================================================================================================

            '=================================Aqui comienza el proceso de Exportación a Excel======================
            Try
                With Excel
                    .SheetsInNewWorkbook = 1
                    .Workbooks.Add()
                    .Worksheets(1).Select()

                    Dim i As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1
                        'For Columnas = 0 To MiDataSet.Tables(0).Columns.Count - 1
                        .cells(1, i).value = dt_reg_concar.Columns(Columnas).ColumnName 'MiDataSet.Tables(0).Columns(Columnas).ColumnName
                        .cells(1, i).EntireRow.Font.Bold = True
                        i += 1
                    Next
                    i = 2
                    Dim k As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1 'MiDataSet.Tables(0).Columns.Count - 1
                        i = 2

                        For Filas = 0 To dt_reg_concar.Rows.Count - 1 'MiDataSet.Tables(0).Rows.Count - 1

                            If k = 3 Or k = 2 Then
                                ' .Cells(1, k).EntireColumn.NumberFormat = "@"
                                .Cells(i, k).EntireColumn.NumberFormat = "@"
                            Else
                                '.Cells(i, k).numberformat = "@"
                            End If
                            If Columnas >= 6 Then
                                valor_celda = IIf(IsDBNull(dt_reg_concar.Rows(Filas).ItemArray(Columnas)), 0, dt_reg_concar.Rows(Filas).ItemArray(Columnas)) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                                If valor_celda = "" Or Val(valor_celda) = 0 Then
                                    .Cells(i, k).Value = 0
                                Else
                                    .Cells(i, k).Value = CDbl(valor_celda)
                                End If
                            Else
                                .Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            End If
                            '.Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            i += 1
                        Next
                        k += 1
                    Next
                    '===================Aquí es donde guarda el archivo en la ruta especificada=====================

                    .ActiveCell.Worksheet.SaveAs(Ruta & NombreArchivo & ".xls")
                End With
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
                Excel = Nothing
                '==================================================================================================

            Catch ex As Exception
                MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical, "Error de proceso")
                Return Nothing
                Exit Function
            End Try

            ' El archivo excel se crea y se abre para insertar los valores.
            Dim Proceso() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
            For Each Pro As Process In Proceso
                Pro.Kill()
                'Advertimos que el trabajo de exportacion se ha realizado exitosamente
                MsgBox("Los datos han sido exportados correctamente.", MsgBoxStyle.Information)
            Next
            Return Excel
        End Function

        Public Function ExportarSQLExcel_Rep_Reg_Compras_Pagos_Diario(ByVal dt_reg_concar As DataTable, ByVal Ruta As String, ByVal NombreArchivo As String)
            'Proceso de conección e instruccion SELECT * FROM

            Dim MiDataSet As New DataSet
            Dim Columnas, Filas As Integer
            Dim valor_celda As String

            Try
                '=============================Proceso de carga del dataset========================================
                If dt_reg_concar.Rows.Count <= 0 Then
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("Error en DataSet :" & ex.Message)
            End Try
            '===================================Fin del proceso===================================================

            '=======================Aquí comprueba si Excel está instalado en el PC===============================

            Dim Excel As Object = CreateObject("Excel.Application")
            If Excel Is Nothing Then
                MsgBox("Al parecer Excel no està instalado en su PC. El funcionamiento de este proceso exige tener MS Excel instalado en su PC.", MsgBoxStyle.Critical)
                Return Nothing
                Exit Function
            End If
            '======================================================================================================

            '=================================Aqui comienza el proceso de Exportación a Excel======================
            Try
                With Excel
                    .SheetsInNewWorkbook = 1
                    .Workbooks.Add()
                    .Worksheets(1).Select()

                    Dim i As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1
                        'For Columnas = 0 To MiDataSet.Tables(0).Columns.Count - 1
                        .cells(1, i).value = dt_reg_concar.Columns(Columnas).ColumnName 'MiDataSet.Tables(0).Columns(Columnas).ColumnName
                        .cells(1, i).EntireRow.Font.Bold = True
                        i += 1
                    Next
                    i = 2
                    Dim k As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1 'MiDataSet.Tables(0).Columns.Count - 1
                        i = 2

                        For Filas = 0 To dt_reg_concar.Rows.Count - 1 'MiDataSet.Tables(0).Rows.Count - 1

                            If k = 3 Or k = 2 Then
                                ' .Cells(1, k).EntireColumn.NumberFormat = "@"
                                .Cells(i, k).EntireColumn.NumberFormat = "@"
                            Else
                                '.Cells(i, k).numberformat = "@"
                            End If
                            If Columnas >= 6 Then
                                valor_celda = IIf(IsDBNull(dt_reg_concar.Rows(Filas).ItemArray(Columnas)), 0, dt_reg_concar.Rows(Filas).ItemArray(Columnas)) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                                If valor_celda = "" Or Val(valor_celda) = 0 Then
                                    .Cells(i, k).Value = 0
                                Else
                                    .Cells(i, k).Value = CDbl(valor_celda)
                                End If
                            Else
                                .Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            End If
                            '.Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            i += 1
                        Next
                        k += 1
                    Next
                    '===================Aquí es donde guarda el archivo en la ruta especificada=====================

                    .ActiveCell.Worksheet.SaveAs(Ruta & NombreArchivo & ".xls")
                End With
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
                Excel = Nothing
                '==================================================================================================

            Catch ex As Exception
                MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical, "Error de proceso")
                Return Nothing
                Exit Function
            End Try

            ' El archivo excel se crea y se abre para insertar los valores.
            Dim Proceso() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
            For Each Pro As Process In Proceso
                Pro.Kill()
                'Advertimos que el trabajo de exportacion se ha realizado exitosamente
                MsgBox("Los datos han sido exportados correctamente.", MsgBoxStyle.Information)
            Next
            Return Excel
        End Function

        Public Function ExportarSQLExcel_Rep_Cobranza_Efectuada_Diario(ByVal dt_reg_concar As DataTable, ByVal Ruta As String, ByVal NombreArchivo As String)
            'Proceso de conección e instruccion SELECT * FROM

            Dim MiDataSet As New DataSet
            Dim Columnas, Filas As Integer
            Dim valor_celda As String
            Dim columna_fecha As String
            Dim fecha_puente As Date
            Try
                '=============================Proceso de carga del dataset========================================
                If dt_reg_concar.Rows.Count <= 0 Then
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("Error en DataSet :" & ex.Message)
            End Try
            '===================================Fin del proceso===================================================

            '=======================Aquí comprueba si Excel está instalado en el PC===============================

            Dim Excel As Object = CreateObject("Excel.Application")
            If Excel Is Nothing Then
                MsgBox("Al parecer Excel no està instalado en su PC. El funcionamiento de este proceso exige tener MS Excel instalado en su PC.", MsgBoxStyle.Critical)
                Return Nothing
                Exit Function
            End If
            '======================================================================================================

            '=================================Aqui comienza el proceso de Exportación a Excel======================
            Try
                With Excel
                    .SheetsInNewWorkbook = 1
                    .Workbooks.Add()
                    .Worksheets(1).Select()

                    Dim i As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1
                        'For Columnas = 0 To MiDataSet.Tables(0).Columns.Count - 1
                        .cells(1, i).value = dt_reg_concar.Columns(Columnas).ColumnName 'MiDataSet.Tables(0).Columns(Columnas).ColumnName
                        .cells(1, i).EntireRow.Font.Bold = True
                        i += 1
                    Next
                    i = 2
                    Dim k As Integer = 1
                    For Columnas = 0 To dt_reg_concar.Columns.Count - 1 'MiDataSet.Tables(0).Columns.Count - 1
                        i = 2

                        For Filas = 0 To dt_reg_concar.Rows.Count - 1 'MiDataSet.Tables(0).Rows.Count - 1

                            If k = 1 Or k = 3 Or k = 2 Or k = 5 Or k = 11 Or k = 15 Then
                                ' .Cells(1, k).EntireColumn.NumberFormat = "@"
                                .Cells(i, k).EntireColumn.NumberFormat = "@"
                            Else
                                '.Cells(i, k).numberformat = "@"
                            End If
                            If Columnas >= 16 Then
                                valor_celda = IIf(IsDBNull(dt_reg_concar.Rows(Filas).ItemArray(Columnas)), 0, dt_reg_concar.Rows(Filas).ItemArray(Columnas)) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                                If valor_celda = "" Or Val(valor_celda) = 0 Then
                                    .Cells(i, k).Value = 0
                                Else
                                    .Cells(i, k).Value = CDbl(valor_celda)
                                End If
                            Else
                                .Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            End If
                            '.Cells(i, k).Value = dt_reg_concar.Rows(Filas).ItemArray(Columnas) 'MiDataSet.Tables(0).Rows(Filas).ItemArray(Columnas)
                            i += 1
                        Next
                        k += 1
                    Next
                    '===================Aquí es donde guarda el archivo en la ruta especificada=====================

                    .ActiveCell.Worksheet.SaveAs(Ruta & NombreArchivo & ".xls")
                End With
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
                Excel = Nothing
                '==================================================================================================

            Catch ex As Exception
                MsgBox("Error :" & ex.Message, MsgBoxStyle.Critical, "Error de proceso")
                Return Nothing
                Exit Function
            End Try

            ' El archivo excel se crea y se abre para insertar los valores.
            Dim Proceso() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
            For Each Pro As Process In Proceso
                Pro.Kill()
                'Advertimos que el trabajo de exportacion se ha realizado exitosamente
                MsgBox("Los datos han sido exportados correctamente.", MsgBoxStyle.Information)
            Next
            Return Excel
        End Function

        Public Function Get_ImprimirRegistroVentas(ByVal _NombreProcedimiento As String, ByVal _fec_ini_ As String, ByVal fec_fin_ As String, _
                                                  ByVal _tipo_Reporte As Integer, Optional ByVal TipoDoc As String = "", Optional ByVal Moneda As String = "", _
                                                  Optional ByVal Num_Serie As String = "") As DataTable
            Select Case _tipo_Reporte
                Case 1
                    Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _fec_ini_, fec_fin_, TipoDoc, Moneda, Num_Serie).Tables(0)
                Case 2
                    Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _fec_ini_, fec_fin_, Num_Serie).Tables(0)
            End Select
        End Function

        Public Function Get_ExportarMovimientos(ByVal _NombreProcedimiento As String, ByVal _fec_ini_ As String, ByVal fec_fin_ As String, _
                                                  ByVal _tipo_Reporte As Integer, Optional ByVal TipoDoc As String = "") As DataTable
            Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _fec_ini_, fec_fin_).Tables(0)
        End Function

        Public Function CopyDataTableBulk(ByVal dTable As DataTable, ByVal dTableR As DataTable, ByVal dTableRL As DataTable, ByVal dTableWT As DataTable, ByVal dTableWTL As DataTable, ByVal STRNomTablaDestino As String, ByVal STRNomTablaDestinoR As String, ByVal STRNomTablaDestinoRL As String, ByVal STRNomTablaDestinoWT As String, ByVal STRNomTablaDestinoWTL As String) As Boolean
            Try
                Dim mySqlBulk As SqlClient.SqlBulkCopy = New SqlClient.SqlBulkCopy(cn)
                mySqlBulk.DestinationTableName = STRNomTablaDestino
                mySqlBulk.WriteToServer(dTable)
                mySqlBulk.DestinationTableName = STRNomTablaDestinoR
                mySqlBulk.WriteToServer(dTableR)
                mySqlBulk.DestinationTableName = STRNomTablaDestinoRL
                mySqlBulk.WriteToServer(dTableRL)
                mySqlBulk.DestinationTableName = STRNomTablaDestinoWT
                mySqlBulk.WriteToServer(dTableWT)
                mySqlBulk.DestinationTableName = STRNomTablaDestinoWTL
                mySqlBulk.WriteToServer(dTableWTL)
                'cn.Close()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


        Public Function Get_ImprimirRepVentas_Vendedor(ByVal _NombreProcedimiento As String, ByVal _fec_ini_ As String, ByVal fec_fin_ As String, _
                                                  ByVal _tipo_doc As String, ByVal _vendedor As String) As DataTable

            Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _fec_ini_, fec_fin_, _tipo_doc, _vendedor).Tables(0)
        End Function

        Public Function Get_ImprimirRepProdPrecDesc(ByVal _NombreProcedimiento As String, ByVal _marca As String, ByVal _generico As String, _
                                                  ByVal _muestra_medica As String) As DataTable

            Return SqlHelper.ExecuteDataset(cn, _NombreProcedimiento, _marca, _generico, _muestra_medica).Tables(0)
        End Function
        Public Function Obtener_Datos_Empresa() As DataTable
            Try
                Return SqlHelper.ExecuteDataset(cn, "ADM_SP_S_COMPANY").Tables(0)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function Get_ImprimirRegistroVentasCobranza(ByVal _NombreProcedimiento As String, ByVal _fec_ini_ As String, ByVal fec_fin_ As String, _
                                                  ByVal _tipo_Reporte As Integer, Optional ByVal TipoDoc As String = "") As DataTable
            Dim sql_query As String
            Select Case _tipo_Reporte
                Case 1

                    sql_query = " exec SP_REGISTRO_VENTAS_COBRANZA '" & _fec_ini_ & "','" & fec_fin_ & "' "
                    SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
                    Return SqlHelper.ExecuteDataset(cn, "SP_REGISTRO_VENTAS_REPORTE_COBRANZA").Tables(0)
                Case 2

                    sql_query = " exec SP_REGISTRO_VENTAS_COBRANZA '" & _fec_ini_ & "','" & fec_fin_ & "' "
                    SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
                    Return SqlHelper.ExecuteDataset(cn, "SP_REGISTRO_VENTAS_REPORTE_COBRANZA_DETALLE").Tables(0)
                Case 3
                    sql_query = " exec SP_REGISTRO_VENTAS_COBRANZA_DIARIO '" & _fec_ini_ & "','" & fec_fin_ & "' "
                    SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
                    Return SqlHelper.ExecuteDataset(cn, "SP_REGISTRO_VENTAS_COBRANZA_DIARIO_PIVOT").Tables(0)
            End Select
        End Function

        Public Function Get_ImprimirRegistroComprasPagos(ByVal _NombreProcedimiento As String, ByVal _fec_ini_ As String, ByVal fec_fin_ As String, _
                                                 ByVal _tipo_Reporte As Integer, Optional ByVal TipoDoc As String = "") As DataTable
            Dim sql_query As String
            Select Case _tipo_Reporte
                Case 1

                    sql_query = " exec SP_REGISTRO_COMPRAS_PAGOS '" & _fec_ini_ & "','" & fec_fin_ & "' "
                    SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
                    Return SqlHelper.ExecuteDataset(cn, "SP_REGISTRO_COMPRAS_REPORTE_PAGOS").Tables(0)
                Case 2

                    sql_query = " exec SP_REGISTRO_COMPRAS_PAGOS '" & _fec_ini_ & "','" & fec_fin_ & "' "
                    SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
                    Return SqlHelper.ExecuteDataset(cn, "SP_REGISTRO_COMPRAS_REPORTE_PAGOS_DETALLE").Tables(0)
                Case 3
                    sql_query = " exec SP_REGISTRO_COMPRAS_PAGOS_DIARIO '" & _fec_ini_ & "','" & fec_fin_ & "' "
                    SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
                    Return SqlHelper.ExecuteDataset(cn, "SP_REGISTRO_COMPRAS_PAGOS_DIARIO_PIVOT").Tables(0)
            End Select
        End Function

        Public Function Get_CobranzaDiario(ByVal _fec_ini_ As String, ByVal fec_fin_ As String) As DataTable
            Dim sql_query As String

            sql_query = " exec SP_REP_COBRANZA_DIARIO '" & _fec_ini_ & "','" & fec_fin_ & "' "
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
            Return SqlHelper.ExecuteDataset(cn, "CXC_S_PEND_POR_DIA").Tables(0)
        
        End Function

        Public Function Get_PagosDiario(ByVal _fec_ini_ As String, ByVal fec_fin_ As String) As DataTable
            Dim sql_query As String

            sql_query = " exec SP_REP_PAGOS_DIARIO '" & _fec_ini_ & "','" & fec_fin_ & "' "
            SqlHelper.ExecuteNonQuery(cn, CommandType.Text, sql_query)
            Return SqlHelper.ExecuteDataset(cn, "CXC_S_PEND_POR_DIA").Tables(0)

        End Function


        Public Function EjecutarReporteCorrelativosFaltantes(ByVal _fec_ini_ As String, ByVal fec_fin_ As String, ByVal serie As String) As DataTable
            If serie = "" Then
                Return SqlHelper.ExecuteDataset(cn, "LISTAR_NUMEROS_NO_INGRESADOS", _fec_ini_, fec_fin_, serie).Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(cn, "LISTAR_NUMEROS_NO_INGRESADOS_SERIE", _fec_ini_, fec_fin_, serie).Tables(0)
            End If

        End Function



        ''CIERRE DE VENTAS MENSUALES 
        Public Function Guardar_ProgCierreVentasMensuales(ByVal mes As String, ByVal anio As String, ByVal fecha_cierre As String, ByVal user_id As String, ByVal fecha_registro As String) As Boolean
            Dim estado As Integer

            Try
                estado = SqlHelper.ExecuteNonQuery(cn, "CLI_SP_I_PROG_CIERRE_VENTAS_MENSUALES", mes, anio, fecha_cierre, user_id, fecha_registro)

                If estado = 0 Then
                    Return False
                ElseIf estado = 1 Then
                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function Modificar_ProgCierreVentasMensuales(ByVal mes As String, ByVal anio As String, ByVal fecha_cierre As String, ByVal user_id As String, ByVal fecha_registro As String) As Boolean
            Dim estado As Integer

            Try
                estado = SqlHelper.ExecuteNonQuery(cn, "CLI_SP_U_PROG_CIERRE_VENTAS_MENSUALES", mes, anio, fecha_cierre, user_id, fecha_registro)

                If estado = 0 Then
                    Return False
                ElseIf estado = 1 Then
                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try

        End Function

        Public Function Ejecutar_Importacion_Movimientos(ByVal _nombre_sp As String, ByVal _nombre_spR As String, ByVal _nombre_spRL As String, ByVal _nombre_spWT As String, ByVal _nombre_spWTL As String) As Boolean
            Dim tr As SqlTransaction
            tr = cn.BeginTransaction(IsolationLevel.Serializable)
            Try
                SqlHelper.ExecuteNonQuery(tr, _nombre_sp)
                SqlHelper.ExecuteNonQuery(tr, _nombre_spR)
                SqlHelper.ExecuteNonQuery(tr, _nombre_spRL)
                SqlHelper.ExecuteNonQuery(tr, _nombre_spWT)
                SqlHelper.ExecuteNonQuery(tr, _nombre_spWTL)

                tr.Commit()
                tr.Dispose()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                tr.Rollback()
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

    End Class

End Class
