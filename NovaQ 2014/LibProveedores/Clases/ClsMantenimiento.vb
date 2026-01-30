Imports LibConexion
Public Class ClsMantenimiento
    Implements IDisposable

    Private LibData As LibConexion.ClsData

    Public Function Ins_Upd_Areas(ByVal Area As AreasTO, ByVal STRInsUpd As String) As Boolean
        Try
            Dim BOLok As Boolean
            LibData = New LibConexion.ClsData

            If STRInsUpd = "I" Then
                BOLok = LibData.Run_Query("Insert into AREA values('" & Area.Id & "','" & Area.Descripcion & "')")
            Else
                BOLok = LibData.Run_Query("update AREA set description='" & Area.Descripcion & "' where id='" & Area.Id & "'")
            End If

            Return BOLok
            LibData = Nothing
        Catch ex As Exception
            Call MostrarError(ex.Message)
        End Try
    End Function




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
