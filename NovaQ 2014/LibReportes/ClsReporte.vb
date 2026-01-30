Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Imports CrystalDecisions.Shared.TableLogOnInfos
Imports CrystalDecisions.Shared.ConnectionInfo
Imports System.Configuration
Imports System.Configuration.ConfigurationSettings
Imports System.Collections.Specialized
Imports LibComunVar
Imports LibConexion
Imports System.Windows.Forms
Imports System.IO

Public Class ClsReporte
    Implements IDisposable

    Private mySetting As NameValueCollection
    Dim ConnectionCR As New ConnectionInfo
    Private ClsVarComun As LibComunVar.ClsVarComun
    Private ClsCnx As LibConexion.ClsData

    Private Sub LeerConfig()
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRServidor = mySetting("Servidor")
        STRUsuario = mySetting("Usuario")
        ClsVarComun = New LibComunVar.ClsVarComun
        ClsCnx = New LibConexion.ClsData
        STRBDatos = ClsVarComun.BaseDatos
        STRPassword = ClsCnx.DesEncryptString(mySetting("Password"))
        ClsVarComun = Nothing
        ClsCnx = Nothing
        'STRBDatos = mySetting("BDatos")
    End Sub

    Public Sub Muestra_Reporte_Exporta_PDF_II(ByVal STRnombreReporte As String, _
            ByVal myDatos As DataTable, ByVal STRnombreTabla As String, _
            ByVal STRfiltro As String, ByVal STRnombre_Archivo As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New frmReporte
            Dim myReporte As New ReportDocument

            Dim ruta As String = ""
            ruta = RutaReportes() & "\" & STRnombreReporte

            'Cargo el reporte segun ruta
            myReporte.Load(RutaReportes() & "\" & STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            'f.CRVisor.SelectionFormula = STRfiltro
            myReporte.SetDataSource(myDatos)
            Call LeerConfig()
            With ConnectionCR
                .ServerName = STRServidor
                .DatabaseName = STRBDatos
                .UserID = STRUsuario
                .Password = STRPassword
            End With
            Dim myTables As Tables = myReporte.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = ConnectionCR
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next


            'myReporte.SetDatabaseLogon(STRUsuario, STRPassword)
            f.Titulo = STRnombreReporte
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            'f.CRVisor.DisplayGroupTree = False
            f.CRVisor.ToolPanelView = Forms.ToolPanelViewType.None
            'f.CRVisor.ShowGroupTreeButton = False
            f.Show()

            ExportToPDF(myReporte, RutaReportes() & "\" & STRnombre_Archivo & ".pdf")
            'Dim rd As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rd.Load(ruta)
            'rd.SetDataSource(myDatos)
            'rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "C:\temp")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Muestra_Reporte_BP(ByVal STRnombreReporte As String,
            ByVal myDatos As DataTable, ByVal STRnombreTabla As String,
            ByVal STRfiltro As String, ByVal STRnombre_Archivo As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New frmReporte
            Dim myReporte As New ReportDocument

            Dim ruta As String = ""
            ruta = RutaReportes() & "\" & STRnombreReporte

            'Cargo el reporte segun ruta
            myReporte.Load(RutaReportes() & "\" & STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            'f.CRVisor.SelectionFormula = STRfiltro
            myReporte.SetDataSource(myDatos)
            Call LeerConfig()
            With ConnectionCR
                .ServerName = STRServidor
                .DatabaseName = STRBDatos
                .UserID = STRUsuario
                .Password = STRPassword
            End With
            Dim myTables As Tables = myReporte.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = ConnectionCR
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next


            'myReporte.SetDatabaseLogon(STRUsuario, STRPassword)
            f.Titulo = STRnombreReporte
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            'f.CRVisor.DisplayGroupTree = False
            f.CRVisor.ToolPanelView = Forms.ToolPanelViewType.None
            'f.CRVisor.ShowGroupTreeButton = False
            f.Show()

            'ExportToPDF(myReporte, STRnombreReporte & ".pdf", RutaReportes() & "\" & STRnombre_Archivo & ".pdf")
            'Dim rd As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rd.Load(ruta)
            'rd.SetDataSource(myDatos)
            'rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "C:\temp")

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Sub

    Public Sub Muestra_Reporte_Exporta_PDF(ByVal STRnombreReporte As String,
            ByVal myDatos As DataTable, ByVal STRnombreTabla As String,
            ByVal STRfiltro As String, ByVal STRnombre_Archivo As String, ByVal STRruta_carpeta As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New frmReporte
            Dim myReporte As New ReportDocument

            Dim ruta As String = ""
            ruta = RutaReportes() & "\" & STRnombreReporte

            'Cargo el reporte segun ruta
            myReporte.Load(RutaReportes() & "\" & STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            'f.CRVisor.SelectionFormula = STRfiltro
            myReporte.SetDataSource(myDatos)
            Call LeerConfig()
            With ConnectionCR
                .ServerName = STRServidor
                .DatabaseName = STRBDatos
                .UserID = STRUsuario
                .Password = STRPassword
            End With
            Dim myTables As Tables = myReporte.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = ConnectionCR
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next


            'myReporte.SetDatabaseLogon(STRUsuario, STRPassword)
            f.Titulo = STRnombreReporte
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            'f.CRVisor.DisplayGroupTree = False
            f.CRVisor.ToolPanelView = Forms.ToolPanelViewType.None
            'f.CRVisor.ShowGroupTreeButton = False
            'f.WindowState = FormWindowState.Minimized
            f.Show()
            f.Hide()

            ExportToPDF(myReporte, STRruta_carpeta & "\" & STRnombre_Archivo & ".pdf")
            'Dim rd As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rd.Load(ruta)
            'rd.SetDataSource(myDatos)
            'rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "C:\temp")
            f.Close()
            myReporte.Close()
            myReporte.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Muestra_Reporte(ByVal STRnombreReporte As String, _
                        ByVal myDatos As DataTable, ByVal STRnombreTabla As String)
        Try
            Dim f As New frmReporte
            Dim myReporte As New ReportDocument

            'Cargo el reporte segun ruta
            myReporte.Load(RutaReportes() & "\" & STRnombreReporte)

            myReporte.SetDataSource(myDatos)
            'Levanto el formulario del reporte

            Call LeerConfig()

            With ConnectionCR
                .ServerName = STRServidor
                .DatabaseName = STRBDatos
                .UserID = STRUsuario
                .Password = STRPassword
            End With
            Dim myTables As Tables = myReporte.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = ConnectionCR
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next


            'myReporte.SetDatabaseLogon(STRUsuario, STRPassword)

            f.CRVisor.ReportSource = myReporte
            f.Titulo = STRnombreReporte
            f.Show()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Muestra_Reporte(ByVal STRnombreReporte As String, _
            ByVal myDatos As DataTable, ByVal STRnombreTabla As String, _
            ByVal STRfiltro As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New frmReporte
            Dim myReporte As New ReportDocument

            Dim ruta As String = ""
            ruta = RutaReportes() & "\" & STRnombreReporte

            'Cargo el reporte segun ruta
            myReporte.Load(RutaReportes() & "\" & STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            'f.CRVisor.SelectionFormula = STRfiltro
            myReporte.SetDataSource(myDatos)
            Call LeerConfig()
            With ConnectionCR
                .ServerName = STRServidor
                .DatabaseName = STRBDatos
                .UserID = STRUsuario
                .Password = STRPassword
            End With
            Dim myTables As Tables = myReporte.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = ConnectionCR
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next


            'myReporte.SetDatabaseLogon(STRUsuario, STRPassword)
            f.Titulo = STRnombreReporte
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            'f.CRVisor.DisplayGroupTree = False
            f.CRVisor.ToolPanelView = Forms.ToolPanelViewType.None
            'f.CRVisor.ShowGroupTreeButton = False
            f.Show()


            'Dim rd As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rd.Load(ruta)
            'rd.SetDataSource(myDatos)
            'rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "C:\temp")

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Sub

    Public Sub Muestra_Reporte_Imprime_Directo(ByVal STRnombreReporte As String, _
            ByVal myDatos As DataTable, ByVal STRnombreTabla As String, _
            ByVal STRfiltro As String, ByVal nombrepdf As String, ByVal nombre_Impresora As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New frmReporte
            Dim myReporte As New ReportDocument

            Dim ruta As String = ""
            ruta = RutaReportes() & "\" & STRnombreReporte

            'Cargo el reporte segun ruta
            myReporte.Load(RutaReportes() & "\" & STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            'f.CRVisor.SelectionFormula = STRfiltro
            myReporte.SetDataSource(myDatos)
            'myReporte.PrintOptions.PrinterName = "HP Color LaserJet CP202X PCL6 Class Driver"
            'myReporte.PrintToPrinter(1, False, 0, 1)

            Call LeerConfig()
            With ConnectionCR
                .ServerName = STRServidor
                .DatabaseName = STRBDatos
                .UserID = STRUsuario
                .Password = STRPassword
            End With
            Dim myTables As Tables = myReporte.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = ConnectionCR
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next

            'myReporte.SetDatabaseLogon(STRUsuario, STRPassword)
            f.Titulo = STRnombreReporte
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            'f.CRVisor.DisplayGroupTree = False
            f.CRVisor.ToolPanelView = Forms.ToolPanelViewType.None
            'f.CRVisor.ShowGroupTreeButton = False

            'f.CRVisor.PrintReport()
            f.Show()
            ExportToPDF(myReporte, nombrepdf & ".pdf", nombre_Impresora)
            f.Close()

            'Dim rd As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rd.Load(ruta)
            'rd.SetDataSource(myDatos)
            'rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "C:\temp")

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Sub

    Public Function ExportToPDF(rpt As ReportDocument, NombreArchivo As String, NombreImpresora As String) As String
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()

        Try
            rpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            rpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat

            vFileName = RutaReportes() & "\" & NombreArchivo
            If File.Exists(vFileName) Then
                File.Delete(vFileName)
            End If
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        End Try

        Return vFileName
    End Function

    Public Shared Function ExportToPDF(rpt As ReportDocument, NombreArchivo As String) As String
        Dim vFileName As String = Nothing
        Dim diskOpts As New DiskFileDestinationOptions()

        Try
            rpt.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            rpt.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat


            vFileName = NombreArchivo
            If File.Exists(vFileName) Then
                File.Delete(vFileName)
            End If
            diskOpts.DiskFileName = vFileName
            rpt.ExportOptions.DestinationOptions = diskOpts
            rpt.Export()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return vFileName
    End Function


    Public Sub Muestra_Reporte(ByVal STRnombreReporte As String, _
            ByVal STRfiltro As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New frmReporte
            Dim myReporte As New ReportDocument

            'Cargo el reporte segun ruta
            Dim ruta As String = ""
            ruta = RutaReportes() & "\" & STRnombreReporte

            myReporte.Load(RutaReportes() & "\" & STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            f.CRVisor.SelectionFormula = STRfiltro
            f.Titulo = STRnombreReporte
            Call LeerConfig()
            With ConnectionCR
                .ServerName = STRServidor
                .DatabaseName = STRBDatos
                .UserID = STRUsuario
                .Password = STRPassword
            End With
            Dim myTables As Tables = myReporte.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = ConnectionCR
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next
            '     Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            'f.CRVisor.DisplayGroupTree = False
            f.CRVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            f.Show()
            'ExportToPDF(myReporte, STRnombreReporte & ".pdf")
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Shared Function Genera_Parametros(ByVal ParamArray MyMatriz() As String) As ParameterFields
        Dim c As Long, STRnombre As String, STRvalor As String, l As Integer
        Dim parametros As New ParameterFields

        Try
            For c = 0 To MyMatriz.Length - 1
                l = InStr(MyMatriz(c), ";")
                If l > 0 Then
                    STRnombre = Mid(MyMatriz(c), 1, l - 1)
                    STRvalor = Mid(MyMatriz(c), l + 1, Len(MyMatriz(c)) - l)
                    Dim parametro As New ParameterField
                    Dim dVal As New ParameterDiscreteValue
                    parametro.ParameterFieldName = STRnombre
                    dVal.Value = STRvalor
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)
                End If
            Next
            Return (parametros)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Function RutaReportes() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRutaReportes = mySetting("Reportes")
        Return STRRutaReportes
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
