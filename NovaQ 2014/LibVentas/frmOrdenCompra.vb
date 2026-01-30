Imports System.Collections.Specialized
Imports System.IO
Imports System.Windows.Forms
Imports LibCobranzas

Public Class frmOrdenCompra

    Public pdfBytes As Byte()
    Public Consulta As Boolean = False

    Private STRTitulo As String
    Private INTTipoAyuda As Integer
    Private _CadenaConsulta As String
    Private clsBusquedaBl As ClsBuscar
    Private dtData As DataTable
    Private dtv As DataView
    Private STRorden As String
    Protected dtHelp As New DataTable
    Private _NumeroPedido As String
    Dim clsPedidoBl As ClsOperaciones.ORDERS
    Private mySetting As NameValueCollection

    Enum STipoAyuda
        PtoVenta = 0
        Clientes = 1
        Articulos = 2
        Transportistas = 3
        Vendedores = 4
        FormaPago = 5
        Reportes = 6
    End Enum

    Public Property CadenaConsulta As String
        Get
            Return _CadenaConsulta
        End Get
        Set(value As String)
            _CadenaConsulta = value
        End Set
    End Property


    Public Property NumeroPedido As String
        Get
            Return _NumeroPedido
        End Get
        Set(value As String)
            _NumeroPedido = value
        End Set
    End Property


    Public Property Data_Matriz() As DataTable
        Get
            Return dtHelp
        End Get
        Set(ByVal Value As DataTable)
            dtHelp = Value
        End Set
    End Property
    Public Property Titulo As String
        Get
            Return STRTitulo
        End Get
        Set(value As String)
            STRTitulo = value
        End Set
    End Property
    Public Property TipoAyuda As STipoAyuda
        Get
            Return INTTipoAyuda
        End Get
        Set(value As STipoAyuda)
            INTTipoAyuda = value
        End Set
    End Property


    Private Sub tAceptar_Click(sender As Object, e As EventArgs) Handles tAceptar.Click
        If txtRutaArchivo.Text <> String.Empty Then

            Dim nombreArchivo As String = System.IO.Path.GetFileName(txtRutaArchivo.Text)
            ' Resultado: "OrdenCompra.pdf"

            ' Leer el archivo y convertirlo a bytes
            Dim bytesArchivo() As Byte = System.IO.File.ReadAllBytes(txtRutaArchivo.Text)


            pdfBytes = File.ReadAllBytes(txtRutaArchivo.Text)

            If Not txt_SerieNumero.Text <> String.Empty Then
                MsgBox("Ingrese Serie-Numero", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            DialogResult = System.Windows.Forms.DialogResult.OK

            'If _NumeroPedido <> "" Then
            '    clsPedidoBl = New ClsOperaciones.ORDERS
            '    If clsPedidoBl.Actualizar_OrdenCompra_Pedido(_NumeroPedido, pdfBytes, txt_SerieNumero.Text) = True Then
            '        MsgBox("Se actualizo Orden de Compra", MsgBoxStyle.Information)
            '        Me.Close()
            '        Exit Sub
            '    End If
            'Else
            '    DialogResult = System.Windows.Forms.DialogResult.OK
            'End If
        Else
            pdfBytes = Nothing
            DialogResult = System.Windows.Forms.DialogResult.OK

        End If

        'If _NumeroPedido <> "" And txt_SerieNumero.Text <> String.Empty Then
        '    clsPedidoBl = New ClsOperaciones.ORDERS
        '    If clsPedidoBl.Actualizar_OrdenCompra_Pedido(_NumeroPedido, Nothing, txt_SerieNumero.Text) = True Then
        '        MsgBox("Se actualizo Orden de Compra", MsgBoxStyle.Information)
        '        Me.Close()
        '        Exit Sub
        '    End If
        'End If
    End Sub




    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles TCancelar.Click

        If _NumeroPedido <> "" Then
            Me.Close()
        Else
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If


    End Sub



    Public Function HexStringToByteArray(hexString As String) As Byte()
        ' Remover el prefijo "0x" si existe
        If hexString.StartsWith("0x") OrElse hexString.StartsWith("0X") Then
            hexString = hexString.Substring(2)
        End If

        ' Crear el array de bytes
        Dim numberChars As Integer = hexString.Length
        Dim bytes(numberChars \ 2 - 1) As Byte

        ' Convertir cada par de caracteres hex a byte
        For i As Integer = 0 To bytes.Length - 1
            bytes(i) = Convert.ToByte(hexString.Substring(i * 2, 2), 16)
        Next

        Return bytes
    End Function

    Private Function Ruta_FE() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRuta_FE = mySetting("Ruta_FE")
        Return STRRuta_FE
    End Function

    Private Function Ruta_Reportes() As String
        mySetting = System.Configuration.ConfigurationSettings.AppSettings()
        STRRutaReportes = mySetting("Reportes")
        Return STRRutaReportes
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles TPDF.Click
        Dim bytesArchivo() As Byte = Nothing

        If Consulta = True Then
            Dim STRPedido As String = String.Empty
            STRPedido = NumeroPedido

            Dim dtPDF As DataTable
            dtPDF = New DataTable

            clsPedidoBl = New ClsOperaciones.ORDERS
            dtPDF = clsPedidoBl.Mostrar_OrdenCompra_Pedido(STRPedido)

            If dtPDF IsNot Nothing AndAlso dtPDF.Rows.Count > 0 Then
                If dtPDF.Rows(0)("Archivo") IsNot DBNull.Value Then
                    'Dim archivoBytes As Byte() = CType(dtPDF.Rows(0)("Archivo"), Byte())
                    pdfBytes = CType(dtPDF.Rows(0)("Archivo"), Byte())
                End If
            End If
        End If

        If Not (pdfBytes Is Nothing) Then
            bytesArchivo = DirectCast(pdfBytes, Byte())
            Dim rutaTemporal As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "OrdenCompra_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".pdf")

            ' Guardar bytes como archivo PDF
            System.IO.File.WriteAllBytes(rutaTemporal, bytesArchivo)

            ' Abrir el archivo con el visor predeterminado
            Process.Start(rutaTemporal)
        Else
            pdfBytes = File.ReadAllBytes(txtRutaArchivo.Text)
            If pdfBytes Is Nothing Then
                MessageBox.Show("No se encontró el archivo PDF")
            Else
                Dim rutaTemporal As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "OrdenCompra_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".pdf")
                bytesArchivo = DirectCast(pdfBytes, Byte())
                ' Guardar bytes como archivo PDF
                System.IO.File.WriteAllBytes(rutaTemporal, bytesArchivo)

                ' Abrir el archivo con el visor predeterminado
                Process.Start(rutaTemporal)
            End If


        End If


        'Try
        '    If txtRutaArchivo.Text <> String.Empty Then
        '        ' Opcional: Abrir el PDF
        '        Process.Start(txtRutaArchivo.Text)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error al recuperar PDF: " & ex.Message)
        'End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Archivo PDF|*.PDF"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtRutaArchivo.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click

        pdfBytes = Nothing
        txtRutaArchivo.Text = String.Empty
        txt_SerieNumero.Text = String.Empty

        'clsPedidoBl = New ClsOperaciones.ORDERS
        'If clsPedidoBl.Actualizar_OrdenCompra_Pedido(_NumeroPedido, Nothing, String.Empty) = True Then
        '    txtRutaArchivo.Text = String.Empty
        '    txt_SerieNumero.Text = String.Empty
        '    MsgBox("Se actualizo Orden de Compra", MsgBoxStyle.Information)
        'End If

    End Sub

    Private Sub frmOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtdocumentoPrin As DataTable
        dtdocumentoPrin = New DataTable

        If Consulta = True Then
            tAceptar.Enabled = False
            TEliminar.Enabled = False
            btnbuscar.Visible = False
            txtRutaArchivo.BackColor = System.Drawing.Color.White

        Else
            tAceptar.Enabled = True
            TEliminar.Enabled = True
            btnbuscar.Visible = True
            txtRutaArchivo.BackColor = System.Drawing.Color.Aquamarine
        End If

        clsPedidoBl = New ClsOperaciones.ORDERS
        dtdocumentoPrin = clsPedidoBl.Mostrar_OrdenCompra_Pedido(_NumeroPedido)

        If dtdocumentoPrin IsNot Nothing AndAlso dtdocumentoPrin.Rows.Count > 0 Then
            If dtdocumentoPrin.Rows(0)("Archivo") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(dtdocumentoPrin.Rows(0)("Archivo").ToString()) Then

                Dim archivoBytes As Byte() = CType(dtdocumentoPrin.Rows(0)("Archivo"), Byte())
                Dim rutaDestino As String = Ruta_Reportes() & "\OC"
                Dim nombreArchivo As String = "Orden_" & _NumeroPedido & ".pdf" ' o extraído si está disponible
                Dim rutaCompleta As String = Path.Combine(rutaDestino, nombreArchivo)
                File.WriteAllBytes(rutaCompleta, archivoBytes)
                txtRutaArchivo.Text = rutaCompleta
            End If


            If dtdocumentoPrin.Rows(0)("ORDER_PURCHASE") IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(dtdocumentoPrin.Rows(0)("ORDER_PURCHASE").ToString()) Then

                Dim archivoBytes As String = CType(dtdocumentoPrin.Rows(0)("ORDER_PURCHASE"), String)
                txt_SerieNumero.Text = archivoBytes
            End If

        End If
    End Sub
End Class