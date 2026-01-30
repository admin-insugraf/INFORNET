Public Interface Implementacion

    Public Interface RECEIVABLE
        Function get_DatosGeneralesFacturacion(ByVal _FECHA_INI As String, ByVal _FECHA_FIN As String, ByVal _OPCION As Integer, _
                                               ByVal _TIPODOCUMENTO As String) As DataTable
    End Interface

End Interface
