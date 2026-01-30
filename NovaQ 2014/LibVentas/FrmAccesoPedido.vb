
Imports System.Windows.Forms
Imports LibComunVar
Public Class FrmAccesoPedido
    Public ClsUsuarioBl As LibSeguridad.ClsUsuario
    Public ClsData As LibConexion.ClsData
    Dim clsVendedorBl As ClsTransacciones.clsVendedores
    Dim dtAccesoVendedor As DataTable
    Dim dtUsuarioAcceso As DataTable


    Private Sub IngresoPedidos()
        Try
            clsVendedorBl = New ClsTransacciones.clsVendedores
            dtAccesoVendedor = New DataTable
            Dim Dni As String = String.Empty
            Dim Pass As String = String.Empty

            If txtdni.Text = String.Empty Then
                MsgBox("Debe ingresar el DNI", MsgBoxStyle.Information)
                Exit Sub
            ElseIf txtpass.Text = String.Empty Then
                MsgBox("Debe ingresar el Password", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim doc As String = txtdni.Text
            Dim ide As String = txtpass.Text
            dtAccesoVendedor = clsVendedorBl.Get_Datos_Vendor(doc, ide)
            If dtAccesoVendedor.Rows.Count() = 0 Then
                MsgBox("No hay informacion con los Datos ingresados.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dni = clsVendedorBl.Dni
            Pass = clsVendedorBl.Password

            If ValidarUsuariosIngreso Then
                Dim frmRegPedidos As New Frm_pedidos
                frmRegPedidos.CodigoVendedor = clsVendedorBl.ID
                frmRegPedidos.DescripcionVendedor = clsVendedorBl.NAME
                frmRegPedidos.tipo_Vendedor = clsVendedorBl.NIVEL
                'Dim frmRegPedidos As New frmRegPedidos
                frmRegPedidos.MdiParent = Me.MdiParent
                frmRegPedidos.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function ValidarUsuariosIngreso() As Boolean
        Dim estado As Boolean = True
        Dim STRUserSys As String, STRPassSys As String
        Try
            ClsUsuarioBl = New LibSeguridad.ClsUsuario
            ClsData = New LibConexion.ClsData
            dtUsuarioAcceso = New DataTable
            Dim codigoUsuario As String = String.Empty
            dtUsuarioAcceso = ClsUsuarioBl.ValidarUsuariosIngresos(LibComunVar.ClsVarComun.USUARIO)
            If dtUsuarioAcceso.Rows.Count() <> 0 Then
                If ClsUsuarioBl.ESTADO = "N" Then
                    MessageBox.Show("El estado del usuario ingresado se encuentra Inactivo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    estado = False
                    Exit Try
                Else
                    STRUserSys = ClsUsuarioBl.CODUSUARIO
                    STRPassSys = ClsUsuarioBl.PASSUSUARIO
                    STRPassSys = ClsData.DesEncryptString(STRPassSys)
                    If txtpass.Text = STRPassSys Then
                        estado = True
                        Exit Try
                    ElseIf txtpass.Text <> STRPassSys Then
                        MessageBox.Show("El password ingresado es incorrecto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        estado = False
                        Exit Try
                    End If
                End If
            Else
                MessageBox.Show("El Usuario ingresado es incorrecto o no Existe, Verifique.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                estado = False
                Exit Try
            End If
        Catch ex As Exception
            estado = False
            MsgBox(ex.Message)
        End Try
        Return estado
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        IngresoPedidos()
    End Sub
 
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub FrmAccesoPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtAccesoVendedor = New DataTable
        clsVendedorBl = New ClsTransacciones.clsVendedores
        dtAccesoVendedor = clsVendedorBl.Get_Datos_vendedor(LibComunVar.ClsVarComun.USUARIO)
        If dtAccesoVendedor.Rows.Count() > 0 Then
            txtdni.Text = dtAccesoVendedor.Rows(0).Item("VAT_REGISTRATION").ToString
        Else
            txtdni.Text = ""
        End If
    End Sub

    Private Sub txtdni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdni.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpass.Focus()
        End If
    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
End Class