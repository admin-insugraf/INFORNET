Imports LibSeguridad.ClsUsuario
Imports System
Imports System.Collections
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Diagnostics
Imports System.Reflection
Imports System.IO
Imports System.Xml
Imports LibComunVar
Imports LibConexion
Imports LibAdministracion

Public Class frmLogin
    Private ClsUsuario As LibSeguridad.ClsUsuario
    Private ClsVarComun As LibComunVar.ClsVarComun
    Private dtMenu As DataTable
    Private dtEmpresa As DataTable
    Public dtUsuarioAcceso As DataTable
    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData
    Private INTOrden As Integer = 0
    Dim flag_salir As Boolean = False
    Dim flag_CambioPass As Boolean = False

    Private Function ValidarUsuariosIngreso() As Boolean
        Dim estado As Boolean = True
        Try
            ClsUsuarioBl = New LibSeguridad.ClsUsuario
            ClsData = New LibConexion.ClsData
            dtUsuarioAcceso = New DataTable
            Dim codigoUsuario As String = String.Empty
            codigoUsuario = txtusuario.Text
            dtUsuarioAcceso = ClsUsuarioBl.ValidarUsuariosIngresos(codigoUsuario)
            If dtUsuarioAcceso.Rows.Count() <> 0 Then
                If ClsUsuarioBl.ESTADO = "N" Then
                    MessageBox.Show("El estado del usuario ingresado se encuentra Inactivo", "Sitemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    estado = False
                    Exit Try
                Else
                    STRUserSys = ClsUsuarioBl.CODUSUARIO
                    STRPassSys = ClsUsuarioBl.PASSUSUARIO
                    STRPassSys = ClsData.DesEncryptString(STRPassSys)
                    If Not String.IsNullOrEmpty(ClsUsuarioBl.OPT_VALIDADO) Then
                        If ClsUsuarioBl.OPT_VALIDADO = "0" Then
                            flag_CambioPass = True
                            MsgBox("Bienvenido al sistema NOVAQ, necesitamos que actualize sus datos de usuario.", MsgBoxStyle.Information)
                            Dim frm As New frm_Mantenimiento_Usuario
                            frm.Usuario = codigoUsuario
                            frm.ShowDialog()
                            flag_salir = frm.flag_salir
                            frm.Close()
                            estado = False
                            Exit Try
                        End If
                    End If
                    If txtpassword.Text = STRPassSys Then
                        LibComunVar.ClsVarComun.USUARIO = STRUserSys
                        LibComunVar.ClsVarComun.AccesoAlmacenes = ClsUsuarioBl.ACCESO_ALMACENES
                        LibComunVar.ClsVarComun.MAIL_USER = ClsUsuarioBl.MAIL
                    ElseIf txtpassword.Text <> STRPassSys Then
                        MessageBox.Show("El password ingresado es incorrecto", "Sitemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        estado = False
                        Exit Try
                    End If
                End If
            Else
                MessageBox.Show("El Usuario ingresado es incorrecto o no Existe, Verifique.", "Sitemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function


    Private Sub ActualizaMenu()
        dtMenu = New DataTable
        dtMenu = New DataTable("MENU_SISTEMA")
        With dtMenu.Columns
            .Add(New DataColumn("COD_OPCION", GetType(String)))
            .Add(New DataColumn("DES_OPCION", GetType(String)))
            .Add(New DataColumn("ORDEN", GetType(Integer)))
        End With
        Call RecorrerEstructuraMenu(frmMenu.MnuPrin)
        ClsUsuario = New LibSeguridad.ClsUsuario
        If ClsUsuario.BulkMenu(dtMenu) = False Then
            MsgBox("Ocurrió un error interno, comuniquese con su proveedor de software.", MsgBoxStyle.Critical, "Error")
            ClsUsuario = Nothing
            End
        End If
        ClsUsuario = Nothing
    End Sub

    Private Sub RecorrerEstructuraMenu(ByVal oMenu As MenuStrip)
        For Each oOpcionMenu As ToolStripMenuItem In oMenu.Items
            Call AgregaOpcion(oOpcionMenu.Name, oOpcionMenu.Text)
            If oOpcionMenu.DropDownItems.Count > 0 Then
                Me.RecorrerSubmenu(oOpcionMenu.DropDownItems, oOpcionMenu)
            End If
        Next
    End Sub
    Private Sub RecorrerSubmenu(ByVal oSubmenuItems As ToolStripItemCollection, ByVal Padre As ToolStripMenuItem)
        For Each oSubitem As ToolStripItem In oSubmenuItems
            If oSubitem.GetType Is GetType(ToolStripMenuItem) Then
                Call AgregaOpcion(oSubitem.Name, oSubitem.Text)
                If CType(oSubitem, ToolStripMenuItem).DropDownItems.Count > 0 Then
                    Me.RecorrerSubmenu(CType(oSubitem, ToolStripMenuItem).DropDownItems, oSubitem)
                End If
            End If
        Next
    End Sub
    Private Sub AgregaOpcion(ByVal STRCodOpcion As String, ByVal STRDesOpcion As String)
        Dim myDataRow As DataRow
        myDataRow = dtMenu.NewRow
        INTOrden = INTOrden + 1
        myDataRow("COD_OPCION") = STRCodOpcion
        myDataRow("DES_OPCION") = STRDesOpcion
        myDataRow("ORDEN") = INTOrden
        dtMenu.Rows.Add(myDataRow)
    End Sub

    Private Function validacionesGenerales() As Boolean
        Dim estado As Boolean = True
        Try
            If cboEmpresas.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                estado = False
                cboEmpresas.Focus()
                Exit Try
            End If
            If txtusuario.Text = String.Empty Then
                MessageBox.Show("Debe ingresar un nombre de Usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtusuario.Focus()
                estado = False
                Exit Try
            ElseIf txtpassword.Text = String.Empty Then
                MessageBox.Show("Debe ingresar un contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtpassword.Focus()
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub IngresarSistema()
        Try
            If validacionesGenerales() = False Then Exit Sub
            ClsVarComun = New LibComunVar.ClsVarComun
            ClsVarComun.BaseDatos = cboEmpresas.Text
            GdtFechaSys = Format(dtpFecha.Value, "Short Date")
            ClsVarComun.FechaSistema = GdtFechaSys
            dtEmpresa = New DataTable
            ClsUsuario = New LibSeguridad.ClsUsuario
            dtEmpresa = ClsUsuario.get_Datos_Empresa
            If dtEmpresa.Rows.Count > 0 Then
                LibComunVar.ClsVarComun.NomEmpresa = dtEmpresa.Rows(0).Item("NAME").ToString
                LibComunVar.ClsVarComun.DirEmpresa = dtEmpresa.Rows(0).Item("ADDR").ToString
                LibComunVar.ClsVarComun.RucEmpresa = dtEmpresa.Rows(0).Item("VAT_REGISTRATION").ToString
            End If
            If ValidarUsuariosIngreso() = False Then
                If flag_CambioPass = True Then
                    If flag_salir = False Then
                        MsgBox("Para validar sus datos debe loggearce nuevamente al sistema.", MsgBoxStyle.Information, "Sistemas")
                        Me.Close()
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            Else
                ValidaOK = True
                ClsUsuario = Nothing
                ClsVarComun = Nothing
                Call ActualizaMenu()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        IngresarSistema()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BYTEmp As Byte = 1
        Dim STRVarEmp As String
        Dim codeBase As String = [Assembly].GetExecutingAssembly().CodeBase
        Dim codeBaseDir As String = Path.GetDirectoryName(codeBase)
        Dim configFilename As String = Path.Combine(codeBaseDir, "CustomConfigFile.config")

        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(configFilename)

        Dim xNode As XmlNode = doc.GetElementsByTagName("empresas").Item(0)

        Dim csh As IConfigurationSectionHandler = New NameValueSectionHandler()
        Dim nvcEmp As NameValueCollection = CType(csh.Create(Nothing, Nothing, xNode), NameValueCollection)

        For Each myEmpresa In nvcEmp
            STRVarEmp = "Empresa" & Microsoft.VisualBasic.Right("00" & BYTEmp, 2)
            cboEmpresas.Items.Add(nvcEmp(STRVarEmp))
            BYTEmp = BYTEmp + 1
        Next
        cboEmpresas.SelectedIndex = 0
        txtusuario.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ValidaOK = False
        Me.Close()
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            IngresarSistema()
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Focus()
        End If
    End Sub
End Class