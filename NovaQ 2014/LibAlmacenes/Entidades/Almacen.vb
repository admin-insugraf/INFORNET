Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Public Class Almacen

    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Distrito As String
    Public Property Telefono As String
    Public Property IdTipoArticulo As String
    Public Property UltimoIngreso As Decimal
    Public Property UltimaSalida As Decimal
    Public Property Estado As String

    Public Sub New()
        Estado = "V"
    End Sub
End Class
