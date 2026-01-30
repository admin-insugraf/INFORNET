Imports LibConexion

Public Class ClsTipoPedido
    Private LibData As LibConexion.ClsData


    Public Function Eliminar_TipoPedido(ByVal STRCodigo As String) As Boolean
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_SP_D_ELIMINA_TIPOPEDIDO", _
                            LibData.DatosParam("@CODTIPOPEDIDO", SqlDbType.VarChar, 20, STRCodigo))
            LibData.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function Accesos_TipoPedido(ByVal STRCodigo As String) As DataTable
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("AX_ACCESO_USUARIO", _
                            LibData.DatosParam("@codigo", SqlDbType.Char, 15, STRCodigo))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Lista_TipoPedido(ByVal STRCodigo As String, ByVal STRDescripcion As String) As DataTable
        Try
            LibData = New ClsData
            Lista_TipoPedido = LibData.Run_SP_DataTable("ADM_LISTAR_TIPOPEDIDO",
                            LibData.DatosParam("@codigo", SqlDbType.VarChar, 10, STRCodigo),
                            LibData.DatosParam("@descripcion", SqlDbType.VarChar, 80, STRDescripcion))
            LibData = Nothing
        Catch ex As Exception
            Call MostrarError(ex.Message)
        Finally

        End Try
    End Function

    Public Function GuardarPermisos(ByVal myDataTable As DataTable, ByVal STRCodigo As String) As Boolean
        Try
            LibData = New ClsData
            If LibData.Run_Store_Procedure("AX_ELIMINA_ACCESO_USUARIO", _
                                    LibData.DatosParam("@codigo", SqlDbType.VarChar, 30, STRCodigo)) = True Then
                If LibData.CopyDataTableBulk(myDataTable, "USUARIOS_OPCION") Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
            LibData.Dispose()
            LibData = Nothing

        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function GuardaPerfil(ByVal STRCodPerfil As String, ByVal STRDesPerfil As String, ByVal STRCodUsuario As String,
                                    ByVal STRHabilitadoSN As String, ByVal STRInsUpd As String,
                                    ByVal myDataTable As DataTable) As Boolean
        Try
            LibData = New ClsData

            GuardaPerfil = LibData.Run_Store_Procedure("ADM_GUARDA_PERFIL", _
                                LibData.DatosParam("@COD_PERFIL", SqlDbType.VarChar, 20, STRCodPerfil), _
                                LibData.DatosParam("@DES_PERFIL", SqlDbType.VarChar, 60, STRDesPerfil), _
                                LibData.DatosParam("@COD_USUARIO", SqlDbType.VarChar, 15, STRCodUsuario), _
                                LibData.DatosParam("@HABILITADO", SqlDbType.Char, 1, STRHabilitadoSN), _
                                LibData.DatosParam("@INS_UPD", SqlDbType.Char, 1, STRInsUpd))

            'Guarda detalle de perfil
            If LibData.Run_Store_Procedure("ADM_ELIMINA_PERFIL_OPCION", _
                                LibData.DatosParam("@COD_PERFIL", SqlDbType.VarChar, 20, STRCodPerfil)) = True Then
                If LibData.CopyDataTableBulk(myDataTable, "ADM_PERFIL_OPCION") = True Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
            LibData.Dispose()
            LibData = Nothing
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function



    'Public Function Carga_Lista_Documentos() As DataTable
    '    Try
    '        LibData = New ClsData
    '        dtTable = New DataTable
    '        dtTable = LibData.Run_SP_DataTable("ADM_LISTA_DATOS_USUARIO")
    '        LibData.Dispose()
    '        Return dtTable
    '    Catch ex As Exception
    '        Call MostrarError(ex.Message)
    '    End Try
    'End Function

    Public Function Lista_Datos_Mantenimientos() As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_LISTA_DATOS_TIPOPEDIDO")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function


    Public Function Get_MostrarTransacciones() As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("GUIA_SP_S_TRANSACCION_SALIDA_AYUDA")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Throw
        End Try
    End Function


    Public Function Existe_TipoPedido(ByVal STRCodigo As String) As Boolean
        Try
            Dim Existe As Boolean
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_DATOS_TIPOPEDIDO",
                            LibData.DatosParam("@codigo", SqlDbType.VarChar, 10, STRCodigo))
            If dtTable.Rows.Count > 0 Then
                Existe = True
            Else
                Existe = False
            End If
            LibData.Dispose()
            Return Existe
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Return False
        End Try
    End Function

    Public Function Creacion_Actualizacion_TipoPedido(ByVal STRCodigo As String,
                            ByVal STRDescripcion As String, ByVal strVincularTransaccion As String,
                             ByVal STRInsUpd As String) As Boolean
        Try
            LibData = New ClsData
            If LibData.Run_Store_Procedure("ADM_CREAR_TIPOPEDIDO",
                        LibData.DatosParam("@codigo", SqlDbType.VarChar, 10, STRCodigo),
                        LibData.DatosParam("@descripcion", SqlDbType.VarChar, 80, STRDescripcion),
                        LibData.DatosParam("@vincular_transacciones", SqlDbType.VarChar, 255, strVincularTransaccion),
                        LibData.DatosParam("@ins_upd", SqlDbType.Char, 1, STRInsUpd)) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Return False
        End Try
    End Function
End Class
