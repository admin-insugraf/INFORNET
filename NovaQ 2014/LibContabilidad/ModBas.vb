Imports LibComunVar
Imports System.Windows.Forms
Imports System.Data.OleDb

Module ModBas
    Friend dtTable As DataTable
    Private ClsVarComun As New LibComunVar.ClsVarComun
    Public gFechaSis As Date = ClsVarComun.FechaSistema
    Friend STRRutaReportes As String

    Public Sub MostrarError(ByVal STRExcep As String)
        Dim f As New frmError
        f.txtError.Text = "Se produjo el siguiente error:" & vbCrLf & STRExcep
        f.ShowDialog()
    End Sub

    Public Function Primer_Dia_Mes(ByVal Fecha As Date) As Date
        Primer_Dia_Mes = DateSerial(Year(Fecha), Month(Fecha) + 0, 1)
    End Function
    Public Function Ultimo_Dia_Mes(ByVal Fecha As Date) As Date
        Ultimo_Dia_Mes = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)
    End Function

    Public Sub CentrarControl(ByVal ctrl As Control)

        ' Si el contenedor del control es Nothing, abandonamos el procedimiento
        '
        If ctrl.Parent Is Nothing Then Return

        With ctrl
            .Top = (.Parent.ClientSize.Height - .Height) \ 2
            .Left = (.Parent.ClientSize.Width - .Width) \ 2
        End With

    End Sub

    Sub Cargar(ByVal dgView As DataGridView, ByVal SLibro As String, ByVal sHoja As String)

        'HDR=YES : Con encabezado  
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                           "Data Source=" & SLibro & ";" & _
                           "Extended Properties=""Excel 8.0;HDR=YES"""
        Try
            ' cadena de conexión  
            Dim cn As New OleDbConnection(cs)

            If Not System.IO.File.Exists(SLibro) Then
                MsgBox("No se encontró el Libro: " & _
                        SLibro, MsgBoxStyle.Critical, _
                        "Ruta inválida")
                Exit Sub
            End If

            ' se conecta con la hoja sheet 1  
            Dim dAdapter As New OleDbDataAdapter("Select * From [" & sHoja & "$]", cs)

            Dim ds As New DataSet
            ' agrega los datos  
            dAdapter.Fill(ds, "MyData")

            dgView.DataSource = ds
            dgView.DataMember = "MyData"
        Catch oMsg As Exception
            MsgBox(oMsg.Message, MsgBoxStyle.Critical)
        End Try
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

    Public Sub Cargar_Meses_en_Combo(cmb As System.Windows.Forms.ComboBox)
        cmb.Items.Clear()
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

    Public Sub Limpiar_Controles(gb As System.Windows.Forms.GroupBox)

        For Each c As System.Windows.Forms.Control In gb.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If

            If TypeOf c Is MaskedTextBox Then
                c.Text = ""
            End If

        Next

    End Sub

End Module
