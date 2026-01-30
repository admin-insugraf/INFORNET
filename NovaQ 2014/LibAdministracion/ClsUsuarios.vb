Imports LibConexion
Public Class ClsUsuarios
    Private LibData As LibConexion.ClsData


    Public Function Eliminar_usuario(ByVal STRCodigo As String) As Boolean
        Try
            LibData = New LibConexion.ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_SP_D_ELIMINA_USUARIO", _
                            LibData.DatosParam("@CODUSUARIO", SqlDbType.VarChar, 20, STRCodigo))
            LibData.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function Accesos_Usuario(ByVal STRCodigo As String) As DataTable
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

    Public Function Lista_Usuarios(ByVal STRCodigo As String, ByVal STRNombre As String) As DataTable
        Try
            LibData = New ClsData
            Lista_Usuarios = LibData.Run_SP_DataTable("ADM_LISTAR_USUARIOS", _
                            LibData.DatosParam("@codigo", SqlDbType.VarChar, 30, STRCodigo), _
                            LibData.DatosParam("@nombre", SqlDbType.VarChar, 80, STRNombre))
            LibData = Nothing
        Catch ex As Exception
            Call MostrarError(ex.Message)
        Finally

        End Try
    End Function
    Public Function Lista_Perfiles() As DataTable
        Try
            LibData = New ClsData
            Lista_Perfiles = LibData.Run_SP_DataTable("ADM_LISTA_PERFILES")
            LibData = Nothing
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function
    Public Function Lista_Perfil_Opcion(ByVal STRCodPerfil As String) As DataTable
        Try
            LibData = New ClsData
            Lista_Perfil_Opcion = LibData.Run_SP_DataTable("ADM_ACCESO_PERFIL", _
                            LibData.DatosParam("@codperfil", SqlDbType.VarChar, 20, STRCodPerfil))
            LibData = Nothing
        Catch ex As Exception
            Call MostrarError(ex.Message)
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

    Public Function Niveles_Acceso_Usuarios(ByVal STRCodigo As String) As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_LISTA_NIVELES_USUARIO", _
                            LibData.DatosParam("@codigo", SqlDbType.Char, 2, STRCodigo))
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Carga_Lista_Documentos() As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_LISTA_DATOS_USUARIO")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Lista_Datos_Mantenimientos() As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_LISTA_DATOS_USUARIO_I")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function


    Public Function Lista_DatosPerfiles() As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_SP_S_PERFILES")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function


    Public Function Get_MostrarAlmacenes() As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_SP_S_WAREHOUSE_AYUDA")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Throw
        End Try
    End Function

    Public Function Get_MostrarVendedores() As DataTable
        Try
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_SP_S_SALES_REP_AYUDA")
            LibData.Dispose()
            Return dtTable
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Throw
        End Try
    End Function


    Public Function Existe_Usuario(ByVal STRCodigoUsuario As String) As Boolean
        Try
            Dim BOLExiste As Boolean
            LibData = New ClsData
            dtTable = New DataTable
            dtTable = LibData.Run_SP_DataTable("ADM_DATOS_USUARIO", _
                            LibData.DatosParam("@codigo", SqlDbType.VarChar, 15, STRCodigoUsuario))
            If dtTable.Rows.Count > 0 Then
                BOLExiste = True
            Else
                BOLExiste = False
            End If
            LibData.Dispose()
            Return BOLExiste
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Return False
        End Try
    End Function

    Public Function Creacion_Actualizacion_Usuarios(ByVal STRCodUsuario As String, _
                            ByVal STRNomUsuario As String, ByVal STRPassUsuario As String, _
                            ByVal STRFecInicio As String, ByVal STRFecFinal As String, _
                            ByVal STREstado As String, ByVal STRNivelAcceso As String, _
                            ByVal STRInsUpd As String, ByVal StrCodigoPerfil As String, _
                            ByVal strAccesoAlmacen As String, ByVal strAccesoVendedor As String, ByVal Opt As String,
                            ByVal Area As String, ByVal Personal As String, ByVal Email As String, _
                            ByVal Tipo_doc As String, ByVal Serie_doc As String, ByVal Valida_Stock As String, ByVal Manejo_Cartera As String, _
                            ByVal Modifica_numeracion_fact As String, ByVal Modifica_pe As String) As Boolean
        Try
            LibData = New ClsData
            If LibData.Run_Store_Procedure("ADM_CREAR_USUARIOS", _
                        LibData.DatosParam("@cod_usuario", SqlDbType.VarChar, 50, STRCodUsuario), _
                        LibData.DatosParam("@nom_usuario", SqlDbType.VarChar, 80, STRNomUsuario), _
                        LibData.DatosParam("@pass_usuario", SqlDbType.VarChar, 15, STRPassUsuario), _
                        LibData.DatosParam("@fecha_inicio", SqlDbType.DateTime, 0, STRFecInicio), _
                        LibData.DatosParam("@fecha_fin", SqlDbType.DateTime, 0, STRFecFinal), _
                        LibData.DatosParam("@estado", SqlDbType.Char, 1, STREstado), _
                        LibData.DatosParam("@nivel_acceso", SqlDbType.Char, 2, STRNivelAcceso), _
                        LibData.DatosParam("@ins_upd", SqlDbType.Char, 1, STRInsUpd), _
                        LibData.DatosParam("@cod_perfil", SqlDbType.VarChar, 255, StrCodigoPerfil), _
                        LibData.DatosParam("@acceso_almacenes", SqlDbType.VarChar, 255, strAccesoAlmacen), _
                        LibData.DatosParam("@acceso_vendedor", SqlDbType.VarChar, 255, strAccesoVendedor), _
                        LibData.DatosParam("@OPT_VALIDADO", SqlDbType.VarChar, 1, Opt), _
                        LibData.DatosParam("@AREA", SqlDbType.VarChar, 6, Area), _
                        LibData.DatosParam("@PERSONAL", SqlDbType.VarChar, 8, Personal), _
                        LibData.DatosParam("@EMAIL", SqlDbType.VarChar, 255, Email), _
                        LibData.DatosParam("@TIPO_DOC", SqlDbType.VarChar, 5, Tipo_doc), _
                        LibData.DatosParam("@SERIE_DOC", SqlDbType.VarChar, 5, Serie_doc), _
                        LibData.DatosParam("@VALIDA_STOCK", SqlDbType.VarChar, 2, Valida_Stock), _
                        LibData.DatosParam("@MANEJO_CARTERA", SqlDbType.VarChar, 2, Manejo_Cartera), _
                        LibData.DatosParam("@MODIFICA_NUMERACION_FACT", SqlDbType.VarChar, 2, Modifica_numeracion_fact), _
                        LibData.DatosParam("@MODIFICA_PE", SqlDbType.VarChar, 2, Modifica_pe)) = True Then
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
