Imports System.Windows.Forms
Imports LibComunVar
Imports System.IO
Imports System.Drawing
Module ModBas

    Friend dtTable As DataTable
    Public GdtFechaSys As Date
    Public GdbTipCambioV As Double
    Public GdbTipCambioC As Double
    Friend STRRuta_FE As String
    Friend STRRuta_FE_Verificacion As String
    Friend STRRutaReportes As String

    Public gFechaSis As Date = Now.Date
    Public gUsuarioSis As String = "cbazan"
    Public gNomEmpresa As String = "Importadora de Vinos pal Mundo"
    Dim str_titulo_msgbox As String = "Sistema Cobranza"
    Public gIGV As Double = (18 / 100)

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
    Public Function Numero(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef cajasTexto As TextBox) As Boolean
        If UCase(e.KeyChar) Like "[!0-9.-]" Then
            Return True
        End If

        Dim c As Short = 0
        If UCase(e.KeyChar) Like "[.]" Then
            If InStr(cajasTexto.Text, ".") = 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
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
    Public Sub Avisar(msg_ As String)
        MessageBox.Show(msg_, str_titulo_msgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function Preguntar(msg_ As String) As Boolean
        Dim rpta As Boolean = False
        If MessageBox.Show(msg_, str_titulo_msgbox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            rpta = Not rpta
        End If
        Return rpta
    End Function

    Public Sub Limpiar_GroupBox(gb As GroupBox)

        Dim controles As Control = gb
        For Each ctrl As Control In controles.Controls
            'si es Label continuar
            If TypeOf (ctrl) Is Label Then Continue For

            '---------
            If TypeOf (ctrl) Is TextBox Then
                '---validando Cajas de Texto
                ctrl.Text = String.Empty
            End If
        Next
    End Sub

    'Public Sub Botonera_Estado_Inicio(frm As Form)
    '    frm.Controls("btn_Nuevo").Enabled = True
    '    frm.Controls("btn_grabar").Enabled = False
    '    frm.Controls("btn_Editar").Enabled = True
    '    frm.Controls("btn_cancelar").Enabled = False
    '    frm.Controls("btn_cancelar").Enabled = False
    '    frm.Controls("btn_eliminar").Enabled = True
    '    frm.Controls("btn_salir").Enabled = True
    'End Sub

    'Public Sub Botonera_Estado_Cambiar(frm As Form)
    '    frm.Controls("btn_Nuevo").Enabled = Not frm.Controls("btn_Nuevo").Enabled
    '    frm.Controls("btn_grabar").Enabled = Not frm.Controls("btn_grabar").Enabled
    '    frm.Controls("btn_Editar").Enabled = Not frm.Controls("btn_Editar").Enabled
    '    frm.Controls("btn_cancelar").Enabled = Not frm.Controls("btn_cancelar").Enabled
    '    frm.Controls("btn_eliminar").Enabled = Not frm.Controls("btn_eliminar").Enabled
    '    frm.Controls("btn_salir").Enabled = Not frm.Controls("btn_salir").Enabled
    'End Sub

    'Public Sub Botonera_Estado_Inicio_v(frm As Form)
    '    frm.Controls("btn_Nuevo").Enabled = True
    '    frm.Controls("btn_grabar").Enabled = False
    '    frm.Controls("btn_Editar").Enabled = True
    '    frm.Controls("btn_cancelar").Enabled = False
    '    frm.Controls("btnImprimir").Enabled = True
    '    frm.Controls("btn_eliminar").Enabled = True
    '    frm.Controls("btn_salir").Enabled = True
    'End Sub

    'Public Sub Botonera_Estado_Cambiar_v(frm As Form)
    '    frm.Controls("btn_Nuevo").Enabled = Not frm.Controls("btn_Nuevo").Enabled
    '    frm.Controls("btn_grabar").Enabled = Not frm.Controls("btn_grabar").Enabled
    '    frm.Controls("btn_Editar").Enabled = Not frm.Controls("btn_Editar").Enabled
    '    frm.Controls("btn_cancelar").Enabled = Not frm.Controls("btn_cancelar").Enabled
    '    frm.Controls("btnImprimir").Enabled = Not frm.Controls("btnImprimir").Enabled
    '    frm.Controls("btn_eliminar").Enabled = Not frm.Controls("btn_eliminar").Enabled
    '    frm.Controls("btn_salir").Enabled = Not frm.Controls("btn_salir").Enabled
    'End Sub

End Module
