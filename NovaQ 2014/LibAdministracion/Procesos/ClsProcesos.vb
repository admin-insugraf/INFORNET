Imports LibConexion
Public Class ClsProcesos
    Private LibDataTipo As LibConexion.ClsDataTipo

    Public Function Inserta_PtoVentas(ByVal cCab As ClsDocSerieTO.Cab_Pto_Venta, _
                                   ByVal cDet As List(Of ClsDocSerieTO.Det_Doc_Serie), _
                                   ByVal STRInsUpd As String) As Boolean
        Try
            Dim BOLOk As Boolean = False
            LibDataTipo = New LibConexion.ClsDataTipo

            BOLOk = LibDataTipo.Run_Store_Procedure("ADM_INSERT_PTO_VENTA", "", _
                            LibDataTipo.DatosParam("@sales_place_id", SqlDbType.VarChar, 2, cCab.CodPtoVenta, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@sales_place_description", SqlDbType.VarChar, 30, cCab.Descripcion, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@sales_place_addr", SqlDbType.VarChar, 60, cCab.Direccion, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@warehouse_id", SqlDbType.VarChar, 2, cCab.CodAlmacen, ParameterDirection.Input), _
                            LibDataTipo.DatosParam("@insupd", SqlDbType.VarChar, 1, STRInsUpd, ParameterDirection.Input))
            LibDataTipo = Nothing



            BOLOk = False
            LibDataTipo = New LibConexion.ClsDataTipo
            BOLOk = LibDataTipo.Run_Query("Delete from DOCUMENT_PLACE_SALES where PLACE_SALES_ID=" & cCab.CodPtoVenta)
            BOLOk = False
            For Each detalle As ClsDocSerieTO.Det_Doc_Serie In cDet
                BOLOk = LibDataTipo.Run_Store_Procedure("ADM_INSERT_DOC_PTO_VENTA", "", _
                                    LibDataTipo.DatosParam("@place_sales_id", SqlDbType.VarChar, 7, cCab.CodPtoVenta, ParameterDirection.Input), _
                                    LibDataTipo.DatosParam("@document_type", SqlDbType.VarChar, 7, detalle.TipoDoc, ParameterDirection.Input), _
                                    LibDataTipo.DatosParam("@number_serie", SqlDbType.VarChar, 3, detalle.Serie, ParameterDirection.Input))
            Next
            LibDataTipo = Nothing
            Return BOLOk
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function
End Class
