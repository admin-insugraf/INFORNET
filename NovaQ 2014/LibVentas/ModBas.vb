Imports System.Windows.Forms
Imports LibComunVar
Imports System.IO
Imports System.Drawing
Imports System.Xml
Imports System.Xml.XPath
Module ModBas
    Friend dtTable As DataTable
    Friend STRRuta_FE As String
    Friend STRRuta_FE_Verificacion As String
    Friend STRRuc As String
    Friend STRRutaReportes As String

    Public Sub MostrarError(ByVal STRExcep As String)
        Dim f As New frmError
        f.txtError.Text = "Se produjo el siguiente error:" & vbCrLf & STRExcep
        f.ShowDialog()
    End Sub
    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Public Function Leer_XML_CDR(ByVal STRRUTA_ARCHIVO As String, ByVal NOMBRE_TAG As String) As String
        Dim dato As String = String.Empty
        Try
            Dim m_xmld As XmlDocument
            Dim i As Integer
            m_xmld = New XmlDocument()
            m_xmld.Load(STRRUTA_ARCHIVO)

            Dim xmlmanager As XmlNamespaceManager = New XmlNamespaceManager(m_xmld.NameTable)
            xmlmanager.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/")
            xmlmanager.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#")
            xmlmanager.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")
            xmlmanager.AddNamespace("ar", "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2")
            xmlmanager.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
            xmlmanager.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
            dato = m_xmld.SelectSingleNode(NOMBRE_TAG, xmlmanager).InnerText
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            dato = ""
        End Try
        Return dato
    End Function

    Public Function Leer_Ticket(ByVal STRRUTA_ARCHIVO As String) As String
        Dim dato As String = String.Empty
        Try
            Dim objReader As New StreamReader(STRRUTA_ARCHIVO)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()

            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()

            For Each sLine In arrText
                dato = sLine
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            dato = ""
        End Try
        Return dato
    End Function
End Module
