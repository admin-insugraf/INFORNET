Imports LibComunVar
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Module ModBas
    Friend dtTable As DataTable
    Private ClsVarComun As New LibComunVar.ClsVarComun
    Public gFechaSis As Date = ClsVarComun.FechaSistema

    Public Sub MostrarError(ByVal STRExcep As String)
        Dim f As New frmError
        f.txtError.Text = "Se produjo el siguiente error:" & vbCrLf & STRExcep
        f.ShowDialog()
    End Sub

    Public Sub Inicializa_Tool(t As System.Windows.Forms.ToolStrip)
        t.Items("Tool_Nuevo").Enabled = True
        t.Items("Tool_Grabar").Enabled = False
        t.Items("Tool_Editar").Enabled = True
        t.Items("Tool_Cancelar").Enabled = False
        t.Items("Tool_Eliminar").Enabled = True
        t.Items("Tool_Salir").Enabled = True
    End Sub

    Public Sub Cambiar_Estado_Tool(t As System.Windows.Forms.ToolStrip)
        t.Items("Tool_Nuevo").Enabled = Not t.Items("Tool_Nuevo").Enabled
        t.Items("Tool_Grabar").Enabled = Not t.Items("Tool_Grabar").Enabled
        t.Items("Tool_Editar").Enabled = Not t.Items("Tool_Editar").Enabled
        t.Items("Tool_Cancelar").Enabled = Not t.Items("Tool_Cancelar").Enabled
        t.Items("Tool_Eliminar").Enabled = Not t.Items("Tool_Eliminar").Enabled
        t.Items("Tool_Salir").Enabled = Not t.Items("Tool_Salir").Enabled
    End Sub

    Public Sub Limpiar_Controles(gb As System.Windows.Forms.GroupBox)

        For Each c As System.Windows.Forms.Control In gb.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If

            If TypeOf c Is MaskedTextBox Then
                c.Text = ""
            End If

            If TypeOf c Is ComboBox Then
                DirectCast(c, ComboBox).SelectedIndex = -1
            End If
        Next

    End Sub

    Public Sub Cargar_Meses_en_Combo(cmb As System.Windows.Forms.ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("Seleccione mes...")
        cmb.Items.Add("ENERO")
        cmb.Items.Add("FEBRERO")
        cmb.Items.Add("MARZO")
        cmb.Items.Add("ABRIL")
        cmb.Items.Add("MAYO")
        cmb.Items.Add("JUNIO")
        cmb.Items.Add("JULIO")
        cmb.Items.Add("AGOSTO")
        cmb.Items.Add("SEPTIEMBRE")
        cmb.Items.Add("OCTUBRE")
        cmb.Items.Add("NOVIEMBRE")
        cmb.Items.Add("DICIEMBRE")
    End Sub

    Public Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0

        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function

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

    Public Function ReadBinaryFile(ByVal fileName As String) As Byte()
        'http://www.mvp-access.es/softjaen/bases/adonet/sjadonet13.htm
        ' Si no existe el archivo, abandono la función.
        '
        If Not System.IO.File.Exists(fileName) Then Return Nothing

        Try
            ' Creamos un objeto Stream para poder leer el archivo especificado.
            '
            Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)

            ' Creamos un array de bytes, cuyo límite superior se corresponderá
            ' con la longitud en bytes de la secuencia.
            '
            Dim data() As Byte = New Byte(Convert.ToInt32(fs.Length)) {}

            ' Al leer la secuencia, se rellenará la matriz.
            '
            fs.Read(data, 0, Convert.ToInt32(fs.Length))

            ' Cerramos la secuencia.
            '
            fs.Close()

            ' Devolvemos el array de bytes.
            '
            Return data

        Catch ex As Exception
            ' Cualquier excepción producida, hace que la
            ' función devuelva el valor Nothing.
            '
            Return Nothing

        End Try

    End Function

    Public Sub WriteBinaryFile(ByVal aByte() As Byte, _
                            ByVal fileName As String)
        'http://www.mvp-access.es/softjaen/bases/adonet/sjadonet14.htm
        ' El procedimiento creará un archivo con la secuencia de bytes
        ' especificada en el argumento.

        ' Compruebo los distintos parámetros pasados a la función.
        '
        If (aByte Is Nothing) OrElse (fileName = "") Then Return

        Try

            ' Compruebo si existe el archivo especificado.
            If System.IO.File.Exists(fileName) Then
                ' Elimino el archivo
                System.IO.File.Delete(fileName)
            End If

            ' Número de bytes que se van a escribir
            Dim data As Int64 = aByte.Length

            ' Obtengo el nombre de un archivo temporal, donde
            ' primeramente se guardará el documento.
            '
            Dim tempFileName As String = System.IO.Path.GetTempFileName

            ' Abrimos o creamos el archivo.
            Dim fs As New FileStream(tempFileName, FileMode.OpenOrCreate)

            ' Crea el escritor para los datos.
            Dim bw As New BinaryWriter(fs)

            ' Escribimos en el archivo los datos realmente leídos.
            bw.Write(aByte, 0, Convert.ToInt32(data))

            ' Borra todos los búferes del sistema de escritura actual y hace
            ' que todos los datos almacenados en el búfer se escriban en el
            ' dispositivo subyacente. 
            bw.Flush()

            ' Cerramos los distintos objetos.
            bw.Close()
            fs.Close()
            bw = Nothing
            fs = Nothing

            ' Muevo el archivo a la ruta indicada.
            System.IO.File.Move(tempFileName, fileName)

        Catch ex As Exception

        End Try

    End Sub

End Module
