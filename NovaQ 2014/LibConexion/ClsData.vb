Imports System.Data
Imports System.Configuration
Imports System.Configuration.ConfigurationSettings
Imports System.Collections.Specialized
Imports LibComunVar

Public Class ClsData
    Implements IDisposable

    Private mySetting As NameValueCollection
    Private CnxSql As SqlClient.SqlConnection
    Private CnxTexto As OleDb.OleDbConnection
    Private CnxExcel As OleDb.OleDbConnection
    Friend myArrayParam As New ArrayList
    Private dtDatos As DataTable
    Private dsDatos As DataSet
    Private daDatos As SqlClient.SqlDataAdapter
    Private drDatos As SqlClient.SqlDataReader
    Private cmdDatos As SqlClient.SqlCommand
    Private STRCadCnx As String = Nothing
    Private Const cnstKey As String = "BUBU"
    Private ClsVarComun As LibComunVar.ClsVarComun

    Private Sub LeerConfig()
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRServidor = mySetting("Servidor")
        'STRBDatos = mySetting("BDatos")
        ClsVarComun = New LibComunVar.ClsVarComun
        STRBDatos = ClsVarComun.BaseDatos
        ClsVarComun = Nothing

        STRUsuario = mySetting("Usuario")

        STRPassword = DesEncryptString(mySetting("Password"))
        'STRPassword = mySetting("Password")
    End Sub

    Public Function CadenaConexion() As String
        Me.LeerConfig()
        STRCadCnx = "data source=" & STRServidor & ";initial catalog=" & STRBDatos & ";" & _
                         "persist security info=false;user id=" & STRUsuario & ";" & _
                         "password=" & STRPassword
        Return STRCadCnx
    End Function

    Public Function ConexionBD() As SqlClient.SqlConnection
        Try
            Call LeerConfig()
            STRCadCnx = "data source=" & STRServidor & ";initial catalog=" & STRBDatos & ";" & _
                         "persist security info=false;user id=" & STRUsuario & ";" & _
                         "password=" & STRPassword
            CnxSql = New SqlClient.SqlConnection(STRCadCnx)
            CnxSql.Open()
            Return CnxSql
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Private Sub ColeccionParametro(ByRef CmdComando As SqlClient.SqlCommand, ByVal ParamArray argparams() As Object)
        Dim INTval As Integer
        Dim oParam As SqlClient.SqlParameter
        For INTval = 0 To myArrayParam.Count - 1
            oParam = New SqlClient.SqlParameter
            oParam.ParameterName = CType(myArrayParam(INTval), ArregloParam).STRnombre
            oParam.SqlDbType = CType(myArrayParam(INTval), ArregloParam).STRtipo
            oParam.Size = CType(myArrayParam(INTval), ArregloParam).INTTamano
            oParam.Value = CType(myArrayParam(INTval), ArregloParam).OBJvalor
            If CType(myArrayParam(INTval), ArregloParam).BYTPrec <> 0 Then
                oParam.Precision = CType(myArrayParam(INTval), ArregloParam).BYTPrec
                oParam.Precision = CType(myArrayParam(INTval), ArregloParam).BYTScala
            End If
            CmdComando.Parameters.Add(oParam)
        Next
        myArrayParam.Clear()
    End Sub
    Public Function DatosParam(ByVal STRNombre As String, ByVal PTipo As System.Data.SqlDbType, _
                                ByVal INTtamano As Integer, ByVal oVal As Object, Optional ByVal BYTPrec As Byte = 0, Optional ByVal BYTScala As Byte = 0)
        myArrayParam.Add(New ArregloParam(STRNombre, PTipo, INTtamano, oVal, BYTPrec, BYTScala))
    End Function

    Public Structure ArregloParam
        Public STRnombre As String
        Public STRtipo As System.Data.SqlDbType
        Public INTTamano As Integer
        Public OBJvalor As Object
        Public BYTPrec As Byte
        Public BYTScala As Byte
        Public Sub New(ByVal nombre As String, ByVal tipo As System.Data.SqlDbType, ByVal Tamano As Integer, _
                       ByVal valor As Object, ByVal Precision As Byte, ByVal Escala As Byte)
            STRnombre = nombre
            STRtipo = tipo
            INTTamano = Tamano
            OBJvalor = valor
            BYTPrec = Precision
            BYTScala = Escala
        End Sub
    End Structure
    Public Function Run_SP_DataReader(ByVal STRsp As String, _
                                      ByVal ParamArray params() As Object) As SqlClient.SqlDataReader
        Try
            cmdDatos = New SqlClient.SqlCommand(STRsp)
            cmdDatos.CommandType = CommandType.StoredProcedure
            cmdDatos.Connection = ConexionBD()
            Call ColeccionParametro(cmdDatos, params)
            drDatos = cmdDatos.ExecuteReader
            Return drDatos
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function Run_SP_DataTable(ByVal STRsp As String, _
                                       ByVal ParamArray params() As Object) As DataTable
        Try
            cmdDatos = New SqlClient.SqlCommand(STRsp)
            cmdDatos.CommandType = CommandType.StoredProcedure
            cmdDatos.Connection = ConexionBD()
            daDatos = New SqlClient.SqlDataAdapter
            Call ColeccionParametro(cmdDatos, params)
            daDatos = New SqlClient.SqlDataAdapter(cmdDatos)
            dtDatos = New DataTable
            dtDatos.Clear()
            daDatos.Fill(dtDatos)
            CnxSql.Close()
            Return dtDatos
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Throw
        End Try
    End Function

    Public Function Run_SP_DataTable(ByVal STRsp As String, _
                                     ByRef myAdapter As SqlClient.SqlDataAdapter, _
                                       ByVal ParamArray params() As Object) As DataTable
        Try
            cmdDatos = New SqlClient.SqlCommand(STRsp)
            cmdDatos.CommandType = CommandType.StoredProcedure
            cmdDatos.Connection = ConexionBD()
            myAdapter = New SqlClient.SqlDataAdapter
            Call ColeccionParametro(cmdDatos, params)
            myAdapter = New SqlClient.SqlDataAdapter(cmdDatos)
            dtDatos = New DataTable
            dtDatos.Clear()
            myAdapter.Fill(dtDatos)
            CnxSql.Close()
            Return dtDatos
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function
    Public Function Run_SP_DataSet(ByVal STRsp As String, _
                                   ByVal STRNomTabla As String, _
                                   ByVal ParamArray params() As Object) As DataSet
        Try
            cmdDatos = New SqlClient.SqlCommand(STRsp)
            cmdDatos.CommandType = CommandType.StoredProcedure
            cmdDatos.Connection = ConexionBD()
            daDatos = New SqlClient.SqlDataAdapter
            Call ColeccionParametro(cmdDatos, params)
            daDatos = New SqlClient.SqlDataAdapter(cmdDatos)
            dsDatos = New DataSet
            daDatos.Fill(dsDatos, STRNomTabla)
            CnxSql.Close()
            Return dsDatos
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function
    Public Function Run_Store_Procedure(ByVal STRsp As String, _
                                        ByVal ParamArray params() As Object) As Boolean
        Dim myTrans As SqlClient.SqlTransaction
        Try
            Dim IntReg As Integer
            cmdDatos = New SqlClient.SqlCommand(STRsp)
            cmdDatos.CommandType = CommandType.StoredProcedure
            cmdDatos.Connection = ConexionBD()
            Call ColeccionParametro(cmdDatos, params)
            myTrans = CnxSql.BeginTransaction
            cmdDatos.Transaction = myTrans
            IntReg = cmdDatos.ExecuteNonQuery
            myTrans.Commit()
            CnxSql.Close()
            Return True
        Catch ex As Exception
            myTrans.Rollback()
            Call MostrarError(ex.Message)
            Return False
        End Try
    End Function

    Public Function Run_Query(ByVal STRQuery As String) As Boolean
        Dim myTrans As SqlClient.SqlTransaction
        Try
            Dim IntReg As Integer
            cmdDatos = New SqlClient.SqlCommand(STRQuery)
            cmdDatos.CommandType = CommandType.Text
            cmdDatos.Connection = ConexionBD()
            myTrans = CnxSql.BeginTransaction
            cmdDatos.Transaction = myTrans
            IntReg = cmdDatos.ExecuteNonQuery
            myTrans.Commit()
            CnxSql.Close()
            Return True
        Catch ex As Exception
            myTrans.Rollback()
            Call MostrarError(ex.Message)
            Return False
        End Try
    End Function

    Public Function Run_Query_DataTable(ByVal STRQuery As String) As DataTable
        Try
            cmdDatos = New SqlClient.SqlCommand(STRQuery)
            cmdDatos.CommandType = CommandType.Text
            cmdDatos.Connection = ConexionBD()
            daDatos = New SqlClient.SqlDataAdapter
            daDatos = New SqlClient.SqlDataAdapter(cmdDatos)
            dtDatos = New DataTable
            dtDatos.Clear()
            daDatos.Fill(dtDatos)
            CnxSql.Close()
            Return dtDatos
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function

    Public Function CopyDataTableBulk(ByVal dTable As DataTable, ByVal STRNomTablaDestino As String) As Boolean
        Try
            Dim mySqlBulk As SqlClient.SqlBulkCopy = New SqlClient.SqlBulkCopy(ConexionBD())
            mySqlBulk.DestinationTableName = STRNomTablaDestino
            mySqlBulk.WriteToServer(dTable)
            CnxSql.Close()
            Return True
        Catch ex As Exception
            Call MostrarError(ex.Message)
            Return False
        End Try
    End Function
