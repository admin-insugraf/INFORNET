Imports System.Data.Entity

Public Class AlmacenConfiguration
    Inherits DbConfiguration

    Public Sub New()
        SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance)
    End Sub
End Class
