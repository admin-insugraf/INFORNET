Public Class InputHandler

#Region "private"
    Private entries As New System.Collections.Generic.List(Of prop)
#End Region

#Region "public"
    Public Sub AddEntries(ByVal entry As prop)
        entries.Add(entry)
    End Sub

    Public Function GetEntries() As System.Collections.Generic.List(Of prop)
        Return entries
    End Function

#End Region


End Class