#Region "Funciones para encriptado y desencriptado de password"

    Public Function EncryptString(ByRef Text As String) As String
        Dim Temp As Short
        Dim i As Short
        Dim j As Short
        Dim n As Short
        Dim rtn As String = ""

        n = Len(cnstKey)
        Dim UserKeyASCIIS(n) As Short
        For i = 1 To n
            UserKeyASCIIS(i) = Asc(Mid(cnstKey, i, 1))
        Next

        Dim TextASCIIS(Len(Text)) As Short
        For i = 1 To Len(Text)
            TextASCIIS(i) = Asc(Mid(Text, i, 1))
        Next

        For i = 1 To Len(Text)
            j = IIf(j + 1 >= n, 1, j + 1)
            Temp = TextASCIIS(i) + UserKeyASCIIS(j)
            If Temp > 255 Then
                Temp = Temp - 255
            End If
            rtn = rtn & Chr(Temp)
        Next
        EncryptString = rtn
    End Function

    Public Function DesEncryptString(ByRef Text As String) As String
        Dim Temp As Short
        Dim i As Short
        Dim j As Short
        Dim n As Short
        Dim rtn As String = ""

        n = Len(cnstKey)
        Dim UserKeyASCIIS(n) As Short
        For i = 1 To n
            UserKeyASCIIS(i) = Asc(Mid(cnstKey, i, 1))
        Next

        Dim TextASCIIS(Len(Text)) As Short
        For i = 1 To Len(Text)
            TextASCIIS(i) = Asc(Mid(Text, i, 1))
        Next

        For i = 1 To Len(Text)
            j = IIf(j + 1 >= n, 1, j + 1)
            Temp = TextASCIIS(i) - UserKeyASCIIS(j)
            If Temp < 0 Then
                Temp = Temp + 255
            End If
            rtn = rtn & Chr(Temp)
        Next
        DesEncryptString = rtn
    End Function
#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: eliminar estado administrado (objetos administrados).
            End If

            ' TODO: liberar recursos no administrados (objetos no administrados) e invalidar Finalize() below.
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: invalidar Finalize() sólo si la instrucción Dispose(ByVal disposing As Boolean) anterior tiene código para liberar recursos no administrados.
    'Protected Overrides Sub Finalize()
    '    ' No cambie este código. Ponga el código de limpieza en la instrucción Dispose(ByVal disposing As Boolean) anterior.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose(disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
